using System;
using Models;
using Controllers;
using System.Collections;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using View.Lib;
using System.ComponentModel;

namespace View{
    partial class ListagemFilmes{
        private Listners listagemFilmes;
        private ButtonsVoltar buttonVoltar;
        private TablePadrao TablePadrao;
        private void InitializeComponent(){
            this.Text = "Listar Filmes";
            this.Size = new Size(500, 500);
            this.TablePadrao = new TablePadrao(this.Width, this.Height-100);

            String[] coluns = {"ID","Título","Data Lançamento","Valor","Disponiveis"};
            this.listagemFilmes = new Listners(coluns, this.Width-25, 400);
                try{
                    IEnumerable funcQuery = from filmes in ControllerFilme.GetFilmes() select filmes;
                    foreach (Filme filme in funcQuery) {
                        ListViewItem filme1 = new ListViewItem(filme.FilmeId.ToString());
                        filme1.SubItems.Add(filme.Nome);
                        filme1.SubItems.Add(filme.DataLancamento);
                        filme1.SubItems.Add("R$: "+filme.Valor.ToString());
                        filme1.SubItems.Add(filme.EstoqueAtual.ToString());
                        listagemFilmes.Items.AddRange(new ListViewItem[]{filme1});
                    }
                }catch(Exception){
                    ListViewItem filme1 = new ListViewItem("Nenhum filme encontrado");
                    listagemFilmes.Items.AddRange(new ListViewItem[]{filme1});
                }

            
            this.buttonVoltar = new ButtonsVoltar(this.Width/2, this.TablePadrao.Height, this ,this.parent);
            this.TablePadrao.Controls.Add(listagemFilmes);
            this.Controls.Add(TablePadrao);
            this.Controls.Add(buttonVoltar);
        }
    }
    partial class GetFilme{
        private ButtonsVoltar buttonVoltar;
        private ButtonsBuscar buttonsBuscar;
        private LabelPadrao labelId;
        private InputPadrao inputId;
        private ErrorProvider inputIdError;
        private TablePadrao TablePadrao;
        private System.ComponentModel.IContainer components = null;
        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent(){
            this.components = new Container();
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(170,150);
            this.Text = "Buscar Filme";

            this.labelId = new LabelPadrao("Digite o ID do Filme:", 190);
            this.inputId = new InputPadrao(70);

            this.inputIdError = new ErrorProvider();
            this.inputIdError.SetIconAlignment(this.inputId, ErrorIconAlignment.MiddleRight);
            this.inputIdError.BlinkStyle = ErrorBlinkStyle.NeverBlink;


            this.TablePadrao = new TablePadrao(this.Width,50);
            
            this.buttonVoltar = new ButtonsVoltar(this.Width/3, this.TablePadrao.Height, this ,this.parent);
            this.buttonsBuscar = new ButtonsBuscar(this.Width/3, this.TablePadrao.Height, Buscar);

            this.TablePadrao.Controls.Add(labelId);
            this.TablePadrao.Controls.Add(inputId);
            this.Controls.Add(TablePadrao);
            this.Controls.Add(buttonVoltar);
            this.Controls.Add(buttonsBuscar);
        }
    }
    partial class AddFilme : Form{
        private ButtonsVoltar buttonVoltar;
        private ButtonsSalvar buttonSalvar;
        private LabelPadrao labelTitulo;
        private LabelPadrao labelLancamento;
        private LabelPadrao labelSinopse;
        private LabelPadrao labelValor;
        private LabelPadrao labelQtde;
        private InputPadrao inputTitulo;
        private InputMascarado inputLancamento;
        private TextAreaPadrao inputSinopse;
        private InputMascarado inputValor;
        private InputMascarado inputQtde;
        //private ErrorProvider inputIdError;
        private TablePadrao TablePadrao;
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing){
            if (disposing && (components != null)){
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent(){
            this.Text = "Adicionar Filme";
            this.Height = 450;
            this.labelTitulo = new LabelPadrao("Digite o Título do Filme:", 200);
            this.inputTitulo = new InputPadrao(150);

            this.labelLancamento = new LabelPadrao("Digite a data de lançamento:", 200);
            this.inputLancamento = new InputMascarado(90, "99/99/9999");

            this.labelSinopse = new LabelPadrao("Descreva o filme:", 200);
            this.inputSinopse = new TextAreaPadrao(150);

            this.labelValor = new LabelPadrao("Digite o Valor do Filme:", 200);
            this.inputValor = new InputMascarado(290, "00,00");

            this.labelQtde = new LabelPadrao("Digite a quantidade de filmes:", 200);
            this.inputQtde = new InputMascarado(350, "09");


            this.TablePadrao = new TablePadrao(this.Width, 320);

            
            this.buttonVoltar = new ButtonsVoltar(this.Width/3, this.TablePadrao.Height, this ,this.parent);
            this.buttonSalvar = new ButtonsSalvar(this.Width/3, this.TablePadrao.Height, Salvar);

            this.TablePadrao.Controls.Add(labelTitulo, 1, 1);
            this.TablePadrao.Controls.Add(inputTitulo, 1, 2);
            this.TablePadrao.Controls.Add(labelLancamento, 1, 3);
            this.TablePadrao.Controls.Add(inputLancamento, 1, 4);
            this.TablePadrao.Controls.Add(labelSinopse, 1, 5);
            this.TablePadrao.Controls.Add(inputSinopse, 1, 6);
            this.TablePadrao.Controls.Add(labelValor, 1, 7);
            this.TablePadrao.Controls.Add(inputValor, 1, 8);
            this.TablePadrao.Controls.Add(labelQtde, 1, 9);
            this.TablePadrao.Controls.Add(inputQtde, 1, 10);
            this.Controls.Add(buttonVoltar);
            this.Controls.Add(buttonSalvar);

            this.Controls.Add(TablePadrao);
        }
    }
}