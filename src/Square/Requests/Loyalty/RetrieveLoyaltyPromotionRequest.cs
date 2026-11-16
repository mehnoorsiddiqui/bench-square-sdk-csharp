namespace Square.Requests.Loyalty;

/// <summary>
/// The inputs of the RetrieveLoyaltyPromotion operation.
/// </summary>
public sealed record RetrieveLoyaltyPromotionRequest
{
    /// <summary>
    /// The ID of the <see href="https://developer.squareup.com/reference/square_2024-04-17/objects/LoyaltyPromotion">loyalty promotion</see> to retrieve.
    /// </summary>
    public required string PromotionId { get; init; }

    /// <summary>
    /// The ID of the base <see href="https://developer.squareup.com/reference/square_2024-04-17/objects/LoyaltyProgram">loyalty program</see>. To get the program ID,
    /// call <see href="https://developer.squareup.com/reference/square_2024-04-17/loyalty-api/retrieve-loyalty-program">RetrieveLoyaltyProgram</see> using the <c>main</c> keyword.
    /// </summary>
    public required string ProgramId { get; init; }
}
