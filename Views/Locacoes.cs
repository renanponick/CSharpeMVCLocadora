using System;
using System.Collections;
using System.Linq;
using Controllers;
using Models;

namespace ViewLocacoes{
    public class ViewLocacao{
        public static void AddLocacoes(){
            ControllerLocacao.AddLocacoes();
        }
        public static void GetLocacoesCliente(){
            Console.WriteLine("Digite o ID do cliente: ");
            int id = Convert.ToInt32 (Console.ReadLine());
            IEnumerable clienteQuerry = from cliente in ControllerCliente.GetClientes() 
                                         where cliente.ID == id select cliente;
            foreach (ClasseCliente cliente in clienteQuerry){ 
                Console.WriteLine(cliente.Nome); 
                Console.WriteLine(" ------ Locação Realizada -----");
                foreach (ClasseLocacao locacao in cliente.Locacoes){ 
                    Console.WriteLine(locacao); 
                    Console.WriteLine("------ Filmes locados -----");
                    foreach (ClasseFilme filme in locacao.Filmes){ 
                        Console.WriteLine(filme);
                    }
                    Console.WriteLine("------ Fim Filmes -----");
                }
                 Console.WriteLine(" ------ Fim Locação  -----");
            }
        }
        public static void GetLocacoesIndividual(){
            Console.WriteLine("Digite o ID da Locacao: ");
            int id = Convert.ToInt32 (Console.ReadLine());
            ClasseCliente clienteQuerry = (from cliente in ControllerCliente.GetClientes() 
                                         where cliente.ID == id select cliente).First();
             Console.WriteLine(clienteQuerry); 
        }
        public static void AddLocacao(){
            int idLocacao, idCliente;
            Console.WriteLine("Digite o id do cliente:");
            idCliente = Convert.ToInt32(Console.ReadLine());
            idLocacao = ControllerLocacao.AddLocacao(idCliente);
            int opc=1;
            do{
                ViewLocacao.AddFilmeLocacao(idLocacao, idCliente);
                Console.WriteLine("Deseja cadastrar outro filme? 0-Não 1-Sim");
                opc = Convert.ToInt32(Console.ReadLine());
            }while(opc!=0);
            Console.WriteLine("Filme Cadastrado com Sucesso");
        }
        public static void AddFilmeLocacao(int idLocacao, int idCliente){
            int idFilme;
            Console.WriteLine("Digite o id do filme:");
            idFilme = Convert.ToInt32(Console.ReadLine());
            ControllerLocacao.AddFilmeLocacao(idCliente, idLocacao, idFilme);
        }
    }
}
           
