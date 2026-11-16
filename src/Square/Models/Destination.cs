using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Information about the destination against which the payout was made.
/// </summary>
public record Destination
{
    /// <summary>
    /// Type of the destination such as a bank account or debit card.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    /// <summary>
    /// Square issued unique ID (also known as the instrument ID) associated with this destination.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
