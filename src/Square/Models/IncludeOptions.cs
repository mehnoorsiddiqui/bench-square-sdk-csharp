using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Options to include related resources of the requested <c>CatalogObject</c>s. Related resources will be included in
/// <c>IncludedResources</c> in the response.
/// </summary>
public record IncludeOptions
{
    /// <summary>
    /// Resources to include in the response.
    /// See <see href="#type-includetype">IncludeType</see> for possible values
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("include")]
    public IReadOnlyList<IncludeType>? Include { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
