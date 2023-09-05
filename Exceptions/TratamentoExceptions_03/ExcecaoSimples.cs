using System;
namespace TratamentoExceptions_03
{
    public class ExcecaoSimples : Exception
    {
        public ExcecaoSimples(string message) : base(message)
        {
            Console.Error.WriteLine(message);
            Console.WriteLine("Exceção definida pela pessoa desencolvedora!");
        }
    }
}

