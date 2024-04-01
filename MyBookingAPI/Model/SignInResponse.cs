namespace MyBookingAPI.Model
{
    /// <summary>
    /// Model of responds for a sign in request
    /// </summary>
    public class SignInResponse: Response
    {
        /// <summary>
        /// Access token for a successful sign-in
        /// </summary>
        public string? Token { get; set; }
    }
}
