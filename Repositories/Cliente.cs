using System.Collections.Generic;
using Models;
using System.Linq;

namespace Repositories
{
    public class RepositorioCliente
        {
            static List<Cliente> Clientes = new List<Cliente>();

            // Adiciona um cliente a lista
            public static void AddClientes(Cliente cliente){
                Clientes.Add(cliente);
            }
            // Retorna todos os clientes da lista
            public static List<Cliente> GetClientes(){
                return Clientes;
            }
            // Retorna o ultimo id cadastrado, se nao tiver nenhum retornará 0
            public static int GetUltimoIdCliente(){
                int id;
                try{
                    id = (from clientes in Clientes select clientes.ClienteId).Max();
                }catch{
                    id = 0;
                }
                return id;
            }
        }
}