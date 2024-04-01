namespace MyBookingAPI.Model
{
    /// <summary>
    /// Model for an event
    /// </summary>
    public class Event
    {
        /// <summary>
        /// A unique Identifier for each Event
        /// </summary>
        public string EventId { get; set; }

        /// <summary>
        /// The Event Name
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// The Date of when the Event will take place
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// The time of when the Event will happen
        /// </summary>
        public DateTime Time { get; set; }

        /// <summary>
        /// The location of where the event will take place
        /// </summary>
        public string? Venue { get; set; }

        /// <summary>
        /// Price for a ticket under each Event Type
        /// </summary>
        public Dictionary<TicketType, decimal> Prices { get; set; }

        /// <summary>
        /// Number of available tickets left
        /// </summary>
        public int Availibility { get; set; }
    }
}
