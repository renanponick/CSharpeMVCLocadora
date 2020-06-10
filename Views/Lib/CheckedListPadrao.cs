using System;
using System.Windows.Forms;
using System.Drawing;

namespace View
{
    namespace Lib
    {
        public class CheckedListPadrao : CheckedListBox
        {
            public CheckedListPadrao(String[] lista, int sizeX, int sizeY){
                this.Size = new Size(sizeX,sizeY);
                this.Items.AddRange(lista);
                this.CheckOnClick = true;
            }
        }
    }
}