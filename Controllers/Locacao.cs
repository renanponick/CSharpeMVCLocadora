using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Models;
using Repositories;

namespace Controllers{
    public class ControllerLocacao{
        public static void AddTodasLocacoes(){
            DateTime data = DateTime.Today;
            IEnumerable funcQuery = from clientes in ControllerCliente.GetClientes() select clientes;
            foreach (Cliente cliente in funcQuery) {
                Locacao locacao = new Locacao(cliente.ClienteId, data);
                IEnumerable funcQueryFilm = from filmes in ControllerFilme.GetFilmes() select filmes;
                    foreach (Filme filme in funcQueryFilm){
                        locacao.AdicionarFilme(filme.FilmeId, locacao);
                    }
            }
        }
        public static void AddLocacao(int ClienteId, int[] filmes){
            DateTime data = DateTime.Today;
            Locacao locacao = new Locacao(ClienteId, data);
            foreach (int filme in filmes){
                locacao.AdicionarFilme(filme, locacao);
            }
        }
        public static Locacao GetLocacao(int idLocacao){
            return Locacao.GetLocacao(idLocacao);
        }
        public static List<Locacao> GetLocacoes(){
            return Locacao.GetLocacoes();
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
           
