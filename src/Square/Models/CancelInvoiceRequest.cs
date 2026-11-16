using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Describes a <c>CancelInvoice</c> request.
/// </summary>
public record CancelInvoiceRequest
{
    /// <summary>
    /// The version of the <see href="https://developer.squareup.com/reference/square_2024-05-15/objects/Invoice">invoice</see> to cancel.
    /// If you do not know the version, you can call
    /// <see href="https://developer.squareup.com/reference/square_2024-05-15/invoices-api/get-invoice">GetInvoice</see> or <see href="https://developer.squareup.com/reference/square_2024-05-15/invoices-api/list-invoices">ListInvoices</see>.
    /// </summary>
    [JsonPropertyName("version")]
    public required int Version { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
