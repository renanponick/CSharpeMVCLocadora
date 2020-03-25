using System;
using ModelLocacoes;
using Repositories;
using System.Linq;
using ModelClientes;
using System.Collections.Generic;

namespace ControllerLocacoes{
    public class ControllerLocacao{
        public static void addLocacoes(){
    //Para agilizar o processo fiz o cadastro automatico dentro dos controllers, porém, será separado um cadastro indivicual de forma que o view passe parametros para o controller como o recomendado.
            if(RepositorioGeral.getClientes().Count > 0){
                //Criar locação para primeiro cliente
                try{
                    RepositorioGeral.getClientes().ElementAt(0).Locacoes.Add(new ClasseLocacao(RepositorioGeral.getClientes().ElementAt(0).Locacoes.Count+1, RepositorioGeral.getClientes().ElementAt(0)));
                        //Locar filmes na primeira locação para o primeiro cliente
                        RepositorioGeral.getClientes().ElementAt(0).Locacoes.ElementAt(0).adicionarFilme(RepositorioGeral.getFilmes().ElementAt(1));
                        RepositorioGeral.getClientes().ElementAt(0).Locacoes.ElementAt(0).adicionarFilme(RepositorioGeral.getFilmes().ElementAt(3));
                        RepositorioGeral.getClientes().ElementAt(0).Locacoes.ElementAt(0).adicionarFilme(RepositorioGeral.getFilmes().ElementAt(5));
                }catch(Exception e){
                    Console.WriteLine(e);
                }
                try{
                    //Criar locação para Segundo cliente
                    RepositorioGeral.getClientes().ElementAt(1).Locacoes.Add(new ClasseLocacao(RepositorioGeral.getClientes().ElementAt(1).Locacoes.Count+1, RepositorioGeral.getClientes().ElementAt(1)));
                        //Locar filmes na primeira locação para o primeiro cliente
                        RepositorioGeral.getClientes().ElementAt(1).Locacoes.ElementAt(0).adicionarFilme(RepositorioGeral.getFilmes().ElementAt(0));
                        RepositorioGeral.getClientes().ElementAt(1).Locacoes.ElementAt(0).adicionarFilme(RepositorioGeral.getFilmes().ElementAt(7));
                        RepositorioGeral.getClientes().ElementAt(1).Locacoes.ElementAt(0).adicionarFilme(RepositorioGeral.getFilmes().ElementAt(8));
                }catch(Exception e){
                    Console.WriteLine(e);
                }
                try{    
                    //Criar locação para Terceiro cliente
                    RepositorioGeral.getClientes().ElementAt(2).Locacoes.Add(new ClasseLocacao(RepositorioGeral.getClientes().ElementAt(2).Locacoes.Count+1, RepositorioGeral.getClientes().ElementAt(2)));
                        //Locar filmes na primeira locação para o primeiro cliente
                        RepositorioGeral.getClientes().ElementAt(2).Locacoes.ElementAt(0).adicionarFilme(RepositorioGeral.getFilmes().ElementAt(1));
                        RepositorioGeral.getClientes().ElementAt(2).Locacoes.ElementAt(0).adicionarFilme(RepositorioGeral.getFilmes().ElementAt(3));
                        RepositorioGeral.getClientes().ElementAt(2).Locacoes.ElementAt(0).adicionarFilme(RepositorioGeral.getFilmes().ElementAt(8));
                    //Criar segunda locação para Terceiro cliente
                    RepositorioGeral.getClientes().ElementAt(2).Locacoes.Add(new ClasseLocacao(RepositorioGeral.getClientes().ElementAt(2).Locacoes.Count+1, RepositorioGeral.getClientes().ElementAt(2)));
                        //Locar filmes na primeira locação para o primeiro cliente
                        RepositorioGeral.getClientes().ElementAt(2).Locacoes.ElementAt(1).adicionarFilme(RepositorioGeral.getFilmes().ElementAt(6));
                        RepositorioGeral.getClientes().ElementAt(2).Locacoes.ElementAt(1).adicionarFilme(RepositorioGeral.getFilmes().ElementAt(5));
                }catch(Exception e){
                    Console.WriteLine(e);
                }
                try{    
                    //Criar locação para Segundo cliente
                    RepositorioGeral.getClientes().ElementAt(3).Locacoes.Add(new ClasseLocacao(RepositorioGeral.getClientes().ElementAt(3).Locacoes.Count+1, RepositorioGeral.getClientes().ElementAt(3)));
                        //Locar filmes na primeira locação para o primeiro cliente
                        RepositorioGeral.getClientes().ElementAt(3).Locacoes.ElementAt(0).adicionarFilme(RepositorioGeral.getFilmes().ElementAt(3));
                        RepositorioGeral.getClientes().ElementAt(3).Locacoes.ElementAt(0).adicionarFilme(RepositorioGeral.getFilmes().ElementAt(4));
                        RepositorioGeral.getClientes().ElementAt(3).Locacoes.ElementAt(0).adicionarFilme(RepositorioGeral.getFilmes().ElementAt(9));
                }catch(Exception e){
                    Console.WriteLine(e);
                }
            }           
        }
        public static void addFilmeLocacao(int idCliente,int idLocacao,int idFilme){
            if(RepositorioGeral.getClientes().Count>0){
                ClasseCliente cliente =  RepositorioGeral.getClientes().ElementAt(idCliente);
                if(cliente.Locacoes.Count>0){
                    ClasseLocacao locacao = cliente.Locacoes.ElementAt(idLocacao);
                    if(RepositorioGeral.getFilmes().Count>0){
                        locacao.adicionarFilme(RepositorioGeral.getFilmes().ElementAt(idFilme));
                    }
                }
            }
        }
        public static string addLocacao(int idCliente){
            int idLocacao = RepositorioGeral.getClientes().ElementAt(idCliente).Locacoes.Count+1;
            // int idLocacao = RepositorioGeral.getClientes().Find(x => x.ID.Equals(idCliente)).Locacoes.Count+1;
            RepositorioGeral.getClientes().ElementAt(idCliente).Locacoes.Add(new ClasseLocacao(idLocacao, RepositorioGeral.getClientes().ElementAt(idCliente)));
            return $"{idLocacao}/{idCliente}";
        }
        public static List<ClasseLocacao> getLocacoes(){
            return Repositories.RepositorioGeral.getLocacoes();
        }
    }
}
           
