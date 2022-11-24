using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Direccion
{
    public partial class Direccion: UserControl
    {
        public Direccion()
        {
            InitializeComponent();
        }

        private void lbCalle_Click(object sender, EventArgs e)
        {

        }

        private void btVerCiudad_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La ciudad es: " + tbCiudad.Text, "Ciudad");
        }
    }
}
