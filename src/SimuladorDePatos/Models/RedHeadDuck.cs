using ProjetoPato.Interfaces;

namespace ProjetoPato.Models
{
    /* A subclasse RedHeadDuck herda da classe Duck os comportamentos padrões de patos
    E implementa os comportamentos específicos de um pato vermelho */
    public class RedHeadDuck : Duck, IFlyable, IQuackable, ISwinable
    {
        /* Construtor que recebe o id do pato e o tipo de pato
        O tipo de pato é definido como "Pato Vermelho" em todas as instâncias, porém o id pode ser alterado */
        public RedHeadDuck(int id) : base(id, "Pato Vermelho")
        {
            HabilidadesList.Add("Fly");
            HabilidadesList.Add("Quack");
            HabilidadesList.Add("Swin");
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
