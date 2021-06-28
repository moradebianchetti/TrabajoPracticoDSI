namespace TrabajoPracticoDSI
{
    partial class Frm_principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Este = new TrabajoPracticoDSI.Clase.Button_Museo();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_1 = new TrabajoPracticoDSI.Clase.Button_Museo();
            this.button_Museo2 = new TrabajoPracticoDSI.Clase.Button_Museo();
            this.button_Museo3 = new TrabajoPracticoDSI.Clase.Button_Museo();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label2.Font = new System.Drawing.Font("Open Sans", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(641, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "Museo pictórico de la ciudad de Córdoba";
            // 
            // Btn_Este
            // 
            this.Btn_Este.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Este.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Btn_Este.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Este.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Este.ForeColor = System.Drawing.Color.Black;
            this.Btn_Este.Location = new System.Drawing.Point(298, 184);
            this.Btn_Este.Name = "Btn_Este";
            this.Btn_Este.Pp_Presionado = false;
            this.Btn_Este.Size = new System.Drawing.Size(232, 41);
            this.Btn_Este.TabIndex = 0;
            this.Btn_Este.Text = "Registrar venta de entradas";
            this.Btn_Este.UseVisualStyleBackColor = false;
            this.Btn_Este.Click += new System.EventHandler(this.button_Aerolinea1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 73);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(803, 91);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btn_1
            // 
            this.btn_1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btn_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_1.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1.ForeColor = System.Drawing.Color.Black;
            this.btn_1.Location = new System.Drawing.Point(298, 304);
            this.btn_1.Name = "btn_1";
            this.btn_1.Pp_Presionado = false;
            this.btn_1.Size = new System.Drawing.Size(232, 48);
            this.btn_1.TabIndex = 0;
            this.btn_1.Text = "Registrar reserva de visita guiada";
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // button_Museo2
            // 
            this.button_Museo2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_Museo2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.button_Museo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Museo2.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Museo2.ForeColor = System.Drawing.Color.Black;
            this.button_Museo2.Location = new System.Drawing.Point(298, 374);
            this.button_Museo2.Name = "button_Museo2";
            this.button_Museo2.Pp_Presionado = false;
            this.button_Museo2.Size = new System.Drawing.Size(232, 53);
            this.button_Museo2.TabIndex = 0;
            this.button_Museo2.Text = "Generar planificación de exposición";
            this.button_Museo2.UseVisualStyleBackColor = false;
            this.button_Museo2.Click += new System.EventHandler(this.button_Museo2_Click);
            // 
            // button_Museo3
            // 
            this.button_Museo3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_Museo3.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.button_Museo3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Museo3.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Museo3.ForeColor = System.Drawing.Color.Black;
            this.button_Museo3.Location = new System.Drawing.Point(298, 245);
            this.button_Museo3.Name = "button_Museo3";
            this.button_Museo3.Pp_Presionado = false;
            this.button_Museo3.Size = new System.Drawing.Size(232, 41);
            this.button_Museo3.TabIndex = 0;
            this.button_Museo3.Text = "Registrar obra";
            this.button_Museo3.UseVisualStyleBackColor = false;
            this.button_Museo3.Click += new System.EventHandler(this.button_Museo3_Click);
            // 
            // Frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrabajoPracticoDSI.Properties.Resources.Museo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Museo3);
            this.Controls.Add(this.button_Museo2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.Btn_Este);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "Frm_principal";
            this.Text = "Museo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clase.Button_Museo Btn_Este;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Clase.Button_Museo btn_1;
        private Clase.Button_Museo button_Museo2;
        private Clase.Button_Museo button_Museo3;
    }
}

