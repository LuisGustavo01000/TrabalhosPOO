using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladordePatos
{
    public abstract class Duck
    {
        protected string Tipo { get; set; }


        protected Duck(string tipo) 
        { 
        
        this.Tipo = tipo;
        
        }
        public void display()
        {
            Console.WriteLine($"\nO meu tipo de pato e: {Tipo}");
        }
    }
}
