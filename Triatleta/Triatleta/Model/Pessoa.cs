namespace Triatleta.Model;

public class Pessoa
{
    private string nome;
    
    //Construtor
    public Pessoa(string nome)
    {
        this.nome = nome;
    }
    
    //Métodos Getters e Setters
    public string GetNome()
    {
        return nome;
    }
    
    public void SetNome(string nome)
    {
        this.nome = nome;
    }
    
    public void Cansou()
    {
        Console.WriteLine("Cansou...");
    }
}