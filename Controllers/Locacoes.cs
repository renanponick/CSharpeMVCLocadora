using System;
using System.Collections.Generic;
using System.Linq;
using Models;
using Repositories;

namespace Controllers{
    public class ControllerLocacao{
        public static void AddLocacoes(){
            if(RepositorioGeral.GetClientes().Count > 0){
                try{
                    ClasseLocacao locacao;
                    locacao = new ClasseLocacao(RepositorioGeral.GetClientes().ElementAt(0));
                    locacao.AdicionarFilme(RepositorioGeral.GetFilmes().ElementAt(1));
                    locacao.AdicionarFilme(RepositorioGeral.GetFilmes().ElementAt(3));
                    locacao.AdicionarFilme(RepositorioGeral.GetFilmes().ElementAt(5));
                    RepositorioGeral.GetClientes().ElementAt(0).Locacoes.Add(locacao);

                    locacao = new ClasseLocacao(RepositorioGeral.GetClientes().ElementAt(1));
                    locacao.AdicionarFilme(RepositorioGeral.GetFilmes().ElementAt(0));
                    locacao.AdicionarFilme(RepositorioGeral.GetFilmes().ElementAt(7));
                    locacao.AdicionarFilme(RepositorioGeral.GetFilmes().ElementAt(8));
                    RepositorioGeral.GetClientes().ElementAt(1).Locacoes.Add(locacao);
              
                    locacao = new ClasseLocacao(RepositorioGeral.GetClientes().ElementAt(2));
                    locacao.AdicionarFilme(RepositorioGeral.GetFilmes().ElementAt(4));
                    locacao.AdicionarFilme(RepositorioGeral.GetFilmes().ElementAt(3));
                    locacao.AdicionarFilme(RepositorioGeral.GetFilmes().ElementAt(9));
                    RepositorioGeral.GetClientes().ElementAt(2).Locacoes.Add(locacao);

                    locacao = new ClasseLocacao(RepositorioGeral.GetClientes().ElementAt(2));
                    locacao.AdicionarFilme(RepositorioGeral.GetFilmes().ElementAt(2));
                    locacao.AdicionarFilme(RepositorioGeral.GetFilmes().ElementAt(1));
                    RepositorioGeral.GetClientes().ElementAt(2).Locacoes.Add(locacao);
                }catch(Exception e){
                    Console.WriteLine(e);
                }
            }           
        }
        public static int AddLocacao(int idCliente){
            RepositorioGeral.GetClientes().ElementAt(idCliente).Locacoes.Add(new ClasseLocacao(RepositorioGeral.GetClientes().ElementAt(idCliente)));
            Console.WriteLine(RepositorioGeral.GetClientes().ElementAt(idCliente));
            return RepositorioGeral.GetUltimoIdLocacao();
        }
        public static void AddFilmeLocacao(int idCliente,int idLocacao,int idFilme){
            Console.WriteLine(idCliente);
            Console.WriteLine(idLocacao);
            Console.WriteLine(idFilme);
            if(RepositorioGeral.GetUltimoIdCliente()>0){
                ClasseCliente cliente =  RepositorioGeral.GetClientes().ElementAt(idCliente);
                if(RepositorioGeral.GetUltimoIdLocacao()>0){
                    ClasseLocacao locacao = cliente.Locacoes.ElementAt(idLocacao);
                    if(RepositorioGeral.GetUltimoIdFilme()>0){
                        locacao.AdicionarFilme(RepositorioGeral.GetFilmes().ElementAt(idFilme));
                    }
                }
            }
        }
        public static List<ClasseLocacao> GetLocacoes(){
            return Repositories.RepositorioGeral.GetLocacoes();
        }
        public static double CalcularPrecoFinal(ClasseLocacao locacao){
            double valorTotal=0;
            foreach(ClasseFilme filme in locacao.Filmes){
                valorTotal += filme.Valor;
            }
            return valorTotal;
        }
        public static String CalculaData(ClasseLocacao locacao){
            return locacao.Data.AddDays(locacao.Cliente.Dias).ToString();
        }

    }
}
           
