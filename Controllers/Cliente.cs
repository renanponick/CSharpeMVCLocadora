using System;
using System.Collections.Generic;
using Models;

namespace Controllers{
    public class ControllerCliente{
        // Adiciona um cliente ao banco
         public static void AddCliente(string nome, string nascimento, string cpf, int dias){
            try{
                new Cliente(nome, nascimento, cpf, dias);
            }catch(Exception e){
                Console.WriteLine(e);
            }
        }

        //Retorna a lista com todos os clientes
        public static List<Cliente> GetClientes(){
            return Cliente.GetClientes();
        }

        //Retorna um cliente especifico buscado pelo ID
        public static Cliente GetCliente(int idCliente){
            return Cliente.GetCliente(idCliente);
        }

        //fazer um metodo para -> GetCliente().FilmesLocados+=1;
    }
}