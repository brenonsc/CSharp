namespace Exercicio7;

class Program
{
    static void Main(string[] args)
    {
        float n1, n2;
        int operacao;
        
        Console.Write("Digite o primeiro número: ");
        n1 = float.Parse(Console.ReadLine());
        
        Console.Write("Digite o segundo número: ");
        n2 = float.Parse(Console.ReadLine());
        
        Console.WriteLine("\nOPERAÇÕES\n--------------------\n1 - Soma\n2 - Subtração\n3 - Multiplicação\n4 - Divisão\n--------------------\n");
        
        Console.Write("Digite a operação desejada (1~4): ");
        operacao = int.Parse(Console.ReadLine());

        switch (operacao)
        {
            case 1:
                Console.WriteLine($"\n{n1} + {n2} = {n1 + n2}");
                break;
            case 2:
                Console.WriteLine($"\n{n1} - {n2} = {n1 - n2}");
                break;
            case 3:
                Console.WriteLine($"\n{n1} * {n2} = {n1 * n2}");
                break;
            case 4:
                Console.WriteLine($"\n{n1} / {n2} = {n1 / n2}");
                break;
            default:
                Console.WriteLine("\nOperação inválida!");
                break;
        }
    }
}

