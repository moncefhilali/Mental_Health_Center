using AutoFixture;
using MediatR;
using MHC.API.Controllers.v1;
using MHC.Application.Doctors.Queries;
using MHC.Application.Doctors.ViewModel;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace MHC.UnitTests.Controllers
{
    public class DoctorsControllerTests
    {
        private readonly Fixture _fixture;
        private readonly DoctorsController _controller;
        private readonly Mock<IMediator> _mediatorMock = new Mock<IMediator>();
        public DoctorsControllerTests()
        {
            _fixture = new Fixture();
            _controller = new DoctorsController(_mediatorMock.Object);
        }

        [Fact]
        public async Task GetAllDoctors_ShouldReturnDoctors_WhenDoctorsExist()
        {
            // Arrange
            var expectedDoctors = _fixture.CreateMany<DoctorViewModel>(3).ToList();
            _mediatorMock.Setup(mediator => mediator.Send(It.IsAny<GetAllDoctorsQuery>(), default)).ReturnsAsync(expectedDoctors);

            // Act
            var result = await _controller.GetAllDoctors();

            // Assert
            var actionResult = Assert.IsType<OkObjectResult>(result);
            var actualDoctors = Assert.IsAssignableFrom<IEnumerable<DoctorViewModel>>(actionResult.Value);

            Assert.Equal(expectedDoctors, actualDoctors);
        }
    }
}
