using System;
using ViewClientes;
using ViewFilmes;
using ViewLocacoes;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
        ButtonsMenu buttonCriarLocações;
        ButtonsMenu buttonConsultarLocações;

        public MenuPrincipal(){
            this.Height = 320;
            buttonImportarDados = new ButtonsMenu("Importar Dados", this.Width-15, 0, 0, new System.EventHandler(this.ImportarDados));
            buttonAdicionarFilme = new ButtonsMenu("Adicionar Filme", this.Width-15, 0, 30, new System.EventHandler(this.AdicionarFilme));
            buttonListarFilmes = new ButtonsMenu("Listar Filmes", this.Width-15, 0, 60, new System.EventHandler(this.ListarFilmes));
            buttonConsultarFilme = new ButtonsMenu("Consultar Filme", this.Width-15, 0, 90, new System.EventHandler(this.ConsultarFilme));
            buttonAdicionarCliente = new ButtonsMenu("Adicionar Cliente", this.Width-15, 0, 120, new System.EventHandler(this.AdicionarCliente));
            buttonListarClientes = new ButtonsMenu("Listar Clientes", this.Width-15, 0, 150, new System.EventHandler(this.ListarClientes));
            buttonConsultarClientes = new ButtonsMenu("Consultar Clientes", this.Width-15, 0, 180, new System.EventHandler(this.ConsultarClientes));
            buttonCriarLocações = new ButtonsMenu("Criar Locações", this.Width-15, 0, 210, new System.EventHandler(this.CriarLocações));
            buttonConsultarLocações = new ButtonsMenu("Consultar Locações", this.Width-15, 0, 240, new System.EventHandler(this.ConsultarLocações));
            
            this.Controls.Add(buttonImportarDados);
            this.Controls.Add(buttonAdicionarFilme);
            this.Controls.Add(buttonListarFilmes);
            this.Controls.Add(buttonConsultarFilme);
            this.Controls.Add(buttonAdicionarCliente);
            this.Controls.Add(buttonListarClientes);
            this.Controls.Add(buttonConsultarClientes);
            this.Controls.Add(buttonCriarLocações);
            this.Controls.Add(buttonConsultarLocações);
        }
        public void ImportarDados(object sender, EventArgs args){
            ViewFilme.AddTodosFilmes();
            ViewCliente.AddTodosClientes();
            ViewLocacao.AddTodasLocacoes();
        }
        public void AdicionarFilme(object sender, EventArgs args){
            ViewFilme.AddFilme();
        }
        public void ListarFilmes(object sender, EventArgs args){
            ViewFilme.GetFilmes();
        }
        public void ConsultarFilme(object sender, EventArgs args){
            ViewFilme.GetFilme();
        }
        public void AdicionarCliente(object sender, EventArgs args){
            ViewCliente.AddCliente();
        }
        public void ListarClientes(object sender, EventArgs args){
            ViewCliente.GetClientes();
        }
        public void ConsultarClientes(object sender, EventArgs args){
            ViewCliente.GetCliente();
        }
        public void CriarLocações(object sender, EventArgs args){
            ViewLocacao.AddTodasLocacoes();
        }
        public void ConsultarLocações(object sender, EventArgs args){
            ViewLocacao.GetLocacoesIndividual();
        }
    }
}
