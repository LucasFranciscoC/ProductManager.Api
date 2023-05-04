using ProductMananger.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager.Domian.Interface
{
   
    public interface IProductService
    {
        Task<IEnumerable<Product>> ObterProdutosAsync();
        Task<Product> ObterProdutoPorIdAsync(int id);
        Task<Product> CriarProdutoAsync(Product product);
        Task<Product> AtualizarProdutosAsync(Product product);
        Task DeletarProdutoAsync(int id);
    }
   
}
