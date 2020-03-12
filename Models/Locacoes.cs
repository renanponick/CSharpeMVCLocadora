using System;
using System.Collections.Generic;
using ModelClientes;
using ModelFilmes;

namespace ModelLocacoes
{
    public class ClasseLocacao
    {
        // Criando atributos e seus getters e setters
        public DateTime Data = DateTime.Today;
        public int ID { get; set; }
        public ClasseCliente Cliente { get; set; }
        public String DataLocacao { get; set; }
        public String DataDevolucao { get; set; }
        public float ValorTotal { get; set; }
        public List<ClasseFilme> Filmes = new List<ClasseFilme>();

        // Criando contrutor
        public ClasseLocacao(int id, ClasseCliente cliente){
            ID = id;
            Cliente = cliente;
            DataLocacao = Data.ToString().Substring(0,10);
        }

        //Criando demais funções
            //Adicionar filme
            public void adicionarFilme(ClasseFilme filme){
                if(filme.EstoqueAtual>1){
                    Filmes.Add(filme);
                    //Filme.filmeLocado();
                    Cliente.FilmesLocados+=1;
                }else{
                    Console.WriteLine($"Não é possivel locar este filme, não temos em estoque.{filme.Nome}");
                }
            }
            //Calcular o valor final da locacao
            public void calcularPrecoFinal(){
                foreach(ClasseFilme filme in Filmes){
                    ValorTotal += filme.Valor;
                }
            }
            // Calcular a data de devolução do filme
            public void calculaData(){
                Data.AddDays(Cliente.Dias);
                DataDevolucao = Data.ToString().Substring(0,10);
            }
    }
}
