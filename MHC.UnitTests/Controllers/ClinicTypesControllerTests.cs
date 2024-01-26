using AutoFixture;
using MediatR;
using MHC.API.Controllers.v1;
using MHC.Application.ClinicTypes.Queries;
using MHC.Application.ClinicTypes.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace MHC.UnitTests.Controllers
{
    public class ClinicTypesControllerTests
    {

        private readonly Fixture _fixture;
        private readonly ClinicTypesController _controller;
        private readonly Mock<IMediator> _mediatorMock = new Mock<IMediator>();
        public ClinicTypesControllerTests()
        {
            _fixture = new Fixture();
            _controller = new ClinicTypesController(_mediatorMock.Object);
        }

        [Fact]
        public async Task GetAllClinicTypes_ShouldReturnClinicTypes_WhenClinicTypesExists()
        {
            // Arrange
            var expectedClinicTypes = _fixture.CreateMany<ClinicTypeViewModel>(3).ToList();
            _mediatorMock.Setup(mediator => mediator.Send(It.IsAny<GetAllClinicTypesQuery>(), default)).ReturnsAsync(expectedClinicTypes);

            // Act
            var result = await _controller.GetAllClinicTypes();

            // Assert
            var actionResult = Assert.IsType<OkObjectResult>(result);
            var actualClinicTypes = Assert.IsAssignableFrom<IEnumerable<ClinicTypeViewModel>>(actionResult.Value);

            Assert.Equal(expectedClinicTypes, actualClinicTypes);
        }
    }
}
