using System;

namespace TryCatch.Ex04
{
    
    public class ExcecaoAcimaDeCem : Exception
    {
        public ExcecaoAcimaDeCem(string mensagem) : base(mensagem)
        {
        }
    }

    public static class Ex04
    {
        public static void Executar()
        {
            double soma = 0;
            int contador = 0;

            Console.WriteLine("Digite números para somar (a soma deve ser até 100):");



            while (true)
            {
                try
                {
                    Console.Write("Digite um número: ");
                    string entrada = Console.ReadLine();
                    double numero = double.Parse(entrada);

                    VerificarSoma(soma, numero); 

                    soma += numero;
                    contador++;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Erro: Entrada inválida! Digite um número válido.\n");
                }
                catch (ExcecaoAcimaDeCem e)
                {
                    Console.WriteLine($"\n{e.Message}");
                    break;
                }
            }

            if (contador > 0)
            {
                double media = soma / contador;
                Console.WriteLine($"\nSoma total antes de ultrapassar 100: {soma}");
                Console.WriteLine($"Quantidade de números somados: {contador}");
                Console.WriteLine($"Média: {media:F2}");
            }
            else
            {
                Console.WriteLine("Nenhum número válido foi somado.");
            }
        }

       
       
       
    }
}
