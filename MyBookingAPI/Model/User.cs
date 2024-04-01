namespace MyBookingAPI.Model
{
    /// <summary>
    /// Model for a User
    /// </summary>
    public class User
    {
        /// <summary>
        /// A unique identifier of a User
        /// </summary>
        public string UserID { get; set; }

        /// <summary>
        /// Name of the User
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Email of the User
        /// </summary>
        public string UserEmail { get; set; }

        /// <summary>
        /// Password of the User
        /// </summary>
        public string Password { get; set; }
    }
}
