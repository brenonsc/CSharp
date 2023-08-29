namespace Exercicio2Collections;

class Program
{
    static void Main(string[] args)
    {
        List<int> numeros = new List<int>()
        {
            2, 5, 1, 3, 4, 9, 7, 8, 10, 6
        };
        
        Console.Write("Digite um número para ser encontrado na lista: ");
        int numero = int.Parse(Console.ReadLine());
        
        if (numeros.Contains(numero))
        {
            Console.Write($"\nO número {numero} está localizado na posição {numeros.IndexOf(numero)} da lista.");
        }
        else
        {
            Console.Write($"\nO número {numero} não foi encontrado!");
        }
    }
}

