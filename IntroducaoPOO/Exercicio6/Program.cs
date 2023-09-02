using Exercicio6.Model;

namespace Exercicio6;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("BEM-VINDO AO SISTEMA DE VISUALIZAÇÃO DE CURSOS\n" +
                          "******************************************************");

        var c1 = new Curso("Ciência da Computação",
            "Curso que explora fundamentos e aplicações da computação, abrangendo programação, algoritmos, estruturas de dados e teoria da computação.",
            4000, new DateOnly(2024, 02, 05), 1150);
        var c2 = new Curso("Engenharia de Software",
            "Curso que ensina o desenvolvimento eficiente e sistemático de software, incluindo planejamento, projeto, implementação e manutenção.",
            4000, new DateOnly(2024, 02, 05), 1000);

        c1.Visualizar();
        c2.Visualizar();
    }
}