using System.Collections.Generic;
using Models;
using System.Linq;

namespace Repositories
{
    public class RepositorioFilme
        {
            static List<Filme> Filmes = new List<Filme>();
            public static void AddFilmes(Filme filme){
                Filmes.Add(filme);
            }
            public static List<Filme> GetFilmes(){
                return Filmes;
            }
            public static int GetUltimoIdFilme(){
                int id;
                try{
                    id = (from filmes in Filmes select filmes.ID).Max();
                }catch{
                    id = 0;
                }
                return id;
            }
        }
}