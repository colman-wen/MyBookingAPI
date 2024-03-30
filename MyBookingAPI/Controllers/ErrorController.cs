using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyBookingAPI.Model;

namespace MyBookingAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ErrorController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var error = HttpContext.Features.Get<IExceptionHandlerFeature>();
            if (error != null)
            {
                var exception = error.Error;
                return StatusCode(500, 
                    new Response
                    {
                        Status = 500,
                        Message = exception.Message
                    }
                );
            }

            return StatusCode(500,
                new Response
                {
                    Status = 500,
                    Message = "Internal Server Error"
                }
            );
        }
    }
}
