using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents additional data for rules with the <c>SPEND</c> accrual type.
/// </summary>
public record LoyaltyProgramAccrualRuleSpendData
{
    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonPropertyName("amount_money")]
    public required Money AmountMoney { get; init; }

    /// <summary>
    /// The IDs of any <c>CATEGORY</c> catalog objects that are excluded from points accrual.
    /// <para>
    /// You can use the <see href="https://developer.squareup.com/reference/square_2024-04-17/catalog-api/batch-retrieve-catalog-objects">BatchRetrieveCatalogObjects</see>
    /// endpoint to retrieve information about the excluded categories.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("excluded_category_ids")]
    public IReadOnlyList<string>? ExcludedCategoryIds { get; init; }

    /// <summary>
    /// The IDs of any <c>ITEM_VARIATION</c> catalog objects that are excluded from points accrual.
    /// <para>
    /// You can use the <see href="https://developer.squareup.com/reference/square_2024-04-17/catalog-api/batch-retrieve-catalog-objects">BatchRetrieveCatalogObjects</see>
    /// endpoint to retrieve information about the excluded item variations.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("excluded_item_variation_ids")]
    public IReadOnlyList<string>? ExcludedItemVariationIds { get; init; }

    /// <summary>
    /// Indicates how taxes should be treated when calculating the purchase amount used for points accrual.
    /// </summary>
    [JsonPropertyName("tax_mode")]
    public required string TaxMode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
