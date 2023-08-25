namespace Exercicio5;

class Program
{
    static void Main(string[] args)
    {
        int numero, somaPositivos = 0;

        do
        {
            Console.Write("Digite um número: ");
            numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                somaPositivos += numero;
            }
        }
        while (numero != 0);
        
        Console.Write($"\nA soma dos números positivos é: {somaPositivos}.");
    }
}

