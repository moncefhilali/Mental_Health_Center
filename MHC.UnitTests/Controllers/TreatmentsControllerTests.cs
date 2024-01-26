using AutoFixture;
using MediatR;
using MHC.API.Controllers.v1;
using MHC.Application.Treatments.Queries;
using MHC.Application.Treatments.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace MHC.UnitTests.Controllers
{
    public class TreatmentsControllerTests
    {
        private readonly Fixture _fixture;
        private readonly TreatmentsController _tc;
        private readonly Mock<IMediator> _mediatorMock = new Mock<IMediator>();
        public TreatmentsControllerTests()
        {
            _fixture = new Fixture();
            _tc = new TreatmentsController(_mediatorMock.Object);
        }

        [Fact]
        public async Task GetAllTreatments_ShouldReturnTreatments_WhenTreatmentsExists()
        {
            // Arrange
            var expectedTreatments = _fixture.CreateMany<TreatmentViewModel>(3).ToList();
            _mediatorMock.Setup(mediator => mediator.Send(It.IsAny<GetAllTreatmentsQuery>(), default)).ReturnsAsync(expectedTreatments);

            // Act
            var result = await _tc.GetAllTreatments();

            // Assert
            var actionResult = Assert.IsType<OkObjectResult>(result);
            var actualTreatments = Assert.IsAssignableFrom<IEnumerable<TreatmentViewModel>>(actionResult.Value);

            Assert.Equal(expectedTreatments, actualTreatments);
        }
    }
}
