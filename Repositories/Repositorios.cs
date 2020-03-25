using System.Collections.Generic;
using Models;
using System.Linq;

namespace Repositories
{
    public class RepositorioGeral
        {
            static List<ClasseFilme> filmes = new List<ClasseFilme>();
            static List<ClasseCliente> clientes = new List<ClasseCliente>();
            static List<ClasseLocacao> locacoes = new List<ClasseLocacao>();

            public static void AddFilmes(ClasseFilme filme){
                filmes.Add(filme);
            }
            public static List<ClasseFilme> GetFilmes(){
                return filmes;
            }
             public static void AddClientes(ClasseCliente cliente){
                clientes.Add(cliente);
            }
            public static List<ClasseCliente> GetClientes(){
                return clientes;
            }
            public static void AddLocacoes(ClasseLocacao locacao){
                locacoes.Add(locacao);
            }
            public static List<ClasseLocacao> GetLocacoes(){
                return locacoes;
            }
            public static int GetUltimoIdCliente(){
                int id;
                try{
                    id = (from clientes in clientes select clientes.ID).Max();
                }catch{
                    id = 0;
                }
                return id;
            }
            public static int GetUltimoIdFilme(){
                int id;
                try{
                    id = (from filmes in filmes select filmes.ID).Max();
                }catch{
                    id = 0;
                }
                return id;
            }
            public static int GetUltimoIdLocacao(){
                 int id;
                try{
                    id = (from locacoes in locacoes select locacoes.ID).Max();
                }catch{
                    id = 0;
                }
                return id;
            }
        }
}