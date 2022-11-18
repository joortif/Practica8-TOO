namespace Form1
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
            this.btMultilinea = new System.Windows.Forms.Button();
            this.tbMultiline = new Biblioteca.TextBoxMultiline();
            this.botonesNumerados1 = new BotonesNumerados.BotonesNumerados();
            this.SuspendLayout();
            // 
            // btMultilinea
            // 
            this.btMultilinea.Location = new System.Drawing.Point(98, 326);
            this.btMultilinea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btMultilinea.Name = "btMultilinea";
            this.btMultilinea.Size = new System.Drawing.Size(100, 28);
            this.btMultilinea.TabIndex = 1;
            this.btMultilinea.Text = "Multilinea";
            this.btMultilinea.UseVisualStyleBackColor = true;
            this.btMultilinea.Click += new System.EventHandler(this.btMultilinea_Click);
            // 
            // tbMultiline
            // 
            this.tbMultiline.Location = new System.Drawing.Point(98, 296);
            this.tbMultiline.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMultiline.Name = "tbMultiline";
            this.tbMultiline.Size = new System.Drawing.Size(149, 22);
            this.tbMultiline.TabIndex = 0;
            // 
            // botonesNumerados1
            // 
            this.botonesNumerados1.Location = new System.Drawing.Point(255, 33);
            this.botonesNumerados1.Name = "botonesNumerados1";
            this.botonesNumerados1.Size = new System.Drawing.Size(800, 450);
            this.botonesNumerados1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.botonesNumerados1);
            this.Controls.Add(this.btMultilinea);
            this.Controls.Add(this.tbMultiline);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Formulario de prueba";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Biblioteca.TextBoxMultiline tbMultiline;
        private System.Windows.Forms.Button btMultilinea;
        private BotonesNumerados.BotonesNumerados botonesNumerados1;
    }
}

