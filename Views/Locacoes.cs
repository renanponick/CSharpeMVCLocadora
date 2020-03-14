using System;
using ControllerLocacoes;

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
    }
}
           
