using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents a get request for an order custom attribute definition.
/// </summary>
public record RetrieveOrderCustomAttributeDefinitionRequest
{
    /// <summary>
    /// To enable <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/optimistic-concurrency">optimistic concurrency</see>
    /// control, include this optional field and specify the current version of the custom attribute.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version")]
    public int? Version { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
