using Simulador_de_Patos.Models;
using System.Text;
using System.Collections.Generic;

public class Battle
{
    private static readonly Dictionary<string, int> ForcaHabilidades = new()
    {
        ["Fly"] = 4,
        ["Swim"] = 3,
        ["Quack"] = 2,
        ["Spin"] = 1,
        ["Breaking"] = 5
    };

    public string ObterHabilidadeAleatoria(Duck pato)
    {
        if (pato.HabilidadesList == null || pato.HabilidadesList.Count == 0)
            return string.Empty;

        Random random = new Random();
        int index = random.Next(pato.HabilidadesList.Count);
        return pato.HabilidadesList[index];
    }

    public string CompararHabilidades(Duck patoJogador, Duck patoInimigo, string habJogador, string habInimigo)
    {
        StringBuilder resultado = new StringBuilder();

        resultado.AppendLine($"Jogador: {patoJogador.Tipo} - Habilidade: {habJogador}");
        resultado.AppendLine($"Inimigo: {patoInimigo.Tipo} - Habilidade: {habInimigo}");

        int forcaJogador = ForcaHabilidades.TryGetValue(habJogador, out int fj) ? fj : 0;
        int forcaInimigo = ForcaHabilidades.TryGetValue(habInimigo, out int fi) ? fi : 0;

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
