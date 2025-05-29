using System;

namespace TryCatch.Ex02
{
    public static class Ex02
    {
        public static void Executar()
        {
            try
            {
                Console.Write("Digite o primeiro número: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                double num2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Escolha a operação (+, -, *, /, %): ");
                string operacao = Console.ReadLine();

                double resultado = 0;

                switch (operacao)
                {
                    case "+":
                        resultado = num1 + num2;
                        break;
                    case "-":
                        resultado = num1 - num2;
                        break;
                    case "*":
                        resultado = num1 * num2;
                        break;
                    case "/":
                        if (num2 == 0)
                            throw new DivideByZeroException("Divisão por zero não é permitida.");
                        resultado = num1 / num2;
                        break;
                    case "%":
                        if (num2 == 0)
                            throw new DivideByZeroException("Módulo por zero não é permitido.");
                        resultado = num1 % num2;
                        break;
                    default:
                        Console.WriteLine("Operação inválida.");
                        return;
                }

                Console.WriteLine($"Resultado: {resultado}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: Você deve digitar um número válido.");
            }
            catch (DivideByZeroException divisao)
            {
                Console.WriteLine($"Erro: {divisao.Message}");
            }
            catch (Exception geral)
            {
                Console.WriteLine($"Erro inesperado: {geral.Message}");
            }
        }
    }
}
