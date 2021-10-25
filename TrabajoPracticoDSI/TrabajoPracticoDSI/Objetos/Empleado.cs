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

        public Empleado(DataRow emp)
        {
            
            this.DNI = int.Parse(emp["DNI"].ToString());
            this.idCargo = int.Parse(emp["idCargo"].ToString());
            this.apellido = emp["apellido"].ToString();
            this.nombre = emp["nombre"].ToString();
            sedeEmpleado = new Sede(int.Parse(emp["idSede"].ToString()));
            this.sedeEmpleado.getSede(int.Parse(emp["idSede"].ToString()));

        }

        public bool esTuUsuario(Usuario usuario)
        {
            if (usuario.dni_empleado == this.DNI)
                return true;
            else
                return false; ;

        }

        public Sede obtenerSede()
        {
            return sedeEmpleado;
        }
    }
}
