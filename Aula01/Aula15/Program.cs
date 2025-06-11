namespace Aula15;

public class  Program
{
    public static void Main()
    {
        string linha = "====================";

        List<string> platinas = new List<string>
        {
            "God of War",
            "God of War 2",
            "God of War 3",
            "God of War 4"
        };

        Console.WriteLine(platinas[1]);

        Console.WriteLine(linha);

        Console.WriteLine("Platinas do God of War:\n");
        foreach (var war in platinas)
        {
            Console.WriteLine(war);
        }

        Console.WriteLine(linha);

        platinas.Add("God of War Ragnarok");
        Console.WriteLine("Adicionando God of War Ragnarok:\n");
        foreach (var war in platinas)
        {
            Console.WriteLine(war);
        }

        Console.WriteLine(linha);

        Console.WriteLine($"Total de Platinas da saga God of War: {platinas.Count}\n");
    }
}
