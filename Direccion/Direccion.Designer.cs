namespace Direccion
{
    partial class Direccion
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

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbCalle = new System.Windows.Forms.TextBox();
            this.tbCiudad = new System.Windows.Forms.TextBox();
            this.tbProvincia = new System.Windows.Forms.TextBox();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.lbCalle = new System.Windows.Forms.Label();
            this.lbCiudad = new System.Windows.Forms.Label();
            this.lbProvincia = new System.Windows.Forms.Label();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.btVerCiudad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbCalle
            // 
            this.tbCalle.Location = new System.Drawing.Point(198, 82);
            this.tbCalle.Name = "tbCalle";
            this.tbCalle.Size = new System.Drawing.Size(100, 20);
            this.tbCalle.TabIndex = 0;
            // 
            // tbCiudad
            // 
            this.tbCiudad.Location = new System.Drawing.Point(198, 130);
            this.tbCiudad.Name = "tbCiudad";
            this.tbCiudad.Size = new System.Drawing.Size(100, 20);
            this.tbCiudad.TabIndex = 1;
            // 
            // tbProvincia
            // 
            this.tbProvincia.Location = new System.Drawing.Point(198, 178);
            this.tbProvincia.Name = "tbProvincia";
            this.tbProvincia.Size = new System.Drawing.Size(100, 20);
            this.tbProvincia.TabIndex = 2;
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(198, 220);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(100, 20);
            this.tbCodigo.TabIndex = 3;
            // 
            // lbCalle
            // 
            this.lbCalle.AutoSize = true;
            this.lbCalle.Location = new System.Drawing.Point(120, 85);
            this.lbCalle.Name = "lbCalle";
            this.lbCalle.Size = new System.Drawing.Size(30, 13);
            this.lbCalle.TabIndex = 4;
            this.lbCalle.Text = "Calle";
            // 
            // lbCiudad
            // 
            this.lbCiudad.AutoSize = true;
            this.lbCiudad.Location = new System.Drawing.Point(120, 130);
            this.lbCiudad.Name = "lbCiudad";
            this.lbCiudad.Size = new System.Drawing.Size(40, 13);
            this.lbCiudad.TabIndex = 5;
            this.lbCiudad.Text = "Ciudad";
            // 
            // lbProvincia
            // 
            this.lbProvincia.AutoSize = true;
            this.lbProvincia.Location = new System.Drawing.Point(120, 178);
            this.lbProvincia.Name = "lbProvincia";
            this.lbProvincia.Size = new System.Drawing.Size(51, 13);
            this.lbProvincia.TabIndex = 6;
            this.lbProvincia.Text = "Provincia";
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Location = new System.Drawing.Point(120, 220);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(40, 13);
            this.lbCodigo.TabIndex = 7;
            this.lbCodigo.Text = "Código";
            // 
            // btVerCiudad
            // 
            this.btVerCiudad.Location = new System.Drawing.Point(198, 278);
            this.btVerCiudad.Name = "btVerCiudad";
            this.btVerCiudad.Size = new System.Drawing.Size(75, 23);
            this.btVerCiudad.TabIndex = 8;
            this.btVerCiudad.Text = "Ver ciudad";
            this.btVerCiudad.UseVisualStyleBackColor = true;
            this.btVerCiudad.Click += new System.EventHandler(this.btVerCiudad_Click);
            // 
            // Direccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btVerCiudad);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.lbProvincia);
            this.Controls.Add(this.lbCiudad);
            this.Controls.Add(this.lbCalle);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.tbProvincia);
            this.Controls.Add(this.tbCiudad);
            this.Controls.Add(this.tbCalle);
            this.Name = "Direccion";
            this.Size = new System.Drawing.Size(800, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCalle;
        private System.Windows.Forms.TextBox tbCiudad;
        private System.Windows.Forms.TextBox tbProvincia;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label lbCalle;
        private System.Windows.Forms.Label lbCiudad;
        private System.Windows.Forms.Label lbProvincia;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Button btVerCiudad;
    }
}
