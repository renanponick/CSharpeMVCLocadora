using System;
using ViewClientes;
using ViewFilmes;
using ViewLocacoes;
using System.Windows.Forms;
using Components;

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
        ButtonsMenu buttonImportarDados;
        ButtonsMenu buttonAdicionarFilme;
        ButtonsMenu buttonListarFilmes;
        ButtonsMenu buttonConsultarFilme;
        ButtonsMenu buttonAdicionarCliente;
        ButtonsMenu buttonListarClientes;
        ButtonsMenu buttonConsultarClientes;
        ButtonsMenu buttonCriarLocacao;
        ButtonsMenu buttonConsultarLocacoes;
        ButtonsMenu buttonConsultarLocacao;

        public MenuPrincipal(){
            this.Height = 400;
            buttonImportarDados = new ButtonsMenu("Importar Dados", this.Width-15, 0, 0, new System.EventHandler(this.ImportarDados));
            buttonAdicionarFilme = new ButtonsMenu("Adicionar Filme", this.Width-15, 0, 30, new System.EventHandler(this.AdicionarFilme));
            buttonListarFilmes = new ButtonsMenu("Listar Filmes", this.Width-15, 0, 60, new System.EventHandler(this.ListarFilmes));
            buttonConsultarFilme = new ButtonsMenu("Consultar Filme", this.Width-15, 0, 90, new System.EventHandler(this.ConsultarFilme));
            buttonAdicionarCliente = new ButtonsMenu("Adicionar Cliente", this.Width-15, 0, 120, new System.EventHandler(this.AdicionarCliente));
            buttonListarClientes = new ButtonsMenu("Listar Clientes", this.Width-15, 0, 150, new System.EventHandler(this.ListarClientes));
            buttonConsultarClientes = new ButtonsMenu("Consultar Clientes", this.Width-15, 0, 180, new System.EventHandler(this.ConsultarClientes));
            buttonCriarLocacao = new ButtonsMenu("Criar Locação", this.Width-15, 0, 210, new System.EventHandler(this.CriarLocacao));
            buttonConsultarLocacoes = new ButtonsMenu("Consultar Todas as Locações", this.Width-15, 0, 240, new System.EventHandler(this.ConsultarLocacoes));
            buttonConsultarLocacao = new ButtonsMenu("Consultar uma Locação", this.Width-15, 0, 270, new System.EventHandler(this.ConsultarLocacao));
           
            this.Controls.Add(buttonImportarDados);
            this.Controls.Add(buttonAdicionarFilme);
            this.Controls.Add(buttonListarFilmes);
            this.Controls.Add(buttonConsultarFilme);
            this.Controls.Add(buttonAdicionarCliente);
            this.Controls.Add(buttonListarClientes);
            this.Controls.Add(buttonConsultarClientes);
            this.Controls.Add(buttonCriarLocacao);
            this.Controls.Add(buttonConsultarLocacoes);
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
            new ListagemFilmes(this, 0).Show();
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
            new ListagemClientes(this, 0).Show();
        }
        public void ConsultarClientes(object sender, EventArgs args){
            this.Hide();
            new GetCliente(this).Show();
        }
        public void CriarLocacao(object sender, EventArgs args){
            this.Hide();
            new AddLocacao(this).Show();
        }
        public void ConsultarLocacoes(object sender, EventArgs args){
            this.Hide();
            new ListagemLocacao(this, 0).Show();
        }
        public void ConsultarLocacao(object sender, EventArgs args){
            this.Hide();
            new GetLocacao(this).Show();
        }
    }
}
