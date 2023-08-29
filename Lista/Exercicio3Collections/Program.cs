namespace Exercicio3Collections;

class Program
{
    static void Main(string[] args)
    {
        HashSet<string> setNumeros = new HashSet<string>();

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite o {i+1}º número: ");
            setNumeros.Add(Console.ReadLine());
        }
        
        Console.WriteLine("\nOs números cadastrados são: ");
        foreach (var numero in setNumeros)
        {
            Console.Write($"{numero} ");
        }
    }
}

