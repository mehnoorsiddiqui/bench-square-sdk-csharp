using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Defines the fields that are included in the response body of
/// a request to the <see href="https://developer.squareup.com/reference/square_2024-04-17/webhook-subscriptions-api/update-webhook-subscription">UpdateWebhookSubscription</see> endpoint.
/// <para>
/// Note: If there are errors processing the request, the <see href="https://developer.squareup.com/reference/square_2024-04-17/objects/WebhookSubscription">Subscription</see> is not
/// present.
/// </para>
/// </summary>
public record UpdateWebhookSubscriptionResponse
{
    /// <summary>
    /// Information on errors encountered during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// Represents the details of a webhook subscription, including notification URL,
    /// event types, and signature key.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subscription")]
    public WebhookSubscription? Subscription { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
