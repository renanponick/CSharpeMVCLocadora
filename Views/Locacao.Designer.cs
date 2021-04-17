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
    public partial class ListagemLocacao : Form{
        private Listners listagemLocacao;
        private ButtonsVoltar buttonVoltar;
        private TablePadrao TablePadrao;
        public void InitializeComponent(){
            this.Text = "Listar Filmes";
            this.Size = new Size(470, 500);
            this.TablePadrao = new TablePadrao(this.Width, this.Height-100);
            String[] coluns = {"ID","Cliente","Valor pago","Data Locado","Data de Devolução"};
            this.listagemLocacao = new Listners(coluns, 430, 400);
            String[] aux;
            try{
                IEnumerable funcQuery = from locacoes in ControllerLocacao.GetLocacoes() select locacoes;
                foreach (Locacao locacao in funcQuery) {
                    ListViewItem locacao1 = new ListViewItem(locacao.LocacaoId.ToString());
                    Cliente cliente = ControllerCliente.GetCliente(locacao.ClienteId);
                    locacao1.SubItems.Add(cliente.Nome.ToString());
                    locacao1.SubItems.Add("R$: "+locacao.ValorTotal.ToString());
                    aux = locacao.DataLocacao.ToString().Split(" ",2);
                    locacao1.SubItems.Add(aux[0]);
                    aux = ControllerLocacao.CalculaData(locacao).ToString().Split(" ",2);
                    locacao1.SubItems.Add(aux[0]);
                    listagemLocacao.Items.AddRange(new ListViewItem[]{locacao1});
                }
            }catch(Exception){
                ListViewItem locacao1 = new ListViewItem("Nenhum filme encontrado");
                listagemLocacao.Items.AddRange(new ListViewItem[]{locacao1});
            }
            this.buttonVoltar = new ButtonsVoltar(this.Width/2, this.TablePadrao.Height, this ,this.parent);
            this.TablePadrao.Controls.Add(listagemLocacao);
            this.Controls.Add(TablePadrao);
            this.Controls.Add(buttonVoltar);
        }
    }
    public partial class GetLocacao : Form{
        private ButtonsVoltar buttonVoltar;
        private ButtonsBuscar buttonsBuscar;
        private LabelPadrao labelId;
        private InputPadrao inputId;
        private TablePadrao TablePadrao;
        public void InitializeComponent(){
            this.Text = "Buscar Locacao";
            this.Height = 250;
            this.TablePadrao = new TablePadrao(this.Width,50);
            this.labelId = new LabelPadrao("Digite o ID da Locação:", 200);
            this.inputId = new InputPadrao(70);

            this.buttonVoltar = new ButtonsVoltar(this.Width/2, this.TablePadrao.Height, this ,this.parent);
            this.buttonsBuscar = new ButtonsBuscar(this.Width/3+40, 100, Buscar);
            
            this.TablePadrao.Controls.Add(labelId);
            this.TablePadrao.Controls.Add(inputId);
            this.Controls.Add(TablePadrao);
            this.Controls.Add(buttonVoltar);
            this.Controls.Add(buttonsBuscar);
        }
    }
    public partial class AddLocacao : Form{
        private ButtonsVoltar buttonVoltar;
        private ButtonsSalvar buttonSalvar;
        private SelectPadrao selectCliente;
        private LabelPadrao labelCliente;
        private LabelPadrao labelFilmes;
        private CheckedListPadrao listaFilmes;
        private TablePadrao TablePadrao;
        public void InitializeComponent(){
            this.Text = "Adicionar Filme";
            this.Height = 480;
            this.TablePadrao = new TablePadrao(this.Width, this.Height-100);
            
            List<Cliente> clientes = ControllerCliente.GetClientes();
            List<String> select = new List<String>();
            select.Add("Selecione");
            foreach (Cliente cliente in clientes)                {
                select.Add(cliente.ClienteId.ToString()+"-"+ cliente.Nome);
            }
            List<Filme> filmes = ControllerFilme.GetFilmes();
            List<String> listFilmes = new List<String>();
            foreach (Filme filme in filmes)                {
                listFilmes.Add(filme.FilmeId.ToString()+"-"+ filme.Nome);
            }
            this.labelCliente = new LabelPadrao("Selecione o cliente:", 150);
            this.selectCliente = new SelectPadrao(select.ToArray());
            this.labelFilmes = new LabelPadrao("Selecione os filmes:", 150);
            this.listaFilmes = new CheckedListPadrao(listFilmes.ToArray(), this.Width-35, 300);
            this.buttonVoltar = new ButtonsVoltar(this.Width/3, this.TablePadrao.Height, this ,this.parent);
            this.buttonSalvar = new ButtonsSalvar(this.Width/3, this.TablePadrao.Height, Salvar);

            this.TablePadrao.Controls.Add(labelCliente);
            this.TablePadrao.Controls.Add(selectCliente);
            this.TablePadrao.Controls.Add(labelFilmes);
            this.TablePadrao.Controls.Add(listaFilmes);
            this.Controls.Add(TablePadrao);
            this.Controls.Add(buttonVoltar);
            this.Controls.Add(buttonSalvar);
        }
    }
}
           
