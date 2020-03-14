using System;
using System.Collections.Generic;
using ModelClientes;
using Repositories;

namespace ControllerClientes{
    public class ControllerCliente{
         public static void addCliente(string nome, string nascimento, string cpf, int dias){
            try{
                new ClasseCliente(RepositorioGeral.getClientes().Count+1, nome, nascimento, cpf, dias);
            }catch(Exception e){
                Console.WriteLine(e);
            }
        }
        public static List<ClasseCliente> getClientes(){
            return RepositorioGeral.getClientes();
        }
    }
}
           