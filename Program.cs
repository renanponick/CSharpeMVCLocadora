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
            int lib=0;
            do{
                Console.WriteLine("\n ----------------------- BlockBuster ---------------------------- \n");
                Console.WriteLine("1 - Criar todos os Filmes");
                if(Repositories.RepositorioGeral.GetFilmes().Count > 0){
                    lib=1;
                    Console.WriteLine("2 - Visualizar Filmes");
                }
                Console.WriteLine("3 - Criar todos os Clientes");
                if(Repositories.RepositorioGeral.GetClientes().Count > 0){
                    lib=1;
                    Console.WriteLine("4 - Visualizar Clientes");
                    if(Repositories.RepositorioGeral.GetFilmes().Count > 0){
                        Console.WriteLine("5 - Criar Locações");
                        Console.WriteLine("6 - Realizar Locação <- Falha, vou tentar corrigir se der tempo");
                    }
                }
                Console.WriteLine("7 - Criar o Filme");
                Console.WriteLine("8 - Criar o Cliente");
                Console.WriteLine("9 - Consultar Locação Por Cliente- Só disponiel depois de ter locações realizadas");
                Console.WriteLine("10 - Consultar Locação Individual - Só disponiel depois de ter locações realizadas");
                
                Console.WriteLine("11 - Sair");
                op = Convert.ToInt32(Console.ReadLine());

                if(lib == 0){
                    if((op != 1)&&(op !=3)&&(op !=8)&&(op !=7)&&(op !=11)){
                        op=0;
                    }
                }

                switch(op){
                    case 0:{
                        Console.WriteLine("Ação Negada");
                        break;
                    }
                    case 1:{
                        ViewFilme.AddTodosFilmes();
                        Console.WriteLine("Filmes criados com sucesso");
                        break;
                    }
                    case 2:{
                        ViewFilme.GetFilmes();
                        break;
                    }
                    case 3:{
                        ViewCliente.AddTodosClientes();
                         Console.WriteLine("Clientes criados com sucesso");
                        break;
                    }
                    case 4:{
                        ViewCliente.GetClientes();
                        break;
                    }
                    case 5:{
                        ViewLocacao.AddLocacoes();
                        Console.WriteLine("Locações criadas com sucesso");
                        break;
                    }
                    case 7:{
                        ViewFilme.AddFilme();
                        Console.WriteLine("Filme criado com sucesso");
                        break;
                    }
                    case 8:{
                        ViewCliente.AddCliente();
                        Console.WriteLine("Cliente criado com sucesso");
                        break;
                    }
                    case 6:{
                        ViewLocacao.AddLocacao();
                        break;
                    }
                    case 9:{
                        ViewLocacao.GetLocacoesCliente();
                        break;
                    }
                    case 10:{
                        ViewLocacao.GetLocacoesIndividual();
                        break;
                    }
                } 
            }while(op!=11);
        }
    }
}
