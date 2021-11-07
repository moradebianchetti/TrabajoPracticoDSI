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
    public class GestorRegistrarVentaEntrada : iSujeto
    {
        //Atributos
        public int cantidadMaximaVisitantes { get; set; }
        public int cantidadVisitantes { get; set; }
        public DateTime fechaHoraActual { get; set; }
        public Sede sedeActual { get; set; }
        public string sesionUsuarioLogueado { get; set; }
        public Tarifa tarifaSeleccionada { get; set; }
        List<object[]> tarifaVigente = new List<object[]>();
        public bool ventaConfirmada { get; set; }
        public ImpresorEntradas impresor { get; set; }
        public Sesion sesion { get; set; }
        public List<Empleado> empleados { get; set; }
        public Usuario usuarioActual { get; set; }
        public List<Entrada> listaEntradas { get; set; }

        //Dos listas?
        private List<iObservadorActualizarPantalla> pantallas { get; set; }

        private List<iObservadorActualizarPantalla> observers = new List<iObservadorActualizarPantalla>();

        public GestorRegistrarVentaEntrada()
        {
            Usuario usuarioActual = new Usuario();
            Sesion sesion = new Sesion();
            ImpresorEntradas impresor = new ImpresorEntradas();
   
            string sql = "SELECT * FROM Empleado";
            DataTable empleadosTable = _DB.EjecutarSelect(sql);
            empleados = new List<Empleado>();


            for (int i = 0; i < empleadosTable.Rows.Count; i++)
            {
                Empleado empleado = new Empleado(empleadosTable.Rows[i]);
                empleados.Add(empleado);
            }
            listaEntradas = new List<Entrada>();

            //TODO: ver pantallas por que seria un atributo de la clase gestor
            pantallas = new List<iObservadorActualizarPantalla>();

            for (int i = 0; i < 3; i++)
            {
                PantallaSala pantallaSala = new PantallaSala();
                pantallas.Add(pantallaSala);
            }

            //TODO: ver pantallaEntrada por que seria un atributo de la clase gestor
            PantallaEntrada pantallaEntrada = new PantallaEntrada();
            pantallas.Add(pantallaEntrada);

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

            foreach (Empleado item in empleados)
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
            this.cantidadVisitantes = visitantesEnSede;
            validarCantidadVisitantesActuales(this.cantidadVisitantes, cantidadIngresada);
        }
        public int buscarCapacidadMaxima()
        {
            return this.sedeActual.cantidadMaxVisitantes;
        }

        public int buscarCantidadVisitantesEnSede()
        {
            return this.sedeActual.obtenerCantidadVisitantesEnSede(duracionExposiciones);
        }

        private void validarCantidadVisitantesActuales(int visitantesEnSede, int cantidadIngresada)
        {

            if (this.sedeActual.cantidadMaxVisitantes < (cantidadIngresada + visitantesEnSede))
            {
                MessageBox.Show("La cantidad de entradas supera a la cantidad maxima de visitantes del museo.");
                return;
            }
            else
            {
                this.cantidadVisitantes += cantidadIngresada;
                Frm_principal.pantalla.mostrarEntradasAComprar();
            }
        }
        public void tomarSeleccionConfirmarCompra(int cantidadEntrada, int montoTotal)
        {
            foreach (iObservadorActualizarPantalla pantalla in pantallas)
            {
                Suscribir(pantalla);
            }
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
            actualizarVisitantesPantalla();
            finCU();
        }
        private void imprimirEntradas(List<Entrada> listaEntradas)
        {
            foreach (Entrada item in listaEntradas)
            {

                impresor.imprimirEntradas(item);

            }
        }

        private void actualizarVisitantesPantalla()
        {
            Notificar();
        }

        public void Notificar()
        {
            //TODO: inconsistencia, loop cuando en diagrama esta solo para las pantallas de las salas
            foreach (iObservadorActualizarPantalla pantalla in observers)
            {
                pantalla.actualizarCantidadVisitantes(this.cantidadVisitantes, sedeActual.cantidadMaxVisitantes);
            }
        }

        public void Suscribir(iObservadorActualizarPantalla observer)
        {
            this.observers.Add(observer);
        }

        public void Quitar(iObservadorActualizarPantalla observer)
        {
            this.observers.Remove(observer);
        }

        private void finCU()
        {
            Frm_principal.pantalla.Close();
            Application.Restart();
        }
    }
}
