namespace TrabajoPracticoDSI.Formularios
{
    partial class Frm_pantallaRegistrarVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelDeSeleccion = new System.Windows.Forms.Label();
            this.Btn_2 = new TrabajoPracticoDSI.Clase.Button_Museo();
            this.msk_Entradas = new TrabajoPracticoDSI.Clase.MaskedTextBox_Museo();
            this.Btn_1 = new TrabajoPracticoDSI.Clase.Button_Museo();
            this.grid_Tarifas = new TrabajoPracticoDSI.Clase.DataGridView_Museo();
            this.TipoVisita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoGuia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Guia = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Indice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Tarifas)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDeSeleccion
            // 
            this.labelDeSeleccion.AutoSize = true;
            this.labelDeSeleccion.Location = new System.Drawing.Point(12, 253);
            this.labelDeSeleccion.Name = "labelDeSeleccion";
            this.labelDeSeleccion.Size = new System.Drawing.Size(174, 13);
            this.labelDeSeleccion.TabIndex = 3;
            this.labelDeSeleccion.Text = "Seleccione la cantidad de entradas";
            this.labelDeSeleccion.Visible = false;
            // 
            // Btn_2
            // 
            this.Btn_2.Location = new System.Drawing.Point(415, 342);
            this.Btn_2.Name = "Btn_2";
            this.Btn_2.Pp_Presionado = false;
            this.Btn_2.Size = new System.Drawing.Size(146, 34);
            this.Btn_2.TabIndex = 4;
            this.Btn_2.Text = "Continuar ->";
            this.Btn_2.UseVisualStyleBackColor = true;
            this.Btn_2.Visible = false;
            this.Btn_2.Click += new System.EventHandler(this.tomarSeleccionCantidadEntradas);
            // 
            // msk_Entradas
            // 
            this.msk_Entradas.Location = new System.Drawing.Point(15, 282);
            this.msk_Entradas.Mask = "000";
            this.msk_Entradas.Name = "msk_Entradas";
            this.msk_Entradas.Pp_EsPk = false;
            this.msk_Entradas.Pp_MensajeError = null;
            this.msk_Entradas.Pp_NombreCampo = null;
            this.msk_Entradas.Pp_NombreTabla = null;
            this.msk_Entradas.Size = new System.Drawing.Size(100, 20);
            this.msk_Entradas.TabIndex = 2;
            this.msk_Entradas.Visible = false;
            // 
            // Btn_1
            // 
            this.Btn_1.Location = new System.Drawing.Point(415, 342);
            this.Btn_1.Name = "Btn_1";
            this.Btn_1.Pp_Presionado = false;
            this.Btn_1.Size = new System.Drawing.Size(146, 34);
            this.Btn_1.TabIndex = 1;
            this.Btn_1.Text = "Continuar ->";
            this.Btn_1.UseVisualStyleBackColor = true;
            this.Btn_1.Click += new System.EventHandler(this.tomarSeleccionTarifa);
            // 
            // grid_Tarifas
            // 
            this.grid_Tarifas.AllowUserToAddRows = false;
            this.grid_Tarifas.AllowUserToDeleteRows = false;
            this.grid_Tarifas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Tarifas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoVisita,
            this.TipoEntrada,
            this.Monto,
            this.MontoGuia,
            this.Guia,
            this.Indice});
            this.grid_Tarifas.Location = new System.Drawing.Point(12, 34);
            this.grid_Tarifas.Name = "grid_Tarifas";
            this.grid_Tarifas.Pp_FormatoGrid = null;
            this.grid_Tarifas.Pp_NombreTabla = null;
            this.grid_Tarifas.Size = new System.Drawing.Size(548, 202);
            this.grid_Tarifas.TabIndex = 0;
            // 
            // TipoVisita
            // 
            this.TipoVisita.HeaderText = "Tipo de visita";
            this.TipoVisita.Name = "TipoVisita";
            // 
            // TipoEntrada
            // 
            this.TipoEntrada.HeaderText = "Tipo de entrada";
            this.TipoEntrada.Name = "TipoEntrada";
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            // 
            // MontoGuia
            // 
            this.MontoGuia.HeaderText = "Monto adicional por guía";
            this.MontoGuia.Name = "MontoGuia";
            // 
            // Guia
            // 
            this.Guia.HeaderText = "Guía";
            this.Guia.Name = "Guia";
            // 
            // Indice
            // 
            this.Indice.HeaderText = "asdasd";
            this.Indice.Name = "Indice";
            this.Indice.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seleccione la cantidad de entradas";
            this.label1.Visible = false;
            // 
            // Frm_pantallaRegistrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 388);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_2);
            this.Controls.Add(this.labelDeSeleccion);
            this.Controls.Add(this.msk_Entradas);
            this.Controls.Add(this.Btn_1);
            this.Controls.Add(this.grid_Tarifas);
            this.Name = "Frm_pantallaRegistrarVenta";
            this.Text = "Frm_pantallaRegistrarVenta";
            ((System.ComponentModel.ISupportInitialize)(this.grid_Tarifas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clase.DataGridView_Museo grid_Tarifas;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoVisita;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoGuia;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Guia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Indice;
        private Clase.Button_Museo Btn_1;
        private Clase.MaskedTextBox_Museo msk_Entradas;
        private System.Windows.Forms.Label labelDeSeleccion;
        private Clase.Button_Museo Btn_2;
        private System.Windows.Forms.Label label1;
    }
}