using Simulador_de_Patos.Interfaces;
using Simulador_de_Patos.Models;

namespace ProjetoPato.Models
{
    /* A subclasse DuckLing herda da classe Duck os comportamentos padrões de patos
    E implementa os comportamentos específicos de um pato filhote */
    public class DuckLing : Duck, IQuackable, ISwimable
    {
        /* Construtor que recebe o id do pato e o tipo de pato
        O tipo de pato é definido como "Pato Filhote" em todas as instâncias, porém o id pode ser alterado */
        public DuckLing(int id) : base(id, "Pato Filhote")
        {
             HabilidadesList.Add("Swim");
             HabilidadesList.Add("Quack");
        }
        public void quack()
        {
            Console.WriteLine("Um quack com lingua presa igual do patolino");
        }

        public void swim()
        {
            Console.WriteLine("Nada de maneira desengonçada");
        }
    }
}