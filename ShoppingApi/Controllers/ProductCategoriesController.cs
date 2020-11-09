using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AdverntureWorksService;
using AdverntureWorksService.Contract;
using Microsoft.Extensions.Logging;

namespace ShoppingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCategoriesController : ControllerBase
    {
        IProductCategoriesInterface _Service;
        ILoggerFactory loggerFactory;
        ILogger _ilogger;
        public ProductCategoriesController(IProductCategoriesInterface iproductCategoriesInterface)
        {
            _Service = iproductCategoriesInterface;
            _ilogger = new LoggerFactory().CreateLogger<ProductCategoriesController>();
        }
        
        // GET: api/<ProductCategoriesController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            _ilogger.LogInformation("get started");
            var prodCategories = await _Service.GetProductCategories();
            _ilogger.LogInformation("get ended");
            return Ok(prodCategories);
        }

      
        // POST api/<ProductCategoriesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProductCategoriesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/<ProductCategoriesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
