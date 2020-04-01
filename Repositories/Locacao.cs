using System.Collections.Generic;
using Models;
using System.Linq;

namespace Repositories
{
    public class RepositorioLocacao
        {
            static List<Locacao> Locacoes = new List<Locacao>();
            public static void AddLocacoes(Locacao locacao){
                Locacoes.Add(locacao);
            }
            public static List<Locacao> GetLocacoes(){
                return Locacoes;
            }
            public static int GetUltimoIdLocacao(){
                 int id;
                try{
                    id = (from locacoes in Locacoes select locacoes.ID).Max();
                }catch{
                    id = 0;
                }
                return id;
            }
        }
}