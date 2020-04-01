using System;
using Models;
using Controllers;
using System.Collections;
using System.Linq;

namespace ViewFilmes{
    public class ViewFilme{
        public static void AddTodosFilmes(){
            ControllerFilme.AddFilme("Jhon, e os quem", "25/10/2018", "Uma História", 2, 3);
            ControllerFilme.AddFilme("A volta dos que não foram", "23/10/2018", "Uma História linda de amor e superação", 1, 4);
            ControllerFilme.AddFilme("Tranças do Careca", "24/10/2018", "Uma História", 5, 1);
            ControllerFilme.AddFilme("Se não fosse o quase", "22/10/2018", "Uma História", 1, 5);
            ControllerFilme.AddFilme("Teste Alfa", "25/10/2018", "Uma História", 5, 2);
            ControllerFilme.AddFilme("Teste Beta", "25/10/2018", "Uma História", 2, 5);
            ControllerFilme.AddFilme("Teste 3 - O retorno do Alfa", "25/10/2018", "Uma História", 2, 4);
            ControllerFilme.AddFilme("Beta, longe de casa", "01/10/2018", "Uma História", 2, 10);
            ControllerFilme.AddFilme("O final do inicio", "12/12/2018", "Uma História", 1, 5);
            ControllerFilme.AddFilme("O paraíso do Tártaro", "10/10/2018", "Uma História", 3, 4);
        }
        public static void AddFilme(){
            try{
                Console.WriteLine("Digite o Título do Filme:");
                string titulo = Console.ReadLine();
                Console.WriteLine("Digite a data de lançamento: (dd/mm/aaaa):");
                string lancamento = Console.ReadLine();
                Console.WriteLine("Descreva o filme:");
                string descricao = Console.ReadLine();
                Console.WriteLine("Digite o Valor do Filme:");
                double valor = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite a quantidade de filmes:");
                int qtde = Convert.ToInt32(Console.ReadLine());
                ControllerFilme.AddFilme(titulo, lancamento, descricao, valor, qtde);
            }catch(Exception e){
                Console.WriteLine(e);
            }
        }
        public static void GetFilmes(){
            IEnumerable funcQuery = from filmes in ControllerFilme.GetFilmes() select filmes;
             foreach (Filme filme in funcQuery) {
                Console.Write(filme);
            }
        }
    }
}
           
