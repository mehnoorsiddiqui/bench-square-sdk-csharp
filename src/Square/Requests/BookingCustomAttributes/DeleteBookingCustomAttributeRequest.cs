namespace Square.Requests.BookingCustomAttributes;

/// <summary>
/// The inputs of the DeleteBookingCustomAttribute operation.
/// </summary>
public sealed record DeleteBookingCustomAttributeRequest
{
    /// <summary>
    /// The ID of the target <see href="https://developer.squareup.com/reference/square_2024-04-17/objects/Booking">booking</see>.
    /// </summary>
    public required string BookingId { get; init; }

    /// <summary>
    /// The key of the custom attribute to delete. This key must match the <c>key</c> of a custom
    /// attribute definition in the Square seller account. If the requesting application is not the
    /// definition owner, you must use the qualified key.
    /// </summary>
    public required string Key { get; init; }
}
