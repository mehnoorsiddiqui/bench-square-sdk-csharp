namespace Square.Requests.Inventory;

/// <summary>
/// The inputs of the RetrieveInventoryPhysicalCount operation.
/// </summary>
public sealed record RetrieveInventoryPhysicalCountRequest
{
    /// <summary>
    /// ID of the
    /// <see href="https://developer.squareup.com/reference/square_2024-04-17/objects/InventoryPhysicalCount">InventoryPhysicalCount</see> to retrieve.
    /// </summary>
    public required string PhysicalCountId { get; init; }
}
