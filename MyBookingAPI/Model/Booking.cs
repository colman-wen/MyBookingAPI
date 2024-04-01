namespace MyBookingAPI.Model
{
    /// <summary>
    /// A model to record when a user book tickets for a event
    /// </summary>
    public class Booking
    {
        /// <summary>
        /// The User ID who books the tickets
        /// </summary>
        public string UserID { get; set; }

        /// <summary>
        /// A unique ID for this Booking. Value can be assigned after Booking has been placed against the event
        /// </summary>
        public string? BookingID { get; set; }

        /// <summary>
        /// The ID of event to be booked for the user
        /// </summary>
        public string EventID { get; set; }

        /// <summary>
        /// Counts the number of tickets to be booked with each Event Type
        /// </summary>
        public  Dictionary<TicketType, int> Counts { get; set; }

        /// <summary>
        /// Indicates whether a Payment has been made against this Booking
        /// </summary>
        public bool Paid { get; set; }
    }
}
