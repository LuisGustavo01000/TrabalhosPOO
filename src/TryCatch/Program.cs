using TryCatch.Ex01;
using TryCatch.Ex02;
using TryCatch.Ex03;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Escolha o exercício para rodar:");
                Console.WriteLine("1 - Exercício 1");
                Console.WriteLine("2 - Exercício 2");
                Console.WriteLine("3 - Exercício 3");
                Console.WriteLine("0 - Sair");
                Console.Write("Opção: ");
                string opcao = Console.ReadLine();

                try
                {
                    switch (opcao)
                    {
                        case "1":
                            TryCatch.Ex01.Ex01.Executar();
                            break;
                        case "2":
                            TryCatch.Ex02.Ex02.Executar();
                            break;
                        case "3":
                            TryCatch.Ex03.Ex03.Executar();
                            break;
                        case "0":
                            Console.WriteLine("Saindo...");
                            return;
                        default:
                            Console.WriteLine("Opção inválida. Tente novamente.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"erro: {ex.Message}");
                }
                Console.WriteLine(); 
            }
             
        }
    }
}
