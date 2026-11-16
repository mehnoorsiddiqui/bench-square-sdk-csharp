using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Core.Validation.Attributes;

namespace Square.Models;

/// <summary>
/// Represents a list request for order custom attribute definitions.
/// </summary>
public record ListOrderCustomAttributeDefinitionsRequest
{
    /// <summary>
    /// Requests that all of the custom attributes be returned, or only those that are read-only or read-write.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("visibility_filter")]
    public string? VisibilityFilter { get; init; }

    /// <summary>
    /// The cursor returned in the paged response from the previous call to this endpoint.
    /// Provide this cursor to retrieve the next page of results for your original request.
    /// For more information, see <see href="https://developer.squareup.com/docs/working-with-apis/pagination">Pagination</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    [MinLength(1)]
    public string? Cursor { get; init; }

    /// <summary>
    /// The maximum number of results to return in a single paged response. This limit is advisory.
    /// The response might contain more or fewer results. The minimum value is 1 and the maximum value is 100.
    /// The default value is 20.
    /// For more information, see <see href="https://developer.squareup.com/docs/working-with-apis/pagination">Pagination</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("limit")]
    [Minimum(1)]
    [Maximum(100)]
    public int? Limit { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
