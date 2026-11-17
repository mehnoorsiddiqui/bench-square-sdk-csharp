using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents details about a <c>REDEEM</c> <see href="https://developer.squareup.com/reference/square_2024-08-21/objects/GiftCardActivityType">gift card activity type</see>.
/// </summary>
public record GiftCardActivityRedeem
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
    /// The ID of the payment that represents the gift card redemption. Square populates this field
    /// if the payment was processed by Square.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payment_id")]
    public string? PaymentId { get; init; }

    /// <summary>
    /// A client-specified ID that associates the gift card activity with an entity in another system.
    /// <para>
    /// Applications that use a custom payment processing system can use this field to track information
    /// related to an order or payment.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference_id")]
    public string? ReferenceId { get; init; }

    /// <summary>
    /// The status of the gift card redemption. Gift cards redeemed from Square Point of Sale or the
    /// Square Seller Dashboard use a two-state process: <c>PENDING</c>
    /// to <c>COMPLETED</c> or <c>PENDING</c> to  <c>CANCELED</c>. Gift cards redeemed using the Gift Card Activities API
    /// always have a <c>COMPLETED</c> status.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public string? Status { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
