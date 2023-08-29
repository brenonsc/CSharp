namespace Lista;

class Program
{
    static void Main(string[] args)
    {
        List<double> notas = new List<double>();
        
        notas.Add(7.0);
        notas.Add(5.0);
        notas.Add(4.0);
        notas.Add(7.0);
        notas.Add(10.0);

        foreach (double nota in notas)
        {
            Console.WriteLine(nota);
        }
        
        Console.WriteLine("Posição da nota 4.0: " + notas.IndexOf(4.0));
        Console.WriteLine("A nota 4.0 existe na lista? " + notas.Contains(4.0));
        
        notas.Remove(4.0);
        
        foreach (double nota in notas)
        {
            Console.WriteLine(nota);
        }
        
        Console.WriteLine("Posição da nota 10.0: " + notas.IndexOf(10.0));
        Console.WriteLine("Quantos elementos tem na lista? " + notas.Count);
        
        notas.Sort();
        
        foreach (double nota in notas)
        {
            Console.WriteLine(nota);
        }

        notas.Reverse();
        
        foreach (double nota in notas)
        {
            Console.WriteLine(nota);
        }

        //Alteração de item da lista
        notas[0] = 9.0;
        
        foreach (var nota in notas)
        {
            Console.WriteLine(nota);
        }
    }
}

