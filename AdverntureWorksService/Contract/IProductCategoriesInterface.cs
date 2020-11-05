using AdventureworksContext.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AdverntureWorksService.Contract
{
   public  interface IProductCategoriesInterface
    {
        Task<List<ProductCategory>> GetProductCategories();
        Task<Boolean> UpdateProductCategory(ProductCategory productCategory);
        Task<Boolean> InsertProductCategory(ProductCategory productCategory);
        Task<ProductCategory> GetProductCategory(int id);
        Task<ProductCategory> GetProductCategory(string categoryName);
    }
}
