using Square.Models;

namespace Square.Requests.Bookings;

/// <summary>
/// The inputs of the UpdateBooking operation.
/// </summary>
public sealed record UpdateBookingOperationRequest
{
    /// <summary>
    /// The ID of the <see href="https://developer.squareup.com/reference/square_2024-04-17/objects/Booking">Booking</see> object representing the to-be-updated booking.
    /// </summary>
    public required string BookingId { get; init; }

    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required UpdateBookingRequest Body { get; init; }
}
