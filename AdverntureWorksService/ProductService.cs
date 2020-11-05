using System;
using AdventureworksContext.Model;
using System.Collections.Generic;
using System.Linq;
using AdverntureWorksService.Contract;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Internal;

namespace AdverntureWorksService
{
    public class ProductService: IProductInterface
    {
        private AdventureWorksDbContext dbContext = new AdventureWorksDbContext();        
        public ProductService()
        {

        }

        public Task<Product> GetProduct(int ProductId)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetProduct(string productName)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Product>> GetProducts()
        {
            var productsList =  dbContext.Product.Where(p => p.ProductInventory != null).Take(100).ToList();
            return productsList;
        }

        public async Task<List<object>> GetProductsByCagtegory(int CategoryID)
        {
            var query = dbContext.ProductSubcategory.Join(dbContext.ProductCategory, r => r.ProductCategoryId, p => p.ProductCategoryId, (r, p) => new { r.ProductSubcategoryId, r.ProductCategoryId  }).Where(q=>q.ProductCategoryId==CategoryID);
           
            var result=query.Join(dbContext.Product, r => r.ProductSubcategoryId, p => p.ProductSubcategoryId, (r, p) => new {p.ProductId, p.Name,p.ProductNumber,p.StandardCost, p.ListPrice })
                .Join(dbContext.ProductProductPhoto, r => r.ProductId, p => p.ProductId, (r,p) => new { p.ProductId, r.Name, r.ProductNumber, r.StandardCost, r.ListPrice, p.ProductPhotoId })
                .Join(dbContext.ProductPhoto, r=> r.ProductPhotoId, p=> p.ProductPhotoId, (r,p)=> new { r.ProductId, r.Name, r.ProductNumber, r.StandardCost, r.ListPrice, p.ProductPhotoId, p.ThumbNailPhoto }) ;
            return result.ToList<object>();
        }

        public Task<bool> InsertProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }

       
    }
}
