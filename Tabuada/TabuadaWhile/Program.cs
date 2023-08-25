namespace TabuadaWhile;

class Program
{
    static void Main(string[] args)
    {
        int numero, i = 1;
        
        Console.Write("Digite um número: ");
        numero = int.Parse(Console.ReadLine());
        Console.Write("\n");
        
        while (i <= 10)
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
            i++;
        }
    }
}

