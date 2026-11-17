using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Defines the fields that are included in the response body of
/// a request to the <see href="https://developer.squareup.com/reference/square_2024-08-21/webhook-subscriptions-api/test-webhook-subscription">TestWebhookSubscription</see> endpoint.
/// <para>
/// Note: If there are errors processing the request, the <see href="https://developer.squareup.com/reference/square_2024-08-21/objects/SubscriptionTestResult">SubscriptionTestResult</see> field is not
/// present.
/// </para>
/// </summary>
public record TestWebhookSubscriptionResponse
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
    [JsonPropertyName("subscription_test_result")]
    public SubscriptionTestResult? SubscriptionTestResult { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
