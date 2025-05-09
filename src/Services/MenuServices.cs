public class Menus
{
    public int escolha;

    public void menupersonagens()
    {
        Console.WriteLine("\nSelecione um tipo de Pato:\n" +
            "1 - Pato Normal\n" +
            "2 - Pato Mudo\n" +
            "3 - Pato Vermelho\n" +
            "4 - Pato de Borracha\n" +
            "5 - Pato Foguete\n" +
            "6 - Super Pato\n" +
            "7 - Pato Filhote\n" +
            "8 - Pato Tonto\n" +
            "9 - Pato de Madeira\n");

        Console.Write("Digite a sua escolha: ");
        string entrada = Console.ReadLine();

        if (int.TryParse(entrada, out int escolha))
        {
            menusescolha(escolha);
        }
        else
        {
            Console.WriteLine("Entrada inválida. Digite um número de 1 a 9.");
        }
    }

    public void menusescolha(int escolha)
    {
        switch (escolha)
        {
            case 1:
                Console.WriteLine("\nO seu pato é: Pato Normal");
                break;
            case 2:
                Console.WriteLine("\nO seu pato é: Pato Mudo");
                break;
            case 3:
                Console.WriteLine("\nO seu pato é: Pato Vermelho");
                break;
            case 4:
                Console.WriteLine("\nO seu pato é: Pato de Borracha");
                break;
            case 5:
                Console.WriteLine("\nO seu pato é: Pato Foguete");
                break;
            case 6:
                Console.WriteLine("\nO seu pato é: Super Pato");
                break;
            case 7:
                Console.WriteLine("\nO seu pato é: Pato Filhote");
                break;
            case 8:
                Console.WriteLine("\nO seu pato é: Pato Tonto");
                break;
            case 9:
                Console.WriteLine("\nO seu pato é: Pato de Madeira");
                break;
            default:
                Console.WriteLine("Digitação Incorreta, digite novamente!");
                break;
        }
    }


}
}
