using NUnit.Framework;
using ShoppingApi;
using ShoppingApi.Controllers;
using AdverntureWorksService.Contract;


namespace NUnitTestShoppingCart
{
    public class ProductCategoriesControllerTests
    {
        ProductCategoriesController controller;
        

        [SetUp]
        public void Setup()
        {
            controller = new ProductCategoriesController();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}