namespace Square.Requests.Loyalty;

/// <summary>
/// The inputs of the RetrieveLoyaltyReward operation.
/// </summary>
public sealed record RetrieveLoyaltyRewardRequest
{
    /// <summary>
    /// The ID of the <see href="https://developer.squareup.com/reference/square_2024-08-21/objects/LoyaltyReward">loyalty reward</see> to retrieve.
    /// </summary>
    public required string RewardId { get; init; }
}
