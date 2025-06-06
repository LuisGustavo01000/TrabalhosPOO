﻿using Simulador_de_Patos.Interfaces;
using Simulador_de_Patos.Models;

namespace ProjetoPato.Models
{
    /* A subclasse RedHeadDuck herda da classe Duck os comportamentos padrões de patos
    E implementa os comportamentos específicos de um pato vermelho */
    public class RedHeadDuck : Duck, IFlyable, IQuackable, ISwimable
    {
        /* Construtor que recebe o id do pato e o tipo de pato
        O tipo de pato é definido como "Pato Vermelho" em todas as instâncias, porém o id pode ser alterado */
        public RedHeadDuck(int id) : base(id, "Pato Vermelho")
        {
            HabilidadesList.Add("Fly");
            HabilidadesList.Add("Quack");
            HabilidadesList.Add("Swim");
        }

        public string fly()
        {
            return "Parece um raio vermelho cortando o céu  ";
        }

        public string quack()
        {
            return "Um quaaaaaack imponente";
        }

        public string swim()
        {
            return "Parece um tambaqui nadando";
        }
    }
}
