namespace Exercicio1Estrutura;

class Program
{
    static void Main(string[] args)
    {
        Queue<string> filaClientes = new Queue<string>();
        int opcao = 0;

        do
        {
            Console.Write("\n***********************************************");
            Console.Write("\n\n\t1 - Adicionar cliente na fila\t\n");
            Console.Write("\t2 - Listar todos os clientes\t\n");
            Console.Write("\t3 - Retirar cliente da fila\t\n");
            Console.Write("\t0 - Sair\t\n\n");
            Console.Write("***********************************************\n");
            
            Console.Write("Digite a opção desejada: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("\nDigite o nome do cliente: ");
                    filaClientes.Enqueue(Console.ReadLine());
                    Console.Write("Cliente adicionado com sucesso!!!\n");
                    break;
                case 2:
                    if(filaClientes.Count == 0)
                    {
                        Console.WriteLine("\nNão há clientes na fila!!!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nClientes na fila: ");
                        foreach (var cliente in filaClientes)
                        {
                            Console.WriteLine(cliente);
                        }
                    }
                    break;
                case 3:
                    Console.Write($"\nChamando o cliente: {filaClientes.Peek()}!!!\n");
                    filaClientes.Dequeue();
                    break;
                case 0:
                    Console.Write("\nEncerrando o sistema...");
                    break; 
                default:
                    Console.Write("\nOpção inválida!\n\n");
                    break;
            }
        } while (opcao != 0);
    }
}

