using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents the details of a tender with <c>type</c> <c>SQUARE_ACCOUNT</c>.
/// </summary>
public record TenderSquareAccountDetails
{
    /// <summary>
    /// The Square Account payment's current state (such as <c>AUTHORIZED</c> or
    /// <c>CAPTURED</c>). See <see href="https://developer.squareup.com/reference/square_2024-08-21/enums/TenderSquareAccountDetailsStatus">TenderSquareAccountDetailsStatus</see>
    /// for possible values.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public string? Status { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
