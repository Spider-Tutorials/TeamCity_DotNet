using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeamCity_DotNet.Controllers;
using System.Collections.Generic;
using System.Linq;

namespace TeamCity_DotNet.Tests.Controllers
{
    [TestClass]
    public class ProductsControllerTest
    {
        [TestMethod]
        public void TestGet()
        {
            ProductsController controller = new ProductsController();

            IQueryable < Product > result = controller.GetProducts();

            Assert.IsNotNull(result);
            //Assert.Equals(2, result.Count());
        }
    }
}
