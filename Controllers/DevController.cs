using Microsoft.AspNetCore.Mvc;

namespace sharecare_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DevController : ControllerBase
    {
        private readonly ILogger<DevController> _logger;

        public DevController(ILogger<DevController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult POSTMapData([FromBody] object jsonData)
        {

            return Content("File saved successfully");
        }
    }
}
