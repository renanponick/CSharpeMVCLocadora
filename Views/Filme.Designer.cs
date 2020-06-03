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
        Listners listagemFilmes;
        ButtonsVoltar buttonVoltar;
        private void InitializeComponent(int id){
            this.Text = "Listar Filmes";
            this.Size = new Size(440, 500);
            String[] coluns = {"ID","Título","Data Lançamento","Valor","Disponiveis"};
            listagemFilmes = new Listners(coluns, 400, 400);
            if(id==0){
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
            buttonVoltar = new ButtonsVoltar(0,0, this ,this.parent);
            this.Controls.Add(listagemFilmes);
            this.Controls.Add(buttonVoltar);
        }
    }
    partial class GetFilme{
        private ButtonsVoltar buttonVoltar;
        private ButtonsBuscar buttonsBuscar;
        private LabelPadrao labelId;
        private InputPadrao inputId;
        private ErrorProvider inputIdError;
        private FlowLayoutPanel FlowLayoutPanel;
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
            this.ClientSize = new Size(230,250);
            this.Text = "Buscar Filme";
            
            this.FlowLayoutPanel = new FlowLayoutPanel();
            this.FlowLayoutPanel.Dock = DockStyle.Fill;
            this.FlowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;

            this.labelId = new LabelPadrao("Digite o ID do Filme:", 190, 5, 30);
            this.inputId = new InputPadrao(this.Width-40, 5, 70);

            this.inputIdError = new ErrorProvider();
            this.inputIdError.SetIconAlignment(this.inputId, ErrorIconAlignment.MiddleRight);
            this.inputIdError.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            this.buttonVoltar = new ButtonsVoltar(0, 0, this ,this.parent);
            this.buttonsBuscar = new ButtonsBuscar(0, 0, Buscar);

            this.FlowLayoutPanel.Controls.Add(labelId);
            this.FlowLayoutPanel.Controls.Add(inputId);
            this.FlowLayoutPanel.Controls.Add(buttonVoltar);
            this.FlowLayoutPanel.Controls.Add(buttonsBuscar);
            this.Controls.Add(FlowLayoutPanel);
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
        private FlowLayoutPanel FlowLayoutPanel;
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
            this.labelTitulo = new LabelPadrao("Digite o Título do Filme:", 200, 5, 10);
            this.inputTitulo = new InputPadrao(this.Width-30, 5, 30);

            this.labelLancamento = new LabelPadrao("Digite a data de lançamento:", 200, 5, 60);
            this.inputLancamento = new InputMascarado(this.Width-30, 5, 90, "99/99/9999");

            this.labelSinopse = new LabelPadrao("Descreva o filme:", 200, 5, 120);
            this.inputSinopse = new TextAreaPadrao(this.Width-30, 5, 150);

            this.labelValor = new LabelPadrao("Digite o Valor do Filme:", 200, 5, 260);
            this.inputValor = new InputMascarado(this.Width-30, 5, 290, "00,00");

            this.labelQtde = new LabelPadrao("Digite a quantidade de filmes:", 200, 5, 320);
            this.inputQtde = new InputMascarado(this.Width-30, 5, 350, "09");

            this.buttonVoltar = new ButtonsVoltar(0, 0, this ,this.parent);
            this.buttonSalvar = new ButtonsSalvar(this.Width/3+40, 380, Salvar);

            this.FlowLayoutPanel = new FlowLayoutPanel();
            this.FlowLayoutPanel.Dock = DockStyle.Fill;
            this.FlowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;

            this.FlowLayoutPanel.Controls.Add(labelTitulo);
            this.FlowLayoutPanel.Controls.Add(labelLancamento);
            this.FlowLayoutPanel.Controls.Add(labelSinopse);
            this.FlowLayoutPanel.Controls.Add(labelValor);
            this.FlowLayoutPanel.Controls.Add(labelQtde);
            this.FlowLayoutPanel.Controls.Add(inputTitulo);
            this.FlowLayoutPanel.Controls.Add(inputLancamento);
            this.FlowLayoutPanel.Controls.Add(inputSinopse);
            this.FlowLayoutPanel.Controls.Add(inputValor);
            this.FlowLayoutPanel.Controls.Add(inputQtde);
            this.FlowLayoutPanel.Controls.Add(buttonVoltar);
            this.FlowLayoutPanel.Controls.Add(buttonSalvar);

            this.Controls.Add(FlowLayoutPanel);
        }
    }
}