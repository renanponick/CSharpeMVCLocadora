using System;
using ControllerClientes;
using ModelClientes;

namespace ViewClientes{
    public class ViewCliente{
        public static void addTodosClientes(){
           ControllerCliente.addTodosClientes();
        }
        public static void addCliente(){
           ControllerCliente.addCliente();
        }
        public static void getClientes(){
            foreach(ClasseCliente cliente in ControllerCliente.getClientes()){
                Console.WriteLine(cliente);
            }
        }
    }
}
           