using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladordePatos
{
    public class RuberDuck : Duck,IQuackable
    {

        public RuberDuck(string tipo) : base(tipo)
        {

        }
        public void quack()
        {
            Console.WriteLine("Eu faço: quack quack");
        }
    }
}
