namespace Exercicio3.Model;

public class Jogo
{
    private string titulo = string.Empty;
    private string plataformas = string.Empty;
    private string genero = string.Empty;
    private int notaMetacritic;
    private string desenvolvedora = string.Empty;
    
    //Método Construtor
    public Jogo(string titulo, string plataformas, string genero, int notaMetacritic, string desenvolvedora)
    {
        this.titulo = titulo;
        this.plataformas = plataformas;
        this.genero = genero;
        this.notaMetacritic = notaMetacritic;
        this.desenvolvedora = desenvolvedora;
    }
    
    //Métodos Getters e Setters
    public string GetTitulo()
    {
        return titulo;
    }
    
    public void SetTitulo(string titulo)
    {
        this.titulo = titulo;
    }
    
    public string GetPlataformas()
    {
        return plataformas;
    }
    
    public void SetPlataformas(string plataformas)
    {
        this.plataformas = plataformas;
    }
    
    public string GetGenero()
    {
        return genero;
    }
    
    public void SetGenero(string genero)
    {
        this.genero = genero;
    }
    
    public int GetNotaMetacritic()
    {
        return notaMetacritic;
    }
    
    public void SetNotaMetacritic(int notaMetacritic)
    {
        this.notaMetacritic = notaMetacritic;
    }
    
    public string GetDesenvolvedora()
    {
        return desenvolvedora;
    }
    
    public void SetDesenvolvedora(string desenvolvedora)
    {
        this.desenvolvedora = desenvolvedora;
    }
    
    //Método para visualizar os dados do jogo
    public void Visualizar()
    {
        Console.WriteLine($"\n\n{this.titulo.ToUpper()}\n" +
                          "*************************************************************" +
                          "\nPlataformas: " + this.plataformas + 
                          "\nGênero: " + this.genero +
                          "\nNota Metacritic: " + this.notaMetacritic +
                          "\nDesenvolvedora: " + this.desenvolvedora +
                          "\n*************************************************************");
    }
}