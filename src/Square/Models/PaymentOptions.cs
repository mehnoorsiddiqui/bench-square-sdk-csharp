using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record PaymentOptions
{
    /// <summary>
    /// Indicates whether the <c>Payment</c> objects created from this <c>TerminalCheckout</c> are automatically
    /// <c>COMPLETED</c> or left in an <c>APPROVED</c> state for later modification.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("autocomplete")]
    public bool? Autocomplete { get; init; }

    /// <summary>
    /// The duration of time after the payment's creation when Square automatically cancels the
    /// payment. This automatic cancellation applies only to payments that do not reach a terminal state
    /// (COMPLETED or CANCELED) before the <c>delay_duration</c> time period.
    /// <para>
    /// This parameter should be specified as a time duration, in RFC 3339 format, with a minimum value
    /// of 1 minute.
    /// </para>
    /// <para>
    /// Note: This feature is only supported for card payments. This parameter can only be set for a delayed
    /// capture payment (<c>autocomplete=false</c>).
    /// Default:
    /// - Card-present payments: "PT36H" (36 hours) from the creation time.
    /// - Card-not-present payments: "P7D" (7 days) from the creation time.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("delay_duration")]
    public string? DelayDuration { get; init; }

    /// <summary>
    /// If set to <c>true</c> and charging a Square Gift Card, a payment might be returned with
    /// <c>amount_money</c> equal to less than what was requested. For example, a request for $20 when charging
    /// a Square Gift Card with a balance of $5 results in an APPROVED payment of $5. You might choose
    /// to prompt the buyer for an additional payment to cover the remainder or cancel the Gift Card
    /// payment.
    /// <para>
    /// This field cannot be <c>true</c> when <c>autocomplete = true</c>.
    /// This field cannot be <c>true</c> when an <c>order_id</c> isn't specified.
    /// </para>
    /// <para>
    /// For more information, see
    /// <see href="https://developer.squareup.com/docs/payments-api/take-payments/card-payments/partial-payments-with-gift-cards">Take Partial Payments</see>.
    /// </para>
    /// <para>
    /// Default: false
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accept_partial_authorization")]
    public bool? AcceptPartialAuthorization { get; init; }

    /// <summary>
    /// The action to be applied to the payment when the delay_duration has elapsed.
    /// The action must be CANCEL or COMPLETE.
    /// <para>
    /// This parameter can only be set for a delayed capture payment (when <c>autocomplete</c> is <c>false</c>).
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("delay_action")]
    public string? DelayAction { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
