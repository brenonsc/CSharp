namespace Exercicio3;

class Program
{
    static void Main(string[] args)
    {
        int[,] matriz = new int[3,3];
        int somaPrincipal = 0, somaSecundaria = 0;
        
        for(int i = 0; i < matriz.GetLength(0); i++)
        {
            for(int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write($"Matriz [{i}][{j}] = ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }
        
        Console.WriteLine("\nDiagonal principal:");
        for(int i = 0; i < matriz.GetLength(0); i++)
        {
            for(int j = 0; j < matriz.GetLength(1); j++)
            {
                if (i == j)
                {
                    Console.Write($"{matriz[i, j]} ");
                    
                    somaPrincipal += matriz[i, j];
                }
            }
        }
        
        Console.WriteLine("\n\nDiagonal secundária:");
        for(int i = 0; i < matriz.GetLength(0); i++)
        {
            for(int j = 0; j < matriz.GetLength(1); j++)
            {
                if (i + j == matriz.GetLength(0) - 1)
                {
                    Console.Write($"{matriz[i, j]} ");

                    somaSecundaria += matriz[i, j];
                }
            }
        }
        
        Console.Write($"\n\nSoma dos elementos da diagonal principal: {somaPrincipal}\nSoma dos elementos da diagonal secundária: {somaSecundaria}");
    }
}

