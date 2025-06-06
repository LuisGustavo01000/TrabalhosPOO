using Simulador_de_Patos.Models;
using Simulador_de_Patos.Interfaces;

namespace Simulador_de_Patos.Services
{
    public class Menus
    {
        private GerenciadorDePatos gerenciador;
        private Duck jogador;
        private Duck inimigo;

        public Menus()
        {
            // Inicializa a lista de patos
            var patos = new List<Duck>
            {
                DuckFactory.CriarPato("Pato Selvagem", 1),
                DuckFactory.CriarPato("Pato Mudo", 2),
                DuckFactory.CriarPato("Pato Vermelho", 3),
                DuckFactory.CriarPato("Pato de Borracha", 4),
                DuckFactory.CriarPato("Pato Foguete", 5),
                DuckFactory.CriarPato("Super Pato", 6),
                DuckFactory.CriarPato("Pato Filhote", 7),
                DuckFactory.CriarPato("Pato Tonto", 8),
                DuckFactory.CriarPato("Pato de Madeira", 9)
            };

            gerenciador = new GerenciadorDePatos(patos);
        }

        public void IniciarMenu()
        {
            int escolha = -1;
            bool escolhaValida = false;

            while (!escolhaValida)
            {
                Console.WriteLine("\nSelecione um Pato:");
                foreach (var pato in gerenciador.ObterTodosPatos())
                {
                    Console.WriteLine($"{pato.Id} - {pato.Tipo}");
                }
                Console.Write("Digite sua escolha: ");

                string entrada = Console.ReadLine()!;

                if (int.TryParse(entrada, out escolha) && escolha >= 1 && escolha <= 9)
                {
                    bool confirmar = false;

                    jogador = gerenciador.ObterPatoPorId(escolha);
                    inimigo = gerenciador.ObterPatoAleatorio(escolha);

                    Console.WriteLine($"\nVocê escolheu: {jogador.Tipo}");
                    Console.WriteLine("\nCaracterísticas do pato escolhido:");
                    jogador.Habilidades();

                    while (!confirmar)
                    {
                        Console.WriteLine($"\nDeseja confirmar sua escolha? 1 - Sim (Iniciará a batalha), 2 - Não (Voltar ao menu de seleção): ");
                        string entradaConfirmacao = Console.ReadLine()!;

                        if (entradaConfirmacao == "1")
                        {
                            Console.Clear();
                            confirmar = true;
                            escolhaValida = true;
                            Console.WriteLine($"\nInimigo escolhido: {inimigo.Tipo}");
                            Console.WriteLine("\nCaracterísticas do pato inimigo:");
                            inimigo.Habilidades();
                        }
                        else if (entradaConfirmacao == "2")
                        {
                            Console.Clear();
                            Console.WriteLine("\nEscolha um pato novamente.");
                            confirmar = true;
                        }
                        else
                        {
                            Console.WriteLine("\nEscolha inválida. Tente novamente.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("\nEscolha inválida. Tente novamente.");
                }
            }
        }

        private void ExecutarHabilidade(Duck pato, string habilidade)
        {
            if (habilidade == "Fly" && pato is IFlyable flyable)
            {
                flyable.fly();
            }
            else if (habilidade == "Quack" && pato is IQuackable quackable)
            {
                quackable.quack();
            }
            else if (habilidade == "Swim" && pato is ISwimable swimable)
            {
                swimable.swim();
            }
            else if (habilidade == "Breaking" && pato is IBroken broken)
            {
                broken.breaking();
            }
            else if (habilidade == "Spin" && pato is IDizzy spinable)
            {
                spinable.spin();
            }
        }

        public void BattleMenu()
        {
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("\nIniciando a batalha...");
            Console.WriteLine($"\nJogador: {jogador.Tipo}  vs  Inimigo: {inimigo.Tipo}");
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            // Habilidade do inimigo
            Random random = new Random();
            int habInimigo = random.Next(0, inimigo.HabilidadesList.Count);
            string habInimigoStr = inimigo.HabilidadesList[habInimigo];

            Console.WriteLine("\nBatalha iniciada!");
            Console.WriteLine($"\nO inimigo usou a habilidade: {habInimigoStr}\n");
            ExecutarHabilidade(inimigo, habInimigoStr);
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();

            // Habilidade do jogador
            Console.WriteLine($"\nSelecione uma habilidade para atacar o inimigo:");
            for (int i = 0; i < jogador.HabilidadesList.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {jogador.HabilidadesList[i]}");
            }
            Console.Write("Digite sua escolha: ");
            int entrada;
            string habJogador = "";

            if (int.TryParse(Console.ReadLine(), out entrada) && entrada >= 1 && entrada <= jogador.HabilidadesList.Count)
            {
                habJogador = jogador.HabilidadesList[entrada - 1];
                Console.WriteLine($"\nVocê usou a habilidade: {habJogador}\n");
                ExecutarHabilidade(jogador, habJogador);
            }
            else
            {
                Console.WriteLine("\nEscolha inválida. Tente novamente.");
            }

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();


            var battle = new Battle();
            string resultado = battle.CompararHabilidades(jogador, inimigo, habJogador, habInimigoStr);
            Console.WriteLine(resultado);

        }
    }
}
