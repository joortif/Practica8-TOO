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

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btSoloLectura_Click(object sender)
        {
            TextBoxColoreado tbc = sender as TextBoxColoreado;
            if (tbc != null)
            {
                tbc.ReadOnly = true;
            }
        }

        private void btCrear_Click(object sender, EventArgs e)
        {

            TextBoxColoreado tbc2 = new TextBoxColoreado();
            this.Controls.Add(tbc2);

            tbc2.Height = 20;
            tbc2.Width = 100;
            tbc2.Location = new Point(571, 111);
            tbc2.Show();

            Button btCrear2 = new Button();
            this.Controls.Add(btCrear2);

            btCrear2.Height = 23;
            btCrear2.Width = 75;
            btCrear2.Location = new Point(571, 170);
            btCrear2.Text = "Solo Lectura";
            btCrear2.Click += new System.EventHandler(btCrear_Click(tbc2));
            btCrear2.Show();

            this.btCrear.Enabled = false;
            
        }

    }
}
