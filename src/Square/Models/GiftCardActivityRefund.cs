using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents details about a <c>REFUND</c> <see href="https://developer.squareup.com/reference/square_2024-04-17/objects/GiftCardActivityType">gift card activity type</see>.
/// </summary>
public record GiftCardActivityRefund
{
    /// <summary>
    /// The ID of the refunded <c>REDEEM</c> gift card activity. Square populates this field if the
    /// <c>payment_id</c> in the corresponding <see href="https://developer.squareup.com/reference/square_2024-04-17/refunds-api/refund-payment">RefundPayment</see> request
    /// represents a redemption made by the same gift card. Note that you must use <c>RefundPayment</c>
    /// to refund a gift card payment to the same gift card if the payment was processed by Square.
    /// <para>
    /// For applications that use a custom payment processing system, this field is required when creating
    /// a <c>REFUND</c> activity. The provided <c>REDEEM</c> activity ID must be linked to the same gift card.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("redeem_activity_id")]
    public string? RedeemActivityId { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount_money")]
    public Money? AmountMoney { get; init; }

    /// <summary>
    /// A client-specified ID that associates the gift card activity with an entity in another system.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference_id")]
    public string? ReferenceId { get; init; }

    /// <summary>
    /// The ID of the refunded payment. Square populates this field if the refund is for a
    /// payment processed by Square and one of the following conditions is true:
    /// <para>
    /// - The Refunds API is used to refund a gift card payment to the same gift card.
    /// - A seller initiated the refund from Square Point of Sale or the Seller Dashboard. The payment source can be the
    /// same gift card or a cross-tender payment from a credit card or a different gift card.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payment_id")]
    public string? PaymentId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
