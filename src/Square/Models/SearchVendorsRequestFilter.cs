using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Defines supported query expressions to search for vendors by.
/// </summary>
public record SearchVendorsRequestFilter
{
    /// <summary>
    /// The names of the <see href="https://developer.squareup.com/reference/square_2024-08-21/objects/Vendor">Vendor</see> objects to retrieve.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public IReadOnlyList<string>? Name { get; init; }

    /// <summary>
    /// The statuses of the <see href="https://developer.squareup.com/reference/square_2024-08-21/objects/Vendor">Vendor</see> objects to retrieve.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public IReadOnlyList<string>? Status { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
