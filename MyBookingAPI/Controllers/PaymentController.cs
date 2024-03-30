using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyBookingAPI.Model;

namespace MyBookingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PaymentController : ControllerBase
    {
        private readonly ILogger<PaymentController> _logger;

        public PaymentController(ILogger<PaymentController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Endpoint for user to make a payment for a Booking
        /// </summary>
        /// <param name="bookingID">the booking ID to be paid</param>
        /// <returns>If payment is susseceful, returns the payment information</returns>
        [HttpPost]
        public Payment CreatePayment(string bookingID)
        {
            return new Payment();
        }

        /// <summary>
        /// Endpoint to retrieve a list of Payments for the signed-in user
        /// </summary>
        /// <returns>A list of bookings for the user</returns>
        [HttpGet]
        public IEnumerable<Payment> GetUserPayment()
        {
            return new List<Payment>();
        }

        /// <summary>
        /// Endpoint to retrieve a specific Payment
        /// </summary>
        /// <param name="paymentID">The Payment ID</param>
        /// <returns>A specific booking if found</returns>
        [HttpGet("{paymentID}")]
        public Booking GetPayment(string paymentID)
        {
            return new Booking();
        }
    }
}
