using Microsoft.AspNetCore.Authorization;
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
        /// <returns>If sign in is susseceful, returns a token for authentication</returns>
        [HttpGet(Name = "SignIn")]
        [AllowAnonymous]
        public SignInResponse SignIn(string userName, string password)
        {
            var result = new SignInResponse
            {
                Token = new Guid().ToString()
            };
            return result;
        }

        /// <summary>
        /// Endpoint for user to create an account
        /// </summary>
        /// <param name="user">User account information</param>
        /// <returns>If create is susseceful, returns a token</returns>
        [HttpPut(Name = "CreateAccount")]
        [AllowAnonymous]
        public SignInResponse CreateAccount(User user)
        {
            var result = new SignInResponse
            {
                Token = new Guid().ToString()
            };
            return result;
        }

        /// <summary>
        /// Endpoint for user to update an existing account
        /// </summary>
        /// <param name="user">User Account Information</param>
        /// <returns>Response result</returns>
        [HttpPost(Name = "UpdateAccount")]
        public Response UpdateAccount(User user)
        {
            return new Response();
        }

        /// <summary>
        /// Endpoint for user to delete an existing account
        /// </summary>
        /// <param name="userID">User Account ID</param>
        /// <returns>Response result</returns>
        [HttpDelete(Name = "DeleteAccount")]
        public Response DeleteAccount(string userID)
        {
            return new Response();
        }
    }
}
