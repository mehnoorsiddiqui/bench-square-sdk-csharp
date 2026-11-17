using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Filter events by loyalty account.
/// </summary>
public record LoyaltyEventLoyaltyAccountFilter
{
    /// <summary>
    /// The ID of the <see href="https://developer.squareup.com/reference/square_2024-08-21/objects/LoyaltyAccount">loyalty account</see> associated with loyalty events.
    /// </summary>
    [JsonPropertyName("loyalty_account_id")]
    [MinLength(1)]
    public required string LoyaltyAccountId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
