using System;
using System.Windows.Forms;
using System.Drawing;

namespace View
{
    namespace Lib
    {
        public class ButtonMenu : Button
        {
            public ButtonMenu(String name, int sizeX, int locationX, int locationY, EventHandler click)
            {
                this.Size = new Size(sizeX ,30);
                this.Text = name;
                this.Location = new Point(locationX, locationY);
                this.Click += click;
            }
        }
    }
}