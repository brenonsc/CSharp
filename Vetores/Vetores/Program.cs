namespace Vetores;

class Program
{
    static void Main(string[] args)
    {
        int[] vetor01 = {1,2,3,4,5,6,7,8,9,10};
        int[] vetor02 = new int[5];
        
        Array.Reverse(vetor01);
        for(int i = 0; i < vetor01.Length; i++)
        {
            Console.WriteLine($"vetor01[{i}] = {vetor01[i]}");
        }
        
        Console.WriteLine("\nDigite 5 números para o vetor02:");
        
        for(int i = 0; i < vetor02.Length; i++)
        {
            Console.Write($"vetor02[{i}] = ");
            vetor02[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(vetor02);
        Console.WriteLine("\nVetor02:");
        
        for(int i = 0; i < vetor02.Length; i++)
        {
            Console.WriteLine($"vetor02[{i}] = {vetor02[i]}");
        }
        
        string[] vetor03 = {"Ingrid", "Allan", "Pedro", "Maria", "João"};
        
        Array.Sort(vetor03);
        Console.WriteLine("\nVetor03:");
        
        for(int i = 0; i < vetor03.Length; i++)
        {
            Console.WriteLine($"vetor03[{i}] = {vetor03[i]}");
        }
        
        Console.WriteLine("\nDigite um nome para pesquisar no vetor03:");
        string nome = Console.ReadLine();
        
        int posicao = Array.BinarySearch(vetor03, nome);
    }
}

