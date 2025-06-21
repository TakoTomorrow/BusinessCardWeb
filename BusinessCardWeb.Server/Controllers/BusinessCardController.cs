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
        public async Task<ResponseData<BusinessCard>> Get(int? id)
        {
            var response = new ResponseData<BusinessCard>();
            try
            {
                response.Data = await _businessCardBL.GetBusinessCardAsync(id ?? 1);
                response.Success = true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while getting business card.");
                response.Success = false;
                response.ErrorMessage = ex.Message;
            }
            return response;
        }
    }
}
