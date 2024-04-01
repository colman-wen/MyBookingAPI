namespace MyBookingAPI.Model
{
    /// <summary>
    /// Model of responds for a request
    /// </summary>
    public class Response
    {
        /// <summary>
        /// Message of the response
        /// </summary>
        public string? Message {  get; set; }

        /// <summary>
        /// Error Code of the response. 0 means successful
        /// </summary>
        public int Status { get; set; } = 0;
    }
}
