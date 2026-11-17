using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Defines input parameters in a request to the
/// <see href="https://developer.squareup.com/reference/square_2024-08-21/subscriptions-api/retrieve-subscription">RetrieveSubscription</see> endpoint.
/// </summary>
public record RetrieveSubscriptionRequest
{
    /// <summary>
    /// A query parameter to specify related information to be included in the response.
    /// <para>
    /// The supported query parameter values are:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><c>actions</c>: to include scheduled actions on the targeted subscription.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("include")]
    public string? Include { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
