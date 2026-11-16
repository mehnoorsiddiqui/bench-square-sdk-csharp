using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates which products matched by a CatalogPricingRule
/// will be excluded if the pricing rule uses an exclude set.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ExcludeStrategy>))]
public sealed record ExcludeStrategy : OpenStringEnum<ExcludeStrategy>
{
    private ExcludeStrategy(string value) : base(value)
    {
    }

    /// <summary>
    /// The least expensive matched products are excluded from the pricing. If
    /// the pricing rule is set to exclude one product and multiple products in the
    /// match set qualify as least expensive, then one will be excluded at random.
    /// <para>
    /// Excluding the least expensive product gives the best discount value to the buyer.
    /// </para>
    /// </summary>
    public static readonly ExcludeStrategy LeastExpensive = new("LEAST_EXPENSIVE");

    /// <summary>
    /// The most expensive matched product is excluded from the pricing rule.
    /// If multiple products have the same price and all qualify as least expensive,
    /// one will be excluded at random.
    /// <para>
    /// This guarantees that the most expensive product is purchased at full price.
    /// </para>
    /// </summary>
    public static readonly ExcludeStrategy MostExpensive = new("MOST_EXPENSIVE");

    public TResult Match<TResult>(Func<TResult> onLeastExpensive,
        Func<TResult> onMostExpensive,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == LeastExpensive => onLeastExpensive(),
            _ when this == MostExpensive => onMostExpensive(),
            _ => otherwise(Value)
        };

    public void Match(Action onLeastExpensive, Action onMostExpensive, Action<string> otherwise)
    {
        if (this == LeastExpensive) onLeastExpensive();
        else if (this == MostExpensive) onMostExpensive();
        else otherwise(Value);
    }
}
