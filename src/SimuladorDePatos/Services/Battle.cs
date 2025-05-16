using ProjetoPato.Models;

namespace ProjetoPato.Services
{
    public static class Battle
    {
        public static void CompararHabilidades(Duck patoJogador, Duck patoInimigo, string habJogador, string habInimigo)
        {
            if (habJogador == habInimigo)
                Console.WriteLine($"{patoJogador} e {patoInimigo} fazem a mesma ação e ficam confusos. Empate!");

            else if ((habJogador == "Fly" && habInimigo == "Swim") ||
                (habJogador == "Swim" && habInimigo == "Quack") ||
                (habJogador == "Quack" && habInimigo == "Spin") ||
                (habJogador == "Spin" && habInimigo == "Breaking") ||
                (habJogador == "Breaking" && habInimigo == "Fly")
            )
                Console.WriteLine($"\n {patoJogador.Tipo} usou {habJogador} e amassou o {patoInimigo.Tipo} Voce ganhou ");
            else
            {
                Console.WriteLine($"\n{patoInimigo.Tipo} derrotou seu pato... Voce é muito ruim");
            }
        }

    }
}
