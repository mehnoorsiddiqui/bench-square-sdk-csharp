namespace Square.Requests.Loyalty;

/// <summary>
/// The inputs of the DeleteLoyaltyReward operation.
/// </summary>
public sealed record DeleteLoyaltyRewardRequest
{
    /// <summary>
    /// The ID of the <see href="https://developer.squareup.com/reference/square_2024-04-17/objects/LoyaltyReward">loyalty reward</see> to delete.
    /// </summary>
    public required string RewardId { get; init; }
}
