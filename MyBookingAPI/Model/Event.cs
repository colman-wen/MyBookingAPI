namespace MyBookingAPI.Model
{

    /// <summary>
    /// Model for an event
    /// </summary>
    public class Event
    {
        public string Id { get; set; }

        public string? Name { get; set; }

        public DateTime Date { get; set; }

        public DateTime Time { get; set; }

        public string? Venue { get; set; }

        /// <summary>
        /// Price for each ticket
        /// </summary>
        public decimal Price { get; set; } = 0;

        /// <summary>
        /// Number of available tickets
        /// </summary>
        public int Availibility { get; set; }
    }
}
