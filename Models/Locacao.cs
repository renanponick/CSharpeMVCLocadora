using System;
using Controllers;
using Repositories;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;

namespace Models
{
    public class Locacao
    {
        [Key]
        public int LocacaoId { get; set; }
        [ForeignKey("Cliente")]
        [Column(Order = 1)]
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime DataLocacao { get; set; }
        public double ValorTotal { get; set; }
        public Locacao(){}
        // Criando contrutor
        public Locacao (Cliente cliente, DateTime dtLocacao) {
            LocacaoId = RepositorioLocacao.GetUltimoIdLocacao()+1;
            Cliente = cliente;
            DataLocacao = dtLocacao;
            //Filmes = new List<Filme>();
            cliente.InserirLocacao(this);
            Context db = new Context();
            db.Locacoes.Add(this);
            db.SaveChanges();
            RepositorioLocacao.AddLocacoes(this);
        }
        //Criando demais funções
            public static Locacao GetLocacao(int locacaoId){           
                return RepositorioLocacao.GetLocacoes().Find(locacao => locacao.LocacaoId == locacaoId);
            }
           
            public List<Filme> GetFilmes(int LocacaoId){
                Context db = new Context();
                IEnumerable<Filme> filmes =from Filmes in db.FilmesLocacoes
                                        where Filmes.LocacaoId == LocacaoId
                                        select Filmes.Filme;
                return filmes.ToList();
            }
            //Adicionar filme
            public void AdicionarFilme(Filme filme){
                //toda vez que eu for adicionar um filme preciso relacionar agora a clase relacional indicando o 
                //filme e a locação correspondente
                var db = new Context();
                FilmeLocacao filmeLocacao = new FilmeLocacao(){
                    FilmeId = filme.FilmeId,
                    LocacaoId = LocacaoId
                };
                db.FilmesLocacoes.Add(filmeLocacao);
                db.SaveChanges();
                //Filmes.Add(filme);
                ControllerFilme.FilmeLocado(filme);
                Cliente.FilmesLocados+=1;
            }
            
            public override string ToString(){
                return  $"Id Locação: {LocacaoId}\n"+
                        $"Valor pago R$: {ControllerLocacao.CalcularPrecoFinal(this)} \n"+
                        $"Data Locado: {DataLocacao} \n"+
                        $"Data de Devolução: {ControllerLocacao.CalculaData(this)} \n";
            }
    }
}
