using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// A request to update a <c>Shift</c> object.
/// </summary>
public record UpdateShiftRequest
{
    /// <summary>
    /// A record of the hourly rate, start, and end times for a single work shift
    /// for an employee. This might include a record of the start and end times for breaks
    /// taken during the shift.
    /// </summary>
    [JsonPropertyName("shift")]
    public required Shift Shift { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
