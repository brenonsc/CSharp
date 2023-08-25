namespace Exercicio4;

class Program
{
    static void Main(string[] args)
    {
        string? continua = "S";
        int idade, identidadeGenero, stack, backend = 0, mulheresFront = 0, homensMobileM40 = 0, nBinariosFullm30 = 0, somaIdades = 0, total = 0;

        while (continua.Equals("S"))
        {
            Console.Write("Digite a idade do colaborador: ");
            idade = int.Parse(Console.ReadLine());

            do
            {
                Console.Write("\nIDENTIDADES DE GÊNERO\n---------------------------------\n1 - Mulher Cis\n2 - Homem Cis\n3 - Não Binário\n4 - Mulher Trans\n5 - Homem Trans\n6 - Outros\n---------------------------------\nDigite o número da identidade de gênero do colaborador (1~6): ");
                identidadeGenero = int.Parse(Console.ReadLine());
                
                if (identidadeGenero < 1 || identidadeGenero > 6)
                {
                    Console.WriteLine("\nOpção inválida!\n");
                }
            } while (identidadeGenero < 1 || identidadeGenero > 6);

            do
            {
                Console.Write(
                    "\nSTACKS\n---------------------------------\n1 - Backend\n2 - Frontend\n3 - Mobile\n4 - FullStack\n---------------------------------\nDigite o número da stack do colaborador (1~4): ");
                stack = int.Parse(Console.ReadLine());

                if (stack < 1 || stack > 4)
                {
                    Console.WriteLine("\nOpção inválida!\n");
                }

                if (stack == 1)
                {
                    backend += 1;
                }

                if ((identidadeGenero == 1 || identidadeGenero == 4) && stack == 2)
                {
                    mulheresFront += 1;
                }

                if ((identidadeGenero == 2 || identidadeGenero == 5) && stack == 3 && idade > 40)
                {
                    homensMobileM40 += 1;
                }
                
                if(identidadeGenero == 3 && stack == 4 && idade < 30)
                {
                    nBinariosFullm30 += 1;
                }
            } while (stack < 1 || stack > 4);
            
            total += 1;
            somaIdades += idade;
            
            Console.Write("\nDeseja continuar? (S/N) ");
            continua = Console.ReadLine().ToUpper();
            
            Console.Write("\n");
        }
        
        Console.WriteLine($"RESULTADOS\n-----------------------------------------------------------------------------\nTotal de pessoas desenvolvedoras backend: {backend}\nO número de Mulheres Cis e Trans desenvolvedoras Frontend: {mulheresFront}\nO número de Homens Cis e Trans desenvolvedores Mobile maiores de 40 anos: {homensMobileM40}\nO número de Não Binários desenvolvedores FullStack menores de 30 anos: {nBinariosFullm30}\nO número total de pessoas que responderam à pesquisa: {total}\nMédia de idade das pessoas que responderam à pesquisa: {somaIdades/total}\n-----------------------------------------------------------------------------");
    }
}

