using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyBookingAPI.Model;

namespace MyBookingAPI.Controllers
{
    /// <summary>
    /// Controller to handle errors and exceptions
    /// </summary>
    [Route("[controller]")]
    [ApiController]
    public class ErrorController : ControllerBase
    {
        private readonly ILogger<ErrorController> _logger;

        /// <summary>
        /// Constructor with Logger
        /// </summary>
        /// <param name="logger"></param>
        internal ErrorController(ILogger<ErrorController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Error handling endpoint
        /// </summary>
        /// <returns></returns>
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
