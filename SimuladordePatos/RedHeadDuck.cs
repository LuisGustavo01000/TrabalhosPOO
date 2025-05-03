using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladordePatos
{
    public class RedHeadDuck : Duck, IFlyable, IQuackable, ISwinable

    {

        public RedHeadDuck(string tipo) : base(tipo) 
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
