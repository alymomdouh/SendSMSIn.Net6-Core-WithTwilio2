using Microsoft.AspNetCore.Mvc;
using SendSMSIn.Net6_Core_WithTwilio2.Dtos;
using SendSMSIn.Net6_Core_WithTwilio2.Services;

namespace SendSMSIn.Net6_Core_WithTwilio2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SMSController : ControllerBase
    {
        private readonly ISMSService smsservice;

        public SMSController(ISMSService _service)
        {
            smsservice = _service;
        }

        [HttpPost("send")]
        public IActionResult Send(SendSMSDto dto)
        {
            var result = smsservice.Send(dto.MobileNumber, dto.body);
            // result.ErrorMessage will return null if service sussfully send message 
            if (!string.IsNullOrEmpty(result.ErrorMessage))
            {
                return BadRequest(result.ErrorMessage);
            }
            return Ok(result);
        }
    }
}
