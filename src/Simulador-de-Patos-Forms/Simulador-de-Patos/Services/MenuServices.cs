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
            // Inicializa o gerenciador de patos
            gerenciador = new GerenciadorDePatos();
        }

        public void IniciarMenu()
        {
            int escolha = -1;
            bool escolhaValida = false;

            while (!escolhaValida)
            {
                // Exibe o menu de seleção de patos
                Console.WriteLine("\nSelecione um Pato:");
                Console.Write("Digite sua escolha: ");

                string entrada = Console.ReadLine()!;

                // Valida a entrada do usuário
                if (int.TryParse(entrada, out escolha) && escolha >= 1 && escolha <= 9)
                {

                    bool confirmar = false;

                    // Obtém o pato escolhido e um pato aleatório como inimigo
                    jogador = gerenciador.ObterPatoPorId(escolha);
                    inimigo = gerenciador.ObterPatoAleatorio(escolha);

                    // Exibe os patos selecionados
                    Console.WriteLine($"\nVocê escolheu: {jogador.Tipo}");

                    // exibir as interfaces implementadas pelo pato escolhido
                    Console.WriteLine("\nCaracterísticas do pato escolhido:");
                    jogador.Habilidades();

                    while (!confirmar)
                    {
                        // Pergunta se o usuário deseja confirmar a escolha
                        Console.WriteLine($"\nDeseja confirmar sua escolha? 1 - Sim (Iniciara a batalha), 2 - Não (Voltara ao menu de seleção): ");
                        string entradaConfirmacao = Console.ReadLine()!;

                        // Valida a entrada de confirmação
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
            if(habilidade == "Fly" && pato is Simulador_de_Patos.Interfaces.IFlyable flyable)
            {
                flyable.fly();
            }
            else if (habilidade == "Quack" && pato is Simulador_de_Patos.Interfaces.IQuackable quackable)
            {
                quackable.quack();
            }
            else if (habilidade == "Swim" && pato is Simulador_de_Patos.Interfaces.ISwimable swimable)
            {
                swimable.swim();
            }
            else if (habilidade == "Breaking" && pato is Simulador_de_Patos.Interfaces.IBroken broken)
            {
                broken.breaking();
            }
            else if (habilidade == "Spin" && pato is Simulador_de_Patos.Interfaces.IDizzy spinable)
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
            Console.WriteLine($"\nPato escolhido: {jogador.Tipo}");
            Console.WriteLine($"\nPato inimigo: {inimigo.Tipo}");
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            // Gera um numero aleatorio para escolher a habilidade do inimigo
            Random random = new Random();
            int habInimigo = random.Next(0, inimigo.HabilidadesList.Count);
            string habInimigoStr = inimigo.HabilidadesList[habInimigo];

            Console.WriteLine("\nBatalha iniciada!");
            Console.WriteLine($"\nO inimigo usou a habilidade: {habInimigoStr}\n");
            // Executa a habilidade do inimigo chamando o metodo da subclasse pato escolhida e que herda da interface
            ExecutarHabilidade(inimigo, habInimigoStr);
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();

            Console.WriteLine($"\nSelecione uma habilidade para atacar o inimigo:");
            jogador.Habilidades();
            Console.Write("Digite sua escolha: ");
            int entrada = int.Parse(Console.ReadLine()!);

            string habJogador = "";

            if (entrada >= 1 && entrada <= jogador.HabilidadesList.Count)
            {
                habJogador = jogador.HabilidadesList[entrada];
                // Executa a habilidade escolhida pelo jogador pegando sua entrada e olhando na posicao da lista qual é ela
                Console.WriteLine($"\nVocê usou a habilidade: {habJogador}\n");
                // Executa a habilidade do jogador chamando o metodo da subclasse pato escolhida e que herda da interface
                ExecutarHabilidade(jogador, habJogador);
            }
            else
            {
                Console.WriteLine("\nEscolha inválida. Tente novamente.");
            }

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();

            Battle.CompararHabilidades(jogador, inimigo, habJogador ,  habInimigoStr);



        }
    }
}

