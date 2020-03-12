using System;
using ModelLocacoes;
using Repositories;
using System.Linq;

namespace ControllerLocacoes{
    public class ControllerLocacao{
        public static void addLocacoes(){
            if(RepositorioGeral.getClientes().Count > 0){
                //Criar locação para primeiro cliente
                try{
                    RepositorioGeral.getClientes().ElementAt(0).Locacoes.Add(new ClasseLocacao(RepositorioGeral.getClientes().ElementAt(0).ID+=1, RepositorioGeral.getClientes().ElementAt(0)));
                        //Locar filmes na primeira locação para o primeiro cliente
                        RepositorioGeral.getClientes().ElementAt(0).Locacoes.ElementAt(0).adicionarFilme(RepositorioGeral.getFilmes().ElementAt(1));
                        RepositorioGeral.getClientes().ElementAt(0).Locacoes.ElementAt(0).adicionarFilme(RepositorioGeral.getFilmes().ElementAt(3));
                        RepositorioGeral.getClientes().ElementAt(0).Locacoes.ElementAt(0).adicionarFilme(RepositorioGeral.getFilmes().ElementAt(5));
                }catch(Exception e){
                    Console.WriteLine(e);
                }
                try{
                    //Criar locação para Segundo cliente
                    RepositorioGeral.getClientes().ElementAt(1).Locacoes.Add(new ClasseLocacao(RepositorioGeral.getClientes().ElementAt(0).ID+=1, RepositorioGeral.getClientes().ElementAt(1)));
                        //Locar filmes na primeira locação para o primeiro cliente
                        RepositorioGeral.getClientes().ElementAt(1).Locacoes.ElementAt(0).adicionarFilme(RepositorioGeral.getFilmes().ElementAt(0));
                        RepositorioGeral.getClientes().ElementAt(1).Locacoes.ElementAt(0).adicionarFilme(RepositorioGeral.getFilmes().ElementAt(7));
                        RepositorioGeral.getClientes().ElementAt(1).Locacoes.ElementAt(0).adicionarFilme(RepositorioGeral.getFilmes().ElementAt(8));
                }catch(Exception e){
                    Console.WriteLine(e);
                }
                try{    
                    //Criar locação para Terceiro cliente
                    RepositorioGeral.getClientes().ElementAt(2).Locacoes.Add(new ClasseLocacao(RepositorioGeral.getClientes().ElementAt(0).ID+=1, RepositorioGeral.getClientes().ElementAt(2)));
                        //Locar filmes na primeira locação para o primeiro cliente
                        RepositorioGeral.getClientes().ElementAt(2).Locacoes.ElementAt(0).adicionarFilme(RepositorioGeral.getFilmes().ElementAt(1));
                        RepositorioGeral.getClientes().ElementAt(2).Locacoes.ElementAt(0).adicionarFilme(RepositorioGeral.getFilmes().ElementAt(3));
                        RepositorioGeral.getClientes().ElementAt(2).Locacoes.ElementAt(0).adicionarFilme(RepositorioGeral.getFilmes().ElementAt(8));
                    //Criar segunda locação para Terceiro cliente
                    RepositorioGeral.getClientes().ElementAt(2).Locacoes.Add(new ClasseLocacao(RepositorioGeral.getClientes().ElementAt(0).ID+=1, RepositorioGeral.getClientes().ElementAt(2)));
                        //Locar filmes na primeira locação para o primeiro cliente
                        RepositorioGeral.getClientes().ElementAt(2).Locacoes.ElementAt(1).adicionarFilme(RepositorioGeral.getFilmes().ElementAt(6));
                        RepositorioGeral.getClientes().ElementAt(2).Locacoes.ElementAt(1).adicionarFilme(RepositorioGeral.getFilmes().ElementAt(5));
                }catch(Exception e){
                    Console.WriteLine(e);
                }
                try{    
                    //Criar locação para Segundo cliente
                    RepositorioGeral.getClientes().ElementAt(3).Locacoes.Add(new ClasseLocacao(RepositorioGeral.getClientes().ElementAt(0).ID+=1, RepositorioGeral.getClientes().ElementAt(3)));
                        //Locar filmes na primeira locação para o primeiro cliente
                        RepositorioGeral.getClientes().ElementAt(3).Locacoes.ElementAt(0).adicionarFilme(RepositorioGeral.getFilmes().ElementAt(3));
                        RepositorioGeral.getClientes().ElementAt(3).Locacoes.ElementAt(0).adicionarFilme(RepositorioGeral.getFilmes().ElementAt(4));
                        RepositorioGeral.getClientes().ElementAt(3).Locacoes.ElementAt(0).adicionarFilme(RepositorioGeral.getFilmes().ElementAt(9));
                }catch(Exception e){
                    Console.WriteLine(e);
                }
            }           
        }
    }
}
           
