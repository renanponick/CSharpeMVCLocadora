using System;
using Controllers;
using Models;
using System.Linq;

namespace ViewLocacoes{
    public class ViewLocacao{
        // Busca uma locação específica pelo ID
        public static void GetLocacoesIndividual(){
            Console.WriteLine("Digite o ID da Locacao: ");
            int id = Convert.ToInt32 (Console.ReadLine());
            try{
                Console.WriteLine(ControllerLocacao.GetLocacao(id));
            }catch(Exception e){
                Console.WriteLine(e);
            } 
        }
        // Adiciona todas as locações
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
}
           
