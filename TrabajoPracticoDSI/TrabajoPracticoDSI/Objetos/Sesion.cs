using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoDSI.Objetos
{
   public class Sesion
    {
        public string fechaFin { get; set; }
        public string fechaInicio { get; set; }
        public string horaFin { get; set; }
        public string horaInicio { get; set; }
        public Usuario usuario { get; set; }

        public int BuscarUsuario()
        {
            return usuario.dni_empleado;
        }
    }
}
