using Microsoft.Extensions.Logging;
using Moq;
using TTDS.WebAPI.Services;

namespace TTDS.UnitTests
{
    [TestFixture]
    public class CalculationServiceTests
    {
        private CalculationService _calculatorService;
        private Mock<ILogger<CalculationService>> _mockLogger;

        [SetUp]
        public void Setup()
        {
            _mockLogger = new Mock<ILogger<CalculationService>>();
            _calculatorService = new CalculationService(_mockLogger.Object);
        }

        [Test]
        public void Calculate_Sum_ShouldReturnCorrectResult()
        {
            // Arrange
            double firstNumber =  123.45;
            double secondNumber = 678.9;

            // Act
            var result = _calculatorService.Sum(firstNumber, secondNumber);

            // Assert
            Equals(result, 802.35);
        }

        [Test]
        public void Calculate_Difference_ShouldReturnCorrectResult()
        {
            // Arrange
            double firstNumber = 123.45;
            double secondNumber = 678.9;

            // Act
            var result = _calculatorService.Difference(firstNumber, secondNumber);

            // Assert
            Equals(result, -555.45);
        }
    }
}
