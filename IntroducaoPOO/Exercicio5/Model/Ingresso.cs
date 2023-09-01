namespace Exercicio5.Model;

public class Ingresso
{
    private int id;
    private string evento = string.Empty;
    private string local = string.Empty;
    private DateTime dataHora;
    private decimal preco;
    
    //Método Construtor
    public Ingresso(int id, string evento, string local, DateTime dataHora, decimal preco)
    {
        this.id = id;
        this.evento = evento;
        this.local = local;
        this.dataHora = dataHora;
        this.preco = preco;
    }
    
    //Métodos Getters e Setters
    public int GetId()
    {
        return id;
    }
    
    public void SetId(int id)
    {
        this.id = id;
    }
    
    public string GetEvento()
    {
        return evento;
    }
    
    public void SetEvento(string evento)
    {
        this.evento = evento;
    }
    
    public string GetLocal()
    {
        return local;
    }
    
    public void SetLocal(string local)
    {
        this.local = local;
    }
    
    public DateTime GetDataHora()
    {
        return dataHora;
    }
    
    public void SetDataHora(DateTime dataHora)
    {
        this.dataHora = dataHora;
    }
    
    public decimal GetPreco()
    {
        return preco;
    }
    
    public void SetPreco(decimal preco)
    {
        this.preco = preco;
    }
    
    //Método Visualizar
    public void Visualizar()
    {
        Console.WriteLine("\nDados do Ingresso\n" +
                          "***************************************************\n" +
                          $"ID: {this.id}\n" +
                          $"Evento: {this.evento}\n" +
                          $"Local: {this.local}\n" +
                          $"Data e Hora: {this.dataHora.ToString("f")}\n" +
                          $"Preço: {this.preco.ToString("C")}" +
                          "\n***************************************************");
    }
}