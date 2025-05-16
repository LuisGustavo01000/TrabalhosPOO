using ProjetoPato.Interfaces;

namespace ProjetoPato.Models
{
    /* A subclasse MallardDuck herda da classe Duck os comportamentos padrões de patos
    E implementa os comportamentos específicos de um pato normal */
    public class MallardDuck : Duck, IFlyable, IQuackable, ISwimable
    {


        /* Construtor que recebe o id do pato e o tipo de pato
        O tipo de pato é definido como "Pato Normal" em todas as instâncias, porém o id pode ser alterado */
        public MallardDuck(int id) : base(id, "Pato Selvagem")
        {
            HabilidadesList.Add("Swim");
            HabilidadesList.Add("Fly");
            HabilidadesList.Add("Quack");
        }

        public void fly()
        {
            Console.WriteLine("Voa de uma maneira estranha mas muito rapida");
        }
        
        public void quack()
        {
            Console.WriteLine("Um quaaaaack que voce escuta ao adentrar uma floresta");
        }
       
        public void swim()
        {
            Console.WriteLine("Nada sem rumo mas muito rapido");
        }
    }
}

