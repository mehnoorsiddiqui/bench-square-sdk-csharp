namespace Square.Requests.Inventory;

/// <summary>
/// The inputs of the RetrieveInventoryTransfer operation.
/// </summary>
public sealed record RetrieveInventoryTransferRequest
{
    /// <summary>
    /// ID of the <see href="https://developer.squareup.com/reference/square_2024-08-21/objects/InventoryTransfer">InventoryTransfer</see> to retrieve.
    /// </summary>
    public required string TransferId { get; init; }
}
