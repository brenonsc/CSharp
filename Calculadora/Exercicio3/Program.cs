namespace Exercicio3;

class Program
{
    static void Main(string[] args)
    {
        float salarioBruto, adicionalNoturno, horasExtras, descontos;
        
        Console.WriteLine("Digite o salário bruto: ");
        salarioBruto = float.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite o valor do adicional noturno: ");
        adicionalNoturno = float.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite a quantidade de horas extras: ");
        horasExtras = float.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite o valor dos descontos: ");
        descontos = float.Parse(Console.ReadLine());
        
        float salarioLiquido = salarioBruto + adicionalNoturno + (horasExtras * 5) - descontos;
        
        Console.WriteLine($"\nSalário líquido: {salarioLiquido.ToString("C")}");
    }
}

