using AutoFixture;
using MediatR;
using MHC.API.Controllers.v1;
using MHC.Application.Categories.Queries;
using MHC.Application.Categories.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Collections.Generic;

namespace MHC.UnitTests.Controllers
{
    public class CategoriesControllerTests
    {
        private readonly Fixture _fixture;
        private readonly CategoriesController _controller;
        private readonly Mock<IMediator> _mediatorMock = new Mock<IMediator>();
        public CategoriesControllerTests()
        {
            _fixture = new Fixture();
            _controller = new CategoriesController(_mediatorMock.Object);
        }

        [Fact]
        public async Task GetAllCategories_ShouldReturnCategories_WhenCategoriesExist()
        {
            // Arrange
            var expectedCategories = _fixture.CreateMany<CategoryViewModel>(3).ToList();
            _mediatorMock.Setup(mediator => mediator.Send(It.IsAny<GetAllCategoriesQuery>(), default)).ReturnsAsync(expectedCategories);

            // Act
            var result = await _controller.GetAllCategories();

            // Assert
            var actionResult = Assert.IsType<OkObjectResult>(result);
            var actualCategories = Assert.IsAssignableFrom<IEnumerable<CategoryViewModel>>(actionResult.Value);

            Assert.Equal(expectedCategories, actualCategories);
        }
    }
}
