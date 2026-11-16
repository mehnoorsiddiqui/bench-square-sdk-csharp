namespace Square.Requests.Inventory;

/// <summary>
/// The inputs of the DeprecatedRetrieveInventoryPhysicalCount operation.
/// </summary>
public sealed record DeprecatedRetrieveInventoryPhysicalCountRequest
{
    /// <summary>
    /// ID of the
    /// <see href="https://developer.squareup.com/reference/square_2024-05-15/objects/InventoryPhysicalCount">InventoryPhysicalCount</see> to retrieve.
    /// </summary>
    public required string PhysicalCountId { get; init; }
}
