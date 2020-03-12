using System;
using ModelFilmes;
using ControllerFilmes;

namespace ViewFilmes{
    public class ViewFilme{
        public static void addTodosFilmes(){
            ControllerFilme.addTodosFilmes();
        }
        public static void addFilme(){
            ControllerFilme.addFilme();
        }
        public static void getFilmes(){
            foreach(ClasseFilme filme in ControllerFilme.getFilmes()){
                Console.WriteLine(filme);
            }
        }
    }
}
           
