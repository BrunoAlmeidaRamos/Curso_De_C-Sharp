namespace Aula16;
using System.IO;

public class  Program
{
    public static void Main()
    {

        string pasta = @"C:\Users\Bruno Ramos\Documents\GitHub\Curso_De_C-Sharp\Aula01\Aula16\fileName.txt";

        Console.WriteLine("Escrevendo no arquivo...");
        Console.WriteLine("Digite o texto que deseja escrever no arquivo:");
        string text = Console.ReadLine();

        System.IO.File.WriteAllText(pasta, text);

        Console.WriteLine("Texto escrito com sucesso!");
    }
}
