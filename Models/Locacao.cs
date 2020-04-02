using System;
using System.Collections.Generic;
using Controllers;
using Repositories;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Locacao
    {
        // Criando atributos e seus getters e setters
       
        [Key]
        public int IdLocacao { get; set; }
       // [ForeignKey("Cliente")]
      //  [Column(Order = 1)]
        public Cliente Cliente { get; set; }
        public DateTime DataLocacao { get; set; }
        public double ValorTotal { get; set; }
       // [ForeignKey("Filme")]
      //  [Column(Order = 2)]
        public List<Filme> Filmes = new List<Filme>();

        public Locacao(){}

        // Criando contrutor
        public Locacao (Cliente cliente, DateTime dtLocacao) {
            IdLocacao = RepositorioLocacao.GetUltimoIdLocacao()+1;
            Cliente = cliente;
            DataLocacao = dtLocacao;
            Filmes = new List<Filme>();
            cliente.InserirLocacao(this);

            Context db = new Context();
            db.Locacoes.Add(this);
            db.SaveChanges();

            RepositorioLocacao.AddLocacoes(this);
        }
        public static Locacao GetLocacao(int idLocacao){           
            return RepositorioLocacao.GetLocacoes().Find(locacao => locacao.IdLocacao == idLocacao);
        }
        //Criando demais funções
            //Adicionar filme
            public void AdicionarFilme(Filme filme){
                Filmes.Add(filme);
                ControllerFilme.FilmeLocado(filme);
                Cliente.FilmesLocados+=1;
            }
            public override string ToString(){
                return  $"Id Locação: {IdLocacao}\n"+
                        $"Valor pago R$: {ControllerLocacao.CalcularPrecoFinal(this)} \n"+
                        $"Data Locado: {DataLocacao} \n"+
                        $"Data de Devolução: {ControllerLocacao.CalculaData(this)} \n";
            }
    }
}
