using Simulador_de_Patos.Models;

public class GerenciadorDePatos
{
    private List<Duck> patos;

    public GerenciadorDePatos(List<Duck> patos)
    {
        this.patos = patos;
    }

    public List<Duck> ObterTodosPatos() => patos;

    public Duck ObterPatoPorId(int id) => patos.Find(p => p.Id == id)!;

    public Duck ObterPatoAleatorio(int idJogador)
    {
        Random random = new Random();
        Duck inimigo;
        do
        {
            int randomId = random.Next(1, patos.Count + 1);
            inimigo = ObterPatoPorId(randomId);
        } while (inimigo.Id == idJogador);

        return inimigo;
    }
}
