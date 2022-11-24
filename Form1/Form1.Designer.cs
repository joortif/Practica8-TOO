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
            this.btMultilinea.Location = new System.Drawing.Point(74, 265);
            this.btMultilinea.Name = "btMultilinea";
            this.btMultilinea.Size = new System.Drawing.Size(75, 23);
            this.btMultilinea.TabIndex = 1;
            this.btMultilinea.Text = "Multilinea";
            this.btMultilinea.UseVisualStyleBackColor = true;
            this.btMultilinea.Click += new System.EventHandler(this.btMultilinea_Click);
            // 
            // tbMultiline
            // 
            this.tbMultiline.Location = new System.Drawing.Point(74, 240);
            this.tbMultiline.Name = "tbMultiline";
            this.tbMultiline.Size = new System.Drawing.Size(113, 20);
            this.tbMultiline.TabIndex = 0;
            // 
            // botonesNumerados1
            // 
            this.botonesNumerados1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.botonesNumerados1.Location = new System.Drawing.Point(191, 27);
            this.botonesNumerados1.Margin = new System.Windows.Forms.Padding(2);
            this.botonesNumerados1.Name = "botonesNumerados1";
            this.botonesNumerados1.Size = new System.Drawing.Size(600, 366);
            this.botonesNumerados1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonesNumerados1);
            this.Controls.Add(this.btMultilinea);
            this.Controls.Add(this.tbMultiline);
            this.Name = "Form1";
            this.Text = "Formulario de prueba";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Biblioteca.TextBoxMultiline tbMultiline;
        private System.Windows.Forms.Button btMultilinea;
        private BotonesNumerados.BotonesNumerados botonesNumerados1;
    }
}

