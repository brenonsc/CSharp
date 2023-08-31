namespace Exercicio1.Model;

public class Cliente
{
    private int id;
    private string nome = string.Empty;
    private string endereco = string.Empty;
    private string email = string.Empty;
    private string telefone = string.Empty;
    
    //Método Construtor
    public Cliente(int id, string nome, string endereco, string email, string telefone)
    {
        this.id = id;
        this.nome = nome;
        this.endereco = endereco;
        this.email = email;
        this.telefone = telefone;
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
    
    public string GetEndereco()
    {
        return endereco;
    }
    
    public void SetEndereco(string endereco)
    {
        this.endereco = endereco;
    }
    
    public string GetEmail()
    {
        return email;
    }
    
    public void SetEmail(string email)
    {
        this.email = email;
    }
    
    public string GetTelefone()
    {
        return telefone;
    }
    
    public void SetTelefone(string telefone)
    {
        this.telefone = telefone;
    }
    
    //Métodos da Classe
    public void Visualizar()
    {
        Console.WriteLine($"\nCliente {this.id}\n" +
                          "********************************" +
                          "\nNome: " + this.nome + 
                          "\nEndereço: " + this.endereco + 
                          "\nE-mail: " + this.email + 
                          "\nTelefone: " + FormataTelefone(this.telefone) +
                          "\n********************************");
    }
    
    static string FormataTelefone(string number) 
    {
        if (number.Length != 10 && number.Length != 11) throw new ArgumentException($"O número não corresponde ao padrão telefônico.", nameof(number));
        ReadOnlySpan<char> span = stackalloc char[number.Length];
        span = number.AsSpan();
        var offset = 11 - number.Length;
        return $"({span[0..2]}) {span[2..(7 - offset)]}-{span[(7 - offset)..]}";
    }
}