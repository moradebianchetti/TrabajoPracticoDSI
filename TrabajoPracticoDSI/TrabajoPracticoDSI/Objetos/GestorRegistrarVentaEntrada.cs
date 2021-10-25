using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPracticoDSI.Backend;
using TrabajoPracticoDSI.Formularios;

namespace TrabajoPracticoDSI.Objetos
{
    public class GestorRegistrarVentaEntrada
    {
        //Atributos
        public DateTime fechaHoraActual { get; set; }
        public Sede sedeActual { get; set; }
        public Tarifa tarifaSeleccionada { get; set; }
        List<object[]> tarifaVigente = new List<object[]>();
        public bool ventaConfirmada { get; set; }
        public int visitantesSede { get; set; }
        public Sesion sesion { get; set; }
        public List<Empleado> list_empleados { get; set; }
        public Usuario usuarioActual { get; set; }
        public string sesionUsuarioLogueado { get; set; }
        public List<Entrada> listaEntradas { get; set; }

        public GestorRegistrarVentaEntrada()
        {
            usuarioActual = new Usuario();
            sesion = new Sesion();

            string sql = "SELECT * FROM Empleado";
            DataTable empleados = _DB.EjecutarSelect(sql);
            list_empleados = new List<Empleado>();

            for (int i = 0; i < empleados.Rows.Count; i++)
            {
                Empleado empleado = new Empleado(empleados.Rows[i]);
                list_empleados.Add(empleado);
            }
            listaEntradas = new List<Entrada>();

        }

        Conexion_DB _DB = new Conexion_DB();
        
        public void tomarSeleccionOpcionRegistrarVenta(Sesion sesion)
        {
            this.buscarSede(sesion);
        }
        
        int duracionExposiciones = 0;

        public void buscarSede(Sesion sesion)
        {
            
            usuarioActual.dni_empleado = this.buscarUsuarioLogueado(sesion);

            foreach (Empleado item in list_empleados)
            {
                if (item.esTuUsuario(usuarioActual))
                {
                    this.sedeActual = item.obtenerSede();
                    break;
                }

            }

            this.tarifaVigente = buscarTarifa();

            Frm_principal.pantalla.solicitaSeleccionTarifa(this.tarifaVigente);
        }

        public List<object[]> buscarTarifa()
        {
            return this.sedeActual.obtenerTarifa();
        }

        public int buscarUsuarioLogueado(Sesion sesion)
        {
            return sesion.BuscarUsuario();
        }

        public void tomarSeleccionTarifa(Tarifa tarifa)
        {
            this.tarifaSeleccionada = tarifa;
            calcularDuracionAExposicionesVigentes();
            Frm_principal.pantalla.solicitarSeleccionCantidadEntradas();
        }

        private void calcularDuracionAExposicionesVigentes()
        {
            duracionExposiciones = this.sedeActual.obtenerDuracionAExposicionesVigentes();
        }

        public void tomarSeleccionCantidadEntradas(int cantidadIngresada)
        {
            sedeActual.cantidadMaxVisitantes = buscarCapacidadMaxima();
            int visitantesEnSede = buscarCantidadVisitantesEnSede();
            this.visitantesSede = visitantesEnSede;
            validarCantidadVisitantesActuales(this.visitantesSede, cantidadIngresada);
        }
        public int buscarCapacidadMaxima()
        {
            return this.sedeActual.cantidadMaxVisitantes; 
        }

        public int buscarCantidadVisitantesEnSede()
        {
            return this.sedeActual.obtenerCantidadVisitantesEnSede(duracionExposiciones);
        }

        private void validarCantidadVisitantesActuales( int visitantesEnSede, int cantidadIngresada)
        {
             
            if (this.sedeActual.cantidadMaxVisitantes < (cantidadIngresada + visitantesEnSede))
            {
                MessageBox.Show("La cantidad de entradas supera a la cantidad maxima de visitantes del museo.");
                return;
            }
            else
            {
                this.visitantesSede += cantidadIngresada; 
                Frm_principal.pantalla.mostrarEntradasAComprar();
            }
        }
        public void tomarSeleccionConfirmarCompra(int cantidadEntrada, int montoTotal)
        {
            this.buscarUltimoNroEntrada(cantidadEntrada, montoTotal);
        }
        private void buscarUltimoNroEntrada(int cantidadEntrada, int montoTotal)
        {
            int mayorNumero = sedeActual.obtenerUltimoNroEntrada();
            obtenerFechaHoraActual(cantidadEntrada, montoTotal, mayorNumero);
        }
        private void obtenerFechaHoraActual(int cantidadEntrada, int montoTotal, int mayorNumero)
        {
            this.fechaHoraActual = DateTime.Now;
            RegistrarEntrada(cantidadEntrada, montoTotal, mayorNumero);
        }
        private void RegistrarEntrada(int cantidadEntrada, int montoTotal, int mayorNumero)
        {
            
            for (int i = 0; i < cantidadEntrada; i++)
            {
                int numeroEntrada = mayorNumero + i + 1;
                Entrada entrada = new Entrada(this.fechaHoraActual, sedeActual, this.tarifaSeleccionada, numeroEntrada);

                listaEntradas.Add(entrada);

            }
            MessageBox.Show("Se confirmo su compra con éxito");
            imprimirEntradas(listaEntradas);
        }
        private void imprimirEntradas(List<Entrada> listaEntradas)
        {
            foreach (Entrada item in listaEntradas)
            {
                ImpresorEntradas impresor = new ImpresorEntradas();
                impresor.imprimirEntradas(item);

            }
            actualizarCantidadVisitantes();
        }
        private void actualizarCantidadVisitantes()
        {
            for (int i = 0; i < 3; i++)
            {
                PantallaSala pantallaSala = new PantallaSala();
                pantallaSala.actualizarCantidadVisitantes(this.visitantesSede, sedeActual);

            }
            
            actualizarVisitantesPantalla();
        }
        private void actualizarVisitantesPantalla()
        {
            PantallaEntrada pantallaEntrada = new PantallaEntrada();
            pantallaEntrada.actualizarCantidadVisitantes(this.visitantesSede, sedeActual);
            finCU();
        }
        private void finCU()
        {
            Frm_principal.pantalla.Close();
            Application.Restart();
        }
    }
}
