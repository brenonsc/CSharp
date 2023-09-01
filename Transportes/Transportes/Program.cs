namespace Transportes;

class Program
{
    static void Main(string[] args)
    {
        Transporte t1 = new Transporte(5);
        
        t1.Visualizar();
        
        Console.Write("\n\n");
        
        Terrestre t2 = new Terrestre(5, 4, 200);
        
        t2.Visualizar(); 
        
        Console.Write("\n\n");
        
        Automovel t3 = new Automovel(5, 4, 200, "Vermelho", 4, "ABC-1234", 6);
        
        t3.Visualizar();
    }
}

