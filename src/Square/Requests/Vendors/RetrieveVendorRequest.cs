namespace Square.Requests.Vendors;

/// <summary>
/// The inputs of the RetrieveVendor operation.
/// </summary>
public sealed record RetrieveVendorRequest
{
    /// <summary>
    /// ID of the <see href="https://developer.squareup.com/reference/square_2024-05-15/objects/Vendor">Vendor</see> to retrieve.
    /// </summary>
    public required string VendorId { get; init; }
}
