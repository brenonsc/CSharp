namespace Exercicio6.Model;

public class Especializacao : Curso
{
    private bool temDiploma;
    
    //Método Construtor
    public Especializacao(string titulo, string descricao, int duracao, DateOnly dataInicio, decimal valor, bool temDiploma) : base(titulo, descricao, duracao, dataInicio, valor)
    {
        this.temDiploma = temDiploma;
    }
    
    //Métodos Getters e Setters
    public bool GetTemDiploma()
    {
        return temDiploma;
    }
    
    public void SetTemDiploma(bool temDiploma)
    {
        this.temDiploma = temDiploma;
    }
    
    //Método Visualizar
    public override void Visualizar()
    {
        string diploma = temDiploma ? "Sim" : "Não";
        
        base.Visualizar();
        Console.WriteLine($"Diploma ao final do curso: {diploma}" +
                          "\n*********************************************************************************************************************************************************");
    }
}