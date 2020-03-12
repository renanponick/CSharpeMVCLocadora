using System;

namespace ModelFilmes
{
    public class ClasseFilme
    {
        // Criando os atributos com o gets e sets
        public int ID { get; set; }
        public String Nome { get; set; }
        public String DataLancamento { get; set; }
        public String Sinopse { get; set; }
        public float Valor { get; set; }
        public int EstoqueTotal { get; set; }
        public int EstoqueAtual { get; set; }
        public int Locado { get; set; }

        // Construtor da classe
        public ClasseFilme(int id, String nome, String dataLancamento, String sinopse, float valor, int estoqueTotal){
            ID = id;
            Nome = nome;
            DataLancamento = dataLancamento;
            Sinopse = sinopse;
            Valor = valor;
            EstoqueTotal = estoqueTotal;
            EstoqueAtual = estoqueTotal;
            Locado = 0;
            Repositories.RepositorioGeral.addFilmes(this);
        }
        // Metodo para dizer que o filme foi locado e contabilizar
        public void filmeLocado(){
            EstoqueAtual-=1;
            Locado+=1;
        }
        // Metodo para dizer que o filme foi devolvido e contabilizar
        public void devolverFilme(){
            EstoqueAtual+=1;
            Locado-=1;
        }
        public override string ToString(){
            return $"Nome: {Nome} \n Data Lançamento:  {DataLancamento} \n Sinope: {Sinopse} \n Valor: R$  {Valor} \n Estoque Atual:  {EstoqueAtual}\n " +
                    $"Quantidade de locações feitas: {Locado}\n ";
        }  
    }
}
