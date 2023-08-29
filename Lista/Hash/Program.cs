namespace Hash;

class Program
{
    static void Main(string[] args)
    {
        HashSet<string> setNomes = new HashSet<string>()
        {
            "Breno",
            "Eduardo",
            "Julia",
            "Leonardo",
            "Gaspar"
        };
        
        Console.WriteLine("Os nomes cadastrados são: ");
        foreach (var nome in setNomes)
        {
            Console.WriteLine(nome);
        }
        
        Console.WriteLine("\nO Gaspar está cadastrado? " + setNomes.Contains("Gaspar"));
        Console.WriteLine("Quantos nomes estão cadastrados? " + setNomes.Count);
        
        setNomes.Remove("Gaspar");

        setNomes.Add("Valéria");
        setNomes.Add("Gabriel");
        
        Console.WriteLine("\nOs nomes cadastrados são: ");
        foreach (var nome in setNomes)
        {
            Console.WriteLine(nome);
        }
        
        setNomes.Clear();
        Console.WriteLine("Limpeza do cadastro de nomes!");
        Console.WriteLine("\nQuantos nomes estão cadastrados? " + setNomes.Count);
    }
}

