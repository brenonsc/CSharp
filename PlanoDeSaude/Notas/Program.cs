namespace Notas;

class Program
{
    static void Main(string[] args)
    {
        float nota1, nota2, media;
        
        Console.Write("Digite a primeira nota: ");
        nota1 = float.Parse(Console.ReadLine());
        
        Console.Write("Digite a segunda nota: ");
        nota2 = float.Parse(Console.ReadLine());
        
        media = (nota1 + nota2) / 2;

        Console.WriteLine((media>=6) ? "\nAprovado!" : "\nReprovado!");
    }
}

