namespace MyBookingAPI.Model
{
    public abstract class Response
    {
        protected Response() { }
        public string? Message {  get; set; }

        public int Status { get; set; } = 0;
    }
}
