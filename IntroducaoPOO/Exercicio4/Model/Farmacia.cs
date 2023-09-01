namespace Exercicio4.Model;

public class Farmacia
{
    private string nome = string.Empty;
    private string principioAtivo = string.Empty;
    private string laboratorio = string.Empty;
    private decimal preco;
    private string dosagem = string.Empty;
    
    //Método Construtor
    public Farmacia(string nome, string principioAtivo, string laboratorio, decimal preco, string dosagem)
    {
        this.nome = nome;
        this.principioAtivo = principioAtivo;
        this.laboratorio = laboratorio;
        this.preco = preco;
        this.dosagem = dosagem;
    }
    
    //Métodos Getters e Setters
    public string GetNome()
    {
        return nome;
    }
    
    public void SetNome(string nome)
    {
        this.nome = nome;
    }
    
    public string GetPrincipioAtivo()
    {
        return principioAtivo;
    }
    
    public void SetPrincipioAtivo(string principioAtivo)
    {
        this.principioAtivo = principioAtivo;
    }
    
    public string GetLaboratorio()
    {
        return laboratorio;
    }
    
    public void SetLaboratorio(string laboratorio)
    {
        this.laboratorio = laboratorio;
    }
    
    public decimal GetPreco()
    {
        return preco;
    }
    
    public void SetPreco(decimal preco)
    {
        this.preco = preco;
    }
    
    public string GetDosagem()
    {
        return dosagem;
    }
    
    public void SetDosagem(string dosagem)
    {
        this.dosagem = dosagem;
    }
    
    //Método para visualizar os dados
    public void Visualizar()
    {
        Console.WriteLine($"\n{this.nome.ToUpper()}\n" +
                          "************************************" +
                          "\nPrincípio Ativo: " + this.principioAtivo + 
                          "\nLaboratório: " + this.laboratorio + 
                          "\nDosagem: " + this.dosagem +
                          "\nPreço: " + this.preco.ToString("C") + 
                          "\n************************************");
    }
}