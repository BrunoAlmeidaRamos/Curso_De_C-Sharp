using System.ComponentModel.Design;

namespace Aula10;
 public class Program
{
    public static void Main()
    {

        bool continuar = true;

        while(continuar == true)
        {

            Console.WriteLine("=============CALCULADORA SIMPLES===============");

            Console.WriteLine("Digite o primeiro numero: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nEscolha a operacação");
            Console.WriteLine("1 - Adição [+]");
            Console.WriteLine("2 - Subtração [-]");
            Console.WriteLine("3 - Mutplicação [*]");
            Console.WriteLine("4 - Divisão [/]");
            Console.WriteLine("\nQual operação você vai querer?");
            double operacao = Convert.ToDouble(Console.ReadLine());

            double resultado = 0;

            if (operacao == 1)
            {
                resultado = num1 + num2;
            }
            else if (operacao == 2)
            {
                resultado = num1 - num2;
            }
            else if (operacao == 3)
            {
                resultado = num1 * num2;
            }
            else if (operacao == 4)
            {
                if (num2 != 0)
                {
                    resultado = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Divisão por zero não é permitida.");
                }
            }
            else
            {
                Console.WriteLine("Operação inválida, tente novamente!");
            }
            Console.WriteLine($"\nO resultado da operação é: {resultado}\n");

            Console.WriteLine("Desaja continuar a operação? [S/N]");
            string run = Console.ReadLine();

            if (run != "s")
            {
                continuar = false;
            }
        }

        Console.WriteLine("Obrigado por usar nossa calculadora!");
    }
}