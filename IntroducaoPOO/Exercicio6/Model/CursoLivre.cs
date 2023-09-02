namespace Exercicio6.Model;

public class CursoLivre : Curso
{
    private string preRequisitos = string.Empty;
    
    //Método Construtor
    public CursoLivre(string titulo, string descricao, int duracao, DateOnly dataInicio, decimal valor, string preRequisitos) : base(titulo, descricao, duracao, dataInicio, valor)
    {
        this.preRequisitos = preRequisitos;
    }
    
    //Métodos Getters e Setters
    public string GetPreRequisitos()
    {
        return preRequisitos;
    }
    
    public void SetPreRequisitos(string preRequisitos)
    {
        this.preRequisitos = preRequisitos;
    }
    
    //Método Visualizar
    public override void Visualizar()
    {
        base.Visualizar();
        Console.WriteLine($"Pré-requisitos: {preRequisitos}" +
                          "\n*********************************************************************************************************************************************************");
    }
}