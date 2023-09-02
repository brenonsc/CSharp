using Exercicio5.Model;

namespace Exercicio5;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("BEM-VINDO AO SISTEMA DE VISUALIZAÇÃO DE INGRESSOS\n" +
                          "******************************************************");

        MeiaEntrada i1 = new MeiaEntrada(1, "Coldplay Music of The Spheres", "Estádio do Morumbi",
            new DateTime(2023, 03, 14, 21, 00, 00), "Pista", 550);
        MeiaEntrada i2 = new MeiaEntrada(2, "GP do Brasil de F1", "Autódromo de Interlagos",
            new DateTime(2023, 11, 05, 14, 00, 00), "Arquibancada A", 395);
        Vip i3 = new Vip(3, "Arctic Monkeys The Car Tour", "Allianz Parque",
            new DateTime(2022, 12, 10, 20, 00, 00), "Pista Premium", 1200);
        Vip i4 = new Vip(4, "Phil Collins The Last Farewell Tour", "Estádio do Morumbi",
            new DateTime(2022, 03, 20, 21, 00, 00), "Pista Premium", 1500);

        i1.Visualizar();
        i2.Visualizar();
        i3.Visualizar();
        i4.Visualizar();
    }
}