using ProjetoPato.Models;
using ProjetoPato.Interfaces;
using System.Collections.Generic;

namespace ProjetoPato.Services
{
    public class GerenciadorDePatos
    {
        // Lista que armazena todos os patos gerenciados
        private List<Duck> patos;

        public GerenciadorDePatos()
        {
            // Inicializa a lista de patos com instâncias de diferentes subclasses de Duck
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
            foreach (var pato in patos)
            {
                Console.WriteLine($" {pato.Id}, {pato.Tipo}");
            }
        }
        // Método que retorna um pato com base no ID fornecido
        public Duck ObterPatoPorId(int id)
        {
            // Busca o primeiro pato na lista cujo ID corresponde ao parâmetro
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