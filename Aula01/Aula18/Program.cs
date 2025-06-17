namespace Aula18;

public class Program
{
        public static void Main()
    {
        Car CarSkyline = new Car();

        CarSkyline.Color = "Azul";
        CarSkyline.Year = 2005;
        CarSkyline.Name = "Skyline";
        CarSkyline.Model = "Nissan";
        CarSkyline.value = 125035000;

        Console.WriteLine($"Nome do carro: {CarSkyline.Name}");
        Console.WriteLine($"Cor do carro: {CarSkyline.Color}");
        Console.WriteLine($"Marca do carro: {CarSkyline.Model}");
        Console.WriteLine($"Ano docarro: {CarSkyline.Year}");
        Console.WriteLine($"Valor do carro R$ {CarSkyline.value}");

    }
}