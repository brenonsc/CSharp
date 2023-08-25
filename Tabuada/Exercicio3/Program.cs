namespace Exercicio3;

class Program
{
    static void Main(string[] args)
    {
        int idade = 1, idadesm21 = 0, idadesM50 = 0, i = 1;

        while (idade >= 0)
        {
            Console.Write($"Digite a idade da {i}ª pessoa: ");
            idade = int.Parse(Console.ReadLine());
            
            if (idade < 21 && idade >= 0)
            {
                idadesm21 += 1;
            }
            else if (idade > 50)
            {
                idadesM50 += 1;
            }

            if (idade < 0)
            {
                Console.WriteLine("\nPesquisa finalizada!");
            }

            i++;
        }
        
        Console.WriteLine($"\nRESULTADOS\n-----------------------------------------\nTotal de pessoas menores de 21 anos: {idadesm21}\nTotal de pessoas maiores de 50 anos: {idadesM50}\n-----------------------------------------");
    }
}

