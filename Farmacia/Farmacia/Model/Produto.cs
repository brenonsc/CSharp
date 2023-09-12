namespace Farmacia.Model;

public abstract class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public int Tipo { get; set; }
    public decimal Preco { get; set; }
    
    public Produto(int id, string nome, int tipo, decimal preco)
    {
        Id = id;
        Nome = nome;
        Tipo = tipo;
        Preco = preco;
    }
    
    public virtual void Visualizar()
    {
        string tipo = "";

        switch (Tipo)
        {
            case 1:
                tipo = "Medicamento";
                break;
            case 2:
                tipo = "Cosmético";
                break;
        }

        Console.WriteLine($"\nDados do Produto: {Id}\n" +
                          "**************************" +
                          "\nNome: " + Nome +
                          "\nTipo: " + tipo +
                          "\nPreço: " + Preco.ToString("C"));
    }
}