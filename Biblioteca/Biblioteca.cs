using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public class TextBoxMultiline : TextBox
    {
        public override bool Multiline
        {
            get
            {
                return base.Multiline;
            }
            set
            {

                if (base.Multiline != value)
                {
                    if (value)
                    {
                        this.Height = this.Height * 2;
                    }
                    else
                    {
                        this.Height = this.Height / 2;
                    }
                    base.Multiline = value;

                }
            }
        }
    }
    public class TextBoxColoreado : TextBox
    {
        public new bool ReadOnly
        {
            get
            {
                return base.ReadOnly;
            }
            set
            {
                if (base.ReadOnly != value)
                {
                    this.BackColor = Color.FromKnownColor(KnownColor.Red);
                }
                else
                {
                    this.BackColor = Color.FromKnownColor(KnownColor.Window);
                }
                base.ReadOnly = value;
            }
        }
    }
}
