using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Core.Validation.Attributes;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Represents a <see href="$e/MerchantCustomAttributes/ListMerchantCustomAttributeDefinitions">ListMerchantCustomAttributeDefinitions</see> request.
/// </summary>
public record ListMerchantCustomAttributeDefinitionsRequest
{
    /// <summary>
    /// Enumeration of visibility-filter values used to set the ability to view custom attributes or custom attribute definitions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("visibility_filter")]
    public VisibilityFilter? VisibilityFilter { get; init; }

    /// <summary>
    /// The maximum number of results to return in a single paged response. This limit is advisory.
    /// The response might contain more or fewer results. The minimum value is 1 and the maximum value is 100.
    /// The default value is 20. For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("limit")]
    [Minimum(1)]
    [Maximum(100)]
    public int? Limit { get; init; }

    /// <summary>
    /// The cursor returned in the paged response from the previous call to this endpoint.
    /// Provide this cursor to retrieve the next page of results for your original request.
    /// For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
