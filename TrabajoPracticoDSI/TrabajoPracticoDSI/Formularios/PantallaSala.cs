﻿using System;
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
    public partial class PantallaSala : Form, iObservadorActualizarPantalla
    {
        public int cantidadVisitantes { get; set; }
        public int capacidadMaximaSede { get; set; }

        public PantallaSala()
        {
            InitializeComponent();
        }
        public void actualizarCantidadVisitantes(int cantidadVisitantes, int cantidadMaximaVisitantes)
        {
            this.capacidadMaximaSede = cantidadMaximaVisitantes;
            txt_MaxCant.Text = cantidadMaximaVisitantes.ToString();
            this.cantidadVisitantes = cantidadVisitantes;
            txt_visitantes.Text = cantidadVisitantes.ToString();
            this.ShowDialog();
        }

    }
}