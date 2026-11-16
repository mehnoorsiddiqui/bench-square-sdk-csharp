using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Dietary preferences that can be assigned to an <c>FOOD_AND_BEV</c> item and its ingredients.
/// </summary>
public record CatalogItemFoodAndBeverageDetailsDietaryPreference
{
    /// <summary>
    /// The type of dietary preference for the <c>FOOD_AND_BEV</c> type of items and integredients.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public CatalogItemFoodAndBeverageDetailsDietaryPreferenceType? Type { get; init; }

    /// <summary>
    /// The name of the dietary preference from a standard pre-defined list. This should be null if it's a custom dietary preference.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("standard_name")]
    public string? StandardName { get; init; }

    /// <summary>
    /// The name of a user-defined custom dietary preference. This should be null if it's a standard dietary preference.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("custom_name")]
    public string? CustomName { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
