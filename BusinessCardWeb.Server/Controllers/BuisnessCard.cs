using Microsoft.AspNetCore.Mvc;

namespace BusinessCardWeb.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BusinessCardController : ControllerBase
    {
        
        private readonly ILogger<BusinessCardController> _logger;

        public BusinessCardController(ILogger<BusinessCardController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetBusinessCard")]
        public async Task<string> Get()
        {
            return "hello world";
        }
    }
}
