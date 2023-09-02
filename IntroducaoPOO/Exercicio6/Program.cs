using Exercicio6.Model;

namespace Exercicio6;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("BEM-VINDO AO SISTEMA DE VISUALIZAÇÃO DE CURSOS\n" +
                          "******************************************************");

        CursoLivre c1 = new CursoLivre("Introdução à Programação","Curso introdutório de programação que abrange conceitos como lógica, variáveis, controle de fluxo, repetição, funções e procedimentos.", 40, new DateOnly(2024, 10, 05), 500, "Nenhum");
        CursoLivre c2 = new CursoLivre("Introdução à Programação Orientada a Objetos","Curso que ensina os fundamentos da programação orientada a objetos, incluindo classes, objetos, encapsulamento, herança e polimorfismo.", 40, new DateOnly(2024, 12, 05), 550, "Curso Introdução à Programação");
        Especializacao c3 = new Especializacao("Ciência da Computação", "Curso que explora fundamentos e aplicações da computação, abrangendo programação, algoritmos, estruturas de dados e teoria da computação.", 4000, new DateOnly(2024, 02, 05), 1150, true);
        Especializacao c4 = new Especializacao("Engenharia de Software", "Curso que ensina o desenvolvimento eficiente e sistemático de software, incluindo planejamento, projeto, implementação e manutenção.", 4000, new DateOnly(2024, 02, 05), 1000, true);

        c1.Visualizar();
        c2.Visualizar();
        c3.Visualizar();
        c4.Visualizar();
    }
}