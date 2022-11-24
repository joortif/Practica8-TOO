using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BotonesNumerados bn = new BotonesNumerados(5);
        }

        private void btMultilinea_Click(object sender, EventArgs e)
        {
            if (!this.tbMultiline.Multiline)
            {
                this.tbMultiline.Multiline = true;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
