using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Defines input parameters in a request to the
/// <see href="https://developer.squareup.com/reference/square_2024-04-17/subscriptions-api/update-subscription">UpdateSubscription</see> endpoint.
/// </summary>
public record UpdateSubscriptionRequest
{
    /// <summary>
    /// Represents a subscription purchased by a customer.
    /// <para>
    /// For more information, see
    /// <see href="https://developer.squareup.com/docs/subscriptions-api/manage-subscriptions">Manage Subscriptions</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subscription")]
    public Subscription? Subscription { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
