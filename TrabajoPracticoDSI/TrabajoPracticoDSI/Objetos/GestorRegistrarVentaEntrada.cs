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
    class GestorRegistrarVentaEntrada
    {
        //Atributos
        public DateTime fechaHoraActual { get; set; }
        public Sede sedeActual { get; set; }
        public Tarifa tarifaSeleccionada { get; set; }
        List<Tarifa> tarifaVigente = new List<Tarifa>();
        public bool ventaConfirmada { get; set; }
        public int visitantesSede { get; set; }
        public Sesion sesion { get; set; }
        //public int cantidadEntrada { get; set; }

        public string sesionUsuarioLogueado { get; set; }

        Conexion_DB _DB = new Conexion_DB();
        //this.sedeActual = new Sede();
        
        int duracionExposiciones = 0;

        public void tomarSeleccionOpcionRegistrarVenta(Sesion sesion)
        {
            this.buscarSede(sesion);
        }

        public void buscarSede(Sesion sesion)
        {
            Usuario usuarioActual = new Usuario();
            usuarioActual.dni_empleado = this.buscarUsuarioLogueado(sesion);

            string sql = "SELECT * FROM Empleado";
            DataTable empleados = _DB.EjecutarSelect(sql);

            for (int i = 0; i < empleados.Rows.Count; i++)
            {
                Empleado empleado = new Empleado();
                empleado.DNI = int.Parse(empleados.Rows[i]["DNI"].ToString());
                int idSede = int.Parse(empleados.Rows[i]["idSede"].ToString());
                this.sedeActual = empleado.esTuUsuario(usuarioActual, idSede);

                if (this.sedeActual.id != 0)
                    break;
            }

            this.tarifaVigente = buscarTarifa();

            Frm_principal.pantalla.solicitaSeleccionTarifa(this.tarifaVigente);
        }

        public List<Tarifa> buscarTarifa()
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
            this.tarifaSeleccionada.tipoVisita.id = tarifa.tipoVisita.id;
            this.tarifaSeleccionada.tipoEntrada.id = tarifa.tipoEntrada.id;
            calcularDuracionAExposicionesVigentes();
            Frm_principal.pantalla.solicitarSeleccionCantidadEntradas();
        }

        private void calcularDuracionAExposicionesVigentes()
        {
            duracionExposiciones = this.sedeActual.obtenerDuracionAExposicionesVigentes();
            //MessageBox.Show("Duracion " + duracionExposiciones);
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
            return this.sedeActual.obtenerCantidadReservasYEntradas(duracionExposiciones);
        }

        private void validarCantidadVisitantesActuales( int visitantesEnSede, int cantidadIngresada)
        {
            int suma = cantidadIngresada + visitantesEnSede;

            if (this.sedeActual.cantidadMaxVisitantes < suma)
            {
                MessageBox.Show("La cantidad de entradas supera a la cantidad maxima de visitantes del museo.");
                return;
            }
            else
            {
                Frm_principal.pantalla.mostrarEntradasAComprar();
            }
        }
        public void tomarSeleccionConfirmarCompra(int cantidadEntrada, int montoTotal)
        {
            this.buscarUltimoNroEntrada(cantidadEntrada, montoTotal);
        }
        private void buscarUltimoNroEntrada(int cantidadEntrada, int montoTotal)
        {
            
            obtenerFechaHoraActual(cantidadEntrada, montoTotal);
        }
        private void obtenerFechaHoraActual(int cantidadEntrada, int montoTotal)
        {
            this.fechaHoraActual = DateTime.Now;
            RegistrarEntrada(cantidadEntrada, montoTotal);
        }
        private void RegistrarEntrada(int cantidadEntrada, int montoTotal)
        {
            for (int i = 0; i < cantidadEntrada; i++)
            {
               
                Entrada entrada = new Entrada();
                int mayorNumero = sedeActual.obtenerUltimoNroEntrada();
                entrada.newEntrada(this.fechaHoraActual, sedeActual, tarifaSeleccionada, mayorNumero);
               
            }
            imprimirEntradas(cantidadEntrada);
        }
        private void imprimirEntradas(int cantidadEntrada)
        {
            for (int i = 0; i < cantidadEntrada; i++)
            {
                //ImpresorEntradas.imprimirEntradas();
            }
            actualizarCantidadVisitantes();
        }
        private void actualizarCantidadVisitantes()
        {
            //PantallaSala.actualizarCantidadVisitantes(visitantesSede);
            actualizarVisitantesPantalla();
        }
        private void actualizarVisitantesPantalla()
        {
           // PantallaEntrada.actualizarCantidadVisitantes(visitantesSede);

        }
    }
}
