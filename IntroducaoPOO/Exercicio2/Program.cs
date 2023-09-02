using Exercicio2.Model;

namespace Exercicio2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("BEM-VINDO AO SISTEMA DE VISUALIZAÇÃO DE FUNCIONÁRIOS\n" +
                          "******************************************************");
        
        Vendedor f1 = new Vendedor(1, "Breno", 2, 2000, new DateOnly(2018, 03, 07), 45);
        Vendedor f2 = new Vendedor(2, "Pedro", 2, 2000, new DateOnly(2022, 05, 01), 60);
        Gerente f3 = new Gerente(3, "João", 4, 10000, new DateOnly(2015, 06, 05), 5);
        Gerente f4 = new Gerente(4, "Maria", 4, 12000, new DateOnly(2012, 08, 03), 1);
        
        f1.Visualizar();
        f2.Visualizar();
        f3.Visualizar();
        f4.Visualizar();
    }
}

