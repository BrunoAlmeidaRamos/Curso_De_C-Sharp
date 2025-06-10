namespace Aula07
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("=========Verificar números pares e ímpares=========");
            Console.Write("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            int resultado = numero % 2;

                if (resultado == 0)
            {
                Console.WriteLine($"O número {numero} é par!");
            } else
            {
                Console.WriteLine($"O número {numero} é impar!");
            }

        }
    }


}
