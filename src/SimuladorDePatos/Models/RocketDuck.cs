using ProjetoPato.Interfaces;

namespace ProjetoPato.Models
{
    public class RocketDuck : Duck, IFlyable
    {
        public RocketDuck(int id) : base(id, "Pato Foguete") { }
        public void fly()
        {
            Console.WriteLine("Eu voo na velocidade da Luz e sou muito rapido kkkkk");
        }
    }
}

