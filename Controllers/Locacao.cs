using System;
using System.Collections.Generic;
using System.Linq;
using Models;
using Repositories;

namespace Controllers{
    public class ControllerLocacao{
        /*public static void AddFilmeLocacao(int idCliente,int idLocacao,int idFilme){
            if(RepositorioCliente.GetUltimoIdCliente()>0){
                Cliente cliente =  RepositorioCliente.GetClientes().ElementAt(idCliente);
                if(RepositorioLocacao.GetUltimoIdLocacao()>0){
                    Locacao locacao = cliente.GetLocacoes(cliente.ClienteId).ElementAt(idLocacao);
                    if(RepositorioFilme.GetUltimoIdFilme()>0){
                        locacao.AdicionarFilme(RepositorioFilme.GetFilmes().ElementAt(idFilme));
                    }
                }
            }
        }*/
        public static void AddTodasLocacoes(){
            DateTime data = DateTime.Today;

            Locacao locacao = new Locacao(1, data);
            locacao.AdicionarFilme(1);
            locacao.AdicionarFilme(2);
            locacao.AdicionarFilme(3);

            locacao = new Locacao(2, data);
            locacao.AdicionarFilme(1);
            locacao.AdicionarFilme(6);
            locacao.AdicionarFilme(5);

            locacao = new Locacao(3, data);
            locacao.AdicionarFilme(10);
            locacao.AdicionarFilme(9);
            locacao.AdicionarFilme(7);
        }
        public static Locacao GetLocacao(int idLocacao){
            return Locacao.GetLocacao(idLocacao);
        }
        public static double CalcularPrecoFinal(Locacao locacao){
            double valorTotal=0;
            List<Filme> filmes = locacao.GetFilmes(locacao.LocacaoId);
            foreach(Filme filme in filmes){
                valorTotal += filme.Valor;
            }
            return valorTotal;
        }
        public static DateTime CalculaData(Locacao locacao){
            DateTime data = DateTime.Today;
            Cliente cliente = Cliente.GetCliente(locacao.ClienteId);
            return data.AddDays(cliente.Dias);
        }

    }
}
           
