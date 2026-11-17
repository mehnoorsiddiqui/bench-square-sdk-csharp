using Square.Models;

namespace Square.Requests.Invoices;

/// <summary>
/// The inputs of the CancelInvoice operation.
/// </summary>
public sealed record CancelInvoiceOperationRequest
{
    /// <summary>
    /// The ID of the <see href="https://developer.squareup.com/reference/square_2024-08-21/objects/Invoice">invoice</see> to cancel.
    /// </summary>
    public required string InvoiceId { get; init; }

    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required CancelInvoiceRequest Body { get; init; }
}
