using System;
using Repositories;

namespace Models
{
    public class ClasseFilme
    {
        // Criando os atributos com o gets e sets
        public int ID { get; set; }
        public String Nome { get; set; }
        public String DataLancamento { get; set; }
        public String Sinopse { get; set; }
        public double Valor { get; set; }
        public int EstoqueTotal { get; set; }
        public int EstoqueAtual { get; set; }
        public int Locado { get; set; }

        // Construtor da classe
        public ClasseFilme(String nome, String dataLancamento, String sinopse, double valor, int estoqueTotal){
            ID = RepositorioGeral.GetUltimoIdFilme()+1;
            Nome = nome;
            DataLancamento = dataLancamento;
            Sinopse = sinopse;
            Valor = valor;
            EstoqueTotal = estoqueTotal;
            EstoqueAtual = estoqueTotal;
            Locado = 0;
            Repositories.RepositorioGeral.AddFilmes(this);
        }
        // Metodo para dizer que o filme foi locado e contabilizar
        public override string ToString(){
            return  $"Nome: {Nome} \n"+
                    $"Data Lançamento:  {DataLancamento} \n"+
                    $"Sinope: {Sinopse} \n"+
                    $"Valor: R$  {Valor} \nEstoque Atual:  {EstoqueAtual}\n"+
                    $"Quantidade de locações feitas: {Locado}\n";
        }  
    }
}
