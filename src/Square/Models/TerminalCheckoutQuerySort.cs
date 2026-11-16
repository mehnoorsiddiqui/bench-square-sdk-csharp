using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record TerminalCheckoutQuerySort
{
    /// <summary>
    /// The order in which results are listed.
    /// Default: <c>DESC</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sort_order")]
    public string? SortOrder { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
