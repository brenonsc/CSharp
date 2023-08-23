namespace Exercicio4;

class Program
{
    static void Main(string[] args)
    {
        float[] numeros = new float[4];
        float diferenca;
        
        for(int i=0; i < numeros.Length; i++)
        {
            Console.WriteLine($"Digite o {i+1}° número: ");
            numeros[i] = float.Parse(Console.ReadLine());
        }
        
        diferenca = (numeros[0]*numeros[1]) - (numeros[2]*numeros[3]);
        
        Console.WriteLine($"\nDiferença: {diferenca.ToString("N1")}");
    }
}

