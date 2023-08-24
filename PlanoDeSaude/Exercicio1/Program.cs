namespace Exercicio1;

class Program
{
    static void Main(string[] args)
    {
        int a, b, c;
        
        Console.Write("Digite o número A: ");
        a = int.Parse(Console.ReadLine());
        
        Console.Write("Digite o número B: ");
        b = int.Parse(Console.ReadLine());
        
        Console.Write("Digite o número C: ");
        c = int.Parse(Console.ReadLine());

        if (a + b > c)
            Console.WriteLine($"\nA soma de A({a}) e B({b}) é maior que C({c}).");
        else if (a + b == c)
            Console.WriteLine($"\nA soma de A({a}) e B({b}) é igual a C({c}).");
        else
            Console.WriteLine($"\nA soma de A({a}) e B({b}) é menor que C({c}).");
    }
}

