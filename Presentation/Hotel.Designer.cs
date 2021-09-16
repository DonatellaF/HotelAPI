namespace Presentation
{
    partial class Hotel
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
            this.txtNombre = new System.Windows.Forms.Label();
            this.txtNombreValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Location = new System.Drawing.Point(23, 42);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(47, 13);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Text = "Nombre:";
            // 
            // txtNombreValue
            // 
            this.txtNombreValue.AutoSize = true;
            this.txtNombreValue.Location = new System.Drawing.Point(76, 42);
            this.txtNombreValue.Name = "txtNombreValue";
            this.txtNombreValue.Size = new System.Drawing.Size(35, 13);
            this.txtNombreValue.TabIndex = 1;
            this.txtNombreValue.Text = "label2";
            // 
            // Hotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 450);
            this.Controls.Add(this.txtNombreValue);
            this.Controls.Add(this.txtNombre);
            this.Name = "Hotel";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Hotel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.Label txtNombreValue;
    }
}

