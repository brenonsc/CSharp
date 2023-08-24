namespace Exercicio5;

class Program
{
    static void Main(string[] args)
    {
        int id, quantidade;
        
        Console.Write("Digite o código do produto (1~6): ");
        id = int.Parse(Console.ReadLine());

        if (id > 0 && id <= 6)
        {
            Console.Write("Digite a quantidade: ");
            quantidade = int.Parse(Console.ReadLine());

            switch (id)
            {
                case 1:
                    Console.WriteLine("\nProduto: Cachorro quente\nValor unitário: R$ 10,00\nValor total: " +
                                      (quantidade * 10).ToString("C"));
                    break;
                case 2:
                    Console.WriteLine("\nProduto: X-Salada\nValor unitário: R$ 15,00\nValor total: " +
                                      (quantidade * 15).ToString("C"));
                    break;
                case 3:
                    Console.WriteLine("\nProduto: X-Bacon\nValor unitário: R$ 18,00\nValor total: " +
                                      (quantidade * 18).ToString("C"));
                    break;
                case 4:
                    Console.WriteLine("\nProduto: Bauru\nValor unitário: R$ 12,00\nValor total: " +
                                      (quantidade * 12).ToString("C"));
                    break;
                case 5:
                    Console.WriteLine("\nProduto: Refrigerante\nValor unitário: R$ 8,00\nValor total: " +
                                      (quantidade * 8).ToString("C"));
                    break;
                case 6:
                    Console.WriteLine("\nProduto: Suco de laranja\nValor unitário: R$ 13,00\nValor total: " +
                                      (quantidade * 13).ToString("C"));
                    break;
                default:
                    Console.WriteLine("\nCódigo inválido!");
                    break;
            }
        }
        else
        {
            Console.WriteLine("\nCódigo inválido!");
        }
    }
}

