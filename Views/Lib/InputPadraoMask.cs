using System;
using System.Windows.Forms;
using System.Drawing;

namespace View
{
    namespace Lib
    {
         public class InputPadrao : TextBox{
            public InputPadrao(int sizeX, int locationX, int locationY)
            {
                this.Size = new Size(sizeX ,20);
                this.Location = new Point(locationX, locationY);
            }
        }
        public class InputMascarado : MaskedTextBox{
            public InputMascarado(int sizeX, int locationX, int locationY, String mask)
            {
                this.Size = new Size(sizeX ,20);
                this.Location = new Point(locationX, locationY);
                this.Mask = mask;
            }
        }
    }
}