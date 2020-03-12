using System;
using System.Collections.Generic;
using ModelLocacoes;
using ModelFilmes;
using System.Linq;

namespace ModelClientes
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

        public ClasseCliente(int id, String nome, String dataNascimento, String cpf, int dias){
            ID = id;
            Nome = nome;
            DataNascimento = dataNascimento;
            Cpf = cpf;
            Dias = dias;
            FilmesLocados = 0;
            Repositories.RepositorioGeral.addClientes(this);
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
                    locacao.calculaData();
                    locacao.calcularPrecoFinal();
                        retorno += $"Valor pago R$: {locacao.ValorTotal} \n"+
                                    $"Data Locado: {locacao.DataLocacao} \n"+
                                    $"Data de Devolução: {locacao.DataDevolucao} \n";
                }
                    retorno += $"\nQuantidade de locações realizadas foi: {aux} \n----------------------------------------------------------\n";
            }   
            return retorno;
        }
    }
}
