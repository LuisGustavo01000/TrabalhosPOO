using Simulador_de_Patos.Interfaces;
using Simulador_de_Patos.Models;

namespace ProjetoPato.Models
{
    /* A subclasse SuperDuck herda da classe Duck os comportamentos padrões de patos
    E implementa os comportamentos específicos de um super pato */
    public class SuperDuck : Duck, IFlyable, IQuackable, ISwimable
    {

        /* Construtor que recebe o id do pato e o tipo de pato
        O tipo de pato é definido como "Super Pato" em todas as instâncias, porém o id pode ser alterado */
        public SuperDuck(int id) : base(id, "Super Pato")
        {
            HabilidadesList.Add("Fly");
            HabilidadesList.Add("Quack");
            HabilidadesList.Add("Swim");
        }

        public string fly()
        {
            return "Zummmm o pato voa como um super homem";
        }

        public string quack()
        {
            return "Quaaaaaaaaaaaaaaaack um super grito que explode os timpanos";
        }

        public string swim()
        {
            return "Uma nadada na velocidade da luz";
        }
    }
}

