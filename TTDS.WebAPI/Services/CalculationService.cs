using TTDSMathLibraryWrapper;

namespace TTDS.WebAPI.Services
{
    /// <summary>
    /// Represents a service that calls an external calculation C++/CLI library
    /// </summary>
    public class CalculationService : ICalculationService
    {
        private readonly MathLibraryWrapper _calculator;
        private readonly ILogger<CalculationService> _logger;

        /// <summary>
        /// .ctor
        /// </summary>
        public CalculationService(ILogger<CalculationService> logger)
        {
            _calculator = new MathLibraryWrapper();
            _logger = logger;
        }

        public double? Difference(double a, double b)
        {
            _logger.LogInformation("Call Difference method with args:", a, b);

            double? result;
            try
            {
                checked
                {
                    result = _calculator.Difference(a, b);
                }
            }
            catch (OverflowException ex)
            {
                _logger.LogError(ex, ex.Message, a, b);
                throw;
            }

            return result;
        }

        public double? Sum(double a, double b)
        {
            _logger.LogInformation("Call Sum method with args:", a, b);

            double? result;
            try
            {
                checked
                {
                    result = _calculator.Sum(a, b);
                }
            }
            catch (OverflowException ex)
            {
                _logger.LogError(ex, ex.Message, a, b);
                throw;
            }

            return result;
        }
    }
}
