namespace Aula05;

public class  program
{
    public static void Main()
    {
        Console.WriteLine("-------CADASTRO-DE-USUARIO--------");
        Console.WriteLine("Digite Seu Nome: ");
        string name = Console.ReadLine();

        Console.WriteLine("Digite Sua Idade: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("De Qual Cidade Você É? ");
        string city = Console.ReadLine();

        Console.WriteLine("-------CADASTRO-CONCLUIDO--------");

        Console.WriteLine($"Seja bem vindo {name}!");
        Console.WriteLine($"Sua idade foi registrado com sucesso: [{age} Anos]");
        Console.WriteLine($"Sua cidade foi registrada com sucesso: [{city}]");
    }
}