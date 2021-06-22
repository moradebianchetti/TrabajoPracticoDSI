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
        Conexion_DB _DB = new Conexion_DB();
        Sede sedeActual = new Sede();
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
                sedeActual = empleado.esTuUsuario(usuarioActual, idSede);

                if (sedeActual.id != 0)
                    break;
            }

            tarifas = buscarTarifa();

            Frm_principal.pantalla.solicitaSeleccionTarifa(tarifas);
        }

        public List<Tarifa> buscarTarifa()
        {
            return sedeActual.obtenerTarifa();
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
            duracionExposiciones = sedeActual.obtenerDuracionAExposicionesVigentes();
            MessageBox.Show("Duracion " + duracionExposiciones);
        }

        public void tomarSeleccionCantidadEntradas()
        {
            validarCantidadVisitantesActuales();
        }

        private void validarCantidadVisitantesActuales()
        {
            int cantidadMaxVisitantes = sedeActual.cantidadMaxVisitantes;
            int cantidadVisitantesActuales = sedeActual.obtenerCantidadReservasYEntradas();
        }
    }
}
