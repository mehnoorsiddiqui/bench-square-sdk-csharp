namespace Square.Requests.Loyalty;

/// <summary>
/// The inputs of the CancelLoyaltyPromotion operation.
/// </summary>
public sealed record CancelLoyaltyPromotionRequest
{
    /// <summary>
    /// The ID of the <see href="https://developer.squareup.com/reference/square_2024-05-15/objects/LoyaltyPromotion">loyalty promotion</see> to cancel. You can cancel a
    /// promotion that has an <c>ACTIVE</c> or <c>SCHEDULED</c> status.
    /// </summary>
    public required string PromotionId { get; init; }

    /// <summary>
    /// The ID of the base <see href="https://developer.squareup.com/reference/square_2024-05-15/objects/LoyaltyProgram">loyalty program</see>.
    /// </summary>
    public required string ProgramId { get; init; }
}
