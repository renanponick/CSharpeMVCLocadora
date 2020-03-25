using System;
using ControllerLocacoes;
using System.Collections;
using ModelLocacoes;
using ControllerClientes;
using ModelFilmes;
using ModelClientes;
using System.Linq;

namespace ViewLocacoes{
    public class ViewLocacao{
        public static void addLocacoes(){
            ControllerLocacao.addLocacoes();
        }
        public static string addLocacao(){
            int idCliente;
            Console.WriteLine("Digite o id do cliente:");
            idCliente = Convert.ToInt32(Console.ReadLine());
            idCliente --;
            return ControllerLocacao.addLocacao(idCliente);
        }
        public static void addFilmeLocacao(int idLocacao, int idCliente){
            int idFilme;
            Console.WriteLine("Digite o id do filme:");
            idFilme = Convert.ToInt32(Console.ReadLine());
            ControllerLocacao.addFilmeLocacao(idCliente, idLocacao, idFilme);
        }
        public static void getLocacoes(){
            Console.WriteLine("Digite o ID do cliente: ");
            int id = Convert.ToInt32 (Console.ReadLine());
            IEnumerable clienteQuerry = from cliente in ControllerCliente.getClientes() 
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
    }
}
           
