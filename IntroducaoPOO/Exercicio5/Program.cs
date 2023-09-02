using Exercicio5.Model;

namespace Exercicio5;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("BEM-VINDO AO SISTEMA DE VISUALIZAÇÃO DE INGRESSOS\n" +
                          "******************************************************");

        var i1 = new Ingresso(1, "Coldplay Music of The Spheres", "Estádio do Morumbi",
            new DateTime(2023, 03, 14, 21, 00, 00), 550);
        var i2 = new Ingresso(2, "GP do Brasil de F1", "Autódromo de Interlagos",
            new DateTime(2023, 11, 05, 14, 00, 00), 395);

        i1.Visualizar();
        i2.Visualizar();
    }
}