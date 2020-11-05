using System;
using System.Collections.Generic;
using System.Text;
using AdventureworksContext.Model;
using System.Linq;
using AdverntureWorksService.Contract;
using System.Threading.Tasks;

namespace AdverntureWorksService
{
    public class ProductCategoriesService : IProductCategoriesInterface
    {
        private AdventureWorksDbContext dbContext = new AdventureWorksDbContext();
        public async Task<List<ProductCategory>> GetProductCategories()
        {
            var productsList =  dbContext.ProductCategory.Where(p => p.Name != null).ToList();
            return productsList;
        }

        public async Task<ProductCategory> GetProductCategory(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ProductCategory> GetProductCategory(string categoryName)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> InsertProductCategory(ProductCategory productCategory)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateProductCategory(ProductCategory productCategory)
        {
            throw new NotImplementedException();
        }
    }
}
