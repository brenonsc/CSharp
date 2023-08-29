namespace Pilha;

class Program
{
    static void Main(string[] args)
    {
        Stack<string> pilha = new Stack<string>();
        
        pilha.Push("Breno");
        pilha.Push("Eduardo");
        pilha.Push("Julia");
        pilha.Push("Leonardo");
        pilha.Push("Gaspar");

        pilha.Pop();
        foreach (var nome in pilha)
        {
            Console.WriteLine(nome);
        }
        
        Console.WriteLine("\nPrimeiro da pilha: " + pilha.Peek());
        Console.WriteLine("O Gaspar entrou na pilha? " + pilha.Contains("Gaspar"));
        Console.WriteLine("Quantos elementos tem na pilha? " + pilha.Count);
    }
}

