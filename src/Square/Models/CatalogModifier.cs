using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// A modifier applicable to items at the time of sale. An example of a modifier is a Cheese add-on to a Burger item.
/// </summary>
public record CatalogModifier
{
    /// <summary>
    /// The modifier name.  This is a searchable attribute for use in applicable query filters, and its value length is of Unicode code points.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    [MaxLength(255)]
    public string? Name { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("price_money")]
    public Money? PriceMoney { get; init; }

    /// <summary>
    /// Determines where this <c>CatalogModifier</c> appears in the <c>CatalogModifierList</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ordinal")]
    public int? Ordinal { get; init; }

    /// <summary>
    /// The ID of the <c>CatalogModifierList</c> associated with this modifier.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("modifier_list_id")]
    public string? ModifierListId { get; init; }

    /// <summary>
    /// Location-specific price overrides.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_overrides")]
    public IReadOnlyList<ModifierLocationOverrides>? LocationOverrides { get; init; }

    /// <summary>
    /// The ID of the image associated with this <c>CatalogModifier</c> instance.
    /// Currently this image is not displayed by Square, but is free to be displayed in 3rd party applications.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("image_id")]
    public string? ImageId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
