namespace Form2
{
    partial class Form2
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
            this.btSoloLectura = new System.Windows.Forms.Button();
            this.btCrear = new System.Windows.Forms.Button();
            this.tbc1 = new Biblioteca.TextBoxColoreado();
            this.SuspendLayout();
            // 
            // btSoloLectura
            // 
            this.btSoloLectura.Location = new System.Drawing.Point(179, 171);
            this.btSoloLectura.Name = "btSoloLectura";
            this.btSoloLectura.Size = new System.Drawing.Size(75, 23);
            this.btSoloLectura.TabIndex = 1;
            this.btSoloLectura.Text = "Solo Lectura";
            this.btSoloLectura.UseVisualStyleBackColor = true;
            this.btSoloLectura.Click += new System.EventHandler(this.btSoloLectura_Click);
            // 
            // btCrear
            // 
            this.btCrear.Location = new System.Drawing.Point(179, 233);
            this.btCrear.Name = "btCrear";
            this.btCrear.Size = new System.Drawing.Size(75, 23);
            this.btCrear.TabIndex = 2;
            this.btCrear.Text = "Crear";
            this.btCrear.UseVisualStyleBackColor = true;
            this.btCrear.Click += new System.EventHandler(this.btCrear_Click);
            // 
            // tbc1
            // 
            this.tbc1.BackColor = System.Drawing.SystemColors.Window;
            this.tbc1.Location = new System.Drawing.Point(179, 112);
            this.tbc1.Name = "tbc1";
            this.tbc1.Size = new System.Drawing.Size(100, 20);
            this.tbc1.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btCrear);
            this.Controls.Add(this.btSoloLectura);
            this.Controls.Add(this.tbc1);
            this.Name = "Form2";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Biblioteca.TextBoxColoreado tbc1;
        private System.Windows.Forms.Button btSoloLectura;
        private System.Windows.Forms.Button btCrear;
    }
}

