using System;
using System.Collections.Generic;
using Controllers;
using Repositories;

namespace Models
{
    public class ClasseLocacao
    {
        // Criando atributos e seus getters e setters
        public DateTime Data = DateTime.Today;
        public int ID { get; set; }
        public ClasseCliente Cliente { get; set; }
        public String DataLocacao { get; set; }
        public double ValorTotal { get; set; }
        public List<ClasseFilme> Filmes = new List<ClasseFilme>();

        // Criando contrutor
        public ClasseLocacao(ClasseCliente cliente){
            ID = RepositorioGeral.GetUltimoIdLocacao()+1;
            Cliente = cliente;
            DataLocacao = Data.ToString().Substring(0,10);
            Repositories.RepositorioGeral.AddLocacoes(this);
        }
        //Criando demais funções
            //Adicionar filme
            public void AdicionarFilme(ClasseFilme filme){
                Filmes.Add(filme);
                ControllerFilme.FilmeLocado(filme);
                Cliente.FilmesLocados+=1;
            }
            public override string ToString(){
                return  $"Id Locação: {ID}\n"+
                        $"Valor pago R$: {ControllerLocacao.CalcularPrecoFinal(this)} \n"+
                        $"Data Locado: {DataLocacao} \n"+
                        $"Data de Devolução: {ControllerLocacao.CalculaData(this)} \n";
            }
    }
}
