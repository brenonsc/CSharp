using Metodos2.Namespace01;

namespace Metodos;

class Program
{
    static void Main(string[] args)
    {
        float numero1, numero2, divisao;

        Console.WriteLine("Digite o primeiro número:");
        numero1 = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        numero2 = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine($"\n{numero1} + {numero2} = " + Somar(numero1, numero2));
        Console.WriteLine($"{numero1} - {numero2} = " + Subtrair(numero1, numero2));
        Console.WriteLine($"{numero1} * {numero2} = " + Multiplicar(numero1, numero2));
        divisao = Dividir(numero1, numero2);
        Console.WriteLine(divisao == 0 ? "Não é possível dividir por 0" : $"{numero1} / {numero2} = {divisao}");
        Console.WriteLine($"{numero1} ^ {numero2} = " + Potencia(numero1, numero2));
        Console.WriteLine($"Raiz quadrada de {numero1} = " + RaizQuadrada(numero1));
        
        Classe02.MetodoPublico();
        
        Dev();
    }
    
    static float Somar(float numero1, float numero2)
    {
        return numero1 + numero2;
    }
    
    static float Subtrair(float numero1, float numero2)
    {
        return numero1 - numero2;
    }
    
    static float Multiplicar(float numero1, float numero2)
    {
        return numero1 * numero2;
    }
    
    static float Dividir(float numero1, float numero2)
    {
        if (numero2 > 0)
            return numero1 / numero2;
        else
            return 0;
    }
    
    static double Potencia(float numero1, float numero2)
    {
        return Math.Pow(numero1, numero2);
    }
    
    static double RaizQuadrada(float numero1)
    {
        return Math.Sqrt(numero1);
    }

    static void Dev()
    {
        Console.Write("\nCriado por: Breno Henrique");
    }
}

