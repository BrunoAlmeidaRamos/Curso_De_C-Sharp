namespace Aula08; 

    public class Program()
    {
        public static void Main()

        {
        Console.WriteLine("============ Operadores Relacionais===============\n");
        Console.WriteLine("Digite o primeiro número:");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Difite o segundo número:");
        int y = Convert.ToInt32(Console.ReadLine());

        if (x == y)
        {
            Console.WriteLine($"Os números {x} e {y} são iguais!");
        }
        else
        {
            Console.WriteLine($"Ôs números {x} e {y} são diferentes");
        }
    }
    
      
    }
   
       

  

