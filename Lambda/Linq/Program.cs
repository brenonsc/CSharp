namespace Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        List<string> nomes = new List<string>() {"João", "Breno", "Julia", "Samantha", "Vitor 1", "Vitor 2", "Victor", "Matheus", "Matheus", "Karina", "Carolina"};
        
        var numerosAoCubo = numeros.Select(n => Math.Pow(n, 3));
        
        Console.WriteLine("Números elevados ao cubo: " + string.Join(", ", numerosAoCubo));
        
        var numerosImpares = from numero in numeros
                             where numero % 2 != 0
                             select(numero);
        
        Console.WriteLine("Números ímpares: " + string.Join(", ", numerosImpares));
        
        var nomesIniciadosComMeV = from nome in nomes
                                   where nome.ToUpper().StartsWith("M") || nome.ToUpper().StartsWith("V")
                                   select(nome);
        
        Console.WriteLine("Nomes iniciados com M ou V: " + string.Join(", ", nomesIniciadosComMeV));
        
        var nomesContemC = (from nome in nomes
                           where nome.ToUpper().Contains("C")
                           select nome).ToList();

        //nomesContemC.ForEach(n => Console.WriteLine(n)) -> Funciona por conta do ToList();
        
        Console.WriteLine("Nomes que contém a letra C: " + string.Join(", ", nomesContemC));
        
        var numerosOrdemCrescente = from numero in numeros
                               orderby numero
                               select(numero);
        
        Console.WriteLine("Números ordenados crescente: " + string.Join(", ", numerosOrdemCrescente));
        
        var numerosOrdemDecrescente = from numero in numeros
                                      orderby numero descending
                                      select(numero);
        
        Console.WriteLine("Números ordenados decrescente: " + string.Join(", ", numerosOrdemDecrescente));
        
        var nomesSemDuplicidade = nomes.Distinct();
        
        Console.WriteLine("Nomes sem repetição: " + string.Join(", ", nomesSemDuplicidade));
        
        var contarVitors = nomes.Count(n => n.ToUpper() == "VITOR");
        
        Console.WriteLine("Quantidade de Vitors: " + contarVitors);
        
        var primeiroVitor = nomes.First(n => n.ToUpper() == "VITOR");
        
        Console.WriteLine("Primeiro Vitor: " + primeiroVitor);
    }
}

