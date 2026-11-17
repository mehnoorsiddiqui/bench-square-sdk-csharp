using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Updates a <see href="https://developer.squareup.com/reference/square_2024-08-21/objects/WebhookSubscription">Subscription</see> by replacing the existing signature key with a new one.
/// </summary>
public record UpdateWebhookSubscriptionSignatureKeyRequest
{
    /// <summary>
    /// A unique string that identifies the <see href="https://developer.squareup.com/reference/square_2024-08-21/webhook-subscriptions-api/update-webhook-subscriptionSignatureKey">UpdateWebhookSubscriptionSignatureKey</see> request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("idempotency_key")]
    [MaxLength(45)]
    public string? IdempotencyKey { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
