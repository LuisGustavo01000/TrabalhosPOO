using Simulador_de_Patos.Models;
using Simulador_de_Patos.Services;


namespace Simulador_de_Patos.Services
{
    public static class Battle
    {
        // Método para obter uma habilidade aleatória de um pato
        public static string ObterHabilidadeAleatoria(Duck pato)
        {
            Random random = new Random();
            int index = random.Next(pato.HabilidadesList.Count);
            return pato.HabilidadesList[index];
        }

        // Método para comparar habilidades entre dois patos
       public static void CompararHabilidades(Duck patoJogador, Duck patoInimigo, string habJogador, string habInimigo)
{
    Console.WriteLine($"\nBatalha: {patoJogador.Tipo} ({habJogador}) vs {patoInimigo.Tipo} ({habInimigo})");

    if (habJogador == habInimigo)
    {
        Console.WriteLine($"{patoJogador.Tipo} e {patoInimigo.Tipo} fazem a mesma ação e ficam confusos. Empate!");
    }
    else if ((habJogador == "Fly" && habInimigo == "Swim") ||
             (habJogador == "Swim" && habInimigo == "Quack") ||
             (habJogador == "Quack" && habInimigo == "Spin") ||
             (habJogador == "Spin" && habInimigo == "Breaking") ||
             (habJogador == "Breaking" && habInimigo == "Fly"))
    {
        Console.WriteLine($"{patoJogador.Tipo} usou {habJogador} e venceu o {patoInimigo.Tipo}!");
    }
    else
    {
        Console.WriteLine($"{patoInimigo.Tipo} derrotou seu pato... Você perdeu!");
    }
}

    }
}
