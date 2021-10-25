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
       
        public static Frm_pantallaRegistrarVenta pantalla = new Frm_pantallaRegistrarVenta();
        Sesion sesion = new Sesion();
      

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

        private void btn_1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esperando implementación");
            return;
        }

        private void button_Museo2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esperando implementación");
            return;
        }

        private void button_Museo3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esperando implementación");
            return;
        }
    }
}
