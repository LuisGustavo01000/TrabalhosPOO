using ProjetoPato.Interfaces;

namespace ProjetoPato.Models
{
    /* A subclasse DecoyDuck herda da classe Duck os comportamentos padrões de patos
    E implementa os comportamentos específicos de um pato de madeira */
    public class DecoyDuck : Duck, IBroken, ISwinable
    {

        /* Construtor que recebe o id do pato e o tipo de pato
        O tipo de pato é definido como "Pato de Madeira" em todas as instacias, porem o id pode ser alterado*/
        public DecoyDuck(int id) : base(id, "Pato de Madeira") { }

        public void breaking()
        {
            Console.WriteLine("Ops! Você me derrubou e eu quebrei, sou só um pato de madeira.");
        }
        public void swin()
        {
            Console.WriteLine("Eu não nado, sou só um pato de madeira mas boio na água.");
        }
    }
}


