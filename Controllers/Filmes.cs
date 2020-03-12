using ModelFilmes;
using Repositories;
using System.Collections.Generic;

namespace ControllerFilmes{
    public class ControllerFilme{
        public static void addTodosFilmes(){
            new ClasseFilme(RepositorioGeral.getFilmes().Count+1, "Jhon, e os quem", "25/10/2018", "Uma História", 2, 3);
            new ClasseFilme(RepositorioGeral.getFilmes().Count+1, "A volta dos que não foram", "23/10/2018", "Uma História linda de amor e superação", 1, 4);
            new ClasseFilme(RepositorioGeral.getFilmes().Count+1, "Tranças do Careca", "24/10/2018", "Uma História", 5, 1);
            new ClasseFilme(RepositorioGeral.getFilmes().Count+1, "Se não fosse o quase", "22/10/2018", "Uma História", 1, 5);
            new ClasseFilme(RepositorioGeral.getFilmes().Count+1, "Teste Alfa", "25/10/2018", "Uma História", 5, 2);
            new ClasseFilme(RepositorioGeral.getFilmes().Count+1, "Teste Beta", "25/10/2018", "Uma História", 2, 5);
            new ClasseFilme(RepositorioGeral.getFilmes().Count+1, "Teste 3 - O retorno do Alfa", "25/10/2018", "Uma História", 2, 4);
            new ClasseFilme(RepositorioGeral.getFilmes().Count+1, "Beta, longe de casa", "01/10/2018", "Uma História", 2, 10);
            new ClasseFilme(RepositorioGeral.getFilmes().Count+1, "O final do inicio", "12/12/2018", "Uma História", 1, 5);
            new ClasseFilme(RepositorioGeral.getFilmes().Count+1, "O paraíso do Tártaro", "10/10/2018", "Uma História", 3, 4);
        }
        public static void addFilme(){

        }
        public static List<ClasseFilme> getFilmes(){
            return Repositories.RepositorioGeral.getFilmes();
        }
    }
}
           
