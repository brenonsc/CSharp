namespace Exercicio3;

class Program
{
    static void Main(string[] args)
    {
        string nome;
        int idade;
        Boolean primeiraDoacao = true;
        
        Console.Write("Digite seu nome: ");
        nome = Console.ReadLine();
        
        Console.Write("Digite sua idade: ");
        idade = int.Parse(Console.ReadLine());

        if (idade >= 60 && idade < 70)
        {
            Console.Write("Você já doou sangue alguma vez? (S/N): ");
            if (Console.ReadLine().ToUpper() == "S")
            {
                primeiraDoacao = false;
            }
        }
        
        if(idade < 0)
        {
            Console.WriteLine("\nIdade inválida!");
        }
        else if (idade < 18)
        {
            Console.WriteLine($"\n{nome} não está apto a doar sangue!");
        }
        else if (idade > 18 && idade < 60)
        {
            Console.WriteLine($"\n{nome} está apto a doar sangue!");
        }
        else if (idade >= 60 && idade < 70 && primeiraDoacao == false)
        {
            Console.WriteLine($"\n{nome} está apto a doar sangue!");
        }
        else
        {
            Console.WriteLine($"\n{nome} não está apto doar sangue!");
        }
    }
}

