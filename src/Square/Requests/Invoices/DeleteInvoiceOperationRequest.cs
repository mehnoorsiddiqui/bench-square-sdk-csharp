namespace Square.Requests.Invoices;

/// <summary>
/// The inputs of the DeleteInvoice operation.
/// </summary>
public sealed record DeleteInvoiceOperationRequest
{
    /// <summary>
    /// The ID of the invoice to delete.
    /// </summary>
    public required string InvoiceId { get; init; }

    /// <summary>
    /// The version of the <see href="https://developer.squareup.com/reference/square_2024-05-15/objects/Invoice">invoice</see> to delete.
    /// If you do not know the version, you can call <see href="https://developer.squareup.com/reference/square_2024-05-15/invoices-api/get-invoice">GetInvoice</see> or
    /// <see href="https://developer.squareup.com/reference/square_2024-05-15/invoices-api/list-invoices">ListInvoices</see>.
    /// </summary>
    public int? Version { get; init; }
}
