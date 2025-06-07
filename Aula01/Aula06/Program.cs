namespace Aula06;

public class program
{
    public static void Main()
    {
        Console.WriteLine("============= CLCULADORA SIMPLES ==============");

        Console.WriteLine("Informe o primeiro Número: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe o segundo Número: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int soma = num1 + num2;
        int subtraçao = num1 - num2;
        int divisao = num1 / num2;
        int mutplicacao = num1 * num2;
        int resto = num1 % num2;

        Console.WriteLine($"A Soma dos números é: {soma}");
        Console.WriteLine($"A Subtração dos números é: {subtraçao}");
        Console.WriteLine($"A Divisão dos números é: {divisao}");
        Console.WriteLine($"O Resto da Divisão é: {resto}");
        Console.WriteLine($"A Mutplicação dos números é: {mutplicacao}");
    }
   
       
}
