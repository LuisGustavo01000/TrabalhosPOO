using System;


namespace TryCatch.Ex03
{
          public static class Ex03
        {
            public static void Executar()
            {
                int[] vetor = new int[10];

                for (int i = 0; i < vetor.Length; i++)
                {
                    try
                    {
                        Console.Write("Digite um número inteiro: ");
                        int valor = int.Parse(Console.ReadLine());

                        Console.Write("Digite a posição (de 0 a 9) para inserir o valor na posição do vetor: ");
                        int posicao = int.Parse(Console.ReadLine());

                        vetor[posicao] = valor;
                        Console.WriteLine($"Valor {valor} inserido na posição {posicao}.\n");
                    }
                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine("Erro: Posição inválida! O vetor vai de 0 a 9.\n");
                        i--;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Erro: Valor ou posição inválida! Digite apenas números inteiros.\n");
                        i--;
                    }
                }

                Console.WriteLine("\n Conteúdo final do vetor:");
                for (int i = 0; i < vetor.Length; i++)
                {
                    Console.WriteLine($"Posição [{i}] : {vetor[i]}");
                }
            }

        
    }
}