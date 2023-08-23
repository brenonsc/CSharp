namespace Calculadora;

class Program
{
    static void Main(string[] args)
    {
        float numero1, numero2;
        
        Console.WriteLine("Digite o primeiro número: ");
        numero1 = float.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite o segundo número: ");
        numero2 = float.Parse(Console.ReadLine());
        
        Console.WriteLine($"\nOperações\n{numero1} + {numero2} = {numero1 + numero2}");
        Console.WriteLine($"{numero1} - {numero2} = {numero1 - numero2}");
        Console.WriteLine($"{numero1} * {numero2} = {numero1 * numero2}");
        Console.WriteLine($"{numero1} / {numero2} = {Math.Round((numero1/numero2),2)}");
        Console.WriteLine($"{numero1} % {numero2} = {numero1 % numero2}");
        Console.WriteLine($"{numero1} ^ {numero2} = {Math.Pow(numero1,numero2)}");
        Console.WriteLine($"Raiz quadrada de {numero1} = {Math.Sqrt(numero1)}");
        Console.WriteLine($"Raiz quadrada de {numero2} = {Math.Sqrt(numero2)}");
    }
}

