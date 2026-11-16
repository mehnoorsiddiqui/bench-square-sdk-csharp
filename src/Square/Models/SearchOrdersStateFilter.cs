using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Filter by the current order <c>state</c>.
/// </summary>
public record SearchOrdersStateFilter
{
    /// <summary>
    /// States to filter for.
    /// </summary>
    [JsonPropertyName("states")]
    public required IReadOnlyList<string> States { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
