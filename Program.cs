using System;
using ViewClientes;
using ViewFilmes;
using ViewLocacoes;

namespace CSharpeAvaliacaoMVCLocadora
{
    public class Program
    {
        public static void Main(string[] args){
            int op=0;
            do{
                Console.WriteLine("\n ----------------------- BlockBuster ---------------------------- \n");
                Console.WriteLine("0 - Importar Dados");
                Console.WriteLine("1 - Adicionar Filme");
                Console.WriteLine("2 - Listar Filmes");
                Console.WriteLine("3 - Consultar Filme");
                Console.WriteLine("4 - Adicionar Cliente");
                Console.WriteLine("5 - Listar Clientes");
                Console.WriteLine("6 - Consultar Clientes");
                Console.WriteLine("7 - Criar Locações");
                Console.WriteLine("8 - Consultar Locações");
                Console.WriteLine("9 - Sair");
                op = Convert.ToInt32(Console.ReadLine());
                switch(op){
                    case 0:{
                        ViewFilme.AddTodosFilmes();
                        ViewCliente.AddTodosClientes();
                        ViewLocacao.AddTodasLocacoes();
                        break;
                    }
                    case 1:{
                        // Adiciona um filme - Ok
                        ViewFilme.AddFilme();
                        break;
                    }
                    case 2:{
                        // Lista todos os filmes - Ok
                        ViewFilme.GetFilmes();
                        break;
                    }
                    case 3:{
                        // Mostra UM filme através do ID - Ok
                        ViewFilme.GetFilme();
                        break;
                    }
                    case 4:{
                        // Adiciona um Cliente - 
                        ViewCliente.AddCliente();
                        break;
                    }
                    case 5:{
                        // Lista todos os clientes - Ok
                        ViewCliente.GetClientes();
                        break;
                    }
                    case 6:{
                        // Mostra UM  cliente através do ID -
                        ViewCliente.GetCliente();
                        break;
                    }
                    case 7:{
                        // Adiciona uma locação -
                        //ViewLocacao.AddTodasLocacoes();
                        break;
                    }
                    case 8:{
                        // Mostra UMA locação através do ID -
                        ViewLocacao.GetLocacoesIndividual();
                        break;
                    }
                   
                } 
            }while(op!=9);
        }
    }
}
