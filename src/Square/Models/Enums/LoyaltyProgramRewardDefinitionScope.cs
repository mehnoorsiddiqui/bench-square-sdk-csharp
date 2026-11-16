using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates the scope of the reward tier. DEPRECATED at version 2020-12-16. Discount details
/// are now defined using a catalog pricing rule and other catalog objects. For more information, see
/// <see href="https://developer.squareup.com/docs/loyalty-api/loyalty-rewards#get-discount-details">Getting discount details for a reward tier</see>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LoyaltyProgramRewardDefinitionScope>))]
public sealed record LoyaltyProgramRewardDefinitionScope : OpenStringEnum<LoyaltyProgramRewardDefinitionScope>
{
    private LoyaltyProgramRewardDefinitionScope(string value) : base(value)
    {
    }

    /// <summary>
    /// The discount applies to the entire order.
    /// </summary>
    public static readonly LoyaltyProgramRewardDefinitionScope Order = new("ORDER");

    /// <summary>
    /// The discount applies only to specific item variations.
    /// </summary>
    public static readonly LoyaltyProgramRewardDefinitionScope ItemVariation = new("ITEM_VARIATION");

    /// <summary>
    /// The discount applies only to items in the given categories.
    /// </summary>
    public static readonly LoyaltyProgramRewardDefinitionScope Category = new("CATEGORY");

    public TResult Match<TResult>(Func<TResult> onOrder,
        Func<TResult> onItemVariation,
        Func<TResult> onCategory,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Order => onOrder(),
            _ when this == ItemVariation => onItemVariation(),
            _ when this == Category => onCategory(),
            _ => otherwise(Value)
        };

    public void Match(Action onOrder, Action onItemVariation, Action onCategory, Action<string> otherwise)
    {
        if (this == Order) onOrder();
        else if (this == ItemVariation) onItemVariation();
        else if (this == Category) onCategory();
        else otherwise(Value);
    }
}
