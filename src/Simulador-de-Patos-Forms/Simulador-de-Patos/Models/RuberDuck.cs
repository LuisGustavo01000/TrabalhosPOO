using Simulador_de_Patos.Interfaces;
using Simulador_de_Patos.Models;

namespace ProjetoPato.Models
{
    /* A subclasse RuberDuck herda da classe Duck os comportamentos padrões de patos
    E implementa os comportamentos específicos de um pato de borracha */
    public class RuberDuck : Duck, IQuackable, ISwimable
    {



        /* Construtor que recebe o id do pato e o tipo de pato
        O tipo de pato é definido como "Pato de Borracha" em todas as instâncias, porém o id pode ser alterado */
        public RuberDuck(int id) : base(id, "Pato de Borracha")
        {
            HabilidadesList.Add("Swim");
            HabilidadesList.Add("Quack");
        }

        public string quack()
        {
            return "Quack quack quack, um som insuportavel";
        }

        public string swim()
        {
            return "Ele boia e como um pato de borracha";
        }
    }
}

