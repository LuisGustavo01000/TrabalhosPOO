using ProjetoPato.Models;

namespace ProjetoPato.Services
{
    public class Menus
    {
        private GerenciadorDePatos gerenciador;

        public Menus()
        {
            // Inicializa o gerenciador de patos
            gerenciador = new GerenciadorDePatos();
        }
    
        public void Iniciar()
        {
            int escolha = -1;
            bool escolhaValida = false;
            RuberDuck r = new RuberDuck(33);

            while (!escolhaValida)
            {
                // Exibe o menu de seleção de patos
                Console.WriteLine("\nSelecione um Pato:");
                gerenciador.ExibirPatos();
                Console.Write("Digite sua escolha: ");

                string entrada = Console.ReadLine();

                // Valida a entrada do usuário
                if(int.TryParse (entrada, out escolha) && escolha >= 1 && escolha <= 9)
                {
                    escolhaValida = true;

                    // Obtém o pato escolhido e um pato aleatório como inimigo
                    Duck jogador = gerenciador.ObterPatoPorId(escolha);
                    Duck inimigo = gerenciador.ObterPatoAleatorio(escolha);

                    // Exibe os patos selecionados
                    Console.WriteLine($"\nVocê escolheu: {jogador.Tipo}");
                    Console.WriteLine($"\nInimigo escolhido: {inimigo.Tipo}");
                    Console.WriteLine($"\n🚧  Batalha em construção 🚧\n");
                }
                else
                {
                    // Mensagem de erro para entrada inválida
                    Console.WriteLine("Escolha inválida. Tente novamente.");
                }
            }
        }
    }
}

