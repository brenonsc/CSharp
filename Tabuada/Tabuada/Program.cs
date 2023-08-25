namespace Tabuada;

class Program
{
    static void Main(string[] args)
    {
        int numero;
        
        Console.Write("Digite um número: ");
        numero = int.Parse(Console.ReadLine());
        Console.Write("\n");
        
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
        }
    }
}

