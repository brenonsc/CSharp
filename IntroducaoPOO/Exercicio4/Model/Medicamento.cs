namespace Exercicio4.Model;

public class Medicamento : Farmacia
{
    private string dosagem = string.Empty;
    private string laboratorio = string.Empty;

    //Método Construtor
    public Medicamento(int id, string nome, string descricao, decimal preco, int estoque, string dosagem,
        string laboratorio) : base(id, nome, descricao, preco, estoque)
    {
        this.laboratorio = laboratorio;
        this.dosagem = dosagem;
    }

    //Métodos Getters e Setters
    public string GetLaboratorio()
    {
        return laboratorio;
    }

    public void SetLaboratorio(string laboratorio)
    {
        this.laboratorio = laboratorio;
    }

    public string GetDosagem()
    {
        return dosagem;
    }

    public void SetDosagem(string dosagem)
    {
        this.dosagem = dosagem;
    }

    //Método Visualizar
    public override void Visualizar()
    {
        base.Visualizar();
        Console.WriteLine($"Laboratório: {laboratorio}\n" +
                          $"Dosagem: {dosagem}\n" +
                          "************************************");
    }
}