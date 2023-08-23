namespace Exercicio2;

class Program
{
    static void Main(string[] args)
    {
        float[] notas = new float[4];
        float soma = 0;
        
        for(int i=0; i < notas.Length; i++)
        {
            Console.WriteLine($"Digite a {i+1}ª nota: ");
            notas[i] = float.Parse(Console.ReadLine());
            
            soma += notas[i];
        }
        
        float media = soma / notas.Length;
        
        Console.WriteLine($"\nMédia: {media.ToString("N1")}");
    }
}

