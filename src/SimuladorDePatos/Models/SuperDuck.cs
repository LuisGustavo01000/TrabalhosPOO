using ProjetoPato.Interfaces;

namespace ProjetoPato.Models
{
    /* A subclasse SuperDuck herda da classe Duck os comportamentos padrões de patos
    E implementa os comportamentos específicos de um super pato */
    public class SuperDuck : Duck, IFlyable, IQuackable, ISwinable
    {
        /* Construtor que recebe o id do pato e o tipo de pato
        O tipo de pato é definido como "Super Pato" em todas as instâncias, porém o id pode ser alterado */
        public SuperDuck(int id) : base(id, "Super Pato") { }

        public void fly()
        {
            Console.WriteLine("Eu consigo voar muito bem!!!");
        }

        public void quack()
        {
            Console.WriteLine("Eu faço: quack quack, com uma velocidade e força muito boa kkkk");
        }

        public void swin()
        {
            Console.WriteLine("Eu sei nadar, como um tubarão, como um peixe e ainda sou rápido");
        }
    }
}

