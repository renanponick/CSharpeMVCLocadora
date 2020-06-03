using System;
using Models;
using Controllers;
using System.Collections;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using View.Lib;

namespace View{
    public class ViewFilme{
        // metodo para adicionar todos os filmes
        public static void AddTodosFilmes(){
            ControllerFilme.AddFilme("Jhon, e os quem", "25/10/2018", "Uma História", 2, 6);
            ControllerFilme.AddFilme("A volta dos que não foram", "23/10/2018", "Uma História linda de amor e superação", 1, 6);
            ControllerFilme.AddFilme("Tranças do Careca", "24/10/2018", "Uma História", 5, 6);
            ControllerFilme.AddFilme("Se não fosse o quase", "22/10/2018", "Uma História", 1, 6);
            ControllerFilme.AddFilme("Teste Alfa", "25/10/2018", "Uma História", 5, 6);
            ControllerFilme.AddFilme("Teste Beta", "25/10/2018", "Uma História", 2, 6);
            ControllerFilme.AddFilme("Teste 3 - O retorno do Alfa", "25/10/2018", "Uma História", 2, 6);
            ControllerFilme.AddFilme("Beta, longe de casa", "01/10/2018", "Uma História", 2, 10);
            ControllerFilme.AddFilme("O final do inicio", "12/12/2018", "Uma História", 1, 6);
            ControllerFilme.AddFilme("O paraíso do Tártaro", "10/10/2018", "Uma História", 3, 6);
        }
    }
    public partial class ListagemFilmes : Form{
        Form parent;
        public ListagemFilmes(Form parent, int id){
            this.parent = parent;
            InitializeComponent(id);
        }
    }
    public partial class AddFilme : Form{
        Form parent;
        public AddFilme(Form parent){
            this.parent = parent;
            InitializeComponent();
        }
        public void Salvar(object sender, EventArgs args){
            try{
                double valor = Convert.ToDouble(this.inputValor.Text);
                int qtde = Convert.ToInt32(this.inputQtde.Text);
                ControllerFilme.AddFilme(this.inputTitulo.Text,
                                        this.inputLancamento.Text, 
                                        this.inputSinopse.Text, 
                                        valor, 
                                        qtde);
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
    }
    public partial class GetFilme : Form{
        Form parent;
        public GetFilme(Form parent){
            this.parent = parent;
            InitializeComponent();
        }
        public void Buscar(object sender, EventArgs args){
            if(this.inputId.Text.Length <1){
                this.inputIdError.SetError(this.inputId, "Não pode ser vazio");
            }else{
                  this.inputIdError.SetError(this.inputId, String.Empty);
                int id = Convert.ToInt32(this.inputId.Text);
                new ListagemFilmes(this, id).Show();
                this.Hide();
            }
        }
    }
}
           
