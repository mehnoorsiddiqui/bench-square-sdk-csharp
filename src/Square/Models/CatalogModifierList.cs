using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// For a text-based modifier, this encapsulates the modifier's text when its <c>modifier_type</c> is <c>TEXT</c>.
/// For example, to sell T-shirts with custom prints, a text-based modifier can be used to capture the buyer-supplied
/// text string to be selected for the T-shirt at the time of sale.
/// <para>
/// For non text-based modifiers, this encapsulates a non-empty list of modifiers applicable to items
/// at the time of sale. Each element of the modifier list is a <c>CatalogObject</c> instance of the <c>MODIFIER</c> type.
/// For example, a "Condiments" modifier list applicable to a "Hot Dog" item
/// may contain "Ketchup", "Mustard", and "Relish" modifiers.
/// </para>
/// <para>
/// A non text-based modifier can be applied to the modified item once or multiple times, if the <c>selection_type</c> field
/// is set to <c>SINGLE</c> or <c>MULTIPLE</c>, respectively. On the other hand, a text-based modifier can be applied to the item
/// only once and the <c>selection_type</c> field is always set to <c>SINGLE</c>.
/// </para>
/// </summary>
public record CatalogModifierList
{
    /// <summary>
    /// The name of the <c>CatalogModifierList</c> instance. This is a searchable attribute for use in applicable query filters, and its value length is of
    /// Unicode code points.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    [MaxLength(255)]
    public string? Name { get; init; }

    /// <summary>
    /// The position of this <c>CatalogModifierList</c> within a list of <c>CatalogModifierList</c> instances.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ordinal")]
    public int? Ordinal { get; init; }

    /// <summary>
    /// Indicates whether a single (<c>SINGLE</c>) or multiple (<c>MULTIPLE</c>) modifiers from the list
    /// can be applied to a single <c>CatalogItem</c>.
    /// <para>
    /// For text-based modifiers, the <c>selection_type</c> attribute is always <c>SINGLE</c>. The other value is ignored.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("selection_type")]
    public string? SelectionType { get; init; }

    /// <summary>
    /// A non-empty list of <c>CatalogModifier</c> objects to be included in the <c>CatalogModifierList</c>,
    /// for non text-based modifiers when the <c>modifier_type</c> attribute is <c>LIST</c>. Each element of this list
    /// is a <c>CatalogObject</c> instance of the <c>MODIFIER</c> type, containing the following attributes:
    /// <code>
    /// {
    /// "id": "{{catalog_modifier_id}}",
    /// "type": "MODIFIER",
    /// "modifier_data": {{a CatalogModifier instance&gt;}}
    /// }
    /// </code>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("modifiers")]
    public IReadOnlyList<CatalogObject>? Modifiers { get; init; }

    /// <summary>
    /// The IDs of images associated with this <c>CatalogModifierList</c> instance.
    /// Currently these images are not displayed on Square products, but may be displayed in 3rd-party applications.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("image_ids")]
    public IReadOnlyList<string>? ImageIds { get; init; }

    /// <summary>
    /// The type of the modifier.
    /// <para>
    /// When this <c>modifier_type</c> value is <c>TEXT</c>,  the <c>CatalogModifierList</c> represents a text-based modifier.
    /// When this <c>modifier_type</c> value is <c>LIST</c>, the <c>CatalogModifierList</c> contains a list of <c>CatalogModifier</c> objects.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("modifier_type")]
    public string? ModifierType { get; init; }

    /// <summary>
    /// The maximum length, in Unicode points, of the text string of the text-based modifier as represented by
    /// this <c>CatalogModifierList</c> object with the <c>modifier_type</c> set to <c>TEXT</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("max_length")]
    public int? MaxLength { get; init; }

    /// <summary>
    /// Whether the text string must be a non-empty string (<c>true</c>) or not (<c>false</c>) for a text-based modifier
    /// as represented by this <c>CatalogModifierList</c> object with the <c>modifier_type</c> set to <c>TEXT</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("text_required")]
    public bool? TextRequired { get; init; }

    /// <summary>
    /// A note for internal use by the business.
    /// <para>
    /// For example, for a text-based modifier applied to a T-shirt item, if the buyer-supplied text of "Hello, Kitty!"
    /// is to be printed on the T-shirt, this <c>internal_name</c> attribute can be "Use italic face" as
    /// an instruction for the business to follow.
    /// </para>
    /// <para>
    /// For non text-based modifiers, this <c>internal_name</c> attribute can be
    /// used to include SKUs, internal codes, or supplemental descriptions for internal use.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("internal_name")]
    [MaxLength(512)]
    public string? InternalName { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
