using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladordePatos
{
    public class MuteDuck : Duck, IFlyable, ISwinable
    {

        public MuteDuck(string tipo) : base(tipo) {
        
        }

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
