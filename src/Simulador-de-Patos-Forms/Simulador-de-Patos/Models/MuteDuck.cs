﻿using Simulador_de_Patos.Interfaces;
using Simulador_de_Patos.Models;

namespace ProjetoPato.Models
{
    /* A subclasse MuteDuck herda da classe Duck os comportamentos padrões de patos
    E implementa os comportamentos específicos de um pato mudo */
    public class MuteDuck : Duck, IFlyable, ISwimable
    {
        /* Construtor que recebe o id do pato e o tipo de pato
        O tipo de pato é definido como "Pato Mudo" em todas as instâncias, porém o id pode ser alterado */
        public MuteDuck(int id) : base(id, "Pato Mudo")
        {
            HabilidadesList.Add("Swim");
            HabilidadesList.Add("Fly");
        }

        
        public string fly()
        {
            return "Vooa silenciosamente";
        }
        
        public string swim()
        {
            return "Nada tao imperceptivelmente que parece uma agua viva";
        }
    }
}

