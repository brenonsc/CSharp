using Metodos2.Namespace01;

namespace Metodos2;

class Program
{
    static void Main(string[] args)
    {
        MetodoPublico();
        MetodoInternal();
        MetodoProtegido();
        MetodoPrivado();
        
        Classe01.MetodoPublico();
        Classe01.MetodoInternal();
        
        Classe02.MetodoPublico();
        Classe02.MetodoInternal();
    }
    
    public static void MetodoPublico()
    {
        Console.WriteLine("Método Público - Classe Program");
    }
    
    internal static void MetodoInternal()
    {
        Console.WriteLine("Método Internal - Classe Program");
    }
    
    protected static void MetodoProtegido()
    {
        Console.WriteLine("Método Protected - Classe Program");
    }
    
    private static void MetodoPrivado()
    {
        Console.WriteLine("Método Private - Classe Program");
    }
}

