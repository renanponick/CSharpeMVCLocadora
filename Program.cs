using System;


namespace CSharpeAvaliacaoMVCLocadora
{
    public class Program
    {
        public static void Main(string[] args){
            int op;
           
            Console.WriteLine("O que gostaria de executar?");
            Console.WriteLine("1 - Exibir relatórios de clientes");
            Console.WriteLine("2 - Exibir relatórios de filmes");
            op = Convert.ToInt32(Console.ReadLine());
            
           
        }
    }
}
