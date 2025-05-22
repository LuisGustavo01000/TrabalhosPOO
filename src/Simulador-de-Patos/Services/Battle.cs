using System.Text;
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
        public static string CompararHabilidades(Duck patoJogador, Duck patoInimigo, string habJogador, string habInimigo)
        {
            StringBuilder resultado = new StringBuilder();

            resultado.AppendLine($"Jogador: {patoJogador.Tipo} - Habilidade: {habJogador}");
            resultado.AppendLine($"Inimigo: {patoInimigo.Tipo} - Habilidade: {habInimigo}");

            if (habJogador == habInimigo)
            {
                resultado.AppendLine("Resultado: Empate! Ambos ficaram confusos.");
            }
            else if ((habJogador == "Fly" && habInimigo == "Swim") ||
                     (habJogador == "Swim" && habInimigo == "Quack") ||
                     (habJogador == "Quack" && habInimigo == "Spin") ||
                     (habJogador == "Spin" && habInimigo == "Breaking") ||
                     (habJogador == "Breaking" && habInimigo == "Fly"))
            {
                resultado.AppendLine($"Resultado: Vitória do jogador! {patoJogador.Tipo} venceu usando {habJogador}.");
            }
            else
            {
                resultado.AppendLine($"Resultado: Vitória do inimigo! {patoInimigo.Tipo} venceu usando {habInimigo}.");
            }

            resultado.AppendLine(new string('-', 40));

            return resultado.ToString();
        }
    }
}
