using Simulador_de_Patos.Models;
using System.Text;

public static class Battle 
{
    private static readonly Dictionary<string, int> ForcaHabilidades = new()
    {
        ["Fly"] = 4,
        ["Swim"] = 3,
        ["Quack"] = 2,
        ["Spin"] = 1,
        ["Breaking"] = 5
    };

    public static string ObterHabilidadeAleatoria(Duck pato)
    {
        Random random = new Random();
        int index = random.Next(pato.HabilidadesList.Count);
        return pato.HabilidadesList[index];
    }

    public static string CompararHabilidades(Duck patoJogador, Duck patoInimigo, string habJogador, string habInimigo)
    {
        StringBuilder resultado = new StringBuilder();

        resultado.AppendLine($"Jogador: {patoJogador.Tipo} - Habilidade: {habJogador}");
        resultado.AppendLine($"Inimigo: {patoInimigo.Tipo} - Habilidade: {habInimigo}");

        int forcaJogador = ForcaHabilidades.ContainsKey(habJogador) ? ForcaHabilidades[habJogador] : 0;
        int forcaInimigo = ForcaHabilidades.ContainsKey(habInimigo) ? ForcaHabilidades[habInimigo] : 0;

        if (forcaJogador == forcaInimigo)
        {
            resultado.AppendLine("Resultado: Empate! Ambos se equivalem.");
        }
        else if (forcaJogador > forcaInimigo)
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
