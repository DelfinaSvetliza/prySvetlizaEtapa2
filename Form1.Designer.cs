namespace prySvetlizaEtapa2
{
    partial class Form1
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
            this.pctVehiculo = new System.Windows.Forms.PictureBox();
            this.btnVehiculo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctVehiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // pctVehiculo
            // 
            this.pctVehiculo.Location = new System.Drawing.Point(75, 28);
            this.pctVehiculo.Name = "pctVehiculo";
            this.pctVehiculo.Size = new System.Drawing.Size(417, 297);
            this.pctVehiculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctVehiculo.TabIndex = 0;
            this.pctVehiculo.TabStop = false;
            // 
            // btnVehiculo
            // 
            this.btnVehiculo.Location = new System.Drawing.Point(197, 365);
            this.btnVehiculo.Name = "btnVehiculo";
            this.btnVehiculo.Size = new System.Drawing.Size(125, 57);
            this.btnVehiculo.TabIndex = 1;
            this.btnVehiculo.Text = "Cambiar vehiculo";
            this.btnVehiculo.UseVisualStyleBackColor = true;
            this.btnVehiculo.Click += new System.EventHandler(this.btnVehiculo_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 459);
            this.Controls.Add(this.btnVehiculo);
            this.Controls.Add(this.pctVehiculo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pctVehiculo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctVehiculo;
        private System.Windows.Forms.Button btnVehiculo;
    }
}

