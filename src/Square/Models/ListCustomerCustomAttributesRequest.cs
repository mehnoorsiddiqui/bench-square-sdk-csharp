using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Core.Validation.Attributes;

namespace Square.Models;

/// <summary>
/// Represents a <see href="https://developer.squareup.com/reference/square_2024-08-21/customer-custom-attributes-api/list-customer-custom-attributes">ListCustomerCustomAttributes</see> request.
/// </summary>
public record ListCustomerCustomAttributesRequest
{
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
    /// Provide this cursor to retrieve the next page of results for your original request. For more
    /// information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    /// <summary>
    /// Indicates whether to return the <see href="https://developer.squareup.com/reference/square_2024-08-21/objects/CustomAttributeDefinition">custom attribute definition</see> in the <c>definition</c> field of each
    /// custom attribute. Set this parameter to <c>true</c> to get the name and description of each custom
    /// attribute, information about the data type, or other definition details. The default value is <c>false</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("with_definitions")]
    public bool? WithDefinitions { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
