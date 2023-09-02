namespace Exercicio2.Model;

public class Gerente : Funcionario
{
    private int departamento;
    
    //Método Construtor
    public Gerente(int id, string nome, int cargo, decimal salario, DateOnly dataAdmissao, int departamento) : base(id, nome, cargo, salario, dataAdmissao)
    {
        this.departamento = departamento;
    }
    
    //Métodos Getters e Setters
    public int GetDepartamento()
    {
        return departamento;
    }
    
    public void SetDepartamento(int departamento)
    {
        this.departamento = departamento;
    }
    
    //Método para visualizar os dados do Gerente
    public override void Visualizar()
    {
        string departamento = string.Empty;

        switch (this.departamento)
        {
            case 1:
                departamento = "Financeiro";
                break;
            case 2:
                departamento = "Comercial";
                break;
            case 3:
                departamento = "Produção";
                break;
            case 4:
                departamento = "RH";
                break;
            case 5:
                departamento = "TI";
                break;
            default:
                departamento = "Departamento não informado";
                break;
        }
        
        base.Visualizar();
        Console.WriteLine($"Departamento: {departamento}\n" +
                          $"********************************");
    }
}