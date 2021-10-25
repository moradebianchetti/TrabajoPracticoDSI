using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPracticoDSI.Backend;

namespace TrabajoPracticoDSI.Clase
{
    class ComboBox_Museo : ComboBox
    {
        public string Pp_NombreCampoInsert { get; set; }
        public string Pp_PkTabla { get; set; }
        public string Pp_NombreCampo { get; set; }
        public string Pp_MensajeError { get; set; }
        public string Pp_NombreTabla { get; set; }
        public bool Pp_CampoAceptaNull { get; set; }
        public bool Pp_EsPk { get; set; }

        Conexion_DB _BD = new Conexion_DB();

        public void CargarCombo()
        {
            string sql = "SELECT " + Pp_PkTabla + ", " + Pp_NombreCampo + " FROM " + Pp_NombreTabla + " ORDER BY " + Pp_NombreTabla + "." + Pp_NombreCampo + " ASC ";
            this.DisplayMember = Pp_NombreCampo;
            this.ValueMember = Pp_PkTabla;
            this.DataSource = _BD.EjecutarSelect(sql);
            if (this.Pp_CampoAceptaNull == true)
            {
                this.SelectedIndex = -1;
            }
            else
            {
                this.SelectedIndex = 0;
            }
        }

        public void CargarComboJoin(string JoinYCondicion)
        {
            string sql = $"SELECT {Pp_PkTabla}, {Pp_NombreCampo} FROM {Pp_NombreTabla} {JoinYCondicion}";
            this.DisplayMember = Pp_NombreCampo;
            this.ValueMember = Pp_PkTabla;
            this.DataSource = _BD.EjecutarSelect(sql);
            if (this.Pp_CampoAceptaNull == true)
            {
                this.SelectedIndex = -1;
            }
            else
            {
                this.SelectedIndex = 0;
            }
        }

        public void CargarComboDependiente(string dependencia)
        {
            string sql = "SELECT " + Pp_PkTabla + ", " + Pp_NombreCampo + " FROM " + Pp_NombreTabla;
            this.DisplayMember = Pp_NombreCampo;
            this.ValueMember = Pp_PkTabla;
            this.DataSource = _BD.EjecutarSelect(sql);
            if (this.Pp_CampoAceptaNull == true)
            {
                this.SelectedIndex = -1;
            }
            else
            {
                this.SelectedIndex = 0;
            }
        }
    }
}
