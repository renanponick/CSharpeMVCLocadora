using System;
using System.Collections.Generic;
using Repositories;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
       // [ForeignKey("Locacao")]
       // [Column(Order = 1)]
        public List<Locacao> Locacoes = new List<Locacao>();

        public Cliente(){}

        public Cliente(String nome, String dataNascimento, String cpf, int dias){
            ClienteId = RepositorioCliente.GetUltimoIdCliente()+1;
            Nome = nome;
            DataNascimento = dataNascimento;
            Cpf = cpf;
            Dias = dias;
            FilmesLocados = 0;
            Context db = new Context();
            db.Clientes.Add(this);
            db.SaveChanges();
            RepositorioCliente.AddClientes(this);
        }

        public void InserirLocacao(Locacao locacao) {
            Locacoes.Add(locacao);
        }

        public static List<Cliente> GetClientes(){
            return RepositorioCliente.GetClientes();
        }

        public static Cliente GetCliente(int ClienteId){
            return RepositorioCliente.GetClientes().Find(cliente => cliente.ClienteId == ClienteId);
        }

        public override string ToString(){
             String retorno = $"Id: {ClienteId}\n"+
                                $"Nome: {Nome}\n"+
                                $"Nascido em: {DataNascimento}\n"+
                                $"Cpf : {Cpf}\n"+
                                $"Dias para devolução: {Dias}\n"+
                                $"Qtde Filmes Locados: {FilmesLocados}\n";
                           
            if(Locacoes.Count>0){
                int aux = 0 ;
                foreach(Locacao locacao in Locacoes){
                    aux ++;
                        retorno += $" ----------- Locação - {aux} -------------\n";
                    foreach(Filme filme in locacao.Filmes){
                            retorno += filme.Nome+"\n";
                    }
                    retorno += locacao.ToString()+"\n";
                }
                retorno += $"\nQuantidade de locações realizadas foi: {aux} \n----------------------------------------------------------\n";
            }   
            return retorno;
        }
    }
}
