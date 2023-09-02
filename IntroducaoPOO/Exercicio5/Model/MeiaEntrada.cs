namespace Exercicio5.Model;

public class MeiaEntrada : Ingresso
{
    private decimal valorMeiaEntrada;
    
    //Método Construtor
    public MeiaEntrada(int id, string evento, string local, DateTime dataHora, string setor, decimal valorMeiaEntrada) : base(id, evento, local, dataHora, setor)
    {
        this.valorMeiaEntrada = valorMeiaEntrada;
    }
    
    //Métodos Getters e Setters
    public decimal GetValorMeiaEntrada()
    {
        return valorMeiaEntrada;
    }
    
    public void SetValorMeiaEntrada(decimal valorMeiaEntrada)
    {
        this.valorMeiaEntrada = valorMeiaEntrada;
    }
    
    //Método Visualizar
    public override void Visualizar()
    {
        base.Visualizar();
        Console.WriteLine($"Valor da Meia Entrada: {valorMeiaEntrada.ToString("C")}" +
                          "\n***************************************************");
    }
}