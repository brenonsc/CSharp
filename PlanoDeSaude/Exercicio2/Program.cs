namespace Exercicio2;

class Program
{
    static void Main(string[] args)
    {
        int numero;
        
        Console.Write("Digite um número: ");
        numero = int.Parse(Console.ReadLine());
        
        if (numero % 2 == 0)
        {
            Console.Write($"\nO número {numero} é par ");
        }
        else
        {
            Console.Write($"\nO número {numero} é ímpar ");
        }

        if (numero > 0)
        {
            Console.Write("e positivo!");
        }
        else if(numero == 0)
        {
            Console.Write("e neutro!");
        }
        else
        {
            Console.Write("e negativo!");
        }
    }
}

