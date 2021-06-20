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
            this.button_Aerolinea1 = new TrabajoPracticoDSI.Clase.Button_Museo();
            this.SuspendLayout();
            // 
            // button_Aerolinea1
            // 
            this.button_Aerolinea1.Location = new System.Drawing.Point(438, 156);
            this.button_Aerolinea1.Name = "button_Aerolinea1";
            this.button_Aerolinea1.Pp_Presionado = false;
            this.button_Aerolinea1.Size = new System.Drawing.Size(75, 23);
            this.button_Aerolinea1.TabIndex = 0;
            this.button_Aerolinea1.Text = "button_Aerolinea1";
            this.button_Aerolinea1.UseVisualStyleBackColor = true;
            // 
            // Frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Aerolinea1);
            this.Name = "Frm_principal";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Clase.Button_Museo button_Aerolinea1;
    }
}

