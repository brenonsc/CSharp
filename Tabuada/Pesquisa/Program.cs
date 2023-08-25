namespace Pesquisa;

class Program
{
    static void Main(string[] args)
    {
        string? nome, continua = "S";
        int idade, esporte, futebol = 0, voleiM18 = 0, basquetem18 = 0;

        do
        {
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            
            Console.Write("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());

            do
            {
                Console.Write("\nESPORTES\n------------------\n1 - Futebol\n2 - Vôlei\n3 - Basquete\n4 - Outros\n------------------\nDigite o número do seu esporte favorito: ");
                esporte = int.Parse(Console.ReadLine());

                if (esporte < 1 || esporte > 4)
                {
                    Console.WriteLine("Opção inválida!");
                }
            } while (esporte < 1 || esporte > 4);

            if (nome != "")
            {
                Console.Write($"\nNome: {nome}\nIdade: {idade}");
            }
            else
            {
                Console.Write($"\nIdade: {idade}");
            }

            switch (esporte)
            {
                case 1:
                    Console.Write("\nEsporte: Futebol\n");
                    futebol += 1;
                    break;
                case 2:
                    Console.Write("\nEsporte: Vôlei\n");
                    if (idade > 18)
                    {
                        voleiM18 += 1;
                    }
                    break;
                case 3:
                    Console.Write("\nEsporte: Basquete\n");
                    if (idade < 18)
                    {
                        basquetem18 += 1;
                    }
                    break;
                default:
                    Console.Write("\nEsporte: Outros\n");
                    break;
            }
            
            Console.Write("\nDeseja continuar? (S/N): ");
            continua = Console.ReadLine().ToUpper();
            
            Console.Write("\n");
        } while (continua.Equals("S"));
        
        Console.WriteLine("RESULTADOS\n----------------------------\nFutebol: " + futebol + "\nVôlei (+18 anos): " + voleiM18 + "\nBasquete (-18 anos): " + basquetem18 + "\n----------------------------");
    }
}

