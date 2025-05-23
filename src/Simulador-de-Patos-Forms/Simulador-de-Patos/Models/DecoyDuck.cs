using Simulador_de_Patos.Interfaces;
using Simulador_de_Patos.Models;

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

        public string breaking()
        {
            return "Ele endurece suas penas como se fosse de madeira";
        }
        public string swim()
        {
            return "Ele nada como se fosse um tronco de uma arvore boiando";
        }

    }
}


