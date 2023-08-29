namespace Exercicio1Collections;

class Program
{
    static void Main(string[] args)
    {
        List<string> cores = new List<string>();
        
        Console.WriteLine("Serão cadastradas 5 cores!");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Digite a {i+1}ª cor: ");
            cores.Add(Console.ReadLine());
        }
        
        Console.WriteLine("\nAs cores cadastradas são: ");
        foreach (var cor in cores)
        {
            Console.WriteLine(cor);
        }
        
        cores.Sort();
        
        Console.WriteLine("\nAs cores cadastradas em ordem alfabética são: ");
        foreach (var cor in cores)
        {
            Console.WriteLine(cor);
        }
    }
}

