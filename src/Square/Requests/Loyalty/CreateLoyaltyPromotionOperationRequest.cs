using Square.Models;

namespace Square.Requests.Loyalty;

/// <summary>
/// The inputs of the CreateLoyaltyPromotion operation.
/// </summary>
public sealed record CreateLoyaltyPromotionOperationRequest
{
    /// <summary>
    /// The ID of the <see href="https://developer.squareup.com/reference/square_2024-04-17/objects/LoyaltyProgram">loyalty program</see> to associate with the promotion.
    /// To get the program ID, call <see href="https://developer.squareup.com/reference/square_2024-04-17/loyalty-api/retrieve-loyalty-program">RetrieveLoyaltyProgram</see>
    /// using the <c>main</c> keyword.
    /// </summary>
    public required string ProgramId { get; init; }

    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required CreateLoyaltyPromotionRequest Body { get; init; }
}
