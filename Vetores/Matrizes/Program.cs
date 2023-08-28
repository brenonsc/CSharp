namespace Matrizes;

class Program
{
    static void Main(string[] args)
    {
        int[,] matriz01 = {{1,2,3}, {4,5,6}, {7,8,9}};
        int[,] matriz02 = new int[4,4];
        int[,] matriz03 = {{1,2,3}, {4,5,6}};
        int[] vetor = { 1, 2, 3, 4, 5 };
        
        for(int iLinha = 0; iLinha < Math.Sqrt(matriz01.Length); iLinha++)
        {
            for(int iColuna = 0; iColuna < 3; iColuna++)
            {
                Console.WriteLine($"matriz01 [{iLinha}][{iColuna}] = {matriz01[iLinha, iColuna]}");
            }
        }
        
        Console.WriteLine("\nDigite o matriz 02:");
        
        for(int iLinha = 0; iLinha < Math.Sqrt(matriz02.Length); iLinha++)
        {
            for(int iColuna = 0; iColuna < 3; iColuna++)
            {
                Console.Write($"matriz[{iLinha}][{iColuna}] = ");
                matriz02[iLinha, iColuna] = int.Parse(Console.ReadLine());
            }
        }
        
        Console.WriteLine("\nMatriz02:");
        for(int iLinha = 0; iLinha < Math.Sqrt(matriz02.Length); iLinha++)
        {
            for(int iColuna = 0; iColuna < 3; iColuna++)
            {
                Console.WriteLine($"matriz02 [{iLinha}][{iColuna}] = {matriz02[iLinha, iColuna]}");
            }
        }
        
        Console.WriteLine("\nMatriz03:");
        for (int iLinha = 0; iLinha < matriz03.GetLength(0); iLinha++)
        {
            for(int iColuna = 0; iColuna < matriz03.GetLength(1); iColuna++)
            {
                Console.WriteLine($"matriz03 [{iLinha}][{iColuna}] = {matriz03[iLinha, iColuna]}");
            }
        }

        foreach (int elemento in vetor)
        {
            Console.WriteLine(elemento);
        }

        foreach (int elemento in matriz01)
        {
            if(elemento % 3 == 0)
                Console.WriteLine(elemento);
        }
    }
}

