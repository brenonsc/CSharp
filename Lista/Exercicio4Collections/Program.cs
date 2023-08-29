namespace Exercicio4Collections;

class Program
{
    static void Main(string[] args)
    {
        HashSet<int> setNumeros = new HashSet<int>()
        {
            2, 5, 1, 3, 4, 9, 7, 8, 10, 6
        };
        
        Console.Write("Digite um número para ser encontrado na lista: ");
        int numero = int.Parse(Console.ReadLine());
        
        if (setNumeros.Contains(numero))
        {
            Console.Write($"\nO número {numero} foi encontrado!");
        }
        else
        {
            Console.Write($"\nO número {numero} não foi encontrado!");
        }
    }
}

