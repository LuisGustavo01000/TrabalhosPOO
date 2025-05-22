using Simulador_de_Patos.Models;
using System;
using Simulador_de_Patos.Interfaces;
using System.Collections.Generic;
using ProjetoPato.Models;

namespace Simulador_de_Patos.Services
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
        public List<Duck> ObterTodosPatos()
        {
            return patos;
        }

        // Método que retorna um pato com base no ID fornecido
        public Duck ObterPatoPorId(int id)
        {
            // Busca o primeiro pato na lista cujo ID corresponde ao parâmetro
            Duck patoSelecionado = patos.Find(p => p.Id == id)!;

            return patoSelecionado!;
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