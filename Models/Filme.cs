using System;
using Repositories;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Models
{
    public class Filme
    {
        // Criando os atributos com o gets e sets
        [Key]
        public int FilmeId { get; set; }
        [Required]
        public String Nome { get; set; }
        public String DataLancamento { get; set; }
        public String Sinopse { get; set; }
        public double Valor { get; set; }
        public int EstoqueTotal { get; set; }
        public int EstoqueAtual { get; set; }
        public int Locado { get; set; }

        public Filme(){}

        public static List<Filme> GetFilmes(){
            return RepositorioFilme.GetFilmes();
        }

        public static Filme GetFilmes(int filmeId){
            return RepositorioFilme.GetFilmes().Find(filme => filme.FilmeId == filmeId);
        }

        // Construtor da classe
        public Filme(String nome, String dataLancamento, String sinopse, double valor, int estoqueTotal){
            FilmeId = RepositorioFilme.GetUltimoIdFilme()+1;
            Nome = nome;
            DataLancamento = dataLancamento;
            Sinopse = sinopse;
            Valor = valor;
            EstoqueTotal = estoqueTotal;
            EstoqueAtual = estoqueTotal;
            Locado = 0;

            Context db = new Context();
            db.Filmes.Add(this);
            db.SaveChanges();
            
            RepositorioFilme.AddFilmes(this);
        }

        // Metodo para dizer que o filme foi locado e contabilizar
        public override string ToString(){
            return  $"Nome: {Nome} \n"+
                    $"Data Lançamento:  {DataLancamento} \n"+
                    $"Sinope: {Sinopse} \n"+
                    $"Valor: R$  {Valor} \nEstoque Atual:  {EstoqueAtual}\n"+
                    $"Quantidade de locações feitas: {Locado}\n";
        }  
    }
}
