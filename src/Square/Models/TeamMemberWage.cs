using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// The hourly wage rate that a team member earns on a <c>Shift</c> for doing the job
/// specified by the <c>title</c> property of this object.
/// </summary>
public record TeamMemberWage
{
    /// <summary>
    /// The UUID for this object.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The <c>TeamMember</c> that this wage is assigned to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("team_member_id")]
    public string? TeamMemberId { get; init; }

    /// <summary>
    /// The job title that this wage relates to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("title")]
    public string? Title { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hourly_rate")]
    public Money? HourlyRate { get; init; }

    /// <summary>
    /// An identifier for the job that this wage relates to. This cannot be
    /// used to retrieve the job.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("job_id")]
    public string? JobId { get; init; }

    /// <summary>
    /// Whether team members are eligible for tips when working this job.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tip_eligible")]
    public bool? TipEligible { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
