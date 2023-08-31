using Exercicio2.Model;

namespace Exercicio2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("BEM-VINDO AO SISTEMA DE VISUALIZAÇÃO DE FUNCIONÁRIOS\n" +
                          "******************************************************");
        
        Funcionario f1 = new Funcionario(1, "Breno", 4, 10000, new DateOnly(2018, 03, 07));
        Funcionario f2 = new Funcionario(2, "Pedro", 2, 3000, new DateOnly(2022, 05, 1));
        
        f1.Visualizar();
        f2.Visualizar();
    }
}

