using Simulador_de_Patos.Interfaces;
using Simulador_de_Patos.Models;

namespace ProjetoPato.Models
{
    /* A subclasse RocketDuck herda da classe Duck os comportamentos padrões de patos
    E implementa os comportamentos específicos de um pato foguete */
    public class RocketDuck : Duck, IFlyable
    {
        /* Construtor que recebe o id do pato e o tipo de pato
        O tipo de pato é definido como "Pato Foguete" em todas as instâncias, porém o id pode ser alterado */
        public RocketDuck(int id) : base(id, "Pato Foguete")
        {
            HabilidadesList.Add("Fly");
        }


        public string fly()
        {
            return "Parece um foguete no céu";
        }
        public string spin()
        {
            return "Voou tao rapido que ficou tonto";
        }
    }
}

