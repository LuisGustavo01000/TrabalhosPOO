using ProjetoPato.Interfaces;

namespace ProjetoPato.Models
{
    /* A subclasse DuckLing herda da classe Duck os comportamentos padrões de patos
    E implementa os comportamentos específicos de um pato filhote */
    public class DuckLing : Duck, IQuackable, ISwinable
    {
        /* Construtor que recebe o id do pato e o tipo de pato
        O tipo de pato é definido como "Pato Filhote" em todas as instâncias, porém o id pode ser alterado */
        public DuckLing(int id) : base(id, "Pato Filhote") { }
        public void quack()
        {
            Console.WriteLine("Eu tento fazer: quack quack, mas faço piu piu...");
        }

        public void swin()
        {
            Console.WriteLine("Eu sei nadar, mas ainda estou aprendendo...");
        }
    }
}