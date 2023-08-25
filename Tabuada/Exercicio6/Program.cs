namespace Exercicio6;

class Program
{
    static void Main(string[] args)
    {
        float numero, somaMultiplos3 = 0, quantidade = 0;

        do
        {
            Console.Write("Digite um número: ");
            numero = float.Parse(Console.ReadLine());

            if(numero % 3 == 0 && numero != 0)
            {
                quantidade += 1;
                somaMultiplos3 += numero;
            }
        }
        while (numero != 0);
        
        Console.Write($"\nA média da soma dos números múltiplos de 3 é: {(somaMultiplos3/quantidade).ToString("F1")}.");
    }
}

