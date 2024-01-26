using AutoFixture;
using MediatR;
using MHC.API.Controllers.v1;
using MHC.Application.Images.Queries;
using MHC.Application.Images.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Collections.Generic;

namespace MHC.UnitTests.Controllers
{
    public class ImagesControllerTests
    {
        private readonly Fixture _fixture;
        private readonly ImagesController _controller;
        private readonly Mock<IMediator> _mediatorMock = new Mock<IMediator>();
        public ImagesControllerTests()
        {
            _fixture = new Fixture();
            _controller = new ImagesController(_mediatorMock.Object);
        }

        [Fact]
        public async Task GetAllImages_ShouldReturnImages_WhenImagesExists()
        {
            // Arrange
            var expectedImages = _fixture.CreateMany<ImageViewModel>(3).ToList();
            _mediatorMock.Setup(mediator => mediator.Send(It.IsAny<GetAllImagesQuery>(), default)).ReturnsAsync(expectedImages);

            // Act
            var result = await _controller.GetAllImages();

            // Assert
            var actionResult = Assert.IsType<OkObjectResult>(result);
            var actualImages = Assert.IsAssignableFrom<IEnumerable<ImageViewModel>>(actionResult.Value);

            Assert.Equal(expectedImages, actualImages);
        }
    }
}
