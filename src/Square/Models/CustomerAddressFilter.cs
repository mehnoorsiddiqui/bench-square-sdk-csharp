using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// The customer address filter. This filter is used in a <see href="https://developer.squareup.com/reference/square_2024-08-21/objects/CustomerCustomAttributeFilterValue">CustomerCustomAttributeFilterValue</see> filter when
/// searching by an <c>Address</c>-type custom attribute.
/// </summary>
public record CustomerAddressFilter
{
    /// <summary>
    /// A filter to select customers based on exact or fuzzy matching of
    /// customer attributes against a specified query. Depending on the customer attributes,
    /// the filter can be case-sensitive. This filter can be exact or fuzzy, but it cannot be both.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("postal_code")]
    public CustomerTextFilter? PostalCode { get; init; }

    /// <summary>
    /// The country code to search for.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("country")]
    public string? Country { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
