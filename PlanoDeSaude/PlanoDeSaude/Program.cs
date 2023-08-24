namespace PlanoDeSaude;

class Program
{
    static void Main(string[] args)
    {
        string? nome;
        int idade;
        
        Console.WriteLine("Digite seu nome: ");
        nome = Console.ReadLine();
        
        Console.WriteLine("Digite sua idade: ");
        idade = int.Parse(Console.ReadLine());

        if(idade < 0)
        {
            Console.WriteLine("\nIdade inválida!");
        }
        else if (idade <= 10)
        {
            Console.WriteLine($"\nOlá, {nome}! O valor do seu plano de saúde é R$ 100,00.");
        }
        else if (idade > 10 && idade < 30)
        {
            Console.WriteLine($"\nOlá, {nome}! O valor do seu plano de saúde é R$ 200,00.");
        }
        else if (idade > 29 && idade < 45)
        {
            Console.WriteLine($"\nOlá, {nome}! O valor do seu plano de saúde é R$ 300,00.");
        }
        else if (idade > 44 && idade < 60)
        {
            Console.WriteLine($"\nOlá, {nome}! O valor do seu plano de saúde é R$ 500,00.");
        }
        else if (idade > 59 && idade <= 65)
        {
            Console.WriteLine($"\nOlá, {nome}! O valor do seu plano de saúde é R$ 600,00.");
        }
        else
        {
            Console.WriteLine($"\nOlá, {nome}! O valor do seu plano de saúde é R$ 1000,00.");
        }
    }
}

