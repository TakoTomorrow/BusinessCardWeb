using BusinessCardWeb.Server.BusinessLogics.Interface;
using BusinessCardWeb.Server.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace BusinessCardWeb.Server.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class BusinessCardController : ControllerBase
    {

        private readonly ILogger<BusinessCardController> _logger;
        private readonly IBusinessCardBusinessLogic _businessCardBL;

        public BusinessCardController(IBusinessCardBusinessLogic businessCardBL,ILogger<BusinessCardController> logger)
        {
            _businessCardBL = businessCardBL;
            _logger = logger;
        }

        [HttpGet(Name = "GetBusinessCard")]
        [EnableCors]
        public async Task<BusinessCard> Get()
        {
            return await _businessCardBL.GetBusinessCardAsync(1);
        }
    }
}
