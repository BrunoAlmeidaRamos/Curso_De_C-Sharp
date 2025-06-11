namespace Aula14;

public class  Program 
{
    public static void Main()
    {
        List<int> itens = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
        foreach (var numeros in itens)
            Console.WriteLine(numeros);
    }
}
