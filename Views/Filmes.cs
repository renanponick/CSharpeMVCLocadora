using System;
using ModelFilmes;
using ControllerFilmes;
using System.Collections;
using System.Linq;

namespace ViewFilmes{
    public class ViewFilme{
        public static void addTodosFilmes(){
            ControllerFilme.addFilme("Jhon, e os quem", "25/10/2018", "Uma História", 2, 3);
            ControllerFilme.addFilme("A volta dos que não foram", "23/10/2018", "Uma História linda de amor e superação", 1, 4);
            ControllerFilme.addFilme("Tranças do Careca", "24/10/2018", "Uma História", 5, 1);
            ControllerFilme.addFilme("Se não fosse o quase", "22/10/2018", "Uma História", 1, 5);
            ControllerFilme.addFilme("Teste Alfa", "25/10/2018", "Uma História", 5, 2);
            ControllerFilme.addFilme("Teste Beta", "25/10/2018", "Uma História", 2, 5);
            ControllerFilme.addFilme("Teste 3 - O retorno do Alfa", "25/10/2018", "Uma História", 2, 4);
            ControllerFilme.addFilme("Beta, longe de casa", "01/10/2018", "Uma História", 2, 10);
            ControllerFilme.addFilme("O final do inicio", "12/12/2018", "Uma História", 1, 5);
            ControllerFilme.addFilme("O paraíso do Tártaro", "10/10/2018", "Uma História", 3, 4);
        }
        public static void addFilme(){
            string titulo, lancamento, descricao;
            double valor;
            int qtde;
            try{
                Console.WriteLine("Digite o Título do Filme:");
                titulo = Console.ReadLine();
                Console.WriteLine("Digite a data de lançamento: (dd/mm/aaaa):");
                lancamento = Console.ReadLine();
                Console.WriteLine("Descreva o filme:");
                descricao = Console.ReadLine();
                Console.WriteLine("Digite o Valor do Filme:");
                valor = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite a quantidade de filmes:");
                qtde = Convert.ToInt32(Console.ReadLine());
                ControllerFilme.addFilme(titulo, lancamento, descricao, valor, qtde);
            }catch(Exception e){
                Console.WriteLine(e);
            }
        }
        public static void getFilmes(){
            IEnumerable funcQuery = from filmes in ControllerFilme.getFilmes() select filmes;
             foreach (ClasseFilme filme in funcQuery) {
                Console.Write(filme);
            }
        }
    }
}
           
