namespace Transportes;

public class Transporte
{
    private int capacidade;
    
    public Transporte(int capacidade)
    {
        this.capacidade = capacidade;
    }
    
    //Métodos Getters e Setters
    public int GetCapacidade()
    {
        return capacidade;
    }
    
    public void SetCapacidade(int capacidade)
    {
        this.capacidade = capacidade;
    }
    
    public virtual void Visualizar()
    {
        Console.WriteLine("******************************");
        Console.WriteLine("     Dados do Transporte      ");
        Console.WriteLine("******************************");
        Console.WriteLine($"Capacidade: {this.capacidade} pessoas");
    }
}