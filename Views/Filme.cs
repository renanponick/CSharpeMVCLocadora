using System;
using Models;
using Controllers;
using System.Collections;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using Components;

namespace ViewFilmes{
    public partial class ListagemFilmes : Form{
        Form parent;
        public ListagemFilmes(Form parent, int id){
            this.parent = parent;
            InitializeComponent(id);
        }
        public void Voltar(object sender, EventArgs args){
            this.parent.Show();
            this.Close();
        }
    }
    public class AddFilme : Form{
        Form parent;
        ButtonsVoltar buttonVoltar;
        ButtonsSalvar buttonSalvar;
        LabelPadrao labelTitulo;
        LabelPadrao labelLancamento;
        LabelPadrao labelSinopse;
        LabelPadrao labelValor;
        LabelPadrao labelQtde;
        InputPadrao inputTitulo;
        InputMascarado inputLancamento;
        TextAreaPadrao inputSinopse;
        InputMascarado inputValor;
        InputMascarado inputQtde;
        public AddFilme(Form parent){
                this.parent = parent;
                this.Text = "Adicionar Filme";
                this.Height = 450;
                labelTitulo = new LabelPadrao("Digite o Título do Filme:", 200, 5, 10);
                inputTitulo = new InputPadrao(this.Width-30, 5, 30);

                labelLancamento = new LabelPadrao("Digite a data de lançamento:", 200, 5, 60);
                inputLancamento = new InputMascarado(this.Width-30, 5, 90, "99/99/9999");
                
                labelSinopse = new LabelPadrao("Descreva o filme:", 200, 5, 120);
                inputSinopse = new TextAreaPadrao(this.Width-30, 5, 150);

                labelValor = new LabelPadrao("Digite o Valor do Filme:", 200, 5, 260);
                inputValor = new InputMascarado(this.Width-30, 5, 290, "00,00");

                labelQtde = new LabelPadrao("Digite a quantidade de filmes:", 200, 5, 320);
                inputQtde = new InputMascarado(this.Width-30, 5, 350, "09");

                buttonVoltar = new ButtonsVoltar(this.Width/3-20, 380, Voltar);
                buttonSalvar = new ButtonsSalvar(this.Width/3+40, 380, Salvar);

                this.Controls.Add(labelTitulo);
                this.Controls.Add(labelLancamento);
                this.Controls.Add(labelSinopse);
                this.Controls.Add(labelValor);
                this.Controls.Add(labelQtde);
                
                this.Controls.Add(inputTitulo);
                this.Controls.Add(inputLancamento);
                this.Controls.Add(inputSinopse);
                this.Controls.Add(inputValor);
                this.Controls.Add(inputQtde);
                this.Controls.Add(buttonVoltar);
                this.Controls.Add(buttonSalvar);
        }
        public void Voltar(object sender, EventArgs args){
            this.parent.Show();
            this.Close();
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
    public partial class GetFilme : Form{
        Form parent;
        public GetFilme(Form parent){
            this.parent = parent;
            InitializeComponent();
        }
        public void Voltar(object sender, EventArgs args){
            this.parent.Show();
            this.Close();
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
           
