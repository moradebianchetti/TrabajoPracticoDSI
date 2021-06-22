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
        // ESTO ES ILEGAL PERO FUNCIONA
        // ESTO ES ILEGAL PERO FUNCIONA
        // ESTO ES ILEGAL PERO FUNCIONA
        // ESTO ES ILEGAL PERO FUNCIONA
        // ESTO ES ILEGAL PERO FUNCIONA
        public static Frm_pantallaRegistrarVenta pantalla = new Frm_pantallaRegistrarVenta();
        Sesion sesion = new Sesion();
        // ESTO ES ILEGAL PERO FUNCIONA
        // ESTO ES ILEGAL PERO FUNCIONA
        // ESTO ES ILEGAL PERO FUNCIONA
        // ESTO ES ILEGAL PERO FUNCIONA
        // ESTO ES ILEGAL PERO FUNCIONA

        public Frm_principal()
        {
            InitializeComponent();
        }


        private void button_Aerolinea1_Click(object sender, EventArgs e)
        {
            pantalla.opcionRegistrarVenta(sesion);
        }

        private void Frm_principal_Load(object sender, EventArgs e)
        {
            Frm_Login login = new Frm_Login();
            login.habilitarPantalla();
            sesion = login.SesionActual();
            login.Dispose();

            if (sesion.fechaInicio == null)
                Application.Exit();
        }
    }
}
