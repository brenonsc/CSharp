namespace Fila;

class Program
{
    static void Main(string[] args)
    {
        Queue<string> fila = new Queue<string>();
        
        fila.Enqueue("Breno");
        fila.Enqueue("Eduardo");
        fila.Enqueue("Julia");
        fila.Enqueue("Leonardo");
        fila.Enqueue("Gaspar");

        fila.Dequeue();
        foreach (var nome in fila)
        {
            Console.WriteLine(nome);
        }
        
        Console.WriteLine("\nPrimeiro da fila: " + fila.Peek());
        Console.WriteLine("O Gaspar entrou na fila? " + fila.Contains("Gaspar"));
        Console.WriteLine("Quantos elementos tem na fila? " + fila.Count);
    }
}

