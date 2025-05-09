using ProjetoPato.Models;

namespace ProjetoPato.Services
{
    public class Menus
    {
        private GerenciadorDePatos gerenciador;

        public Menus()
        {
            gerenciador = new GerenciadorDePatos();
        }
    
        public void Iniciar()
        {
            int escolha = -1;
            bool escolhaValida = false;

            while (!escolhaValida)
            {
                Console.WriteLine("\nSelecione um Pato:");
                gerenciador.ExibirPatos();
                Console.Write("Digite sua escolha: ");

                string entrada = Console.ReadLine();

                if(int.TryParse (entrada, out escolha) && escolha >= 1 && escolha <= 9)
                {
                    escolhaValida = true;

                    Duck jogador = gerenciador.ObterPatoPorId(escolha);
                    Duck inimigo = gerenciador.ObterPatoAleatorio(escolha);

                    Console.WriteLine($"\nVocê escolheu: {jogador.Tipo}");
                    Console.WriteLine($"Inimigo escolhido: {inimigo.Tipo}");
                }
                else
                {
                    Console.WriteLine("Escolha inválida. Tente novamente.");
                }
            }
        }
    }
}

