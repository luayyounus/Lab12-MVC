using System;
using Xunit;
using DontWineAboutIt.Controllers;
using DontWineAboutIt.Models;
using Microsoft.AspNetCore.Mvc;

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

        [Fact]
        public void RedirectToResult()
        {
            // Arrange
            string customerName = "Winnie";
            Wine wine = new Wine
            {
                Price = 22.ToString(),
                Points = 44.ToString()
            };

            // Act
            var home = new HomeController();
            var result = home.Index(customerName, wine);

            // Assert
            var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Null(redirectToActionResult.ControllerName);
        }
    }
}
