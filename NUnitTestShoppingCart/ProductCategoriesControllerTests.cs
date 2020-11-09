using NUnit.Framework;
using ShoppingApi;
using ShoppingApi.Controllers;
using AdverntureWorksService.Contract;
using Rhino.Mocks;

namespace NUnitTestShoppingCart
{
    public class ProductCategoriesControllerTests
    {
        ProductCategoriesController controller;


        IProductCategoriesInterface _Service = MockRepository.GenerateMock<IProductCategoriesInterface>();
        [SetUp]
        public void Setup()
        {
            controller = new ProductCategoriesController(_Service);
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}