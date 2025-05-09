using ProjetoPato.Interfaces;

namespace ProjetoPato.Models
{
    public class RuberDuck : Duck, IQuackable, ISwinable
    {

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

