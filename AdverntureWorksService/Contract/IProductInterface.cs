using AdventureworksContext.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AdverntureWorksService.Contract
{
   public interface IProductInterface
    {
        Task<List<Product>> GetProducts();
        Task<List<object>> GetProductsByCagtegory(int CategoryID);
        Task<List<Product>> GetProductsByName(string Name);
        Task<Boolean> UpdateProduct(Product product);
        Task<Boolean> InsertProduct(Product product);
        Task<Product> GetProduct(int id);
        Task<Product> GetProduct(string productName);

    }
}
