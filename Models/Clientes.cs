using System;
using System.Collections.Generic;
using Locacoes;
using Filmes;
using System.Linq;

namespace Clientes
{
    public class ClasseCliente
    {
        public int ID { get; set; }
        public String Nome { get; set; }
        public String DataNascimento { get; set; }
        public String Cpf { get; set; }
        public int Dias { get; set; }
        public int FilmesLocados { get; set; }
        public List<ClasseLocacao> Locacoes = new List<ClasseLocacao>();

        public ClasseCliente(int id, String nome, String dataNascimento, String cpf, int dias){
            ID = id;
            Nome = nome;
            DataNascimento = dataNascimento;
            Cpf = cpf;
            Dias = dias;
            FilmesLocados = 0;
        }
        public override string ToString(){
            Console.WriteLine($"Id: {ID}");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Nascido em: {DataNascimento}");
            Console.WriteLine($"Cpf : {Cpf}");
            Console.WriteLine($"Dias para devolução: {Dias}");
            Console.WriteLine($"Qtde Filmes Locados: {FilmesLocados}");
            if(locacoes.ElementAt(0).Id!=0){
                Console.WriteLine("Filmes Locados:");
                int aux = 0 ;
                foreach(ClasseLocacao locacao in Locacoes){
                    aux ++;
                    Console.WriteLine($" ----------- Locação - {aux} -------------");
                    foreach(ClasseFilme filme in locacao.Filmes){
                        Console.WriteLine(filme.Nome);
                    }
                    locacao.calculaData();
                    locacao.calcularPrecoFinal();
                    Console.WriteLine($"Valor pago R$: {locacao.ValorTotal}");
                    Console.WriteLine($"Data Locado: {locacao.DataLocacao}");
                    Console.WriteLine($"Data de Devolução: {locacao.DataDevolucao}");
                }
                Console.WriteLine($"Quantidade de locações realizadas foi: {aux}");
            }
        }
    }
}
