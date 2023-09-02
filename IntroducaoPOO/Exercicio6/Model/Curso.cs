namespace Exercicio6.Model;

public class Curso
{
    private DateOnly dataInicio;
    private string descricao = string.Empty;
    private int duracao;
    private string titulo = string.Empty;
    private decimal valor;

    //Método Construtor
    public Curso(string titulo, string descricao, int duracao, DateOnly dataInicio, decimal valor)
    {
        this.titulo = titulo;
        this.descricao = descricao;
        this.duracao = duracao;
        this.dataInicio = dataInicio;
        this.valor = valor;
    }

    //Métodos Getters e Setters
    public string GetTitulo()
    {
        return titulo;
    }

    public void SetTitulo(string titulo)
    {
        this.titulo = titulo;
    }

    public string GetDescricao()
    {
        return descricao;
    }

    public void SetDescricao(string descricao)
    {
        this.descricao = descricao;
    }

    public int GetDuracao()
    {
        return duracao;
    }

    public void SetDuracao(int duracao)
    {
        this.duracao = duracao;
    }

    public DateOnly GetDataInicio()
    {
        return dataInicio;
    }

    public void SetDataInicio(DateOnly dataInicio)
    {
        this.dataInicio = dataInicio;
    }

    public decimal GetValor()
    {
        return valor;
    }

    public void SetValor(decimal valor)
    {
        this.valor = valor;
    }

    //Método para visualizar os dados do curso
    public void Visualizar()
    {
        Console.WriteLine($"\n{titulo.ToUpper()}\n" +
                          "*********************************************************************************************************************************************************\n" +
                          $"Descrição: {descricao}\n" +
                          $"Duração: {duracao} horas\n" +
                          $"Data início: {dataInicio}\n" +
                          $"Valor: {valor.ToString("C")}" +
                          "\n*********************************************************************************************************************************************************");
    }
}