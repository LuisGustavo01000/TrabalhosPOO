using ProjetoPato.Interfaces;

namespace ProjetoPato.Models
{
    /* A subclasse DizzyDuck herda da classe Duck os comportamentos padrões de patos
    E implementa os comportamentos específicos de um pato tonto */
    public class DizzyDuck : Duck, IQuackable, IDizzy
    {
        /* Construtor que recebe o id do pato e o tipo de pato
        O tipo de pato é definido como "Pato Tonto" em todas as instâncias, porém o id pode ser alterado */
        public DizzyDuck(int id) : base(id, "Pato Tonto")
        {
             HabilidadesList.Add("Quack");
             HabilidadesList.Add("Spin");
        }


        public void quack()
        {
            Console.WriteLine("Eu faço: quack... e fico tonto!");
        }
        public void spin()
        {
            Console.WriteLine("Estou girando! Estou tonto!");
        }
    }
}
