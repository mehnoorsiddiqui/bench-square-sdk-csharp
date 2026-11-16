using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Describes the ingredient used in a <c>FOOD_AND_BEV</c> item.
/// </summary>
public record CatalogItemFoodAndBeverageDetailsIngredient
{
    /// <summary>
    /// The type of dietary preference for the <c>FOOD_AND_BEV</c> type of items and integredients.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public CatalogItemFoodAndBeverageDetailsDietaryPreferenceType? Type { get; init; }

    /// <summary>
    /// The name of the ingredient from a standard pre-defined list. This should be null if it's a custom dietary preference.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("standard_name")]
    public string? StandardName { get; init; }

    /// <summary>
    /// The name of a custom user-defined ingredient. This should be null if it's a standard dietary preference.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("custom_name")]
    public string? CustomName { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
