using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using web_api.Contracts;
using web_api.Controllers;
using web_api.Model;
using Xunit;

namespace web_api_tests
{
    public class MathControllerTests
    {
        [Fact]
        public void Add_ReturnsCorrectResult()
        {
            // Arrange
            var controller = new MathController();

            // Act
            var result = controller.Add(5, 3) as OkObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(8, (double)result.Value);
        }

        [Fact]
        public void Subtract_ReturnsCorrectResult()
        {
            // Arrange
            var controller = new MathController();

            // Act
            var result = controller.Subtract(8, 3) as OkObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(5, (double)result.Value);
        }

        [Fact]
        public void Multiply_ReturnsCorrectResult()
        {
            // Arrange
            var controller = new MathController();

            // Act
            var result = controller.Multiply(4, 6) as OkObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(24, (double)result.Value);
        }

        [Fact]
        public void Divide_ReturnsCorrectResult()
        {
            // Arrange
            var controller = new MathController();

            // Act
            var result = controller.Divide(10, 2) as OkObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(5, (double)result.Value);
        }

        [Fact]
        public void Divide_ByZero_ReturnsBadRequest()
        {
            // Arrange
            var controller = new MathController();

            // Act
            var result = controller.Divide(10, 0) as BadRequestObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Division by zero is not allowed", result.Value);
        }
    }
}
