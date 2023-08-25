namespace Exercicio2;

class Program
{
    static void Main(string[] args)
    {
        int par = 0, impar = 0;
        
        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"Digite o {i}º número: ");
            if (int.Parse(Console.ReadLine()) % 2 == 0)
            {
                par += 1;
            }
            else
            {
                impar += 1;
            }
        }
        
        Console.WriteLine($"\n---------------------------------\nTotal de números pares: {par}\nTotal de números ímpares: {impar}\n---------------------------------");
    }
}

