using System.Collections.Generic;
using Models;
using System.Linq;

namespace Repositories
{
    public class RepositorioCliente
        {
            static List<Cliente> Clientes = new List<Cliente>();
             public static void AddClientes(Cliente cliente){
                Clientes.Add(cliente);
            }
            public static List<Cliente> GetClientes(){
                return Clientes;
            }
            public static int GetUltimoIdCliente(){
                int id;
                try{
                    id = (from clientes in Clientes select clientes.ID).Max();
                }catch{
                    id = 0;
                }
                return id;
            }
        }
}