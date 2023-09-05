namespace TratamentoExceptions_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;
            bool loop = true;

            do
            {
                try
                {
                    Console.WriteLine("\nDigite uma idade: ");
                    idade = Convert.ToInt32(Console.ReadLine());

                    ValidarIdade(idade);

                    loop = false;
                }

                catch (ArithmeticException ex)
                {
                    Console.WriteLine("Digite uma idade maior ou igual a 18 anos!");
                }
            }
            while (loop);
        }

        public static void ValidarIdade(int idade)
        {
            if (idade < 18)
                throw new ArithmeticException("A pessoa não pode dirigir!");
            else
                Console.WriteLine("A pessoa pode dirigir!");
        }

    }
}