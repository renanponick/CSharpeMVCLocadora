using System;
using System.Collections.Generic;
using System.Linq;
using Models;
using Repositories;

namespace Controllers{
    public class ControllerLocacao{
        
        public static void AddLocacoes(){
            if(RepositorioCliente.GetClientes().Count > 0){
                DateTime data = DateTime.Today;
                try{
                    Locacao locacao;
                    locacao = new Locacao(RepositorioCliente.GetClientes().ElementAt(0),data);
                    locacao.AdicionarFilme(RepositorioFilme.GetFilmes().ElementAt(1));
                    locacao.AdicionarFilme(RepositorioFilme.GetFilmes().ElementAt(3));
                    locacao.AdicionarFilme(RepositorioFilme.GetFilmes().ElementAt(5));
                    RepositorioCliente.GetClientes().ElementAt(0).InserirLocacao(locacao);

                    locacao = new Locacao(RepositorioCliente.GetClientes().ElementAt(1),data);
                    locacao.AdicionarFilme(RepositorioFilme.GetFilmes().ElementAt(0));
                    locacao.AdicionarFilme(RepositorioFilme.GetFilmes().ElementAt(7));
                    locacao.AdicionarFilme(RepositorioFilme.GetFilmes().ElementAt(8));
                    RepositorioCliente.GetClientes().ElementAt(1).InserirLocacao(locacao);
              
                    locacao = new Locacao(RepositorioCliente.GetClientes().ElementAt(2),data);
                    locacao.AdicionarFilme(RepositorioFilme.GetFilmes().ElementAt(4));
                    locacao.AdicionarFilme(RepositorioFilme.GetFilmes().ElementAt(3));
                    locacao.AdicionarFilme(RepositorioFilme.GetFilmes().ElementAt(9));
                    RepositorioCliente.GetClientes().ElementAt(2).InserirLocacao(locacao);

                    locacao = new Locacao(RepositorioCliente.GetClientes().ElementAt(2),data);
                    locacao.AdicionarFilme(RepositorioFilme.GetFilmes().ElementAt(2));
                    locacao.AdicionarFilme(RepositorioFilme.GetFilmes().ElementAt(1));
                    RepositorioCliente.GetClientes().ElementAt(2).InserirLocacao(locacao);
                }catch(Exception e){
                    Console.WriteLine(e);
                }
            }           
        }
        public static int AddLocacao(int idCliente){
            DateTime data = DateTime.Today;
            RepositorioCliente.GetClientes().ElementAt(idCliente).InserirLocacao(new Locacao(RepositorioCliente.GetClientes().ElementAt(idCliente),data));
            Console.WriteLine(RepositorioCliente.GetClientes().ElementAt(idCliente));
            return RepositorioLocacao.GetUltimoIdLocacao();
        }
        public static void AddFilmeLocacao(int idCliente,int idLocacao,int idFilme){
            Console.WriteLine(idCliente);
            Console.WriteLine(idLocacao);
            Console.WriteLine(idFilme);
            if(RepositorioCliente.GetUltimoIdCliente()>0){
                Cliente cliente =  RepositorioCliente.GetClientes().ElementAt(idCliente);
                if(RepositorioLocacao.GetUltimoIdLocacao()>0){
                    Locacao locacao = cliente.GetLocacoes(cliente.ClienteId).ElementAt(idLocacao);
                    if(RepositorioFilme.GetUltimoIdFilme()>0){
                        locacao.AdicionarFilme(RepositorioFilme.GetFilmes().ElementAt(idFilme));
                    }
                }
            }
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
            return data.AddDays(locacao.Cliente.Dias);
        }

    }
}
           
