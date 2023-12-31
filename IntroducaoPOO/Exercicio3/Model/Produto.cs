namespace Exercicio3.Model;

public class Produto
{
    private string descricao = string.Empty;
    private int estoque;
    private int id;
    private string nome = string.Empty;
    private decimal preco;

    //Método Construtor
    public Produto(int id, string nome, string descricao, decimal preco, int estoque)
    {
        this.id = id;
        this.nome = nome;
        this.descricao = descricao;
        this.preco = preco;
        this.estoque = estoque;
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

    public string GetNome()
    {
        return nome;
    }

    public void SetNome(string nome)
    {
        this.nome = nome;
    }

    public string GetDescricao()
    {
        return descricao;
    }

    public void SetDescricao(string descricao)
    {
        this.descricao = descricao;
    }

    public decimal GetPreco()
    {
        return preco;
    }

    public void SetPreco(decimal preco)
    {
        this.preco = preco;
    }

    public int GetEstoque()
    {
        return estoque;
    }

    public void SetEstoque(int estoque)
    {
        this.estoque = estoque;
    }

    //Método para visualizar os dados do jogo
    public virtual void Visualizar()
    {
        Console.WriteLine($"\n\n{nome.ToUpper()}\n" +
                          "*************************************************************" +
                          "\nID: " + id +
                          "\nDescrição: " + descricao +
                          "\nPreço: " + preco.ToString("C") +
                          "\nEstoque: " + estoque);
    }
}