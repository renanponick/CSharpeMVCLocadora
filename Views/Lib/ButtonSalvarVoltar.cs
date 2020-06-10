using System;
using System.Windows.Forms;
using System.Drawing;

namespace View
{
    namespace Lib
    {
        public class ButtonsSalvar : Button
        {
            public ButtonsSalvar(int locationX, int locationY, EventHandler click)
            {
                this.Text = "Salvar";
                this.Size = new Size(50 ,20);
                this.Location = new Point(locationX+40, locationY+30);
                this.Click += click;
            }
        }
        public class ButtonsVoltar : Button
        {
            Form parent;
            Form form;
            /// <summary>
            /// Função para Criar o botão de voltar já com a função de fechar o form atual e abrir o form anterior
            /// </summary>
            /// <param name="locationX"></param>
            /// <param name="locationY"></param>
            /// <param name="form">Form que se encontra o botão que será fechado - this</param>
            /// <param name="parent">Form anterior que será exibido - this.parent</param>
            public ButtonsVoltar(int locationX, int locationY, Form form, Form parent)
            {
                this.Text = "Voltar";
                this.Size = new Size(50 ,20);
                this.Location = new Point(locationX-30, locationY+30);
                this.parent = parent;
                this.form = form;
                this.Click += new EventHandler(this.Voltar);
            }
            public void Voltar(object sender, EventArgs args){
                this.parent.Show();
                this.form.Close();
            }
        }
    }
}