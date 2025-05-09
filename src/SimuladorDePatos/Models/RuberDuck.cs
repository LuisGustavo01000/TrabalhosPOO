using ProjetoPato.Interfaces;

namespace ProjetoPato.Models
{
    /* A subclasse RuberDuck herda da classe Duck os comportamentos padrões de patos
    E implementa os comportamentos específicos de um pato de borracha */
    public class RuberDuck : Duck, IQuackable, ISwinable
    {
        /* Construtor que recebe o id do pato e o tipo de pato
        O tipo de pato é definido como "Pato de Borracha" em todas as instâncias, porém o id pode ser alterado */
        public RuberDuck(int id) : base(id, "Pato de Borracha") { }

        public void quack()
        {
            Console.WriteLine("Eu faço: quack quack");
        }

        public void swin()
        {
            Console.WriteLine("Eu boio na água");
        }
    }
}

