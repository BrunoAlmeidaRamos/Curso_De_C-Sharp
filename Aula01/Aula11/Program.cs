namespace Aula10;

public class  Program
{
    public static void Main()
    {
        Console.WriteLine("===== DIA DA SEMANA =====");
        Console.WriteLine("Escolhe os números de 1 a 7: ");
        int semana = Convert.ToInt32(Console.ReadLine());

        switch (semana)
        {
            case 1:
                Console.WriteLine("Domingo");
                break;

            case 2:
                Console.WriteLine("Segunda-feira");
                break;

            case 3:
                Console.WriteLine("Terca-feira");
                break;

            case 4:
                Console.WriteLine("Quarta-feira");
                break;

            case 5:
                Console.WriteLine("Quinta-feira");
                break;

            case 6:
                Console.WriteLine("Sexta-feira");
                break;

            case 7:
                Console.WriteLine("Sabado");
                break;

            default:
                Console.WriteLine("\nNumero invalido");
                break;
        }
    }
}
