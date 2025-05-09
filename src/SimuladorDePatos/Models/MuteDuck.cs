using ProjetoPato.Interfaces;

namespace ProjetoPato.Models
{
    public class MuteDuck : Duck, IFlyable, ISwinable
    {

        public MuteDuck(int id) : base(id, "Pato Mudo") {}

        public void fly()
        {
            Console.WriteLine("Eu consigo voar");
        }
        public void swin()
        {
            Console.WriteLine("Eu sei nadar");
        }
    }
}

