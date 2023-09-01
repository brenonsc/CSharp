namespace Transportes;

public class Terrestre : Transporte
{
    private int rodas;
    private int velocidadeMaxima;
    
    public Terrestre(int capacidade, int rodas, int velocidadeMaxima) : base(capacidade)
    {
        this.rodas = rodas;
        this.velocidadeMaxima = velocidadeMaxima;
    }
    
    //Métodos Getters e Setters
    public int GetRodas()
    {
        return rodas;
    }
    
    public void SetRodas(int rodas)
    {
        this.rodas = rodas;
    }
    
    public int GetVelocidadeMaxima()
    {
        return velocidadeMaxima;
    }
    
    public void SetVelocidadeMaxima(int velocidadeMaxima)
    {
        this.velocidadeMaxima = velocidadeMaxima;
    }

    public override void Visualizar()
    {
        base.Visualizar();
        Console.WriteLine("Número de rodas: " + this.rodas);
        Console.WriteLine("Velocidade máxima: " + this.velocidadeMaxima);
    }
}