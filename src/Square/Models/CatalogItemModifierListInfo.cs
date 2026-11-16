using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// References a text-based modifier or a list of non text-based modifiers applied to a <c>CatalogItem</c> instance
/// and specifies supported behaviors of the application.
/// </summary>
public record CatalogItemModifierListInfo
{
    /// <summary>
    /// The ID of the <c>CatalogModifierList</c> controlled by this <c>CatalogModifierListInfo</c>.
    /// </summary>
    [JsonPropertyName("modifier_list_id")]
    [MinLength(1)]
    public required string ModifierListId { get; init; }

    /// <summary>
    /// A set of <c>CatalogModifierOverride</c> objects that override whether a given <c>CatalogModifier</c> is enabled by default.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("modifier_overrides")]
    public IReadOnlyList<CatalogModifierOverride>? ModifierOverrides { get; init; }

    /// <summary>
    /// If 0 or larger, the smallest number of <c>CatalogModifier</c>s that must be selected from this <c>CatalogModifierList</c>.
    /// The default value is <c>-1</c>.
    /// <para>
    /// When  <c>CatalogModifierList.selection_type</c> is <c>MULTIPLE</c>, <c>CatalogModifierListInfo.min_selected_modifiers=-1</c>
    /// and <c>CatalogModifierListInfo.max_selected_modifier=-1</c> means that from zero to the maximum number of modifiers of
    /// the <c>CatalogModifierList</c> can be selected from the <c>CatalogModifierList</c>.
    /// </para>
    /// <para>
    /// When the <c>CatalogModifierList.selection_type</c> is <c>SINGLE</c>, <c>CatalogModifierListInfo.min_selected_modifiers=-1</c>
    /// and <c>CatalogModifierListInfo.max_selected_modifier=-1</c> means that exactly one modifier must be present in
    /// and can be selected from the <c>CatalogModifierList</c>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("min_selected_modifiers")]
    public int? MinSelectedModifiers { get; init; }

    /// <summary>
    /// If 0 or larger, the largest number of <c>CatalogModifier</c>s that can be selected from this <c>CatalogModifierList</c>.
    /// The default value is <c>-1</c>.
    /// <para>
    /// When  <c>CatalogModifierList.selection_type</c> is <c>MULTIPLE</c>, <c>CatalogModifierListInfo.min_selected_modifiers=-1</c>
    /// and <c>CatalogModifierListInfo.max_selected_modifier=-1</c> means that from zero to the maximum number of modifiers of
    /// the <c>CatalogModifierList</c> can be selected from the <c>CatalogModifierList</c>.
    /// </para>
    /// <para>
    /// When the <c>CatalogModifierList.selection_type</c> is <c>SINGLE</c>, <c>CatalogModifierListInfo.min_selected_modifiers=-1</c>
    /// and <c>CatalogModifierListInfo.max_selected_modifier=-1</c> means that exactly one modifier must be present in
    /// and can be selected from the <c>CatalogModifierList</c>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("max_selected_modifiers")]
    public int? MaxSelectedModifiers { get; init; }

    /// <summary>
    /// If <c>true</c>, enable this <c>CatalogModifierList</c>. The default value is <c>true</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; init; }

    /// <summary>
    /// The position of this <c>CatalogItemModifierListInfo</c> object within the <c>modifier_list_info</c> list applied
    /// to a <c>CatalogItem</c> instance.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ordinal")]
    public int? Ordinal { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
