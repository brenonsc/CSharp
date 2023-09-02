namespace Exercicio1.Model;

public class PessoaJuridica : Cliente
{
    private string cnpj = string.Empty;
    
    //Construtor
    public PessoaJuridica(int id, string nome, string endereco, string email, string telefone, string cnpj) : base(id, nome, endereco, email, telefone)
    {
        this.cnpj = cnpj;
    }
    
    //Métodos Getters e Setters
    public string GetCnpj()
    {
        return cnpj;
    }
    
    public void SetCnpj(string cnpj)
    {
        this.cnpj = cnpj;
    }
    
    //Método para validar o CNPJ
    public bool ValidarCnpj()
    {
        int[] multiplicador1 = new int[12] {5,4,3,2,9,8,7,6,5,4,3,2};
        int[] multiplicador2 = new int[13] {6,5,4,3,2,9,8,7,6,5,4,3,2};
        int soma;
        int resto;
        string digito;
        string tempCnpj;
        cnpj = cnpj.Trim();
        cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
        if (cnpj.Length != 14)
            return false;
        tempCnpj = cnpj.Substring(0, 12);
        soma = 0;
        for(int i=0; i<12; i++)
            soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
        resto = (soma % 11);
        if ( resto < 2)
            resto = 0;
        else
            resto = 11 - resto;
        digito = resto.ToString();
        tempCnpj = tempCnpj + digito;
        soma = 0;
        for (int i = 0; i < 13; i++)
            soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
        resto = (soma % 11);
        if (resto < 2)
            resto = 0;
        else
            resto = 11 - resto;
        digito = digito + resto.ToString();
        return cnpj.EndsWith(digito);
    }
    
    //Método para formatar o CNPJ
    public static string FormataCnpj(string number) 
    {
        if (number.Length != 14) throw new ArgumentException($"O número não corresponde ao padrão CNPJ.", nameof(number));
        ReadOnlySpan<char> span = stackalloc char[number.Length];
        span = number.AsSpan();
        return $"{span[0..2]}.{span[2..5]}.{span[5..8]}/{span[8..12]}-{span[12..]}";
    }
    
    //Método para validar e formatar o CNPJ
    public string ValidarFormatarCnpj()
    {
        if (ValidarCnpj())
        {
            return FormataCnpj(this.cnpj);
        }
        else
        {
            return "CNPJ inválido!";
        }
    }
    
    //Método para visualizar os dados da Pessoa Jurídica
    public override void Visualizar()
    { 
        base.Visualizar();
        Console.WriteLine("CNPJ: " + ValidarFormatarCnpj() + 
                          "\n********************************");
    }
}