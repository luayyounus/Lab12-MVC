using System;
using Xunit;
using DontWineAboutIt.Controllers;

namespace XUnitTestDontWineAboutIt
{
    public class UnitTest1
    {
        [Fact]
        public void GetMainIndexPage()
        {
            // Arrange
            var homeController = new HomeController();

            // Act
            var result = homeController.Index();
            string viewName = result.ToString();

            // Assert
            Assert.True(!string.IsNullOrEmpty(viewName));
        }
    }
}
