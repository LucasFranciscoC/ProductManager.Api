using ProductManager.Domian.Interface;
using ProductMananger.Core.Models;
using ProductMananger.Infra.Interface;

namespace ProductManager.Domian.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository) 
        { 
            _productRepository = productRepository;
        }

        public async Task<Product> AtualizarProdutosAsync(Product product)
        {
            return await _productRepository.AtualizarProdutosAsync(product);
        }

        public async Task<Product> CriarProdutoAsync(Product product)
        {
            return await _productRepository.CriarProdutoAsync(product);
        }

        public async Task DeletarProdutoAsync(int id)
        {
            await _productRepository.DeletarProdutoAsync(id);
        }

        public async Task<Product> ObterProdutoPorIdAsync(int id)
        {
            return await _productRepository.ObterProdutoPorIdAsync(id);
        }

        public async Task<IEnumerable<Product>> ObterProdutosAsync()
        {
            return await _productRepository.ObterProdutosAsync();
        }
    }
}
