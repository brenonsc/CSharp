namespace Exercicio6;

class Program
{
    static void Main(string[] args)
    {
        string nome;
        int codigoCargo;
        float salario;
        
        Console.Write("Digite o nome do funcionário: ");
        nome = Console.ReadLine();
        
        Console.Write("Digite o salário do funcionário: R$ ");
        salario = float.Parse(Console.ReadLine());
        
        Console.WriteLine("\nCARGOS\n--------------------\n1 - Gerente\n2 - Vendedor\n3 - Supervisor\n4 - Motorista\n5 - Estoquista\n6 - Técnico de TI\n--------------------\n");

        Console.Write("Digite o código do cargo (1~6): ");
        codigoCargo = int.Parse(Console.ReadLine());
        
        switch (codigoCargo)
        {
            case 1:
                Console.WriteLine($"\nNome do colaborador: {nome}\nCargo: Gerente\nSalário reajustado: {(salario + salario * 0.1f).ToString("C")}");
                break;
            case 2:
                Console.WriteLine($"\nNome do colaborador: {nome}\nCargo: Vendedor\nSalário reajustado: {(salario + salario * 0.07f).ToString("C")}");
                break;
            case 3:
                Console.WriteLine($"\nNome do colaborador: {nome}\nCargo: Supervisor\nSalário reajustado: {(salario + salario * 0.09f).ToString("C")}");
                break;
            case 4:
                Console.WriteLine($"\nNome do colaborador: {nome}\nCargo: Motorista\nSalário reajustado: {(salario + salario * 0.06f).ToString("C")}");
                break;
            case 5:
                Console.WriteLine($"\nNome do colaborador: {nome}\nCargo: Estoquista\nSalário reajustado: {(salario + salario * 0.05f).ToString("C")}");
                break;
            case 6:
                Console.WriteLine($"\nNome do colaborador: {nome}\nCargo: Técnico de TI\nSalário reajustado: {(salario + salario * 0.08f).ToString("C")}");
                break;
            default:
                Console.WriteLine("\nCódigo inválido!");
                break;
        }
    }
}

