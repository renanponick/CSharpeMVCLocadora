using System;
using View;
using System.Windows.Forms;
using View.Lib;

namespace CSharpeAvaliacaoMVCLocadora
{
    public class Program
    {
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuPrincipal());
        }
    }
    public class MenuPrincipal : Form{
        ButtonMenu buttonImportarDados;
        ButtonMenu buttonAdicionarFilme;
        ButtonMenu buttonListarFilmes;
        ButtonMenu buttonConsultarFilme;
        ButtonMenu buttonAdicionarCliente;
        ButtonMenu buttonListarClientes;
        ButtonMenu buttonConsultarClientes;
        ButtonMenu buttonCriarLocacao;
        ButtonMenu buttonListarLocacoes;
        ButtonMenu buttonConsultarLocacao;

        public MenuPrincipal(){
            this.Height = 400;
            buttonImportarDados = new ButtonMenu("Importar Dados", this.Width-15, 0, 0, new System.EventHandler(this.ImportarDados));
            buttonAdicionarFilme = new ButtonMenu("Adicionar Filme", this.Width-15, 0, 30, new System.EventHandler(this.AdicionarFilme));
            buttonListarFilmes = new ButtonMenu("Listar Filmes", this.Width-15, 0, 60, new System.EventHandler(this.ListarFilmes));
            buttonConsultarFilme = new ButtonMenu("Consultar Filme", this.Width-15, 0, 90, new System.EventHandler(this.ConsultarFilme));
            buttonAdicionarCliente = new ButtonMenu("Adicionar Cliente", this.Width-15, 0, 150, new System.EventHandler(this.AdicionarCliente));
            buttonListarClientes = new ButtonMenu("Listar Clientes", this.Width-15, 0, 180, new System.EventHandler(this.ListarClientes));
            buttonConsultarClientes = new ButtonMenu("Consultar Clientes", this.Width-15, 0, 210, new System.EventHandler(this.ConsultarClientes));
            buttonCriarLocacao = new ButtonMenu("Realizar Locação", this.Width-15, 0, 270, new System.EventHandler(this.CriarLocacao));
            buttonListarLocacoes = new ButtonMenu("Listar Todas as Locações", this.Width-15, 0, 300, new System.EventHandler(this.ListarLocacoes));
            buttonConsultarLocacao = new ButtonMenu("Consultar uma Locação", this.Width-15, 0, 330, new System.EventHandler(this.ConsultarLocacao));
           //Corrigidos
            this.Controls.Add(buttonImportarDados);
            this.Controls.Add(buttonAdicionarFilme);
            this.Controls.Add(buttonListarFilmes);
            this.Controls.Add(buttonListarClientes);
            this.Controls.Add(buttonAdicionarCliente);
            this.Controls.Add(buttonListarLocacoes);
            this.Controls.Add(buttonCriarLocacao);
            //Falta corrigir
            this.Controls.Add(buttonConsultarFilme);
            this.Controls.Add(buttonConsultarClientes);
            this.Controls.Add(buttonConsultarLocacao);
        }
        public void ImportarDados(object sender, EventArgs args){
            var result = MessageBox.Show(
                "Deseja importar os dados de: Filmes, Clientes e Locações?",
                "Decisão",
                MessageBoxButtons.YesNo
            );
            if(result == DialogResult.Yes){
                ViewFilme.AddTodosFilmes();
                ViewCliente.AddTodosClientes();
                ViewLocacao.AddTodasLocacoes();
                MessageBox.Show(
                "Dados Importados",
                "Informação",
                MessageBoxButtons.OK);
            }
        }
        public void AdicionarFilme(object sender, EventArgs args){
            this.Hide();
            new AddFilme(this).Show();
        }
        public void ListarFilmes(object sender, EventArgs args){
            this.Hide();
            new ListagemFilmes(this).Show();
        }
        public void ConsultarFilme(object sender, EventArgs args){
            this.Hide();
            new GetFilme(this).Show();
        }
        public void AdicionarCliente(object sender, EventArgs args){
             this.Hide();
            new AddCliente(this).Show();
        }
        public void ListarClientes(object sender, EventArgs args){
            this.Hide();
            new ListagemClientes(this).Show();
        }
        public void ConsultarClientes(object sender, EventArgs args){
            this.Hide();
            new GetCliente(this).Show();
        }
        public void CriarLocacao(object sender, EventArgs args){
            this.Hide();
            new AddLocacao(this).Show();
        }
        public void ListarLocacoes(object sender, EventArgs args){
            this.Hide();
            new ListagemLocacao(this).Show();
        }
        public void ConsultarLocacao(object sender, EventArgs args){
            this.Hide();
            new GetLocacao(this).Show();
        }
    }
}
