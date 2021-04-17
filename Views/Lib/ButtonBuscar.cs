using System;
using System.Windows.Forms;
using System.Drawing;

namespace View
{
    namespace Lib
    {
        public class ButtonsBuscar : Button
        {
            public ButtonsBuscar(int locationX, int locationY, EventHandler click)
            {
                this.Text = "Buscar";
                this.Size = new Size(50 ,20);
                this.Location = new Point(locationX+40, locationY+30);
                this.Click += click;
            }
        }
    }
}