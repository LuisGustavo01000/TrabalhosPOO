using ProjetoPato.Interfaces;

namespace ProjetoPato.Models
{
    /* A subclasse DecoyDuck herda da classe Duck os comportamentos padrões de patos
    E implementa os comportamentos específicos de um pato de madeira */
    public class DecoyDuck : Duck, IBroken, ISwimable
    {

        /* Construtor que recebe o id do pato e o tipo de pato
        O tipo de pato é definido como "Pato de Madeira" em todas as instacias, porem o id pode ser alterado*/
        public DecoyDuck(int id) : base(id, "Pato de Madeira")
        {
            HabilidadesList.Add("Swim");
            HabilidadesList.Add("Breaking");
        }

        public void breaking()
        {
            Console.WriteLine("Ele endurece suas penas como se fosse de madeira");
        }
        public void swim()
        {
            Console.WriteLine("Ele nada como se fosse um tronco de uma arvore boiando");
        }

    }
}


