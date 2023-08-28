namespace Exercicio4;

class Program
{
    static void Main(string[] args)
    {
        float [,] matriz = new float[10,4];
        float[] media = new float[10];
        
        for(int i = 0; i < matriz.GetLength(0); i++)
        {
            for(int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write($"Digite a nota {j + 1} do aluno {i + 1}: ");
                matriz[i, j] = float.Parse(Console.ReadLine());
            }
            Console.Write("\n");
        }

        for(int i = 0; i < matriz.GetLength(0); i++)
        {
            for(int j = 0; j < matriz.GetLength(1); j++)
            {
                media[i] += matriz[i, j];
            }
            media[i] = media[i]/4;
        }
        
        Console.WriteLine("\nMédias:");
        for(int i = 0; i < matriz.GetLength(0); i++)
        {
            Console.WriteLine($"Aluno {i + 1}: {media[i].ToString("F1")}");
        }
    }
}

