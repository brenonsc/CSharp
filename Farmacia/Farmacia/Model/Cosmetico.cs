namespace Farmacia.Model;

public class Cosmetico : Produto
{
    public string Fragrancia { get; set; }
    
    public Cosmetico(int id, string nome, int tipo, decimal preco, string fragrancia) : base(id, nome, tipo, preco)
    {
        Fragrancia = fragrancia;
    }
    
    public override void Visualizar()
    {
        base.Visualizar();
        Console.WriteLine("Fragrância: " + Fragrancia);
    }
}