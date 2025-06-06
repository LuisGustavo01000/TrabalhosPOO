﻿using ProjetoPato.Interfaces;

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

        
        public void fly()
        {
            Console.WriteLine("Vooa silenciosamente");
        }
        
        public void swim()
        {
            Console.WriteLine("Nada tao imperceptivelmente que parece uma agua viva");
        }
    }
}

