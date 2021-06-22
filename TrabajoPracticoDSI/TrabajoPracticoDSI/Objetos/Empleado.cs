using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPracticoDSI.Backend;

namespace TrabajoPracticoDSI.Objetos
{
    public class Empleado
    {
        public int DNI{ get; set; }
        public string apellido { get; set; }
        public string nombre { get; set; }
        public int idCargo { get; set; }
        public Sede sedeEmpleado { get; set; }
        Conexion_DB _DB = new Conexion_DB();

        Sede sede = new Sede();

        public Sede esTuUsuario(Usuario usuario, int idSede)
        {
            this.sedeEmpleado = sede;
            this.sedeEmpleado.id = 0;

            if (usuario.dni_empleado == this.DNI)
                this.sedeEmpleado = this.obtenerSede(idSede);

            return sedeEmpleado;
        }

        public Sede obtenerSede(int id)
        {
            sede.getSede(id);
            return sede;
        }
    }
}
