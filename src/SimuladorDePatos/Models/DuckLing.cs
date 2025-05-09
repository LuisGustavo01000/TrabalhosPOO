using ProjetoPato.Interfaces;

namespace ProjetoPato.Models
{
    public class DuckLing : Duck, IQuackable, ISwinable
    {
        public DuckLing(int id) : base(id, "Pato Filhote") { }
        public void quack()
        {
            Console.WriteLine("Eu tento fazer: quack quack, mas faço piu piu...");
        }
        public void swin()
        {
            Console.WriteLine("Eu sei nadar, mas ainda estou aprendendo...");
        }
    }
}