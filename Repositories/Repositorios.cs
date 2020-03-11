using System;
using System.Collections.Generic;
using System.Linq;
using Clientes;
using Filmes;
using Locacoes;

namespace Repositories
{
    public class Funcionario
        {
            static List<ClasseFilme> filmes = new List<ClasseFilme>();
            static List<ClasseCliente> clientes = new List<ClasseCliente>();
            //Criando 10 Filmes
            
/*            filmes.Add(new ClasseFilme(filmes.Count+1, 'Jhon, e os quem', "25/10/2018", "Uma História", 2, 3));
            filmes.Add(new ClasseFilme(filmes.Count+1, "A volta dos que não foram", "23/10/2018", "Uma História linda de amor e superação", 1, 4));
            filmes.Add(new ClasseFilme(filmes.Count+1, "Tranças do Careca", "24/10/2018", "Uma História", 5, 1));
            filmes.Add(new ClasseFilme(filmes.Count+1, "Se não fosse o quase", "22/10/2018", "Uma História", 1, 5));
            filmes.Add(new ClasseFilme(filmes.Count+1, "Teste Alfa", "25/10/2018", "Uma História", 5, 2));
            filmes.Add(new ClasseFilme(filmes.Count+1, "Teste Beta", "25/10/2018", "Uma História", 2, 5));
            filmes.Add(new ClasseFilme(filmes.Count+1, "Teste 3 - O retorno do Alfa", "25/10/2018", "Uma História", 2, 4));
            filmes.Add(new ClasseFilme(filmes.Count+1, "Beta, longe de casa", "01/10/2018", "Uma História", 2, 10));
            filmes.Add(new ClasseFilme(filmes.Count+1, "O final do inicio", "12/12/2018", "Uma História", 1, 5));
            filmes.Add(new ClasseFilme(filmes.Count+1, "O paraíso do Tártaro", "10/10/2018", "Uma História", 3, 4));
            
            
            // Criando clientes
            clientes.Add(new ClasseCliente(clientes.Count+1, "Junior Rezende", "15/05/1998", "123.123.123-32", 2));
            clientes.ElementAt(0).locacoes.Add(new ClasseLocacao(clientes.ElementAt(0).getId()+1, clientes.ElementAt(0)));
                // Locando filme para o cliente
                clientes.ElementAt(0).locacoes.ElementAt(0).adicionarFilme(filmes.ElementAt(1));
                clientes.ElementAt(0).locacoes.ElementAt(0).adicionarFilme(filmes.ElementAt(3));
            clientes.ElementAt(0).locacoes.Add(new ClasseLocacao(clientes.ElementAt(0).getId()+1, clientes.ElementAt(0)));
                // Locando filme para o cliente
                clientes.ElementAt(0).locacoes.ElementAt(1).adicionarFilme(filmes.ElementAt(8));
                clientes.ElementAt(0).locacoes.ElementAt(1).adicionarFilme(filmes.ElementAt(9));

            // Criando clientes
            clientes.Add(new ClasseCliente(clientes.Count+1, "Tafarel Rezende", "12/07/1988", "143.153.123-32", 2));
            clientes.ElementAt(1).locacoes.Add(new ClasseLocacao(clientes.ElementAt(1).getId()+1, clientes.ElementAt(1)));
                // Locando filme para o cliente
                clientes.ElementAt(1).locacoes.ElementAt(0).adicionarFilme(filmes.ElementAt(5));
                clientes.ElementAt(1).locacoes.ElementAt(0).adicionarFilme(filmes.ElementAt(4));
            clientes.ElementAt(1).locacoes.Add(new ClasseLocacao(clientes.ElementAt(1).getId()+1, clientes.ElementAt(1)));
                // Locando filme para o cliente
                clientes.ElementAt(1).locacoes.ElementAt(1).adicionarFilme(filmes.ElementAt(6));
                clientes.ElementAt(1).locacoes.ElementAt(1).adicionarFilme(filmes.ElementAt(7));
            clientes.ElementAt(1).locacoes.Add(new ClasseLocacao(clientes.ElementAt(1).getId()+1, clientes.ElementAt(1)));
                // Locando filme para o cliente
                clientes.ElementAt(1).locacoes.ElementAt(2).adicionarFilme(filmes.ElementAt(8));
                clientes.ElementAt(1).locacoes.ElementAt(2).adicionarFilme(filmes.ElementAt(9));

            // Criando clientes
            clientes.Add(new ClasseCliente(clientes.Count+1, "Bolivar Artagne", "15/05/1978", "123.131.123-32", 2));
            clientes.ElementAt(2).locacoes.Add(new ClasseLocacao(clientes.ElementAt(2).getId()+1, clientes.ElementAt(2)));
                // Locando filme para o cliente
                clientes.ElementAt(2).locacoes.ElementAt(0).adicionarFilme(filmes.ElementAt(3));
                clientes.ElementAt(2).locacoes.ElementAt(0).adicionarFilme(filmes.ElementAt(9));
                clientes.ElementAt(2).locacoes.ElementAt(0).adicionarFilme(filmes.ElementAt(1));
                clientes.ElementAt(2).locacoes.ElementAt(0).adicionarFilme(filmes.ElementAt(2));

            // Criando clientes
            clientes.Add(new ClasseCliente(clientes.Count+1, "Junior Rezende", "15/05/1998", "123.123.123-32", 2));
            clientes.ElementAt(3).locacoes.Add(new ClasseLocacao(clientes.ElementAt(3).getId()+1, clientes.ElementAt(3)));
                // Locando filme para o cliente
                clientes.ElementAt(3).locacoes.ElementAt(0).adicionarFilme(filmes.ElementAt(0));

            // Criando clientes
            clientes.Add(new ClasseCliente(clientes.Count+1, "Junior Rezende", "15/05/1998", "123.123.123-32", 2));
            clientes.ElementAt(4).locacoes.Add(new ClasseLocacao(clientes.ElementAt(4).getId()+1, clientes.ElementAt(4)));
                // Locando filme para o cliente
                clientes.ElementAt(4).locacoes.ElementAt(0).adicionarFilme(filmes.ElementAt(5));
                clientes.ElementAt(4).locacoes.ElementAt(0).adicionarFilme(filmes.ElementAt(8));
                clientes.ElementAt(4).locacoes.ElementAt(0).adicionarFilme(filmes.ElementAt(2)); */

        }
}