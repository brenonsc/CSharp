namespace ReajusteSalarial;

class Program
{
    static void Main(string[] args)
    {
        string? nome;
        float salario, reajuste = 0;
        int cargo;
        
        Console.WriteLine("Digite o nome do funcionário: ");
        nome = Console.ReadLine();
        
        Console.WriteLine("\nDigite o salário do funcionário: ");
        salario = float.Parse(Console.ReadLine());
        
        Console.WriteLine("\nCARGOS\n--------------------\n1 - Supervisor\n2 - Diretor\n3 - Gerente\n--------------------\n");
        Console.Write("Digite o cargo do funcionário (1~3): ");
        cargo = int.Parse(Console.ReadLine());

        switch (cargo)
        {
            case 1:
                reajuste = (salario * 0.07f);
                break;
            case 2:
                reajuste = (salario * 0.09f);
                break;
            case 3:
                reajuste = (salario * 0.05f);
                break;
            default:
                reajuste = (salario * 0.12f);
                break;
        }

        if(nome != "")
            Console.WriteLine($"\nOlá, {nome}! O valor do seu reajuste salarial é de {reajuste.ToString("C")}.\nSeu novo salário é {(salario + reajuste).ToString("C")}.");
        else
            Console.WriteLine($"\nOlá! O valor do seu reajuste salarial é de {reajuste.ToString("C")}.\nSeu novo salário é {(salario + reajuste).ToString("C")}.");
    }
}

