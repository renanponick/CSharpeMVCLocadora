using System;
using Models;
using Controllers;
using System.Collections;
using System.Linq;

namespace ViewClientes{
    public class ViewCliente{
        // Adiciona todos os clientes - Ok
        public static void AddTodosClientes(){
            ControllerCliente.AddCliente("Junior Rezende", "15/05/1998", "123.123.123-32", 2);
            ControllerCliente.AddCliente("Tafarel Rezende", "12/07/1988", "143.153.123-32", 1);
            ControllerCliente.AddCliente("Bolivar Artagne", "15/05/1978", "123.131.123-32", 3);
            ControllerCliente.AddCliente("Teste Rezende", "15/06/1998", "123.123.123-32", 4);
            ControllerCliente.AddCliente("Rezende", "15/07/1998", "123.123.123-32", 2);
        }
         // Adiciona Um cliente - 
        public static void AddCliente (){
            try{
                Console.WriteLine("Digite o Nome:");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite a data de nascimento: (dd/mm/aaaa):");
                string nascimento = Console.ReadLine();
                Console.WriteLine("Descreva o CPF: (999.999.999-99)");
                string cpf = Console.ReadLine();
                Console.WriteLine("Digite a quantidade de dias para devolução:");
                int dias = Convert.ToInt32(Console.ReadLine());
                ControllerCliente.AddCliente(nome, nascimento, cpf, dias);
            }catch(Exception e){
                Console.WriteLine(e);
            }
        }

         // Pega todos os clientes para mostrar em tela - Ok
        public static void GetClientes(){
            IEnumerable funcQuery = from clientes in ControllerCliente.GetClientes() select clientes;
             foreach (Cliente cliente in funcQuery) {
                Console.Write(cliente);
            }
        }
        // Pega um cliente especificoo pelo ID - ok
        public static void GetCliente(){
            try{
                Console.WriteLine("Digite o id do cliente:");
                int idCliente = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(ControllerCliente.GetCliente(idCliente));
            }catch(Exception){
                Console.WriteLine("Cliente não encontrado");
            }
        }
    }
}
           