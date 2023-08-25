namespace Exercicio6;

class Program
{
    static void Main(string[] args)
    {
        int numero, somaMultiplos3 = 0;

        do
        {
            Console.Write("Digite um número: ");
            numero = int.Parse(Console.ReadLine());

            if(numero % 3 == 0)
            {
                somaMultiplos3 += numero;
            }
        }
        while (numero != 0);
        
        Console.Write($"\nA soma dos números múltiplos de 3 é: {somaMultiplos3}.");
    }
}

