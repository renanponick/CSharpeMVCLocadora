using System;
using System.Collections.Generic;
using Models;
using Repositories;

namespace Controllers{
    public class ControllerCliente{
         public static void AddCliente(string nome, string nascimento, string cpf, int dias){
            try{
                new ClasseCliente(nome, nascimento, cpf, dias);
            }catch(Exception e){
                Console.WriteLine(e);
            }
        }
        public static List<ClasseCliente> GetClientes(){
            return RepositorioGeral.GetClientes();
        }
    }
}