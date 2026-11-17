using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Describes a <c>DeleteInvoice</c> request.
/// </summary>
public record DeleteInvoiceRequest
{
    /// <summary>
    /// The version of the <see href="entity:Invoice">invoice</see> to delete.
    /// If you do not know the version, you can call <see href="api-endpoint:Invoices-GetInvoice">GetInvoice</see> or
    /// <see href="api-endpoint:Invoices-ListInvoices">ListInvoices</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version")]
    public int? Version { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
