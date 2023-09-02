namespace Exercicio5.Model;

public class Ingresso
{
    private DateTime dataHora;
    private string evento = string.Empty;
    private int id;
    private string local = string.Empty;
    private string setor = string.Empty;

    //Método Construtor
    public Ingresso(int id, string evento, string local, DateTime dataHora, string setor)
    {
        this.id = id;
        this.evento = evento;
        this.local = local;
        this.dataHora = dataHora;
        this.setor = setor;
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

    public string GetSetor()
    {
        return setor;
    }

    public void SetSetor(string setor)
    {
        this.setor = setor;
    }

    //Método Visualizar
    public virtual void Visualizar()
    {
        Console.WriteLine("\nDados do Ingresso\n" +
                          "***************************************************\n" +
                          $"ID: {this.id}\n" +
                          $"Evento: {this.evento}\n" +
                          $"Local: {this.local}\n" +
                          $"Data e Hora: {this.dataHora.ToString("f")}\n" +
                          $"Setor: {this.setor}");
    }
}