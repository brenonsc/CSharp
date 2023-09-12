using Farmacia.Model;
using Farmacia.Repository;
namespace Farmacia.Controller;

public class ProdutoController : IProdutoRepository
{
    private readonly List<Produto> listaProdutos = new();
    int id = 0;
    
    public void ProcurarPorNumero(int id)
    {
        var produto = BuscarNaCollection(id);

        if (produto is not null)
            produto.Visualizar();
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nO produto número {id} não foi encontrado!");
            Console.ResetColor();
        }
    }

    public void ListarProdutos()
    {
        foreach (var produto in listaProdutos)
        {
            produto.Visualizar();
        }
    }

    public void Cadastrar(Produto produto)
    {
        listaProdutos.Add(produto);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Produto cadastrado com sucesso!");
        Console.ResetColor();
    }

    public void Atualizar(Produto produto)
    {
        var buscaProduto = BuscarNaCollection(produto.Id);
        
        if (buscaProduto is not null)
        {
            var index = listaProdutos.IndexOf(buscaProduto);
            listaProdutos[index] = produto;
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nO produto {produto.Id} foi atualizado com sucesso!\n");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nO produto número {produto.Id} não foi encontrado!\n");
            Console.ResetColor();
        }
    }

    public void Deletar(int id)
    {
        var produto = BuscarNaCollection(id);

        if (produto is not null)
            if (listaProdutos.Remove(produto))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"O produto número {id} foi removido com sucesso!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"O produto número {id} não foi removido!");
                Console.ResetColor();
            }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"O produto número {id} não foi encontrado!");
            Console.ResetColor();
        }
    }
    
    public int GerarNumero()
    {
        id++;
        return id;
    }
    
    public Produto? BuscarNaCollection(int id)
    {
        foreach (var produto in listaProdutos)
        {
            if (produto.Id == id)
            {
                return produto;
            }
        }

        return null;
    }
}