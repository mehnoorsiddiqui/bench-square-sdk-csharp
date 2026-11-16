using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record V1ListOrdersResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("items")]
    public IReadOnlyList<V1Order>? Items { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
