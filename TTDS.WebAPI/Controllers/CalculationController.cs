using Microsoft.AspNetCore.Mvc;
using TTDS.WebAPI.Common;
using TTDS.WebAPI.Models;
using TTDS.WebAPI.Services;

namespace TTDS.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculationController : ControllerBase
    {
        private readonly ICalculationService _calculationService;
        private readonly ILogger<CalculationController> _logger;

        /// <summary>
        /// .ctor
        /// </summary>
        /// <param name="calculationService">calculation service</param>
        /// <param name="logger">logger</param>
        public CalculationController(ICalculationService calculationService, ILogger<CalculationController> logger)
        {
            _calculationService = calculationService;
            _logger = logger;
        }

        [HttpPost]
        public IActionResult Calculate([FromBody] CalculationData data)
        {
            if (data == null)
            {
                return BadRequest($"Argument: {nameof(data)} is null.");
            }

            double? result = null;

            try
            {
                switch (data.Operation)
                {
                    case Constants.Sum:
                        result = _calculationService.Sum(data.FirstNumber, data.SecondNumber);
                        break;

                    case Constants.Difference:
                        result = _calculationService.Difference(data.FirstNumber, data.SecondNumber);
                        break;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, data.ToString());
            }

            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest();
        }
    }
}