namespace Triatleta.Model;

public class Triatleta : Pessoa, ICiclista, ICorredor, INadador
{
    public Triatleta(string nome) : base(nome)
    {
        
    }

    public void Aquecer()
    {
        Console.WriteLine("Aquecendo...");
    }

    public void Nadar()
    {
        Console.WriteLine("Nadando...");
    }

    public void Correr()
    {
        Console.WriteLine("Correndo...");
    }

    public void Pedalar()
    {
        Console.WriteLine("Pedalando...");
    }
}