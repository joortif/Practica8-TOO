using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BotonesNumerados
{
    public partial class BotonesNumerados: UserControl
    {
        private int n;
        public BotonesNumerados()
        {
            InitializeComponent();
            Button bt1 = new Button();
            bt1.Location = new Point(240, 87);
            bt1.Text = "1";
            bt1.Height = 75;
            bt1.Width = 67;
            bt1.Click += new EventHandler(Boton_Click);
            this.Controls.Add(bt1);


            Button bt2 = new Button();
            bt2.Location = new Point(310, 87);
            bt2.Text = "2";
            bt2.Height = 75;
            bt2.Width = 67;
            bt2.Click += new EventHandler(Boton_Click);
            this.Controls.Add(bt2);

            Button bt3 = new Button();
            bt3.Location = new Point(381, 87);
            bt3.Text = "3";
            bt3.Height = 75;
            bt3.Width = 67;
            bt3.Click += new EventHandler(Boton_Click);
            this.Controls.Add(bt3);

            Button bt4 = new Button();
            bt4.Location = new Point(240, 160);
            bt4.Text = "4";
            bt4.Height = 75;
            bt4.Width = 67;
            bt4.Click += new EventHandler(Boton_Click);
            this.Controls.Add(bt4);

            Button bt5 = new Button();
            bt5.Location = new Point(310, 160);
            bt5.Text = "5";
            bt5.Height = 75;
            bt5.Width = 67;
            bt5.Click += new EventHandler(Boton_Click);
            this.Controls.Add(bt5);

            Button bt6 = new Button();
            bt6.Location = new Point(381, 160);
            bt6.Text = "6";
            bt6.Height = 75;
            bt6.Width = 67;
            bt6.Click += new EventHandler(Boton_Click);
            this.Controls.Add(bt6);

            Button bt7 = new Button();
            bt7.Location = new Point(240, 233);
            bt7.Text = "7";
            bt7.Height = 75;
            bt7.Width = 67;
            bt7.Click += new EventHandler(Boton_Click);
            this.Controls.Add(bt7);

            Button bt8 = new Button();
            bt8.Location = new Point(311, 233);
            bt8.Text = "8";
            bt8.Height = 75;
            bt8.Width = 67;
            bt8.Click += new EventHandler(Boton_Click);
            this.Controls.Add(bt8);

            Button bt9 = new Button();
            bt9.Location = new Point(381, 233);
            bt9.Text = "9";
            bt9.Height = 75;
            bt9.Width = 67;
            bt9.Click += new EventHandler(Boton_Click);
            this.Controls.Add(bt9);


        }

        public int N
        {
            get { return n; }
        }

        public BotonesNumerados(int n)
        {
            InitializeComponent();
            this.n = n;
            int x = 0;
            int y = 0;
            
            for (int i=0;i < n; i++)
            {
                for (int j=0; j<n; j++)
                {
                    Button b = new Button();
                    b.Text = "Boton" + i;
                    b.Size = new Size(20, 20);
                    b.Name = "bt" + i;
             
                }
            }
        }

        private void Boton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha pulsado el " + (sender as Button).Text, "Aviso");
        }
    }
}
