namespace Exercicio2.Model;

public class Funcionario
{
    private int id;
    private string nome = string.Empty;
    private int cargo;
    private decimal salario;
    private DateOnly dataAdmissao;
    
    //Método Construtor
    public Funcionario(int id, string nome, int cargo, decimal salario, DateOnly dataAdmissao)
    {
        this.id = id;
        this.nome = nome;
        this.cargo = cargo;
        this.salario = salario;
        this.dataAdmissao = dataAdmissao;
    }
    
    //Métodos Getters e Setters
    public int GetId()
    {
        return id;
    }
    
    public void SetId(int id)
    {
        this.id = id;
    }
    
    public string GetNome()
    {
        return nome;
    }
    
    public void SetNome(string nome)
    {
        this.nome = nome;
    }
    
    public int GetCargo()
    {
        return cargo;
    }
    
    public void SetCargo(int cargo)
    {
        this.cargo = cargo;
    }
    
    public decimal GetSalario()
    {
        return salario;
    }
    
    public void SetSalario(decimal salario)
    {
        this.salario = salario;
    }
    
    public DateOnly GetDataAdmissao()
    {
        return dataAdmissao;
    }
    
    public void SetDataAdmissao(DateOnly dataAdmissao)
    {
        this.dataAdmissao = dataAdmissao;
    }
    
    //Métodos da classe
    public void Visualizar()
    {
        string cargo = string.Empty;

        switch (this.cargo)
        {
            case 1:
                cargo = "Estagiário";
                break;
            case 2:
                cargo = "Analista";
                break;
            case 3:
                cargo = "Gerente";
                break;
            case 4:
                cargo = "Diretor";
                break;
        }
        
        Console.WriteLine($"\nFuncionário {this.id}\n" +
                          "********************************" +
                          "\nNome: " + this.nome + 
                          "\nCargo: " + cargo + 
                          "\nSalário: " + this.salario.ToString("C") + 
                          "\nData de Admissão: " + this.dataAdmissao +
                          "\n********************************");
    }
}