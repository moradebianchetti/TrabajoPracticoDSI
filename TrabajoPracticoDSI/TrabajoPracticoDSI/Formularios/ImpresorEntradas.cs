using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPracticoDSI.Formularios
{
    public partial class ImpresorEntradas : Form
    {
        public ImpresorEntradas()
        {
            InitializeComponent();
        }
        public void imprimirEntradas()
        {
            this.ShowDialog();
        }

    }
}
