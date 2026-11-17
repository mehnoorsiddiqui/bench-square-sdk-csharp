using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Creates a <see href="https://developer.squareup.com/reference/square_2024-08-21/objects/WebhookSubscription">Subscription</see>.
/// </summary>
public record CreateWebhookSubscriptionRequest
{
    /// <summary>
    /// A unique string that identifies the <see href="https://developer.squareup.com/reference/square_2024-08-21/webhook-subscriptions-api/create-webhook-subscription">CreateWebhookSubscription</see> request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("idempotency_key")]
    [MaxLength(45)]
    public string? IdempotencyKey { get; init; }

    /// <summary>
    /// Represents the details of a webhook subscription, including notification URL,
    /// event types, and signature key.
    /// </summary>
    [JsonPropertyName("subscription")]
    public required WebhookSubscription Subscription { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
