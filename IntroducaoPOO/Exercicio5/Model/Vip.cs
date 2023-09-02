namespace Exercicio5.Model;

public class Vip : Ingresso
{
    public decimal valorVip;
    
    //Método Construtor
    public Vip(int id, string evento, string local, DateTime dataHora, string setor, decimal valorVip) : base(id, evento, local, dataHora, setor)
    {
        this.valorVip = valorVip;
    }
    
    //Métodos Getters e Setters
    public decimal GetValorVip()
    {
        return valorVip;
    }
    
    public void SetValorVip(decimal valorVip)
    {
        this.valorVip = valorVip;
    }
    
    //Método Visualizar
    public override void Visualizar()
    {
        base.Visualizar();
        Console.WriteLine($"Valor da Entrada VIP: {valorVip.ToString("C")}" +
                          "\n***************************************************");
    }
}