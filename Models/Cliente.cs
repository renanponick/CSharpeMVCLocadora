using System;
using System.Collections.Generic;
using Repositories;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Collections;

namespace Models
{
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }
        [Required]
        public String Nome { get; set; }
        public String DataNascimento { get; set; }
        [Required]
        public String Cpf { get; set; }
        public int Dias { get; set; }
        public int FilmesLocados { get; set; }

        public Cliente(){}

        public Cliente(String nome, String dataNascimento, String cpf, int dias){
            Nome = nome;
            DataNascimento = dataNascimento;
            Cpf = cpf;
            Dias = dias;
            FilmesLocados = 0;
            Context db = new Context();
            db.Clientes.Add(this);
            db.SaveChanges();
        }
        public static void UpdateClient(int id, String nome, String dataNascimento, String cpf, int dias){
            Context db = new Context();
            try{
                Cliente cliente = GetCliente(id);
                cliente.Nome = nome;
                cliente.DataNascimento = dataNascimento;
                cliente.Cpf = cpf;
                cliente.Dias = dias;
                try{
                    db.SaveChanges();
                }catch(Exception){
                    //InvalidOperationException
                    //ArgumentException
                    throw new Exception("Não alterou");
                }
            }catch{
                throw new Exception("Cliente não encontrado");
            }
        }
        public static void DeleteClient(int id){
            Context db = new Context();
            try{
                Cliente cliente = db.Clientes.First(cliente => cliente.ClienteId == id);
                db.Remove(cliente);
                try{
                    db.SaveChanges();
                }catch{
                    throw new Exception("Tem locações para este cliente");
                }
            }catch{
                throw new Exception("Cliente não encontrado");
            }
        }
        public static List<Cliente> GetClientes(){
            Context db = new Context();
            IEnumerable<Cliente> Clientes = from clientes in db.Clientes select clientes;
            return Clientes.ToList();
        }

        public static Cliente GetCliente(int clienteId){
            Context db = new Context();
            return db.Clientes.Find(clienteId);
        }
        
        public List<Locacao> GetLocacoes(int ClienteId){
            Context db = new Context();
            IEnumerable<Locacao> Locacoes = from Locacao in db.Locacoes
                                            where Locacao.ClienteId == ClienteId
                                            select Locacao;
            return Locacoes.ToList();
        }
        public override string ToString(){
             String retorno = $"Id: {ClienteId}\n"+
                                $"Nome: {Nome}\n"+
                                $"Nascido em: {DataNascimento}\n"+
                                $"Cpf : {Cpf}\n"+
                                $"Dias para devolução: {Dias}\n"+
                                $"Qtde Filmes Locados: {FilmesLocados}\n";

            List<Locacao> Locacoes = GetLocacoes(ClienteId);  
            if(Locacoes.Count>0){
                int aux = 0 ;
                foreach(Locacao locacao in Locacoes){
                    aux ++;
                    retorno += $" ----------- Locação - {aux} -------------\n";
                    retorno += locacao.ToString()+"\n";
                }
                retorno += $"\nQuantidade de locações realizadas foi: {aux} \n----------------------------------------------------------\n";
            }   
            return retorno;
        }
    }
}
