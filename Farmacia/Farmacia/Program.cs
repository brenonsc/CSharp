using Farmacia.Controller;
using Farmacia.Model;

namespace Farmacia;

class Program
{
    private static ConsoleKeyInfo consoleKeyInfo;
    
    static void Main(string[] args)
    {
        int opcao, tipo, id;
        string nome, generico, fragrancia;
        decimal preco;
        
        ProdutoController prod = new();
        
        while (true)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.Write("\n************************************************************\n\n" +
                          "\t\t    FARMÁCIA BEM-ESTAR\n\n" +
                          "************************************************************\n\n" +
                          "\t\t1 - Criar Produto\n" +
                          "\t\t2 - Listar todos os Produtos\n" +
                          "\t\t3 - Buscar Produto por número\n" +
                          "\t\t4 - Atualizar dados do Produto\n" +
                          "\t\t5 - Apagar Produto\n" +
                          "\t\t6 - Sair\n\n" +
                          "************************************************************");

            Console.Write("\nDigite a opção desejada: ");

            //Tratamento de exceção para entrada de dados em formato incorreto
            try
            {
                opcao = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nDigite um valor inteiro entre 1 e 6!\n");
                opcao = 0;
                Console.ResetColor();
                KeyPress();
                continue;
            }

            if (opcao == 6)
            {
                Console.WriteLine("\nFARMÁCIA BEM-ESTAR - Remédio barato é aqui!\n");
                Sobre();
                Console.ResetColor();
                System.Environment.Exit(0);
            }

            switch (opcao)
            {
                case 1:
                    Console.Write("\nCriar produto\n");
                    Console.ResetColor();
                    
                    Console.Write("Digite o nome do produto: ");
                    nome = Console.ReadLine();
                    
                    nome ??= string.Empty;
                    
                    do
                    {
                        Console.Write("Digite o tipo do produto (1 - Medicamento | 2 - Cosmético): ");
                        tipo = int.Parse(Console.ReadLine());

                        if (tipo != 1 && tipo != 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nOpção Inválida!\n");
                            Console.ResetColor();
                        }
                    } while (tipo != 1 && tipo != 2);
                    
                    Console.Write("Digite o valor do produto: ");
                    preco = decimal.Parse(Console.ReadLine());
                    
                    switch (tipo)
                    {
                        case 1:
                            Console.Write("Digite o nome genérico do produto: ");
                            generico = Console.ReadLine();
                        
                            Medicamento remedio = new Medicamento(prod.GerarNumero(), nome, tipo, preco, generico);
                            prod.Cadastrar(remedio);
                            break;
                        case 2:
                            Console.Write("Digite a fragrância do produto: ");
                            fragrancia = Console.ReadLine();
                            
                            Cosmetico cosmetico = new Cosmetico(prod.GerarNumero(), nome, tipo, preco, fragrancia);
                            prod.Cadastrar(cosmetico);
                            break;
                    }
                    KeyPress();
                    break;
                case 2:
                    Console.Write("\nListar todos os produtos\n");
                    Console.ResetColor();
                    prod.ListarProdutos();
                    KeyPress();
                    Console.Write("\n");
                    break;
                case 3:
                    Console.Write("\nBuscar produto por número\n");
                    Console.ResetColor();
                    Console.Write("Digite o número do produto: ");
                    id = int.Parse(Console.ReadLine());

                    prod.ProcurarPorNumero(id);
                    KeyPress();
                    Console.Write("\n");
                    break;
                case 4:
                    Console.Write("\nAtualizar dados do produto\n");
                    Console.ResetColor();
                    
                    Console.Write("Digite o número do produto: ");
                    id = int.Parse(Console.ReadLine());

                    var produto = prod.BuscarNaCollection(id);

                    if (produto is not null)
                    {
                        Console.Write("Digite o nome do produto: ");
                        nome = Console.ReadLine();
                    
                        nome ??= string.Empty;
                    
                        do
                        {
                            Console.Write("Digite o tipo do produto (1 - Medicamento | 2 - Cosmético): ");
                            tipo = int.Parse(Console.ReadLine());

                            if (tipo != 1 && tipo != 2)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nOpção Inválida!\n");
                                Console.ResetColor();
                            }
                        } while (tipo != 1 && tipo != 2);
                    
                        Console.Write("Digite o valor do produto: ");
                        preco = decimal.Parse(Console.ReadLine());
                        
                        switch (produto.Tipo)
                        {
                            case 1:
                                Console.Write("Digite o nome genérico do produto: ");
                                generico = Console.ReadLine();
                            
                                Medicamento remedio = new Medicamento(id, nome, produto.Tipo, preco, generico);
                                prod.Atualizar(remedio);
                                break;
                            case 2:
                                Console.Write("Digite a fragrância do produto: ");
                                fragrancia = Console.ReadLine();
                                
                                Cosmetico cosmetico = new Cosmetico(id, nome, produto.Tipo, preco, fragrancia);
                                prod.Atualizar(cosmetico);
                                break;
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($"\nO produto número {id} não foi encontrado!\n");
                        Console.ResetColor();
                    }
                    KeyPress();
                    break;
                case 5:
                    Console.Write("\nApagar produto\n");
                    Console.ResetColor();
                    
                    Console.Write("Digite o número do produto: ");
                    id = int.Parse(Console.ReadLine());
                    
                    Console.Write("\n");
                    prod.Deletar(id);
                    KeyPress();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nOpção Inválida!\n");
                    Console.ResetColor();
                    
                    KeyPress();
                    break;
            }
        }
    }
    
    static void Sobre()
    {
        Console.Write("####################################################\n" +
                      "\tProjeto desenvolvido por: \n" +
                      "\tBreno Henrique - brenonsc@gmail.com\n" +
                      "\tgithub.com/brenonsc\n" +
                      "####################################################");
    }
        
    static void KeyPress()
    {
        do
        {
            Console.Write("Pressione Enter para continuar...");
            consoleKeyInfo = Console.ReadKey();
        } while (consoleKeyInfo.Key != ConsoleKey.Enter);
    }
}

