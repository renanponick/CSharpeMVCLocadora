using System;
using System.Collections.Generic;
using Models;

namespace Controllers{
    public class ControllerCliente{
         public static void AddCliente(string nome, string nascimento, string cpf, int dias){
            try{
                new Cliente(nome, nascimento, cpf, dias);
            }catch(Exception e){
                Console.WriteLine(e);
            }
        }
        public static List<Cliente> GetClientes(){
            return Cliente.GetClientes();
        }
        public static Cliente GetCliente(int idCliente){
            return Cliente.GetCliente(idCliente);
        }
    }
}