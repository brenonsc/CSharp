namespace Exercicio2.Model;

public class Vendedor : Funcionario
{
    private int metaVendas;
    
    //Método Construtor
    public Vendedor(int id, string nome, int cargo, decimal salario, DateOnly dataAdmissao, int metaVendas) : base(id, nome, cargo, salario, dataAdmissao)
    {
        this.metaVendas = metaVendas;
    }
    
    //Métodos Getters e Setters
    public int GetMetaVendas()
    {
        return metaVendas;
    }
    
    public void SetMetaVendas(int metaVendas)
    {
        this.metaVendas = metaVendas;
    }
    
    //Método para visualizar os dados do Vendedor
    public override void Visualizar()
    {
        base.Visualizar();
        Console.WriteLine($"Meta de Vendas: {metaVendas}\n" +
                          $"********************************");
    }
}