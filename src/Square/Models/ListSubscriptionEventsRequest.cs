using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Core.Validation.Attributes;

namespace Square.Models;

/// <summary>
/// Defines input parameters in a request to the
/// <see href="$e/Subscriptions/ListSubscriptionEvents">ListSubscriptionEvents</see>
/// endpoint.
/// </summary>
public record ListSubscriptionEventsRequest
{
    /// <summary>
    /// When the total number of resulting subscription events exceeds the limit of a paged response,
    /// specify the cursor returned from a preceding response here to fetch the next set of results.
    /// If the cursor is unset, the response contains the last page of the results.
    /// <para>
    /// For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    /// <summary>
    /// The upper limit on the number of subscription events to return
    /// in a paged response.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("limit")]
    [Minimum(1)]
    public int? Limit { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
