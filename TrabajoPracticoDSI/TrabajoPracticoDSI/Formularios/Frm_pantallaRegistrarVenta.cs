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
        public Tarifa tarifaSeleccionada= new Tarifa();

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

            this.tarifaSeleccionada.monto = int.Parse(grid_Tarifas.CurrentRow.Cells["Monto"].Value.ToString());
            int indiceSeleccionado = int.Parse(grid_Tarifas.CurrentRow.Cells["Indice"].Value.ToString());
          
            //this.tarifaSeleccionada.fechaInicioVigencia = DateTime.Now.ToString("dd-MM-yyyy");
            this.tarifaSeleccionada.fechaInicioVigencia = "27-06-2021";
            this.tarifaSeleccionada.fechaFinVigencia = DateTime.Now.ToString("dd-MM-yyyy"); //agregarle dias
            this.tarifaSeleccionada.tipoVisita =listaTarifas[indiceSeleccionado].tipoVisita;
            this.tarifaSeleccionada.tipoVisita.id = listaTarifas[indiceSeleccionado].tipoVisita.id;
            //MessageBox.Show("tipo visita " + listaTarifas[indiceSeleccionado].tipoVisita.id);
            this.tarifaSeleccionada.tipoEntrada = listaTarifas[indiceSeleccionado].tipoEntrada;
            this.tarifaSeleccionada.montoAdicionalGuia = int.Parse(grid_Tarifas.CurrentRow.Cells["MontoGuia"].Value.ToString());

            gestor.tomarSeleccionTarifa(this.tarifaSeleccionada);

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
            if(msk_Entradas.Text != "")
            {
                gestor.tomarSeleccionCantidadEntradas(int.Parse(msk_Entradas.Text));
            }else
            {
                MessageBox.Show("Por favor ingrese una cantidad");
            }

        }

        public void mostrarEntradasAComprar()
        {
            groupBox1.Visible = true;
            txt_cantidad.Text = msk_Entradas.Text;
            txt_montoU.Text = this.tarifaSeleccionada.monto.ToString();

            txt_montoT.Text = (this.tarifaSeleccionada.monto * int.Parse(msk_Entradas.Text)).ToString();
        }
        public void solicitarConfirmacionCompra()
        {
            MessageBox.Show("¿Desea confirmar la compra?"); //VER ESTO
        }
       
        private void tomarSeleccionConfirmarCompra(object sender, EventArgs e)
        {
            gestor.tomarSeleccionConfirmarCompra(int.Parse(msk_Entradas.Text), int.Parse(txt_montoT.Text));
        }

        private void Frm_pantallaRegistrarVenta_Load(object sender, EventArgs e)
        {

        }
    }
}
