using ProductMananger.Core.Models;

namespace ProductMananger.Infra.Interface
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> ObterProdutosAsync();
        Task<Product> ObterProdutoPorIdAsync(int id);
        Task<Product> CriarProdutoAsync(Product product);
        Task<Product> AtualizarProdutosAsync(Product product);
        Task DeletarProdutoAsync(int id);
    }
}
