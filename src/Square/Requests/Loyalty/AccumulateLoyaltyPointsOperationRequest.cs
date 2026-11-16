using Square.Models;

namespace Square.Requests.Loyalty;

/// <summary>
/// The inputs of the AccumulateLoyaltyPoints operation.
/// </summary>
public sealed record AccumulateLoyaltyPointsOperationRequest
{
    /// <summary>
    /// The ID of the target <see href="https://developer.squareup.com/reference/square_2024-05-15/objects/LoyaltyAccount">loyalty account</see>.
    /// </summary>
    public required string AccountId { get; init; }

    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required AccumulateLoyaltyPointsRequest Body { get; init; }
}
