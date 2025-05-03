using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladordePatos
{
    public class RocketDuck : Duck, IFlyable
    {
        public RocketDuck(string tipo) : base(tipo) {
        
        }

        public void fly()
        {
            Console.WriteLine("Eu voo na velocidade da Luz e sou muito rapido kkkkk");
        }
    }
}
