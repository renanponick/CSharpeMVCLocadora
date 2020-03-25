using System;
using System.Collections.Generic;
using Repositories;

namespace Models
{
    public class ClasseCliente
    {
        public int ID { get; set; }
        public String Nome { get; set; }
        public String DataNascimento { get; set; }
        public String Cpf { get; set; }
        public int Dias { get; set; }
        public int FilmesLocados { get; set; }
        public List<ClasseLocacao> Locacoes = new List<ClasseLocacao>();

        public ClasseCliente(String nome, String dataNascimento, String cpf, int dias){
            ID = RepositorioGeral.GetUltimoIdCliente()+1;
            Nome = nome;
            DataNascimento = dataNascimento;
            Cpf = cpf;
            Dias = dias;
            FilmesLocados = 0;
            Repositories.RepositorioGeral.AddClientes(this);
        }
        public override string ToString(){
             String retorno = $"Id: {ID}\n"+
                                $"Nome: {Nome}\n"+
                                $"Nascido em: {DataNascimento}\n"+
                                $"Cpf : {Cpf}\n"+
                                $"Dias para devolução: {Dias}\n"+
                                $"Qtde Filmes Locados: {FilmesLocados}\n";
                           
            if(Locacoes.Count>0){
                int aux = 0 ;
                foreach(ClasseLocacao locacao in Locacoes){
                    aux ++;
                        retorno += $" ----------- Locação - {aux} -------------\n";
                    foreach(ClasseFilme filme in locacao.Filmes){
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
