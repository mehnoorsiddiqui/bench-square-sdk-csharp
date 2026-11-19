using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Related resources of the response <c>CatalogObject</c>s requested using <c>IncludeOptions</c>
/// </summary>
public record IncludedResources
{
    /// <summary>
    /// Nested <c>CatalogModifierList</c>s as requested via <c>INCLUDE_NESTED_MODIFIERS</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nested_modifiers")]
    public IReadOnlyList<CatalogObject>? NestedModifiers { get; init; }

    /// <summary>
    /// Ancestor <c>CatalogModifierList</c>s as requested via INCLUDE_ANCESTOR_MODIFIERS
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ancestor_modifiers")]
    public IReadOnlyList<CatalogObject>? AncestorModifiers { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
