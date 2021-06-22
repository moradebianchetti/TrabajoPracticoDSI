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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Museo1 = new TrabajoPracticoDSI.Clase.Button_Museo();
            this.Btn_Este = new TrabajoPracticoDSI.Clase.Button_Museo();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Museo";
            // 
            // button_Museo1
            // 
            this.button_Museo1.Location = new System.Drawing.Point(566, 45);
            this.button_Museo1.Name = "button_Museo1";
            this.button_Museo1.Pp_Presionado = false;
            this.button_Museo1.Size = new System.Drawing.Size(75, 23);
            this.button_Museo1.TabIndex = 3;
            this.button_Museo1.Text = "button_Museo1";
            this.button_Museo1.UseVisualStyleBackColor = true;
            // 
            // Btn_Este
            // 
            this.Btn_Este.Location = new System.Drawing.Point(698, 180);
            this.Btn_Este.Name = "Btn_Este";
            this.Btn_Este.Pp_Presionado = false;
            this.Btn_Este.Size = new System.Drawing.Size(75, 23);
            this.Btn_Este.TabIndex = 0;
            this.Btn_Este.Text = "ESTE";
            this.Btn_Este.UseVisualStyleBackColor = true;
            this.Btn_Este.Click += new System.EventHandler(this.button_Aerolinea1_Click);
            // 
            // Frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Museo1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Este);
            this.Name = "Frm_principal";
            this.Text = "Museo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clase.Button_Museo Btn_Este;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Clase.Button_Museo button_Museo1;
    }
}

