namespace Exercicio2Estrutura;

class Program
{
    static void Main(string[] args)
    {
        Stack<string> pilhaLivros = new Stack<string>();
        int opcao = 0;
        
        do
        {
            Console.Write("\n***********************************************");
            Console.Write("\n\n\t1 - Adicionar livro à pilha\t\n");
            Console.Write("\t2 - Listar todos os livros\t\n");
            Console.Write("\t3 - Retirar livro da pilha\t\n");
            Console.Write("\t0 - Sair\t\n\n");
            Console.Write("***********************************************\n");
            
            Console.Write("Digite a opção desejada: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("\nDigite o nome do livro: ");
                    pilhaLivros.Push(Console.ReadLine());
                    Console.Write("Livro adicionado com sucesso!!!\n");
                    break;
                case 2:
                    if(pilhaLivros.Count == 0)
                    {
                        Console.WriteLine("\nNão há livros na pilha!!!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nLivros na pilha: ");
                        foreach (var livro in pilhaLivros)
                        {
                            Console.WriteLine(livro);
                        }
                    }
                    break;
                case 3:
                    if (pilhaLivros.Count == 0)
                    {
                        Console.Write("\nNão há livros na pilha!!!\n");
                    }
                    else
                    {
                        Console.Write($"\nRetirando o livro: {pilhaLivros.Peek()}!!!\n");
                        pilhaLivros.Pop();
                    }
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

