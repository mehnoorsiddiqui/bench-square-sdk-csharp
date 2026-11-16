using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Core.Validation.Attributes;

namespace Square.Models;

/// <summary>
/// Defines the query parameters that can be included in a request to the
/// <c>ListCustomers</c> endpoint.
/// </summary>
public record ListCustomersRequest
{
    /// <summary>
    /// A pagination cursor returned by a previous call to this endpoint.
    /// Provide this cursor to retrieve the next set of results for your original query.
    /// <para>
    /// For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    /// <summary>
    /// The maximum number of results to return in a single page. This limit is advisory. The response might contain more or fewer results.
    /// If the specified limit is less than 1 or greater than 100, Square returns a <c>400 VALUE_TOO_LOW</c> or <c>400 VALUE_TOO_HIGH</c> error. The default value is 100.
    /// <para>
    /// For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("limit")]
    [Minimum(1)]
    [Maximum(100)]
    public int? Limit { get; init; }

    /// <summary>
    /// Indicates how customers should be sorted.
    /// <para>
    /// The default value is <c>DEFAULT</c>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sort_field")]
    public string? SortField { get; init; }

    /// <summary>
    /// Indicates whether customers should be sorted in ascending (<c>ASC</c>) or
    /// descending (<c>DESC</c>) order.
    /// <para>
    /// The default value is <c>ASC</c>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sort_order")]
    public string? SortOrder { get; init; }

    /// <summary>
    /// Indicates whether to return the total count of customers in the <c>count</c> field of the response.
    /// <para>
    /// The default value is <c>false</c>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("count")]
    public bool? Count { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
