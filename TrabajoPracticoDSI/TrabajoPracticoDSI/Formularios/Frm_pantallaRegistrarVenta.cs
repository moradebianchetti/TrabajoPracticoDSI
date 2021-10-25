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
        public GestorRegistrarVentaEntrada gestor { get; set; }

        public List<object[]> listaTarifas = new List<object[]>();
        
        public Tarifa tarifaSeleccionada= new Tarifa();


        public Frm_pantallaRegistrarVenta()
        {
            gestor = new GestorRegistrarVentaEntrada();

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
        
        

        private void mostrarTarifas(List<object[]> tarifas)
        {
            grid_Tarifas.Rows.Clear();
            int cont = 0;
            foreach (var item in tarifas)
            {
                
                    grid_Tarifas.Rows.Add();
                    grid_Tarifas.Rows[cont].Cells[0].Value = item[0];
                    grid_Tarifas.Rows[cont].Cells[1].Value = item[1];
                    grid_Tarifas.Rows[cont].Cells[2].Value = item[2];
                    grid_Tarifas.Rows[cont].Cells[3].Value = item[3];
                    grid_Tarifas.Rows[cont].Cells[5].Value = cont;
                    cont++;
                
            }


        }
        public void solicitaSeleccionTarifa(List<object[]> tarifas)
        {
            listaTarifas = tarifas;
            mostrarTarifas(tarifas);
        }
        private void tomarSeleccionTarifa(object sender, EventArgs e)
        {
            int indiceSeleccionado = int.Parse(grid_Tarifas.CurrentRow.Cells["Indice"].Value.ToString());
            Object[] aux = listaTarifas[indiceSeleccionado];
            this.tarifaSeleccionada = (Tarifa)aux[4];

            gestor.tomarSeleccionTarifa(this.tarifaSeleccionada);

        }


        public void solicitarSeleccionCantidadEntradas()
        {
            label6.Text = tarifaSeleccionada.tipoVisita.nombre.ToString();
            label6.Visible = true;
            label5.Text = tarifaSeleccionada.tipoEntrada.nombre.ToString();
            label5.Visible = true;
            label7.Visible = true;
            Btn_1.Visible = false;
            Btn_2.Visible = true;
            grid_Tarifas.Enabled = false;
            msk_Entradas.Enabled = true;
          
        }

       
        private void tomarSeleccionCantidadEntradas(object sender, EventArgs e)
        {
            if (msk_Entradas.Text != "")
            {
                Btn_2.Visible = false;
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
            solicitarConfirmacionCompra();

        }
        public void solicitarConfirmacionCompra()
        {
            btn_confirmar.Enabled = true;
        }
       
        private void tomarSeleccionConfirmarCompra(object sender, EventArgs e)
        {
            if (msk_Entradas.Text != "")
            {
                gestor.tomarSeleccionConfirmarCompra(int.Parse(msk_Entradas.Text), int.Parse(txt_montoT.Text));

            }
            else
            {
                MessageBox.Show("Ingrese una cantidad por favor.");
            }
        }
        
        private void cancelarVenta(object sender, EventArgs e)
        {
            this.Close();
            

        }
    }
}
