using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents additional data for rules with the <c>CATEGORY</c> accrual type.
/// </summary>
public record LoyaltyProgramAccrualRuleCategoryData
{
    /// <summary>
    /// The ID of the <c>CATEGORY</c> <see href="https://developer.squareup.com/reference/square_2024-05-15/objects/CatalogObject">catalog object</see> that buyers can purchase to earn
    /// points.
    /// </summary>
    [JsonPropertyName("category_id")]
    [MinLength(1)]
    public required string CategoryId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
