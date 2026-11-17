using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Defines a sorter used to sort results from <see href="https://developer.squareup.com/reference/square_2024-08-21/vendors-api/search-vendors">SearchVendors</see>.
/// </summary>
public record SearchVendorsRequestSort
{
    /// <summary>
    /// Specifies the sort key to sort the returned vendors.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("field")]
    public string? Field { get; init; }

    /// <summary>
    /// Specifies the sort order for the returned vendors.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order")]
    public string? Order { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
