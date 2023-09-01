using Exercicio4.Model;

namespace Exercicio4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("BEM-VINDO AO SISTEMA DE VISUALIZAÇÃO DE REMÉDIOS\n" +
                          "******************************************************");
        
        Farmacia r1 = new Farmacia("Dipirona", "Dipirona Sódica", "EMS", 10.00m, "500mg");
        Farmacia r2 = new Farmacia("Paracetamol", "Paracetamol", "EMS", 5.00m, "500mg");
        
        r1.Visualizar();
        r2.Visualizar();
    }
}

