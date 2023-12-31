namespace Exercicio3.Model;

public class VideoGame : Produto
{
    private bool isUsado;
    private string marca = string.Empty;

    //Método Construtor
    public VideoGame(int id, string nome, string descricao, decimal preco, int estoque, string marca, bool isUsado) :
        base(id, nome, descricao, preco, estoque)
    {
        this.marca = marca;
        this.isUsado = isUsado;
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

    public bool GetIsUsado()
    {
        return isUsado;
    }

    public void SetIsUsado(bool isUsado)
    {
        this.isUsado = isUsado;
    }

    //Método para visualizar os dados do VideoGame
    public override void Visualizar()
    {
        var isUsado = string.Empty;

        if (this.isUsado)
            isUsado = "Seminovo";
        else
            isUsado = "Novo";

        base.Visualizar();
        Console.WriteLine($"Marca: {marca}\n" +
                          $"Estado: {isUsado}\n" +
                          "*************************************************************");
    }
}