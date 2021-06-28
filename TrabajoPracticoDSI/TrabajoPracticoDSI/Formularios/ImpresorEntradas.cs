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
    public partial class ImpresorEntradas : Form
    {
        public ImpresorEntradas()
        {
            InitializeComponent();
        }
        public void imprimirEntradas(Entrada entrada)
        {

            label2.Text = entrada.fechaVenta.ToString();
            label5.Text = entrada.monto.ToString();
            label3.Text = entrada.numero.ToString();
            label4.Text = entrada.horaVenta.ToString();

            this.ShowDialog();
        }

        
    }
}
