using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using sharecare_backend.Models.Problem;
using System.IO;
using System.Reflection;
using System.Text.Json;

namespace sharecare_backend.Controllers
{
    [ApiController]
    [Authorize(AuthenticationSchemes = "BasicAuthentication")]
    [Route("api/[controller]")]
    public class DevController : ControllerBase
    {
        private readonly ILogger<DevController> _logger;

        public DevController(ILogger<DevController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult POSTProblem([FromBody] object jsonData)
        {
            try
            {
                ProblemEntity newProblem = JsonSerializer.Deserialize<ProblemEntity>(jsonData.ToString());
                return Content("Great Success!");
            }
            catch(Exception ec)
            {
                Console.WriteLine(ec);
                return Content("Error: " + ec.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GETProblemFromId()
        {
            //ProblemEntity problem = 
            return Ok(/*obj*/);
        }
    }
}
