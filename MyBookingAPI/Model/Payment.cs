namespace MyBookingAPI.Model
{
    /// <summary>
    /// Model for a Ticket Payment
    /// </summary>
    public class Payment
    {
        /// <summary>
        /// A unique identifier for a Payment
        /// </summary>
        public string PaymentID { get; set; }

        /// <summary>
        /// The ID of Booking to be paid
        /// </summary>
        public string BookingID { get; set; }

        /// <summary>
        /// Payment type of how the payment is made
        /// </summary>
        public string PaymentType { get; set; }

        /// <summary>
        /// The total amount to be paid for the Booking
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// The Currency of payment to be paid
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// Indicates whether the Payment has been completed
        /// </summary>
        public bool Paid { get; set; }
    }
}
