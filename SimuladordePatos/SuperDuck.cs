using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladordePatos
{
    public class SuperDuck : Duck, IFlyable, IQuackable, ISwinable
    {
        public SuperDuck(string tipo) : base(tipo)
        {
        }

        public void fly()
        {
            Console.WriteLine("Eu consigo voar muito bem!!!");
        }

        public void quack()
        {
            Console.WriteLine("Eu faço: quack quack, com uma velocidade e força muito boa kkkk");
        }
        public void swin()
        {
            Console.WriteLine("Eu sei nadar, como um tubarão,como um peixe e ainda sou rapido");


        }
    }
}
