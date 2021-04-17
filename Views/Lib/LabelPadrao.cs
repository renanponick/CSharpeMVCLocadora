using System;
using System.Windows.Forms;
using System.Drawing;

namespace View
{
    namespace Lib
    {
        public class LabelPadrao : Label{
            public LabelPadrao(String name, int sizeX)
            {
                this.Size = new Size(sizeX ,20);
                this.Text = name;
            }
        }
    }
}