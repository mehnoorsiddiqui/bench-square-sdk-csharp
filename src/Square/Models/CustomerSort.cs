using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents the sorting criteria in a <see href="https://developer.squareup.com/reference/square_2024-04-17/objects/CustomerQuery">search query</see> that defines how to sort
/// customer profiles returned in <see href="https://developer.squareup.com/reference/square_2024-04-17/customers-api/search-customers">SearchCustomers</see> results.
/// </summary>
public record CustomerSort
{
    /// <summary>
    /// Indicates the fields to use as the sort key, which is either the default set of fields or <c>created_at</c>.
    /// <para>
    /// The default value is <c>DEFAULT</c>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("field")]
    public string? Field { get; init; }

    /// <summary>
    /// Indicates the order in which results should be sorted based on the
    /// sort field value. Strings use standard alphabetic comparison
    /// to determine order. Strings representing numbers are sorted as strings.
    /// <para>
    /// The default value is <c>ASC</c>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order")]
    public string? Order { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
