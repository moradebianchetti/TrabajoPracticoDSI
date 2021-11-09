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
    public partial class PantallaEntrada : Form, iObservadorActualizarPantalla
    {
        public int cantidadVisitantes { get; set; }
        public int capacidadMaximaSede { get; set; }

        public PantallaEntrada()
        {
            InitializeComponent();
        }
        public void actualizarCantidadVisitantes(int cantidadVisitantes, int cantidadMaximaVisitantes)
        {
            this.capacidadMaximaSede = cantidadMaximaVisitantes;
            txt_MaxCant.Text = cantidadMaximaVisitantes.ToString();
            this.setCantidadVisitantes(cantidadVisitantes);
        }
        public void setCantidadVisitantes(int cantidadVisitantes)
        {
            this.cantidadVisitantes = cantidadVisitantes;
            txt_visitantes.Text = cantidadVisitantes.ToString();
           
        }
        //public void actualizarCantidadVisitantes(int visitantesActuales, int cantidadMxVisitantes)
        //{
        //    this.capacidadMaximaSede = cantidadMxVisitantes;
        //    this.nroVisitantesActuales = visitantesActuales;
        //    txt_visitantes.Text = visitantesActuales.ToString();
        //    this.ShowDialog();
        //}
    }
}
