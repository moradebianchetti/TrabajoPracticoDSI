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
        public List<Tarifa> listaTarifas = new List<Tarifa>();
        GestorRegistrarVentaEntrada gestor = new GestorRegistrarVentaEntrada();


        public Frm_pantallaRegistrarVenta()
        {
            InitializeComponent();
        }

        public void opcionRegistrarVenta(Sesion sesion)
        {
            gestor.tomarSeleccionOpcionRegistrarVenta(sesion);
            this.habilitarPantalla();
        }

        private void habilitarPantalla()
        {
            this.ShowDialog();
        }
        
        public void solicitaSeleccionTarifa(List<Tarifa> tarifas)
        {
            listaTarifas = tarifas;
            mostrarTarifas(tarifas);
        }

        private void mostrarTarifas(List<Tarifa> tarifas)
        {
            grid_Tarifas.Rows.Clear();
            for (int i = 0; i < tarifas.Count; i++)
            {
                
                grid_Tarifas.Rows.Add();
                grid_Tarifas.Rows[i].Cells[0].Value = tarifas[i].tipoVisita.nombre;
                grid_Tarifas.Rows[i].Cells[1].Value = tarifas[i].tipoEntrada.nombre;
                grid_Tarifas.Rows[i].Cells[2].Value = tarifas[i].monto;
                grid_Tarifas.Rows[i].Cells[3].Value = tarifas[i].montoAdicionalGuia;
                grid_Tarifas.Rows[i].Cells[5].Value = i;
            }
        }

        private void tomarSeleccionTarifa(object sender, EventArgs e)
        {
            Tarifa tarifa = new Tarifa();
            tarifa.monto = int.Parse(grid_Tarifas.CurrentRow.Cells["Monto"].Value.ToString());
            int indiceSeleccionado = int.Parse(grid_Tarifas.CurrentRow.Cells["Indice"].Value.ToString());
            tarifa.tipoVisita = listaTarifas[indiceSeleccionado].tipoVisita;
            tarifa.tipoEntrada = listaTarifas[indiceSeleccionado].tipoEntrada;
            tarifa.montoAdicionalGuia = int.Parse(grid_Tarifas.CurrentRow.Cells["MontoGuia"].Value.ToString());

            gestor.tomarSeleccionTarifa(tarifa);

            Btn_1.Visible = false;
            Btn_2.Visible = true;
            grid_Tarifas.Enabled = false;
            msk_Entradas.Enabled = true;
        }

        public void solicitarSeleccionCantidadEntradas()
        {
            mostrarSeleccionCantidadEntradas();
        }

        private void mostrarSeleccionCantidadEntradas()
        {

            
        }

        private void tomarSeleccionCantidadEntradas(object sender, EventArgs e)
        {
            gestor.tomarSeleccionCantidadEntradas();
        }
    }
}
