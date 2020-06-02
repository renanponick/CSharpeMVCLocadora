using System;
using Models;
using Controllers;
using System.Collections;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using Components;
using System.ComponentModel;

namespace ViewFilmes{
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
            buttonVoltar = new ButtonsVoltar(this.Width/3+50, listagemFilmes.Height+10, new System.EventHandler(this.Voltar));
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

            this.buttonVoltar = new ButtonsVoltar(0, 0, Voltar);
            this.buttonsBuscar = new ButtonsBuscar(0, 0, Buscar);

            this.FlowLayoutPanel.Controls.Add(labelId);
            this.FlowLayoutPanel.Controls.Add(inputId);
            this.FlowLayoutPanel.Controls.Add(buttonVoltar);
            this.FlowLayoutPanel.Controls.Add(buttonsBuscar);
            this.Controls.Add(FlowLayoutPanel);
        }
    }
}