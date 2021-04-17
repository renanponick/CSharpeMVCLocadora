using System;
using System.Windows.Forms;
using System.Drawing;

namespace View
{
    namespace Lib
    {
        public class TablePadrao : TableLayoutPanel
        {
            public TablePadrao(int width, int height){
                this.Size = new Size(width, height);
                //this.SetColumn(this, 3);
            }
        }
    }
}