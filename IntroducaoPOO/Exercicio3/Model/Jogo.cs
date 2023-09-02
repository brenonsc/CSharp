namespace Exercicio3.Model;

public class Jogo : Produto
{
    private string desenvolvedora = string.Empty;
    private string genero = string.Empty;
    private int notaMetacritic;
    private string plataformas = string.Empty;

    //Método Construtor
    public Jogo(int id, string nome, string descricao, decimal preco, int estoque, string plataformas, string genero,
        int notaMetacritic, string desenvolvedora) : base(id, nome, descricao, preco, estoque)
    {
        this.plataformas = plataformas;
        this.genero = genero;
        this.notaMetacritic = notaMetacritic;
        this.desenvolvedora = desenvolvedora;
    }

    //Métodos Getters e Setters
    public string GetPlataformas()
    {
        return plataformas;
    }

    public void SetPlataformas(string plataformas)
    {
        this.plataformas = plataformas;
    }

    public string GetGenero()
    {
        return genero;
    }

    public void SetGenero(string genero)
    {
        this.genero = genero;
    }

    public int GetNotaMetacritic()
    {
        return notaMetacritic;
    }

    public void SetNotaMetacritic(int notaMetacritic)
    {
        this.notaMetacritic = notaMetacritic;
    }

    public string GetDesenvolvedora()
    {
        return desenvolvedora;
    }

    public void SetDesenvolvedora(string desenvolvedora)
    {
        this.desenvolvedora = desenvolvedora;
    }

    //Método para visualizar os dados do Jogo
    public override void Visualizar()
    {
        base.Visualizar();
        Console.WriteLine($"Plataformas: {plataformas}\n" +
                          $"Gênero: {genero}\n" +
                          $"Nota Metacritic: {notaMetacritic}\n" +
                          $"Desenvolvedora: {desenvolvedora}\n" +
                          "*************************************************************");
    }
}