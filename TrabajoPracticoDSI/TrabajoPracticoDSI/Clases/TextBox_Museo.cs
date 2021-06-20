using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPracticoDSI.Clase
{
    class TextBox_Museo : TextBox
    {
        public string Pp_NombreTabla { get; set; }
        public string Pp_MensajeError { get; set; }
        public string Pp_NombreCampo { get; set; }
        public bool Pp_EsPk { get; set; }
    }
}
