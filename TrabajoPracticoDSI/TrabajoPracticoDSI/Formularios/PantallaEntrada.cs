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
    public partial class PantallaEntrada : Form
    {
        public int capacidadMaximaSede { get; set; }
        public int nroVisitantesActuales { get; set; }

        public PantallaEntrada()
        {
            InitializeComponent();
        }
        public void actualizarCantidadVisitantes(int visitantesActuales, Sede sedeActual)
        {
            this.capacidadMaximaSede = sedeActual.cantidadMaxVisitantes;
            this.nroVisitantesActuales = visitantesActuales;
            txt_visitantes.Text = visitantesActuales.ToString();
            this.ShowDialog();
        }
        
        
    }
}
