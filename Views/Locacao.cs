using System;
using Controllers;
using System.Linq;
using Models;
using View.Lib;
using System.Windows.Forms;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;

namespace View{
    public class ViewLocacao{
        public static void AddTodasLocacoes(){
            ControllerLocacao.AddTodasLocacoes();
        }
    }
    public partial class ListagemLocacao : Form{
        Form parent;
        public ListagemLocacao(Form parent){
            this.parent = parent;
            InitializeComponent();
        }
        public void Voltar(object sender, EventArgs args){
            this.parent.Show();
            this.Close();
        }
    }
    public partial class GetLocacao : Form{
        Form parent;
        public GetLocacao(Form parent){
            this.parent = parent;
            InitializeComponent();
        }
        public void Voltar(object sender, EventArgs args){
            this.parent.Show();
            this.Close();
        }
        public void Buscar(object sender, EventArgs args){
            int id = Convert.ToInt32(this.inputId.Text);
            //new ListagemLocacao(this, id).Show();
            this.Hide();
        }
    }
    public partial class AddLocacao : Form{
        Form parent;
        public AddLocacao(Form parent){
            this.parent = parent;
            InitializeComponent();
        }
        public void Salvar(object sender, EventArgs args){
            try{
                //Recebendo o cliente selecionado e pegando apenas o id dele
                String[] idCliente = selectCliente.SelectedItem.ToString().Split("-");
                int clienteId = Convert.ToInt32(idCliente[0]);

                //Recebendo os filmes selecionados e pegando apenas o id deles
                List<int> listaDeFilmes = new List<int>();
                foreach(object o in listaFilmes.SelectedItems){
                    String[] filmeId = o.ToString().Split("-");
                    listaDeFilmes.Add(Convert.ToInt32(filmeId[0]));
                }

                ControllerLocacao.AddLocacao(clienteId,  listaDeFilmes.ToArray());
                MessageBox.Show(
                    "Dados inseridos com sucesso!",
                    "Informação",
                    MessageBoxButtons.OK);                        
                this.parent.Show();
                this.Close();
            }catch(Exception){
                MessageBox.Show(
                    "Preencher os dados corretamente",
                    "Informação",
                    MessageBoxButtons.OK);
            }
        }
    }
}
           
