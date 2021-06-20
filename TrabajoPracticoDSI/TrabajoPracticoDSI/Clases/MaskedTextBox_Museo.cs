using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPracticoDSI.Clase
{
    class MaskedTextBox_Museo : MaskedTextBox
    {
        public string Pp_NombreCampo { get; set; }
        public string Pp_NombreTabla { get; set; }
        public bool Pp_EsPk { get; set; }
        public string Pp_MensajeError { get; set; }
    }
}
