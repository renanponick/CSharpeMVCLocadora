using System;
using System.Collections.Generic;
using Models;
using Repositories;

namespace Controllers{
    public class ControllerFilme{    
        public static void AddFilme(string titulo, string lancamento, string descricao, double valor, int qtde){
            try{
                new Filme(titulo, lancamento, descricao, valor, qtde);
            }catch(Exception e){
                Console.WriteLine(e);
            }
        }
        public static List<Filme> GetFilmes(){
            return Filme.GetFilmes();
        }

        public static Filme GetFilmes(int filmeId){
            //muda retornos
            return Filme.GetFilmes(filmeId);
        }

        // ----------- funções de manipulação de dados ------------- //
        public static void FilmeLocado(Filme filme){
            filme.EstoqueAtual-=1;
            filme.Locado+=1;
        }
        //Não foi feito nada pra devolver o filme por hora.
        public static void DevolverFilme(Filme filme){
            filme.EstoqueAtual+=1;
            filme.Locado-=1;
        }
    }
}
/*
1. `dotnet tool install dotnet-ef -g --version 3.1.1`
2. `dotnet add package Pomelo.EntityFrameworkCore.MySql`
3. -`dotnet add package Pomelo.EntityFrameworkCore.MySql.Desing`
4. `dotnet add package Microsoft.EntityFrameworkCore`
5. -`dotnet add package Microsoft.EntityFrameworkCore.Desing`
6. `dotnet ef migrations add InitialDB`
7. `dotnet ef database update
*/
           
