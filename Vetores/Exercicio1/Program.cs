namespace Exercicio1;

class Program
{
    static void Main(string[] args)
    {
        int[] vetor = { 2, 5, 1, 3, 4, 9, 7, 8, 10, 6 };
        
        Console.Write("Digite um número para ser buscado no vetor: ");
        int numero = int.Parse(Console.ReadLine());
        
        if(Array.IndexOf(vetor, numero) == -1)
            Console.Write($"\nO número {numero} não foi encontrado.");
        else
            Console.Write($"\nO número {numero} está na posição {Array.IndexOf(vetor, numero)} do vetor.");
    }
}