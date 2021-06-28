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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_cantidad = new System.Windows.Forms.Label();
            this.txt_montoU = new System.Windows.Forms.Label();
            this.txt_montoT = new System.Windows.Forms.Label();
            this.button_Museo1 = new TrabajoPracticoDSI.Clase.Button_Museo();
            this.btn_confirmar = new TrabajoPracticoDSI.Clase.Button_Museo();
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Tarifas)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDeSeleccion
            // 
            this.labelDeSeleccion.AutoSize = true;
            this.labelDeSeleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeSeleccion.Location = new System.Drawing.Point(71, 268);
            this.labelDeSeleccion.Name = "labelDeSeleccion";
            this.labelDeSeleccion.Size = new System.Drawing.Size(208, 17);
            this.labelDeSeleccion.TabIndex = 3;
            this.labelDeSeleccion.Text = "Ingrese la cantidad de entradas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seleccione una entrada";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cantidad de entradas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Monto Unitario:  $";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Monto total:  $";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_montoT);
            this.groupBox1.Controls.Add(this.txt_montoU);
            this.groupBox1.Controls.Add(this.txt_cantidad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(15, 291);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 107);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.AutoSize = true;
            this.txt_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad.Location = new System.Drawing.Point(156, 16);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(46, 17);
            this.txt_cantidad.TabIndex = 12;
            this.txt_cantidad.Text = "label5";
            // 
            // txt_montoU
            // 
            this.txt_montoU.AutoSize = true;
            this.txt_montoU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_montoU.Location = new System.Drawing.Point(156, 45);
            this.txt_montoU.Name = "txt_montoU";
            this.txt_montoU.Size = new System.Drawing.Size(46, 17);
            this.txt_montoU.TabIndex = 13;
            this.txt_montoU.Text = "label6";
            // 
            // txt_montoT
            // 
            this.txt_montoT.AutoSize = true;
            this.txt_montoT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_montoT.Location = new System.Drawing.Point(156, 72);
            this.txt_montoT.Name = "txt_montoT";
            this.txt_montoT.Size = new System.Drawing.Size(46, 17);
            this.txt_montoT.TabIndex = 14;
            this.txt_montoT.Text = "label7";
            // 
            // button_Museo1
            // 
            this.button_Museo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_Museo1.Location = new System.Drawing.Point(15, 441);
            this.button_Museo1.Name = "button_Museo1";
            this.button_Museo1.Pp_Presionado = false;
            this.button_Museo1.Size = new System.Drawing.Size(116, 34);
            this.button_Museo1.TabIndex = 13;
            this.button_Museo1.Text = "Cancelar";
            this.button_Museo1.UseVisualStyleBackColor = true;
            this.button_Museo1.Click += new System.EventHandler(this.cancelarVenta);
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Enabled = false;
            this.btn_confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_confirmar.Location = new System.Drawing.Point(445, 441);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Pp_Presionado = false;
            this.btn_confirmar.Size = new System.Drawing.Size(116, 34);
            this.btn_confirmar.TabIndex = 12;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.tomarSeleccionConfirmarCompra);
            // 
            // Btn_2
            // 
            this.Btn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Btn_2.Location = new System.Drawing.Point(472, 262);
            this.Btn_2.Name = "Btn_2";
            this.Btn_2.Pp_Presionado = false;
            this.Btn_2.Size = new System.Drawing.Size(116, 34);
            this.Btn_2.TabIndex = 4;
            this.Btn_2.Text = "Continuar ->";
            this.Btn_2.UseVisualStyleBackColor = true;
            this.Btn_2.Visible = false;
            this.Btn_2.Click += new System.EventHandler(this.tomarSeleccionCantidadEntradas);
            // 
            // msk_Entradas
            // 
            this.msk_Entradas.Enabled = false;
            this.msk_Entradas.Location = new System.Drawing.Point(285, 265);
            this.msk_Entradas.Mask = "000";
            this.msk_Entradas.Name = "msk_Entradas";
            this.msk_Entradas.Pp_EsPk = false;
            this.msk_Entradas.Pp_MensajeError = null;
            this.msk_Entradas.Pp_NombreCampo = null;
            this.msk_Entradas.Pp_NombreTabla = null;
            this.msk_Entradas.Size = new System.Drawing.Size(30, 20);
            this.msk_Entradas.TabIndex = 2;
            // 
            // Btn_1
            // 
            this.Btn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Btn_1.Location = new System.Drawing.Point(472, 262);
            this.Btn_1.Name = "Btn_1";
            this.Btn_1.Pp_Presionado = false;
            this.Btn_1.Size = new System.Drawing.Size(116, 34);
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
            this.grid_Tarifas.Size = new System.Drawing.Size(583, 196);
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
            this.TipoEntrada.Width = 120;
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
            this.Guia.Width = 120;
            // 
            // Indice
            // 
            this.Indice.HeaderText = "asdasd";
            this.Indice.Name = "Indice";
            this.Indice.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(12, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(101, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(82, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "-";
            this.label7.Visible = false;
            // 
            // Frm_pantallaRegistrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(600, 487);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_Museo1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.Btn_2);
            this.Controls.Add(this.labelDeSeleccion);
            this.Controls.Add(this.msk_Entradas);
            this.Controls.Add(this.Btn_1);
            this.Controls.Add(this.grid_Tarifas);
            this.Name = "Frm_pantallaRegistrarVenta";
            this.Text = "Frm_pantallaRegistrarVenta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Tarifas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clase.DataGridView_Museo grid_Tarifas;
        private Clase.Button_Museo Btn_1;
        private Clase.MaskedTextBox_Museo msk_Entradas;
        private System.Windows.Forms.Label labelDeSeleccion;
        private Clase.Button_Museo Btn_2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Clase.Button_Museo btn_confirmar;
        private System.Windows.Forms.GroupBox groupBox1;
        private Clase.Button_Museo button_Museo1;
        private System.Windows.Forms.Label txt_montoT;
        private System.Windows.Forms.Label txt_montoU;
        private System.Windows.Forms.Label txt_cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoVisita;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoGuia;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Guia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Indice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}