using Exercicio1.Model;

namespace Exercicio1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("BEM-VINDO AO SISTEMA DE VISUALIZAÇÃO DE CLIENTES\n" +
                          "******************************************************");
        
        PessoaFisica c1 = new PessoaFisica(1, "Breno", "Rua 1", "brenonsc@gmail.com", "12345678912", "11111111111");
        PessoaFisica c2 = new PessoaFisica(2, "João", "Rua 2", "joaozinho@bol.com.br", "98765432191", "12876040050");
        PessoaJuridica c3 = new PessoaJuridica(3, "Empresa 1", "Rua 3", "juridico@empresa1.com.br", "1140401090", "53360571000101");
        PessoaJuridica c4 = new PessoaJuridica(4, "Empresa 2", "Rua 4", "financeiro@empresa2.com.br", "1140028922", "38459162000165");
        
        c1.Visualizar();
        c2.Visualizar();
        c3.Visualizar();
        c4.Visualizar();
    }
}

