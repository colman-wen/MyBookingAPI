My booking APIs

This is a simple API project that is designed as a ticket booking system. It has controllers to allow users to manage their accounts, view events, book tickets and manage their bookings. The following are details for each controll.

# UserController
All user account related endpoints are under this controller. In the case of user sign in, a token should be returned as an authentication key so that other requests require user information can use this key as an identifier.

# EventController
This controller allow users to view all available events or a specific event. Sign-in is not required as these are public information and read only. Modification of the events will require other system as they should be managed by internal officials only. Each event may contain multiple ticket types for different prices. 

# BookingController
This controller is for users to book, retrieve, modify and cancel their tickets. Users can see all bookings under their account. They can also see details of a specific booking of their own by providing a booking ID. 

# PaymentController
This controller is to manage user payments. Payment itself can be a complex system. It should handle workflows such as redirects, retry, and network connection, etc. Although payments and bookings is a one to one relation, it deserve its own controller instead of being part of the BookingController.
