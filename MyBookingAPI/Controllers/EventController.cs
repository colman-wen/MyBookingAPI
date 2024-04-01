using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyBookingAPI.Model;

namespace MyBookingAPI.Controllers
{
    /// <summary>
    /// Controller to handle Events
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class EventController : ControllerBase
    {
        private readonly ILogger<EventController> _logger;

        /// <summary>
        /// Constructor with Logger
        /// </summary>
        /// <param name="logger"></param>
        public EventController(ILogger<EventController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Endpoint for retrieving all Available Events
        /// </summary>
        /// <returns>A list of all Available Events</returns>
        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return new List<Event>();
        }

        /// <summary>
        /// Endpoint to retrieve a specific event
        /// </summary>
        /// <param name="eventID">The event ID</param>
        /// <returns>A specific event if found</returns>
        [HttpGet("{eventID}")]
        public Event Get(string eventID)
        {
            return new Event();
        }
    }
}
