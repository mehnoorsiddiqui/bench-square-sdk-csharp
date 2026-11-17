using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents the details of a tender with <c>type</c> <c>BANK_ACCOUNT</c>.
/// <para>
/// See <see href="https://developer.squareup.com/reference/square_2024-08-21/objects/BankAccountPaymentDetails">BankAccountPaymentDetails</see>
/// for more exposed details of a bank account payment.
/// </para>
/// </summary>
public record TenderBankAccountDetails
{
    /// <summary>
    /// The bank account payment's current state.
    /// <para>
    /// See <see href="https://developer.squareup.com/reference/square_2024-08-21/enums/TenderBankAccountDetailsStatus">TenderBankAccountPaymentDetailsStatus</see> for possible values.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public string? Status { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
