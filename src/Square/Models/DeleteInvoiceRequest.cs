using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Describes a <c>DeleteInvoice</c> request.
/// </summary>
public record DeleteInvoiceRequest
{
    /// <summary>
    /// The version of the <see href="https://developer.squareup.com/reference/square_2024-04-17/objects/Invoice">invoice</see> to delete.
    /// If you do not know the version, you can call <see href="https://developer.squareup.com/reference/square_2024-04-17/invoices-api/get-invoice">GetInvoice</see> or
    /// <see href="https://developer.squareup.com/reference/square_2024-04-17/invoices-api/list-invoices">ListInvoices</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version")]
    public int? Version { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
