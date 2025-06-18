namespace Aula19;

public class Program
{
    public static void Main()
    {
        Cake cakeChocolate = new Cake("Chocolate", "Prestigio", "Chocolate", 10, 150);

        Console.WriteLine($"Sabor : {cakeChocolate.Sabor}");
        Console.WriteLine($"Recheio : {cakeChocolate.Recheio}");
        Console.WriteLine($"Cobertura : {cakeChocolate.Cobertura}");
        Console.WriteLine($"Tamanho : {cakeChocolate.Tamanho} KG");
        Console.WriteLine($"Valor : R$ {cakeChocolate.Valor}");

        Console.WriteLine("==========================================");

        Cake cakeNinho = new Cake("Ninho", "Nutela", "Ninho", 20, 250);

        Console.WriteLine($"Sabor : {cakeNinho.Sabor}");
        Console.WriteLine($"Recheio : {cakeNinho.Recheio}");
        Console.WriteLine($"Cobertura : {cakeNinho.Cobertura}");
        Console.WriteLine($"Tamanho : {cakeNinho.Tamanho} KG");
        Console.WriteLine($"Valor : R$ {cakeNinho.Valor}");

    }
}
