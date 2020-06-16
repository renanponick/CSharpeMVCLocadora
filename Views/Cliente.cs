using System;
using Models;
using Controllers;
using System.Collections;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using View.Lib;

namespace View{
    public class ViewCliente{
        // Adiciona todos os clientes - Ok
        public static void AddTodosClientes(){
            ControllerCliente.AddCliente("Junior Rezende", "15/05/1998", "123.123.123-32", 2);
            ControllerCliente.AddCliente("Tafarel Rezende", "12/07/1988", "143.153.123-32", 1);
            ControllerCliente.AddCliente("Bolivar Artagne", "15/05/1978", "123.131.123-32", 3);
            ControllerCliente.AddCliente("Teste Rezende", "15/06/1998", "123.123.123-32", 4);
            ControllerCliente.AddCliente("Rezende", "15/07/1998", "123.123.123-32", 2);
        }
    }
    public partial class ListagemClientes : Form{
        Form parent;
        public ListagemClientes(Form parent){
            this.parent = parent;
            InitializeComponent();
        }      
    }
    public partial class GetCliente : Form{
        Form parent;
        public GetCliente(Form parent){
            this.parent = parent;
            InitializeComponent();
        }
        public void Buscar(object sender, EventArgs args){
            if(this.inputId.Text.Length <1){
                this.inputIdError.SetError(this.inputId, "Não pode ser vazio");
            }else{
                  this.inputIdError.SetError(this.inputId, String.Empty);
                int id = Convert.ToInt32(this.inputId.Text);
                //ew ListagemFilmes(this, id).Show();
                this.Hide();
                /*
                    }else if(id>0){
                        try{
                            Filme filme = ControllerFilme.GetFilme(id);
                            ListViewItem filme1 = new ListViewItem(filme.FilmeId.ToString());
                            filme1.SubItems.Add(filme.Nome);
                            filme1.SubItems.Add(filme.DataLancamento);
                            filme1.SubItems.Add("R$: "+filme.Valor.ToString());
                            filme1.SubItems.Add(filme.EstoqueAtual.ToString());
                            listagemFilmes.Items.AddRange(new ListViewItem[]{filme1});
                        }catch(Exception){
                            ListViewItem filme1 = new ListViewItem("Nenhum filme encontrado");
                            listagemFilmes.Items.AddRange(new ListViewItem[]{filme1});
                        } 
                    }

                */
            }
        }
    }
     public partial class AddCliente : Form{
        Form parent;
        public AddCliente(Form parent){
            this.parent = parent;
            
            InitializeComponent(parent, false);
        }
        public void Salvar(object sender, EventArgs args){
            try{
                int dias = Convert.ToInt32(this.inputDiasDev.Text);
                ControllerCliente.AddCliente(this.inputNome.Text, 
                                            this.inputNascimento.Text,
                                            this.inputCpf.Text, 
                                            dias);
                MessageBox.Show(
                    "Dados Cadastrados",
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
        public void setDataClient(object sender, EventArgs args, int id){
            Cliente cliente = ControllerCliente.GetCliente(id);
        }
    }
}
           