using System.Runtime.ConstrainedExecution;

namespace TratamentoExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 0;
            int numero2 = 0;
            bool loop = true;

            do
            {
                try
                {
                    Console.WriteLine("Digite o Dividendo: ");
                    numero1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Digite o Divisor: ");
                    numero2 = Convert.ToInt32(Console.ReadLine());

                    divide(numero1, numero2);

                    loop = false;
                }

                catch (FormatException ex)
                {
                    //Console.Error.WriteLine($"Exceção: {ex.Message}");
                    Console.WriteLine("\nDigite valores inteiros!");
                }
                catch (DivideByZeroException ex)
                {
                    //Console.Error.WriteLine($"Exceção: {ex}");
                    Console.WriteLine("\nDigite valores inteiros diferentes de 0!");
                }
                finally
                {
                    //Console.WriteLine("Sempre será executado.\n");
                }
            }
            while (loop);
        }

        public static void divide(int dividendo, int divisor)
        {
            Console.WriteLine("Divisão = " + (dividendo / divisor));
        }
    }
}