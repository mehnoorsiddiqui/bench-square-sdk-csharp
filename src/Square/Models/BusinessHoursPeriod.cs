using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents a period of time during which a business location is open.
/// </summary>
public record BusinessHoursPeriod
{
    /// <summary>
    /// The day of the week for this time period.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("day_of_week")]
    public string? DayOfWeek { get; init; }

    /// <summary>
    /// The start time of a business hours period, specified in local time using partial-time
    /// RFC 3339 format. For example, <c>8:30:00</c> for a period starting at 8:30 in the morning.
    /// Note that the seconds value is always :00, but it is appended for conformance to the RFC.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("start_local_time")]
    public string? StartLocalTime { get; init; }

    /// <summary>
    /// The end time of a business hours period, specified in local time using partial-time
    /// RFC 3339 format. For example, <c>21:00:00</c> for a period ending at 9:00 in the evening.
    /// Note that the seconds value is always :00, but it is appended for conformance to the RFC.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("end_local_time")]
    public string? EndLocalTime { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
