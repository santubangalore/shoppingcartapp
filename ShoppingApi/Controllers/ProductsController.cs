using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AdverntureWorksService;
using AdventureworksContext.Model;
using Microsoft.AspNetCore.Cors;
using AdverntureWorksService.Contract;
using Microsoft.AspNetCore.Authorization;

namespace ShoppingApi.Controllers
{
  
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductInterface _productInterface;
        public ProductsController(IProductInterface productInterface)
        {
            _productInterface = productInterface;
        }

        [HttpGet]
        
        public async Task<IActionResult> GetProducts()
        {
            var prodList = _productInterface.GetProducts();
            var i = "santu";
            return Ok(prodList);
        }

        [Authorize]
        [HttpGet]
        [Route("GetProductsByCategory/{CategoryID}")]
        public async Task<IActionResult> GetProducts(int CategoryID)
        {
            var prodList = _productInterface.GetProductsByCagtegory(CategoryID);
            return Ok(prodList);
        }

        [HttpPost]
        [Route("AddProduct")]
        public async Task<IActionResult> InsertProduct(Product product)
        {
            var prod = _productInterface.InsertProduct(product);
            return Ok(prod);
        }

        [HttpPost]
        [Route("UpdateProduct")]
        public async Task<IActionResult> UpdateProduct(Product product)
        {
            var prod = _productInterface.InsertProduct(product);
            return Ok(prod);
        }
    }
}
