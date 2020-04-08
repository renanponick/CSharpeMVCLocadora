using System;
using Controllers;
using Repositories;
using System.Linq;
using System.Collections.Generic;

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
            //pega o ultimo id do repositorio
            LocacaoId = RepositorioLocacao.GetUltimoIdLocacao()+1;
            //informa o id da chave de relação
            ClienteId = clienteId;
            DataLocacao = dtLocacao;
            // adiciona a locação no repositorio de locações através do cliente
            InserirLocacao(this);
            //salvando no banco a locacao
            Context db = new Context();
            db.Locacoes.Add(this);
            db.SaveChanges();
        }
        public void InserirLocacao(Locacao locacao) {
            RepositorioLocacao.AddLocacoes(locacao);
        }
        public List<Filme> GetFilmes(int LocacaoId){
            Context db = new Context();
            IEnumerable<Filme> filmes =from Filmes in db.FilmesLocacoes
                                    where Filmes.LocacaoId == LocacaoId
                                    select Filmes.Filme;
            return filmes.ToList();
        }
        public void AdicionarFilme(int filmeId){
            //toda vez que eu for adicionar um filme preciso relacionar agora a classe relacional indicando o 
            //filme e a locação correspondente
            var db = new Context();
            FilmeLocacao filmeLocacao = new FilmeLocacao(){
                FilmeId = filmeId,
                LocacaoId = LocacaoId
            };
            db.FilmesLocacoes.Add(filmeLocacao);
            db.SaveChanges();
            ControllerFilme.FilmeLocado(filmeId);
        }
        
        public static Locacao GetLocacao(int locacaoId){
            return RepositorioLocacao.GetLocacoes().Find(locacao => locacao.LocacaoId == locacaoId);
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
