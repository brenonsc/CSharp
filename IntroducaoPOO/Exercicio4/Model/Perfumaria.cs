namespace Exercicio4.Model;

public class Perfumaria : Farmacia
{
    private string fragrancia = string.Empty;
    private string marca = string.Empty;

    //Método Construtor
    public Perfumaria(int id, string nome, string descricao, decimal preco, int estoque, string marca,
        string fragrancia) : base(id, nome, descricao, preco, estoque)
    {
        this.marca = marca;
        this.fragrancia = fragrancia;
    }

    //Métodos Getters e Setters
    public string GetMarca()
    {
        return marca;
    }

    public void SetMarca(string marca)
    {
        this.marca = marca;
    }

    public string GetFragrancia()
    {
        return fragrancia;
    }

    public void SetFragrancia(string fragrancia)
    {
        this.fragrancia = fragrancia;
    }

    //Método Visualizar
    public override void Visualizar()
    {
        base.Visualizar();
        Console.WriteLine($"Marca: {marca}\n" +
                          $"Fragrância: {fragrancia}\n" +
                          "************************************");
    }
}