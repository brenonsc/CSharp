using Exercicio4.Model;

namespace Exercicio4;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("BEM-VINDO AO SISTEMA DE VISUALIZAÇÃO DE REMÉDIOS\n" +
                          "******************************************************");

        var f1 = new Medicamento(1, "Dipirona", "Analgésico", 5.50m, 100, "500mg", "EMS");
        var f2 = new Medicamento(2, "Paracetamol", "Analgésico", 4.50m, 100, "500mg", "EMS");
        var f3 = new Perfumaria(3, "Shampoo", "Cabelo", 10.00m, 100, "Pantene", "Coco");
        var f4 = new Perfumaria(4, "Condicionador", "Cabelo", 10.00m, 100, "Pantene", "Coco");

        f1.Visualizar();
        f2.Visualizar();
        f3.Visualizar();
        f4.Visualizar();
    }
}