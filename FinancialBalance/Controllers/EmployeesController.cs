using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace FinancialBalance.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : ControllerBase
    {
        public EmployeesController() { }

        [HttpGet("dailyEntriesTemplate")]
        [SwaggerResponse(StatusCodes.Status200OK)]
        [SwaggerResponse(StatusCodes.Status400BadRequest)]
        public IActionResult GetEntriesDailyFileTemplate()
        {
            throw new NotImplementedException();
        }

        [HttpPost("dailyEntries")]
        [SwaggerResponse(StatusCodes.Status201Created)]
        [SwaggerResponse(StatusCodes.Status400BadRequest)]
        public IActionResult PostEntriesDailyFile()
        {
            throw new NotImplementedException();
        }

        [HttpPost("entries")]
        [SwaggerResponse(StatusCodes.Status202Accepted)]
        [SwaggerResponse(StatusCodes.Status400BadRequest)]
        public IActionResult PostEntries()
        {
            throw new NotImplementedException();
        }
    }
}
