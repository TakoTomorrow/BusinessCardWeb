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
        public async Task<BusinessCard> Get()
        {
            return new BusinessCard(name: "John Doe", email: "abcd@gmail.com")
            {
                Title = "Software Engineer",
                PhoneNumber = "123-456-7890",
                Address = "123 Main St, Anytown, USA",
                SocialMedia = new Dictionary<string, string>
                {
                    { "LinkedIn", "https://www.linkedin.com/in/johndoe" },
                    { "Twitter", "https://twitter.com/johndoe" },
                    { "GitHub", "" }
                }
            };
        }
    }
}
