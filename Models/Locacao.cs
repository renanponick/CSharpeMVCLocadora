using System;
using Controllers;
using Repositories;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace Models
{
    public class Locacao
    {
        //[Key]
        public int LocacaoId { get; set; }
        //[ForeignKey("Cliente")]
        public int ClienteId { get; set; }
        //public Cliente Cliente { get; set; }
        public DateTime DataLocacao { get; set; }
        public double ValorTotal { get; set; }
        public Locacao(){}
        // Criando contrutor
        public Locacao (int clienteId, DateTime dtLocacao) {
            Context db = new Context();
            //informa o id da chave de relação
            ClienteId = clienteId;
            DataLocacao = dtLocacao;
            // adiciona a locação no repositorio de locações através do cliente
            InserirLocacao(this);
        }
        public void InserirLocacao(Locacao locacao) {
            Context db = new Context();
            db.Locacoes.Add(locacao);
            db.SaveChanges();
        }
        public List<Filme> GetFilmes(int LocacaoId){
            Context db = new Context();
            IEnumerable<Filme> filmes =from Filmes in db.FilmesLocacoes
                                    where Filmes.LocacaoId == LocacaoId
                                    select Filmes.Filme;
            return filmes.ToList();
        }
        public void AdicionarFilme(int filmeId, Locacao locacao){
            //toda vez que eu for adicionar um filme preciso relacionar agora a classe relacional indicando o 
            //filme e a locação correspondente
            var db = new Context();
            FilmeLocacao filmeLocacao = new FilmeLocacao(){
                FilmeId = filmeId,
                LocacaoId = LocacaoId
            };

            db.FilmesLocacoes.Add(filmeLocacao);
            this.ValorTotal = ControllerLocacao.CalcularPrecoFinal(locacao);
            db.Locacoes.Update(locacao);
            db.SaveChanges();
            ControllerFilme.FilmeLocado(filmeId);
        }
        
        public static Locacao GetLocacao(int locacaoId){
            Context db = new Context();
            return db.Locacoes.Find(locacaoId);
        }
        public static List<Locacao> GetLocacoes(){
            Context db = new Context();
            IEnumerable<Locacao> Locacoes = from locacoes in db.Locacoes select locacoes;
            return Locacoes.ToList();
        }

        public override string ToString(){
                string retorno = $"Id Locação: {LocacaoId}\n"+
                        $"Valor pago R$: {ControllerLocacao.CalcularPrecoFinal(this)} \n"+
                        $"Data Locado: {DataLocacao} \n"+
                        $"Data de Devolução: {ControllerLocacao.CalculaData(this)} \n"+
                        "Filmes: ";

                List<Filme> filmes = GetFilmes(this.LocacaoId);
                filmes.ForEach(
                    filme => retorno += $"\n{filme.Nome}"
                );
                return retorno;   
            }
    }
}
