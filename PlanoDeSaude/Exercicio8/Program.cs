namespace Exercicio8;

class Program
{
    static void Main(string[] args)
    {
        int codigoOperacao;
        float saldo = 1000, valor;

        do
        {
            Console.WriteLine("\nOPERAÇÕES BANCÁRIAS\n--------------------\n1 - Saldo\n2 - Saque\n3 - Depósito\n0 - Sair\n--------------------\n");
        
            Console.Write("Digite a operação desejada (1~3): ");
            codigoOperacao = int.Parse(Console.ReadLine());

            switch (codigoOperacao)
            {
                case 0:
                    Console.WriteLine("\nOperação: Sair\nSaindo...");
                    break;
                case 1:
                    Console.WriteLine($"\nOperação: Saldo\nSaldo atual: {saldo.ToString("C")}.");
                    break;
                case 2:
                    Console.Write("Digite o valor a ser sacado: ");
                    valor = float.Parse(Console.ReadLine());
                    if(valor > saldo)
                        Console.WriteLine("\nOperação: Saque\nSaldo insuficiente!");
                    else
                    {
                        saldo -= valor;
                        Console.WriteLine($"\nOperação: Saque\nSaldo atual: {saldo.ToString("C")}.");
                    }
                    break;
                case 3:
                    Console.Write("Digite o valor a ser depositado: ");
                    saldo += float.Parse(Console.ReadLine());
                    Console.WriteLine($"\nOperação: Depósito\nNovo saldo: {saldo.ToString("C")}.");
                    break;
                default:
                    Console.WriteLine("\nOperação inválida!");
                    break;
            }
        } while (codigoOperacao != 0);
        
        Console.WriteLine("\nObrigado por utilizar nossos serviços!");
    }
}