using System;
using System.Windows.Forms;
using System.Drawing;

namespace View
{
    namespace Lib
    {
        public class TextAreaPadrao : RichTextBox{
            public TextAreaPadrao(int sizeX)
            {
                this.Size = new Size(sizeX ,100);
            }
        }
    }
}