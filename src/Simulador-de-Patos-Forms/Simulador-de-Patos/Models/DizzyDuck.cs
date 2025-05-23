using Simulador_de_Patos.Interfaces;
using Simulador_de_Patos.Models;

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


        public string quack()
        {
            return "QuaAaAaCK ele grita girando";
        }
        public string spin()
        {
            return "Rodando e dando soco para todo lado";
        }
    }
}
