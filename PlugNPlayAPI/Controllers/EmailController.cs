using Microsoft.AspNetCore.Mvc;
using PlugAndPlay.Business;
using PlugAndPlay.Common;

namespace PlugNPlayAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmailController : ControllerBase
    {
        private readonly serviceMail _mailService;

        public EmailController(serviceMail mailService)
        {
            _mailService = mailService;
        }

        // GET Test (Simple)
        [HttpGet("Test")]
        public IActionResult TestMailtrap()
        {
            var result = _mailService.SendEmail(new EmailMessage
            {
                To = "youremail@gmail.com",
                Subject = "Mailtrap API Test ✅",
                Body = "<h2>Hello from ASP.NET Web API ✅</h2>"
            });

            return Ok(result);
        }

        // POST Test (JSON input from Swagger)
        [HttpPost("Send")]
        public IActionResult SendMail([FromBody] EmailMessage message)
        {
            var result = _mailService.SendEmail(message);
            return Ok(result);
        }
    }
}
