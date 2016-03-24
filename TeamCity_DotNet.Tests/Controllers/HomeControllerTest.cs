using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeamCity_DotNet;
using TeamCity_DotNet.Controllers;

namespace TeamCity_DotNet.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
