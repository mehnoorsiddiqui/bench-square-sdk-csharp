namespace Square.Requests.Inventory;

/// <summary>
/// The inputs of the DeprecatedRetrieveInventoryAdjustment operation.
/// </summary>
public sealed record DeprecatedRetrieveInventoryAdjustmentRequest
{
    /// <summary>
    /// ID of the <see href="https://developer.squareup.com/reference/square_2024-08-21/objects/InventoryAdjustment">InventoryAdjustment</see> to retrieve.
    /// </summary>
    public required string AdjustmentId { get; init; }
}
