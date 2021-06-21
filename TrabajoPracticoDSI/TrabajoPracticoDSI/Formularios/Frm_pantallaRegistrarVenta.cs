using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPracticoDSI.Objetos;

namespace TrabajoPracticoDSI.Formularios
{
    public partial class Frm_pantallaRegistrarVenta : Form
    {
        //Atributos


        public Frm_pantallaRegistrarVenta()
        {
            InitializeComponent();
        }

        public void opcionRegistrarVenta()
        {
            this.habilitarPantalla();
        }

        private void habilitarPantalla()
        {
            this.ShowDialog();
            

        }
        

    }
}
