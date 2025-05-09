using ProjetoPato.Models;
using ProjetoPato.Interfaces;
using System.Collections.Generic;

namespace ProjetoPato.Services
{
    public class GerenciadorDePatos
    {
        private List<Duck> patos;

        public GerenciadorDePatos()
        {
            // uma lista com todos os patos ja passando seu id e tipo
            patos = new List<Duck>()
            {
                new MallardDuck (1),
                new MuteDuck (2),
                new RedHeadDuck (3),  
                new RuberDuck (4),
                new RocketDuck (5),
                new SuperDuck (6),
                new DuckLing (7),
                new DizzyDuck (8),
                new DecoyDuck (9)
            };
        }

        // Exibe a lista de patos disponíveis
        public void ExibirPatos()
        {
            Console.WriteLine("Lista de Patos:");
            foreach (var pato in patos)
            {
                Console.WriteLine($"ID: {pato.Id}, Tipo: {pato.Tipo}");
            }
        }

        public Duck ObterPatoPorId(int id)
        {
            return patos.Find(p => p.Id == id);
        }

        // Método para obter um pato aleatório, exceto o pato do jogador
        public Duck ObterPatoAleatorio(int idJogador)
        {
            Random random = new Random();
            Duck inimigo;
            do
            {
                int randomId = random.Next(1, 10);
                inimigo = ObterPatoPorId(randomId);
            } while (inimigo.Id == idJogador);

            return inimigo;
        }

    }
}