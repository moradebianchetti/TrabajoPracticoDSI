using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPracticoDSI.Formularios;
using TrabajoPracticoDSI.Objetos;

namespace TrabajoPracticoDSI
{
    public partial class Frm_principal : Form
    {
        public Frm_principal()
        {
            InitializeComponent();

            Frm_Login login = new Frm_Login();
            login.habilitarPantalla();
            Sesion sesion = login.SesionActual();

           //ENZO NEED YOU
        }


        private void button_Aerolinea1_Click(object sender, EventArgs e)
        {
            Frm_pantallaRegistrarVenta pantalla = new Frm_pantallaRegistrarVenta();
            pantalla.opcionRegistrarVenta();
        }
    }
}
