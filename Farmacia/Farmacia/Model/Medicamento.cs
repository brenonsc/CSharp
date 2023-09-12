namespace Farmacia.Model;

public class Medicamento : Produto
{
    public string Generico { get; set; }
    
    public Medicamento(int id, string nome, int tipo, decimal preco, string generico) : base(id, nome, tipo, preco)
    {
        Generico = generico;
    }
    
    public override void Visualizar()
    {
        base.Visualizar();
        Console.WriteLine("Nome Genérico: " + Generico);
    }
}