using Exercicio2.Model;

namespace Exercicio2;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("BEM-VINDO AO SISTEMA DE VISUALIZAÇÃO DE FUNCIONÁRIOS\n" +
                          "******************************************************");

        var f1 = new Vendedor(1, "Breno", 2, 2000, new DateOnly(2018, 03, 07), 45);
        var f2 = new Vendedor(2, "Pedro", 2, 2000, new DateOnly(2022, 05, 01), 60);
        var f3 = new Gerente(3, "João", 4, 10000, new DateOnly(2015, 06, 05), 5);
        var f4 = new Gerente(4, "Maria", 4, 12000, new DateOnly(2012, 08, 03), 1);

        f1.Visualizar();
        f2.Visualizar();
        f3.Visualizar();
        f4.Visualizar();
    }
}