namespace MyBookingAPI.Model
{
    public class Payment
    {
        public string PaymentID { get; set; }

        public string BookingID { get; set; }

        public string PaymentType { get; set; }

        public decimal Amount { get; set; }

        public bool Paid { get; set; }
    }
}
