namespace LoopDoWhile;

class Program
{
    static void Main(string[] args)
    {
        int numero, resultado, contador = 3;

        do
        {
            Console.Write("Digite um número inteiro: ");
            numero = int.Parse(Console.ReadLine());

            resultado = numero * 5;
            
            Console.WriteLine($"\n{numero} x 5 = {resultado}");
        }
        while (contador <= 2);
    }
}

