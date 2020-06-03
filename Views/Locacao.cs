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

        /*public static void AddLocacao(){
            int idLocacao, ClienteId;
            Console.WriteLine("Digite o id do cliente:");
            ClienteId = Convert.ToInt32(Console.ReadLine());
            idLocacao = ControllerLocacao.AddLocacao(ClienteId);
            int opc=1;
            do{
                ViewLocacao.AddFilmeLocacao(idLocacao, ClienteId);
                Console.WriteLine("Deseja cadastrar outro filme? 0-Não 1-Sim");
                opc = Convert.ToInt32(Console.ReadLine());
            }while(opc!=0);
            Console.WriteLine("Filme Cadastrado com Sucesso");

            int idFilme;
            Console.WriteLine("Digite o id do filme:");
            idFilme = Convert.ToInt32(Console.ReadLine());
            ControllerLocacao.AddFilmeLocacao(clienteId, idLocacao, idFilme);
        }*/
    }
    public class ListagemLocacao : Form{
        Form parent;
        Listners listagemLocacao;
        ButtonsVoltar buttonVoltar;
        public ListagemLocacao(Form parent, int id){
            this.parent = parent;
            this.Text = "Listar Filmes";
            this.Size = new Size(470, 500);
            String[] coluns = {"ID","Cliente","Valor pago","Data Locado","Data de Devolução"};
            listagemLocacao = new Listners(coluns, 430, 400);
            String[] aux;
            if(id==0){
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
            }else if(id>0){
                try{
                    Locacao locacao = ControllerLocacao.GetLocacao(id);
                    ListViewItem locacao1 = new ListViewItem(locacao.LocacaoId.ToString());
                    Cliente cliente = ControllerCliente.GetCliente(locacao.ClienteId);
                    locacao1.SubItems.Add(cliente.Nome.ToString());
                    locacao1.SubItems.Add("R$: "+locacao.ValorTotal.ToString());
                    aux = locacao.DataLocacao.ToString().Split(" ",2);
                    locacao1.SubItems.Add(aux[0]);
                    aux = ControllerLocacao.CalculaData(locacao).ToString().Split(" ",2);
                    locacao1.SubItems.Add(aux[0]);
                    listagemLocacao.Items.AddRange(new ListViewItem[]{locacao1});
                }catch(Exception){
                    ListViewItem locacao1 = new ListViewItem("Nenhum filme encontrado");
                    listagemLocacao.Items.AddRange(new ListViewItem[]{locacao1});
                } 
            }
            buttonVoltar = new ButtonsVoltar(0,0, this ,this.parent);
            this.Controls.Add(listagemLocacao);
            this.Controls.Add(buttonVoltar);
        }
        public void Voltar(object sender, EventArgs args){
            this.parent.Show();
            this.Close();
        }
    }
       public class GetLocacao : Form{
        Form parent;
        ButtonsVoltar buttonVoltar;
        ButtonsBuscar buttonsBuscar;
        LabelPadrao labelId;
        InputPadrao inputId;
        public GetLocacao(Form parent){
                this.parent = parent;
                this.Text = "Buscar Locacao";
                this.Height = 250;
                labelId = new LabelPadrao("Digite o ID da Locação:", 200, 5, 30);
                inputId = new InputPadrao(this.Width-30, 5, 70);

                buttonVoltar = new ButtonsVoltar(0,0, this ,this.parent);
                buttonsBuscar = new ButtonsBuscar(this.Width/3+40, 100, Buscar);

                this.Controls.Add(labelId);
                this.Controls.Add(inputId);
                this.Controls.Add(buttonVoltar);
                this.Controls.Add(buttonsBuscar);
        }
        public void Voltar(object sender, EventArgs args){
            this.parent.Show();
            this.Close();
        }
        public void Buscar(object sender, EventArgs args){
            int id = Convert.ToInt32(this.inputId.Text);
            new ListagemLocacao(this, id).Show();
            this.Hide();
        }
    }
       public class AddLocacao : Form{
        Form parent;
        ButtonsVoltar buttonVoltar;
        ButtonsSalvar buttonSalvar;
        SelectPadrao selectCliente;
        LabelPadrao labelCliente;
        LabelPadrao labelFilmes;
        CheckedListPadrao listaFilmes;
        
        public AddLocacao(Form parent){
                this.parent = parent;
                this.Text = "Adicionar Filme";
                this.Height = 480;
                
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
                labelCliente = new LabelPadrao("Selecione o cliente:", 150, 0, 10);
                selectCliente = new SelectPadrao(select.ToArray(), 5, 40);
                labelFilmes = new LabelPadrao("Selecione os filmes:", 150, 0, 70);
                listaFilmes = new CheckedListPadrao(listFilmes.ToArray(), 5, 100, this.Width-35, 300);
                buttonVoltar = new ButtonsVoltar(0,0, this ,this.parent);
                buttonSalvar = new ButtonsSalvar(this.Width/3+40, 400, Salvar);

                this.Controls.Add(labelCliente);
                this.Controls.Add(selectCliente);
                this.Controls.Add(labelFilmes);
                this.Controls.Add(listaFilmes);
                this.Controls.Add(buttonVoltar);
                this.Controls.Add(buttonSalvar);
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
           
