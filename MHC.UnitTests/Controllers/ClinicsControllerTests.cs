using AutoFixture;
using MediatR;
using MHC.API.Controllers.v1;
using MHC.Application.Clinics.Queries;
using MHC.Application.Clinics.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace MHC.UnitTests.Controllers
{
    public class ClinicsControllerTests
    {
        private readonly Fixture _fixture;
        private readonly ClinicsController _controller;
        private readonly Mock<IMediator> _mediatorMock = new Mock<IMediator>();
        public ClinicsControllerTests()
        {
            _fixture = new Fixture();
            _controller = new ClinicsController(_mediatorMock.Object);
        }

        [Fact]
        public async Task GetAllClinics_ShouldReturnClinics_WhenClinicsExists()
        {
            // Arrange
            var expectedClinics = _fixture.CreateMany<ClinicViewModel>(3).ToList();
            _mediatorMock.Setup(mediator => mediator.Send(It.IsAny<GetAllClinicsQuery>(), default)).ReturnsAsync(expectedClinics);

            // Act
            var result = await _controller.GetAllClinics();

            // Assert
            var actionResult = Assert.IsType<OkObjectResult>(result);
            var actualClinics = Assert.IsAssignableFrom<IEnumerable<ClinicViewModel>>(actionResult.Value);

            Assert.Equal(expectedClinics, actualClinics);
        }
    }
}
