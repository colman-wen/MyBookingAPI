using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyBookingAPI.Model;

namespace MyBookingAPI.Controllers
{
    /// <summary>
    /// Controller to handle Payments
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PaymentController : ControllerBase
    {
        private readonly ILogger<PaymentController> _logger;

        /// <summary>
        /// Constructor with Logger
        /// </summary>
        /// <param name="logger"></param>
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
        /// <returns>The specific payment if found</returns>
        [HttpGet("{paymentID}")]
        public Payment GetPayment(string paymentID)
        {
            return new Payment();
        }
    }
}
