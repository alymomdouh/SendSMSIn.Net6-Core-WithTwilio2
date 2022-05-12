using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SendSMSIn.Net6_Core_WithTwilio2.Services;

namespace SendSMSIn.Net6_Core_WithTwilio2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SMSController : ControllerBase
    {
        private readonly ISMSService service;

        public SMSController(ISMSService _service)
        {
             service = _service;
        }

        [HttpPost("send")]
        public IActionResult Send()
        {

        }
    }
}
