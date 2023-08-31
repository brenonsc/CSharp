using Exercicio1.Model;

namespace Exercicio1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("BEM-VINDO AO SISTEMA DE VISUALIZAÇÃO DE CLIENTES\n" +
                          "******************************************************");
        
        Cliente c1 = new Cliente(1, "Breno", "Rua 1", "brenonsc@gmail.com", "12345678912");
        Cliente c2 = new Cliente(2, "João", "Rua 2", "joaozinho@bol.com.br", "98765432191");
        
        c1.Visualizar();
        c2.Visualizar();
    }
}

