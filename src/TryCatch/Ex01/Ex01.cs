namespace TryCatch.Ex01;

public static class Ex01
{
    public static void Executar()
    {
        int numero = LerInteiro();

        if (NumeroPrimo(numero))
        {
            Console.WriteLine($"O número {numero} é primo.");
        }
        else
        {
            Console.WriteLine($"O número {numero} não é primo.");
        }
    }

    public static int LerInteiro()
    {
        while (true)
        {
            Console.WriteLine("Digite um valor para testar se é primo ou não:");
            try
            {
                int n = int.Parse(Console.ReadLine());
                return n;
            }
            catch (FormatException)
            {
                Console.WriteLine("Valor inválido. Por favor, digite um número inteiro.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Número muito grande. Tente novamente.");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Nenhum valor foi digitado. Por favor, tente novamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro inesperado: {ex.Message}");
            }
        }
    }

    public static bool NumeroPrimo(int numero)
    {
        if (numero <= 1)
            throw new ArgumentException("O número deve ser maior que 1.");
        for (int i = 2; i < numero; i++)
        {
            if (numero % i == 0) return false;
        }
        return true;
    }
}