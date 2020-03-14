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
                        Console.WriteLine("6 - Realizar Locação ");
                    }
                }
                Console.WriteLine("7 - Criar o Filme");
                Console.WriteLine("8 - Criar o Cliente");
                
                Console.WriteLine("9 - Sair");
                op = Convert.ToInt32(Console.ReadLine());

                if(lib == 0){
                    if((op != 1)&&(op !=3)&&(op !=9)&&(op !=8)&&(op !=7)){
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
                    case 7:{
                        ViewFilme.addFilme();
                        Console.WriteLine("Filme criado com sucesso");
                        break;
                    }
                    case 8:{
                        ViewCliente.addCliente();
                        Console.WriteLine("Cliente criado com sucesso");
                        break;
                    }
                    case 6:{
                        int idLocacao, idCliente;
                        string retorno = ViewLocacao.addLocacao();
                        string[] auxiliar = retorno.Split('/');
                        idLocacao = Int32.Parse(auxiliar[0]);
                        idCliente = Int32.Parse(auxiliar[1]);
                        idLocacao--;
                        int opc=1;
                        do{
                            ViewLocacao.addFilmeLocacao(idLocacao, idCliente);
                            Console.WriteLine("Deseja cadastrar outro filme? 0-Não 1-Sim");
                            opc = Convert.ToInt32(Console.ReadLine());
                        }while(opc!=0);
                        Console.WriteLine("Filme Cadastrado com Sucesso");
                        break;
                    }
                } 
            }while(op!=9);
        }
    }
}
