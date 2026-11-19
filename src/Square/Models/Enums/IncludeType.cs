using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Related resources of requested <c>CatalogObject</c>s to include as part of the response.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<IncludeType>))]
public sealed record IncludeType : OpenStringEnum<IncludeType>
{
    private IncludeType(string value) : base(value)
    {
    }

    /// <summary>
    /// Return all nested <c>CatalogModifierList</c>s for <c>CatalogItem</c>, <c>CatalogModifier</c> and <c>CatalogModifierList</c> objects.
    /// </summary>
    public static readonly IncludeType IncludeNestedModifiers = new("INCLUDE_NESTED_MODIFIERS");

    /// <summary>
    /// Return all ancestor <c>CatalogModifierList</c>s for nested <c>CatalogModifierList</c>s objects.
    /// </summary>
    public static readonly IncludeType IncludeAncestorModifiers = new("INCLUDE_ANCESTOR_MODIFIERS");

    public TResult Match<TResult>(Func<TResult> onIncludeNestedModifiers,
        Func<TResult> onIncludeAncestorModifiers,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == IncludeNestedModifiers => onIncludeNestedModifiers(),
            _ when this == IncludeAncestorModifiers => onIncludeAncestorModifiers(),
            _ => otherwise(Value)
        };

    public void Match(Action onIncludeNestedModifiers, Action onIncludeAncestorModifiers, Action<string> otherwise)
    {
        if (this == IncludeNestedModifiers) onIncludeNestedModifiers();
        else if (this == IncludeAncestorModifiers) onIncludeAncestorModifiers();
        else otherwise(Value);
    }
}
