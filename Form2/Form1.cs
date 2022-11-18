using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btSoloLectura_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (b.Name == btSoloLectura.Name)
            {
                this.tbc1.ReadOnly = true;
            } else if (this.Controls["botontbc2"] != null)
            {   
                if (b.Name == this.Controls["botontbc2"].Name)
                {
                    (this.Controls["tbc2"] as TextBoxColoreado).ReadOnly = true;
                }
            }

        }

        private void btCrear_Click(object sender, EventArgs e)
        {

            TextBoxColoreado tbc2 = new TextBoxColoreado();

            tbc2.Height = 22;
            tbc2.Width = 100;
            tbc2.Name = "tbc2";
            tbc2.Location = new Point(400, 85);
            this.Controls.Add(tbc2);

            Button botontbc2 = new Button();

            botontbc2.Height = 23;
            botontbc2.Width = 100;
            botontbc2.Location = new Point(400, 185);
            botontbc2.Name = "botontbc2";
            botontbc2.Text = "Solo Lectura";
            botontbc2.Click += new EventHandler(btSoloLectura_Click);
            this.Controls.Add(botontbc2);

            this.btCrear.Enabled = false;

        }

    }
}
