namespace Aula09;

public class Program()
{
    public static void Main()
    {
        Console.WriteLine("=================Operadores Lógicos================\n");

        string registro = "Bruno@ramos.com";
        int registroSenha = 123456;

        Console.WriteLine("Informe seu nome:");
        string nome = Console.ReadLine();

        Console.WriteLine("Informe seu Email:\n");
        string email = Console.ReadLine();

        Console.WriteLine("Escolha uma senha:\n");
        int senha = Convert.ToInt32(Console.ReadLine());

        if (registro == email && registroSenha == senha)
        {
            Console.WriteLine($"Registrado com sucesso {nome}");
        } else
        {
            Console.WriteLine("Dados inválidos, tente novamente!");
        }
    }
}