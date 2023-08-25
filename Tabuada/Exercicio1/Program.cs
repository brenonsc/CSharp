namespace Exercicio1;

class Program
{
    static void Main(string[] args)
    {
        int n1, n2;

        Console.Write("Digite o primeiro número do intervalo: ");
        n1 = int.Parse(Console.ReadLine());
        
        Console.Write("Digite o segundo número do intervalo: ");
        n2 = int.Parse(Console.ReadLine());
        
        if (n1 < n2)
        {
            for(int i = n1; i <= n2; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write($"\nO número {i} é múltiplo de 3 e 5!");
                }
            }
        }
        else
        {
            Console.WriteLine("\nOpção inválida! O primeiro número deve ser menor que o segundo!");
        }
    }
}

