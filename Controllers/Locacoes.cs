using System;
using ModelLocacoes;
using Repositories;
using System.Linq;

namespace ControllerLocacoes{
    public class ControllerLocacao{
        public static void addLocacoes(){
            if(RepositorioGeral.getClientes().Count > 0){
                RepositorioGeral.getClientes().ElementAt(0).Locacoes.Add(new ClasseLocacao(RepositorioGeral.getClientes().ElementAt(0).getId()+1, RepositorioGeral.getClientes().ElementAt(0)));
            }
            //Repositories.RepositorioGeral.getClientes().ElementAt(0).locacoes.Add(new ClasseLocacao(clientes.ElementAt(0).getId()+1, clientes.ElementAt(0)));
                // Locando filme para o cliente
                //Repositories.RepositorioGeral.getClientes().ElementAt(0).locacoes.ElementAt(0).adicionarFilme(Repositories.RepositorioGeral.getClientes().filmes.ElementAt(1));
               // Repositories.RepositorioGeral.getClientes().ElementAt(0).locacoes.ElementAt(0).adicionarFilme(filmes.ElementAt(3));

           
        }
    }
}
           
