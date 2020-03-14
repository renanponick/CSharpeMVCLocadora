using ModelFilmes;
using Repositories;
using System;
using System.Collections.Generic;

namespace ControllerFilmes{
    public class ControllerFilme{    
        public static void addFilme(string titulo, string lancamento, string descricao, double valor, int qtde){
            try{
                new ClasseFilme(RepositorioGeral.getFilmes().Count+1, titulo, lancamento, descricao, valor, qtde);
            }catch(Exception e){
                Console.WriteLine(e);
            }
        }
        public static List<ClasseFilme> getFilmes(){
            return Repositories.RepositorioGeral.getFilmes();
        }
    }
}
           
