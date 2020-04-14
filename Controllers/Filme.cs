using System;
using System.Collections.Generic;
using Models;
using Repositories;

namespace Controllers{
    public class ControllerFilme{
        // metodo para adicionar um filme no banco 
        public static void AddFilme(string titulo, string lancamento, string descricao, double valor, int qtde){
            try{
                new Filme(titulo, lancamento, descricao, valor, qtde);
            }catch(Exception e){
                Console.WriteLine(e);
            }
        }

        // metodo para buscar a lista de todos os filmes
        public static List<Filme> GetFilmes(){
            return Filme.GetFilmes();
        }
        
        // metodo para buscar um filme em específico
        public static Filme GetFilme(int filmeId){
            return Filme.GetFilme(filmeId);
        }
        // ----------- funções de manipulação de dados ------------- //
        public static void FilmeLocado(int filmeId){
            GetFilme(filmeId).EstoqueAtual-=1;
            GetFilme(filmeId).Locado+=1;
        }
        /*Não foi feito nada pra devolver o filme por hora.
        public static void DevolverFilme(int filmeId){
            GetFilme(filmeId).EstoqueAtual+=1;
            GetFilme(filmeId).Locado-=1;
        }*/
    }
}
           
