using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents a <see href="api-endpoint:Team-ListJobs">ListJobs</see> request.
/// </summary>
public record ListJobsRequest
{
    /// <summary>
    /// The pagination cursor returned by the previous call to this endpoint. Provide this
    /// cursor to retrieve the next page of results for your original request. For more information,
    /// see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
