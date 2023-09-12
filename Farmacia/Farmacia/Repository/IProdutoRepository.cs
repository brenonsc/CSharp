using Farmacia.Model;
namespace Farmacia.Repository;

public interface IProdutoRepository
{
    public void ProcurarPorNumero(int id);
    public void ListarProdutos();
    public void Cadastrar(Produto produto);
    public void Atualizar(Produto produto);
    public void Deletar(int id);
}