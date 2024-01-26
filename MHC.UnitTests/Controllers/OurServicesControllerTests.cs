using AutoFixture;
using MediatR;
using MHC.API.Controllers.v1;
using MHC.Application.OurServices.Queries;
using MHC.Application.OurServices.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Collections.Generic;

namespace MHC.UnitTests.Controllers
{
    public class OurServicesControllerTests
    {
        private readonly Fixture _fixture;
        private readonly OurServicesController _controller;
        private readonly Mock<IMediator> _mediatorMock = new Mock<IMediator>();
        public OurServicesControllerTests()
        {
            _fixture = new Fixture();
            _controller = new OurServicesController(_mediatorMock.Object);
        }

        [Fact]
        public async Task GetAllOurServices_ShouldReturnOurServices_WhenOurServicesExists()
        {
            // Arrange
            var expectedServices = _fixture.CreateMany<OurServiceViewModel>(3).ToList();
            _mediatorMock.Setup(mediator => mediator.Send(It.IsAny<GetAllOurServicesQuery>(), default)).ReturnsAsync(expectedServices);

            // Act
            var result = await _controller.GetAllServices();

            // Assert
            var actionResult = Assert.IsType<OkObjectResult>(result);
            var actualServices = Assert.IsAssignableFrom<IEnumerable<OurServiceViewModel>>(actionResult.Value);

            Assert.Equal(expectedServices, actualServices);
        }
    }
}
