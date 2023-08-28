namespace Exercicio2;

class Program
{
    static void Main(string[] args)
    {
        int[] inteiros = new int[10];
        float media = 0, soma = 0;
        
        for(int i = 0; i < inteiros.Length; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            inteiros[i] = int.Parse(Console.ReadLine());
        }
        
        Console.WriteLine("\nElementos nos índices ímpares:");
        for (int i = 0; i < inteiros.Length; i++)
        {
            soma += inteiros[i];
            
            if(i % 2 != 0)
                Console.Write($"{inteiros[i]} ");
        }

        Console.WriteLine("\n\nElementos pares:");
        for (int i = 0; i < inteiros.Length; i++)
        {
            if(inteiros[i] % 2 == 0)
                Console.Write($"{inteiros[i]} ");
        }
        
        media = soma / inteiros.Length;
        
        Console.Write($"\n\nSoma dos elementos: {soma}\nMédia dos elementos: {media.ToString("F2")}");
    }
}

