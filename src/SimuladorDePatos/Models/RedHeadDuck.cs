using ProjetoPato.Interfaces;

namespace ProjetoPato.Models
{
    public class RedHeadDuck : Duck, IFlyable, IQuackable, ISwinable
    {

        public RedHeadDuck(int id) : base(id, "Pato Vermelho") { }
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
