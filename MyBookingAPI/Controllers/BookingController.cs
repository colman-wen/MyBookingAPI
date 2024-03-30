using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyBookingAPI.Model;

namespace MyBookingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class BookingController : ControllerBase
    {
        private readonly ILogger<BookingController> _logger;

        public BookingController(ILogger<BookingController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Endpoint to retrieve a specific booking
        /// </summary>
        /// <param name="bookingID">The booking ID</param>
        /// <returns>A specific booking if found</returns>
        [HttpGet("{bookingID}")]
        public Booking GetBooking(string bookingID)
        {
            return new Booking();
        }

        /// <summary>
        /// Endpoint to retrieve a list of bookings for the signed-in user
        /// </summary>
        /// <returns>A list of bookings for the user</returns>
        [HttpGet]
        public IEnumerable<Booking> GetUserBookings()
        {
            return new List<Booking>();
        }

        /// <summary>
        /// Endpoint for user to book tickets
        /// </summary>
        /// <param name="booking">booking information</param>
        /// <returns>If create is susseceful, returns the Booking information</returns>
        [HttpPost]
        public Booking BookTickets(Booking booking)
        {
            return new Booking();
        }

        /// <summary>
        /// Endpoint for user to update an existing booking
        /// </summary>
        /// <param name="booking">Updated booking Information</param>
        /// <returns>Response result</returns>
        [HttpPut]
        public Booking UpdateBooking(Booking booking)
        {
            return booking;
        }

        /// <summary>
        /// Endpoint to delete a specific booking
        /// </summary>
        /// <param name="bookingID">The booking ID</param>
        /// <returns>Response result</returns>
        [HttpDelete]
        public Response DeleteBooking(string bookingID)
        {
            return new Response();
        }
    }
}
