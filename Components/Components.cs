using System;
using System.Windows.Forms;
using System.Drawing;

namespace Components
{
    public class ButtonsMenu : Button
    {
        public ButtonsMenu(String name, int sizeX, int locationX, int locationY, EventHandler click)
        {
            this.Size = new Size(sizeX ,30);
            this.Text = name;
            this.Location = new Point(locationX, locationY);
            this.Click += click;
        }
    }
    public class ButtonsVoltar : Button
    {
        public ButtonsVoltar(int locationX, int locationY, EventHandler click)
        {
            this.Text = "Voltar";
            this.Size = new Size(50 ,20);
            this.Location = new Point(locationX, locationY);
            this.Click += click;
        }
    }
    public class ButtonsSalvar : Button
    {
        public ButtonsSalvar(int locationX, int locationY, EventHandler click)
        {
            this.Text = "Salvar";
            this.Size = new Size(50 ,20);
            this.Location = new Point(locationX, locationY);
            this.Click += click;
        }
    }


    public class LabelPadrao : Label{
        public LabelPadrao(String name, int sizeX, int locationX, int locationY)
        {
            this.Size = new Size(sizeX ,20);
            this.Text = name;
            this.Location = new Point(locationX, locationY);
        }
    }

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
    public class TextAreaPadrao : RichTextBox{
         public TextAreaPadrao(int sizeX, int locationX, int locationY)
        {
            this.Size = new Size(sizeX ,100);
            this.Location = new Point(locationX, locationY);
        }
    }

    public class Listners : ListView
    {
        public Listners(String[] coluns, int sizeX, int sizeY){
            this.View = View.Details;
            this.Location = new Point(10,10);
            this.Size = new Size(sizeX,sizeY);
            this.View = View.Details;
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