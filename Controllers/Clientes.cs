using System.Collections.Generic;
using ModelClientes;
using Repositories;

namespace ControllerClientes{
    public class ControllerCliente{
        public static void addTodosClientes(){
            // Criando clientes
            new ClasseCliente(RepositorioGeral.getClientes().Count+1, "Junior Rezende", "15/05/1998", "123.123.123-32", 2);
            new ClasseCliente(RepositorioGeral.getClientes().Count+1, "Tafarel Rezende", "12/07/1988", "143.153.123-32", 1);
            new ClasseCliente(RepositorioGeral.getClientes().Count+1, "Bolivar Artagne", "15/05/1978", "123.131.123-32", 3);
            new ClasseCliente(RepositorioGeral.getClientes().Count+1, "Teste Rezende", "15/06/1998", "123.123.123-32", 4);
            new ClasseCliente(RepositorioGeral.getClientes().Count+1, "Rezende", "15/07/1998", "123.123.123-32", 2);
        }
        public static void addCliente(){
        }
        public static List<ClasseCliente> getClientes(){
            return RepositorioGeral.getClientes();
        }
    }
}
           