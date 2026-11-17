using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents the details of a tender with <c>type</c> <c>BUY_NOW_PAY_LATER</c>.
/// </summary>
public record TenderBuyNowPayLaterDetails
{
    /// <summary>
    /// The Buy Now Pay Later brand.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("buy_now_pay_later_brand")]
    public string? BuyNowPayLaterBrand { get; init; }

    /// <summary>
    /// The buy now pay later payment's current state (such as <c>AUTHORIZED</c> or
    /// <c>CAPTURED</c>). See <see href="https://developer.squareup.com/reference/square_2024-08-21/enums/TenderBuyNowPayLaterDetailsStatus">TenderBuyNowPayLaterDetailsStatus</see>
    /// for possible values.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public string? Status { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
