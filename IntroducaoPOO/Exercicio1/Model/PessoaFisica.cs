using System.Globalization;

namespace Exercicio1.Model;

public class PessoaFisica : Cliente
{
    private string cpf = string.Empty;
    
    //Construtor
    public PessoaFisica(int id, string nome, string endereco, string email, string telefone, string cpf) : base(id, nome, endereco, email, telefone)
    {
        this.cpf = cpf;
    }
    
    //Métodos Getters e Setters
    public string GetCpf()
    {
        return cpf;
    }
    
    public void SetCpf(string cpf)
    {
        this.cpf = cpf;
    }
    
    //Método para validar o CPF
    public bool ValidarCpf(string cpf)
    {
        if (cpf.Length != 11)
        {
            return false;
        }
        
        int[] multiplicador1 = {10, 9, 8, 7, 6, 5, 4, 3, 2};
        int[] multiplicador2 = {11, 10, 9, 8, 7, 6, 5, 4, 3, 2};
        
        string tempCpf;
        string digito;
        int soma;
        int resto;
        
        cpf = cpf.Trim();
        cpf = cpf.Replace(".", "").Replace("-", "");
        
        tempCpf = cpf.Substring(0, 9);
        soma = 0;
        
        for (int i = 0; i < 9; i++)
        {
            soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
        }
        
        resto = soma % 11;
        
        if (resto < 2)
        {
            resto = 0;
        }
        else
        {
            resto = 11 - resto;
        }
        
        digito = resto.ToString();
        tempCpf += digito;
        soma = 0;
        
        for (int i = 0; i < 10; i++)
        {
            soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
        }
        
        resto = soma % 11;
        
        if (resto < 2)
        {
            resto = 0;
        }
        else
        {
            resto = 11 - resto;
        }
        
        digito += resto.ToString();
        
        return cpf.EndsWith(digito);
    }
    
    //Método para formatar o CPF
    public string FormatarCpf()
    {
        return this.cpf.Insert(3, ".").Insert(7, ".").Insert(11, "-");
    }
    
    //Método para validar e formatar o CPF
    public string ValidarFormatarCpf(string cpf)
    {
        if (ValidarCpf(this.cpf))
        {
            return FormatarCpf();
        }
        else
        {
            return "CPF inválido!";
        }
    }
    
    //Método para visualizar os dados da pessoa física
    public override void Visualizar()
    {
        base.Visualizar();
        Console.WriteLine("CPF: " + ValidarFormatarCpf(this.cpf) + 
                          "\n********************************");
    }
}