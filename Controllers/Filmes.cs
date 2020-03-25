using System;
using System.Collections.Generic;
using Models;
using Repositories;

namespace Controllers{
    public class ControllerFilme{    
        public static void AddFilme(string titulo, string lancamento, string descricao, double valor, int qtde){
            try{
                new ClasseFilme(titulo, lancamento, descricao, valor, qtde);
            }catch(Exception e){
                Console.WriteLine(e);
            }
        }
        public static List<ClasseFilme> GetFilmes(){
            return Repositories.RepositorioGeral.GetFilmes();
        }

        // ----------- funções de manipulação de dados ------------- //
        public static void FilmeLocado(ClasseFilme filme){
            filme.EstoqueAtual-=1;
            filme.Locado+=1;
        }
        //Não foi feito nada pra devolver o filme por hora.
        public static void DevolverFilme(ClasseFilme filme){
            filme.EstoqueAtual+=1;
            filme.Locado-=1;
        }
    }
}
           
