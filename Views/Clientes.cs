using System;
using ControllerClientes;
using ModelClientes;
using System.Collections;
using System.Linq;

namespace ViewClientes{
    public class ViewCliente{
        public static void addTodosClientes(){
            ControllerCliente.addCliente("Junior Rezende", "15/05/1998", "123.123.123-32", 2);
            ControllerCliente.addCliente("Tafarel Rezende", "12/07/1988", "143.153.123-32", 1);
            ControllerCliente.addCliente("Bolivar Artagne", "15/05/1978", "123.131.123-32", 3);
            ControllerCliente.addCliente("Teste Rezende", "15/06/1998", "123.123.123-32", 4);
            ControllerCliente.addCliente("Rezende", "15/07/1998", "123.123.123-32", 2);
        }
        public static void addCliente (){
            string nome, nascimento, cpf;
            int dias;
            try{

                Console.WriteLine("Digite o Nome:");
                nome = Console.ReadLine();
                Console.WriteLine("Digite a data de nascimento: (dd/mm/aaaa):");
                nascimento = Console.ReadLine();
                Console.WriteLine("Descreva o CPF: (999.999.999-99)");
                cpf = Console.ReadLine();
                Console.WriteLine("Digite a quantidade de dias para devolução:");
                dias = Convert.ToInt32(Console.ReadLine());
                ControllerCliente.addCliente(nome, nascimento, cpf, dias);
            }catch(Exception e){
                Console.WriteLine(e);
            }
            
        }
        public static void getClientes(){
            IEnumerable funcQuery = from clientes in ControllerCliente.getClientes() select clientes;
             foreach (ClasseCliente cliente in funcQuery) {
                Console.Write(cliente);
            }
        }
    }
}
           