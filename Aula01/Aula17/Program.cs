namespace Aula17;
using System.IO;

public class  Program
{
    public static void Main()
    {
        string pasta = @"C:\Users\Bruno Ramos\Documents\GitHub\Curso_De_C-Sharp\Aula01\Aula17\";
        string fileName = "Lista_de_Compras.txt";
        string filePasta = pasta + fileName;

        List<string> listaCompras = new List<string>();

        if (!Directory.Exists(pasta))
        {
            Directory.CreateDirectory(pasta);
        }

        while (true)
        {
            Console.WriteLine("\n=== Lista de Compras ===");
            Console.WriteLine("[1] Adicionar item");
            Console.WriteLine("[2] Remover item da lista");
            Console.WriteLine("[3] Ver a lista");
            Console.WriteLine("[4] Exportar lista para o .txt");

            string opcao = Console.ReadLine();

            switch(opcao)
            {
                case "1":
                    Console.WriteLine("Digite o item que deseja adicionar:");
                    string item = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(item))
                    {
                        listaCompras.Add(item);
                        Console.WriteLine($"Item '{item}' adicionado com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Item inválido. Tente novamente.");
                    }
                    break;

                case "2":
                    {
                        Console.WriteLine("Digite o item que deseja remover:");
                        string removerItem = Console.ReadLine();

                       listaCompras.Remove(removerItem);
                        Console.WriteLine($"Item '{removerItem}' removido com sucesso!");
                    }
                    break;

                case "3":
                    {
                        Console.WriteLine("Lista de Compras");

                        if (listaCompras.Count == 0)
                        {
                            Console.WriteLine("A lista está vazia.");
                        }
                        else
                        {
                            Console.WriteLine("Itens na lista:");
                            for (var i = 0; i < listaCompras.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}- {listaCompras[i]} ");
                            }
                        }
                    }
                    break;

                case "4":
                    if (listaCompras.Count == 0)
                    {
                        Console.WriteLine("A lista está vazia. Não é possivel exportar.");
                    }
                    else
                    {
                        File.WriteAllLines(filePasta, listaCompras);
                        Console.WriteLine($"Lista exportada para {fileName} com sucesso!");
                        return;
                    }
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;

            }
        }

    }
}
