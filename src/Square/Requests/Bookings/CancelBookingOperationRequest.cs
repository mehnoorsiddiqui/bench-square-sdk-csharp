using Square.Models;

namespace Square.Requests.Bookings;

/// <summary>
/// The inputs of the CancelBooking operation.
/// </summary>
public sealed record CancelBookingOperationRequest
{
    /// <summary>
    /// The ID of the <see href="https://developer.squareup.com/reference/square_2024-04-17/objects/Booking">Booking</see> object representing the to-be-cancelled booking.
    /// </summary>
    public required string BookingId { get; init; }

    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required CancelBookingRequest Body { get; init; }
}
