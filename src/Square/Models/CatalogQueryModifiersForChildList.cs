using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Query to find <c>CatalogModifier</c> objects that reference a given <c>CatalogModifierList</c> in their <c>child_modifier_list_ids</c> field.
/// </summary>
public record CatalogQueryModifiersForChildList
{
    /// <summary>
    /// The <c>CatalogModifierList</c> IDs to find parent <c>CatalogModifier</c>s for.
    /// Returns <c>CatalogModifier</c> objects where <c>child_modifier_list_ids</c> contains any of these IDs.
    /// </summary>
    [JsonPropertyName("child_modifier_list_ids")]
    public required IReadOnlyList<string> ChildModifierListIds { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
