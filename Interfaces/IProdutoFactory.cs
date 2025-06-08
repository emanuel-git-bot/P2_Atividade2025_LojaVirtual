
namespace LojaVirtual
{
    public interface IProdutoFactory
    {
        Produto CriarProduto(string nome, decimal preco, string categoria);
    }
} 