using System;
using System.Windows.Forms;
using System.Drawing;

namespace View
{
    namespace Lib
    { 
        public class SelectPadrao : ComboBox
        {
            public SelectPadrao(String[] linhas, int locationX, int locationY){
                this.Location = new Point(locationX,locationY);
                this.Size = new Size(150 ,30);
                foreach(String linha in linhas){
                    this.Items.Add(linha);
                }
                this.SelectedItem = "Selecione";
            }
        }
    }
}