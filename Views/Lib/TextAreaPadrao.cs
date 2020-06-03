using System;
using System.Windows.Forms;
using System.Drawing;

namespace View
{
    namespace Lib
    {
        public class TextAreaPadrao : RichTextBox{
            public TextAreaPadrao(int sizeX, int locationX, int locationY)
            {
                this.Size = new Size(sizeX ,100);
                this.Location = new Point(locationX, locationY);
            }
        }
    }
}