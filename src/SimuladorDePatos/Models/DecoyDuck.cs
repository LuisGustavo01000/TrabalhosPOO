using ProjetoPato.Interfaces;

namespace ProjetoPato.Models
{
    public class DecoyDuck : Duck, IBroken, ISwinable
    {
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


