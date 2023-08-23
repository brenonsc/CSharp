namespace Exercicio1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o salário: ");
        decimal salario = decimal.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite o valor do abono: ");
        decimal abono = decimal.Parse(Console.ReadLine());

        decimal novoSalario = salario + abono;
        
        Console.WriteLine($"\nNovo salário: R$ {novoSalario}");
    }
}

