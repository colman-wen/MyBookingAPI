using Microsoft.AspNetCore.Mvc;
using MyBookingAPI.Model;

namespace MyBookingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        /// <summary>
        /// Logger
        /// </summary>
        private readonly ILogger<UserController> _logger;

        /// <summary>
        /// Constructor with Logger
        /// </summary>
        /// <param name="logger">Logger</param>
        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Endpoint for user to sign in
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns>If sign in is susseceful, returns a token</returns>
        [HttpPost]
        public SignInResponse SignIn(string userName, string password) {
            return new SignInResponse
            {
                Token = new Guid().ToString()
            };
        }
    }
}
