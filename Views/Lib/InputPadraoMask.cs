using System;
using System.Windows.Forms;
using System.Drawing;

namespace View
{
    namespace Lib
    {
         public class InputPadrao : TextBox{
            public InputPadrao(int sizeX)
            {
                this.Size = new Size(sizeX ,20);
            }
        }
        public class InputMascarado : MaskedTextBox{
            public InputMascarado(int sizeX, String mask)
            {
                this.Size = new Size(sizeX ,20);
                this.Mask = mask;
            }
        }
    }
}