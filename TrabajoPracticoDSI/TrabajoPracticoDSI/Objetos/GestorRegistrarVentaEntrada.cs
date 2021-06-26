using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPracticoDSI.Backend;

namespace TrabajoPracticoDSI.Objetos
{
    class GestorRegistrarVentaEntrada
    {
        //Atributos
        public int fechaHoraAtual { get; set; }
        public Sede sedeActual { get; set; }
        public Sesion sesioUsuarioLoguead { get; set; }
        public int tarifaSeleccionada { get; set; }
        public int tarifaVigente { get; set; }
        public bool ventaConfirmada { get; set; }
        public int visitantesSede { get; set; }

        Conexion_DB _DB = new Conexion_DB();
        //this.sedeActual = new Sede();
        List<Tarifa> tarifas = new List<Tarifa>();
        

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

            tarifas = buscarTarifa();

            Frm_principal.pantalla.solicitaSeleccionTarifa(tarifas);
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
            calcularDuracionAExposicionesVigentes();
            Frm_principal.pantalla.solicitarSeleccionCantidadEntradas();
        }

        private void calcularDuracionAExposicionesVigentes()
        {
            duracionExposiciones = this.sedeActual.obtenerDuracionAExposicionesVigentes();
            MessageBox.Show("Duracion " + duracionExposiciones);
        }

        public void tomarSeleccionCantidadEntradas()
        {
            int cantidadMaximaVisitantes = buscarCapacidaMaxima();

            validarCantidadVisitantesActuales(buscarCapacidaMaxima, buscarCantidadVisitantesEnSede);
        }
        public int buscarCapacidaMaxima()
        {
            return this.sedeActual.cantidadMaxVisitantes; 
        }

        public int buscarCantidadVisitantesEnSede()
        {
            return this.sedeActual.obtenerCantidadReservasYEntradas(duracionExposiciones);
        }

        private void validarCantidadVisitantesActuales(int buscarCapacidaMaxima, int buscarCantidadVisitantesEnSede)
        {
               
            
            if (cantidadMaxVisitantes<cantidadVisitantesActuales)
            {
                MessageBox.Show("La cantidad de entradas supera a la cantidad maxima de visitantes del museo");
                return;
            }
        }
    }
}
