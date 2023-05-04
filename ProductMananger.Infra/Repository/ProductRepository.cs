using ProductMananger.Core.Models;
using ProductMananger.Infra.Interface;

namespace ProductMananger.Infra.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> _products;
        public ProductRepository()
        {
            _products = new List<Product>()
            {
                new Product{ID = 1, Nome = "Produto 1", Preco = 10},
                new Product{ID = 2, Nome = "Produto 2", Preco = 30},
                new Product{ID = 3, Nome = "Produto 3", Preco = 60}
            };
        }

        public Task<Product> AtualizarProdutosAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<Product> CriarProdutoAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public Task DeletarProdutoAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Product> ObterProdutoPorIdAsync(int id)
        {
            return await Task.FromResult(_products.FirstOrDefault(p => p.ID == id));
        }

        public async Task<IEnumerable<Product>> ObterProdutosAsync()
        {
            return await Task.FromResult(_products);
        }
    }
}
