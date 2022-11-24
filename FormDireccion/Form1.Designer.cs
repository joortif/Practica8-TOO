namespace FormDireccion
{
    partial class FormularioDireccion
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
            this.direccion1 = new Direccion.Direccion();
            this.btCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // direccion1
            // 
            this.direccion1.Location = new System.Drawing.Point(1, 12);
            this.direccion1.Name = "direccion1";
            this.direccion1.Size = new System.Drawing.Size(800, 450);
            this.direccion1.TabIndex = 0;
            // 
            // btCancelar
            // 
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Location = new System.Drawing.Point(198, 342);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 1;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // FormularioDireccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancelar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.direccion1);
            this.Name = "FormularioDireccion";
            this.Text = "Formulario Direccion";
            this.ResumeLayout(false);

        }

        #endregion

        private Direccion.Direccion direccion1;
        private System.Windows.Forms.Button btCancelar;
    }
}

