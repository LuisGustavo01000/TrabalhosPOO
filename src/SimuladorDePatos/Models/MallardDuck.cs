using ProjetoPato.Interfaces;

namespace ProjetoPato.Models
{
    public class MallardDuck : Duck, IFlyable, IQuackable, ISwinable
    {
        public MallardDuck(string tipo) : base(tipo)
        {
        }

        public void fly()
        {
            Console.WriteLine("Eu consigo voar");
        }
        public void quack()
        {
            Console.WriteLine("Eu faço: quack quack");
        }
        public void swin()
        {
            Console.WriteLine("Eu sei nadar");
        }
    }
}

