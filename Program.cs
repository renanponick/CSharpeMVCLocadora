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
                if(Repositories.RepositorioGeral.getFilmes().Count > 0){
                    lib=1;
                    Console.WriteLine("2 - Visualizar Filmes");
                }
                Console.WriteLine("3 - Criar todos os Clientes");
                if(Repositories.RepositorioGeral.getClientes().Count > 0){
                    lib=1;
                    Console.WriteLine("4 - Visualizar Clientes");
                    if(Repositories.RepositorioGeral.getFilmes().Count > 0){
                        Console.WriteLine("5 - Criar Locações");
                    }
                }
                
                Console.WriteLine("9 - Sair");
                op = Convert.ToInt32(Console.ReadLine());

                if(lib == 0){
                    if((op != 1)&&(op !=3)&&(op !=9)){
                        op=0;
                    }
                }

                switch(op){
                    case 0:{
                        Console.WriteLine("Ação Negada");
                        break;
                    }
                    case 1:{
                        ViewFilme.addTodosFilmes();
                        Console.WriteLine("Filmes criados com sucesso");
                        break;
                    }
                    case 2:{
                        ViewFilme.getFilmes();
                        break;
                    }
                    case 3:{
                        ViewCliente.addTodosClientes();
                         Console.WriteLine("Clientes criados com sucesso");
                        break;
                    }
                    case 4:{
                        ViewCliente.getClientes();
                        break;
                    }
                    case 5:{
                        ViewLocacao.addLocacoes();
                        Console.WriteLine("Locações criadas com sucesso");
                        break;
                    }
                    case 6:{
                        //ViewFilme.getFilmes();
                        break;
                    }
                } 
            }while(op!=9);
        }
    }
}
