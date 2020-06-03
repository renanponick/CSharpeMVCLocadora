using System;
using System.Windows.Forms;
using System.Drawing;

namespace View
{
    namespace Lib
    {
        public class Listners : ListView
        {
            public Listners(String[] coluns, int sizeX, int sizeY){
                this.View = System.Windows.Forms.View.Details;
                this.Location = new Point(10,10);
                this.Size = new Size(sizeX,sizeY);
                foreach(String colum in coluns){
                    this.Columns.Add(colum, -2, HorizontalAlignment.Left);
                }
                this.FullRowSelect = true;
                this.GridLines = true;
                this.AllowColumnReorder = true;
                this.Sorting = SortOrder.Ascending;
            }
        } 
    }
}