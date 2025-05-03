using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladordePatos
{
    public class DecoyDuck : Duck, IBroken
    {
        public DecoyDuck(string tipo) : base(tipo) {}

        public void breaking()
        {
            Console.WriteLine("Ops! Você me derrubou e eu quebrei, sou só um pato de madeira.");
        }
    }
}

