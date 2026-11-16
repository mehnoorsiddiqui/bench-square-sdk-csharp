namespace Square.Requests.OrderCustomAttributes;

/// <summary>
/// The inputs of the DeleteOrderCustomAttribute operation.
/// </summary>
public sealed record DeleteOrderCustomAttributeRequest
{
    /// <summary>
    /// The ID of the target <see href="https://developer.squareup.com/reference/square_2024-05-15/objects/Order">order</see>.
    /// </summary>
    public required string OrderId { get; init; }

    /// <summary>
    /// The key of the custom attribute to delete.  This key must match the key of an
    /// existing custom attribute definition.
    /// </summary>
    public required string CustomAttributeKey { get; init; }
}
