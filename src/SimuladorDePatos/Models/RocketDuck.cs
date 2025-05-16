using ProjetoPato.Interfaces;

namespace ProjetoPato.Models
{
    /* A subclasse RocketDuck herda da classe Duck os comportamentos padrões de patos
    E implementa os comportamentos específicos de um pato foguete */
    public class RocketDuck : Duck, IFlyable
    {
        /* Construtor que recebe o id do pato e o tipo de pato
        O tipo de pato é definido como "Pato Foguete" em todas as instâncias, porém o id pode ser alterado */
        public RocketDuck(int id) : base(id, "Pato Foguete")
        {
            HabilidadesList.Add("1 - Fly");
        }


        public void fly()
        {
            Console.WriteLine("Parece um foguete no céu");
        }
        public void spin()
        {
            Console.WriteLine("Voou tao rapido que ficou tonto");
        }
    }
}

