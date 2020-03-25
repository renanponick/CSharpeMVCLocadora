using System;
using System.Collections.Generic;
using ModelClientes;
using ModelFilmes;
using ModelLocacoes;

namespace Repositories
{
    public class RepositorioGeral
        {
            static List<ClasseFilme> filmes = new List<ClasseFilme>();
            static List<ClasseCliente> clientes = new List<ClasseCliente>();
            static List<ClasseLocacao> locacoes = new List<ClasseLocacao>();

            public static void addFilmes(ClasseFilme filme){
                filmes.Add(filme);
            }
            public static List<ClasseFilme> getFilmes(){
                return filmes;
            }
             public static void addClientes(ClasseCliente cliente){
                clientes.Add(cliente);
            }
            public static List<ClasseCliente> getClientes(){
                return clientes;
            }
            public static void addLocacoes(ClasseLocacao locacao){
                locacoes.Add(locacao);
            }
            public static List<ClasseLocacao> getLocacoes(){
                return locacoes;
            }
        }
}