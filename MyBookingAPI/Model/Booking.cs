﻿namespace MyBookingAPI.Model
{
    public class Booking
    {
        public string UserID { get; set; }

        public string BookingID { get; set; }

        public string EventID { get; set; }

        public int Count { get; set; }

        public bool Paid { get; set; }
    }
}