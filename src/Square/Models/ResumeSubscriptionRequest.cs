using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Defines input parameters in a request to the
/// <see href="https://developer.squareup.com/reference/square_2024-08-21/subscriptions-api/resume-subscription">ResumeSubscription</see> endpoint.
/// </summary>
public record ResumeSubscriptionRequest
{
    /// <summary>
    /// The <c>YYYY-MM-DD</c>-formatted date when the subscription reactivated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("resume_effective_date")]
    public string? ResumeEffectiveDate { get; init; }

    /// <summary>
    /// The timing to resume a subscription, relative to the specified
    /// <c>resume_effective_date</c> attribute value.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("resume_change_timing")]
    public string? ResumeChangeTiming { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
