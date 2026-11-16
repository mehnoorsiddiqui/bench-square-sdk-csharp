using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Defines the request parameters for the <c>ListDisputes</c> endpoint.
/// </summary>
public record ListDisputesRequest
{
    /// <summary>
    /// A pagination cursor returned by a previous call to this endpoint.
    /// Provide this cursor to retrieve the next set of results for the original query.
    /// For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    /// <summary>
    /// The dispute states used to filter the result. If not specified, the endpoint returns all disputes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("states")]
    public IReadOnlyList<string>? States { get; init; }

    /// <summary>
    /// The ID of the location for which to return a list of disputes.
    /// If not specified, the endpoint returns disputes associated with all locations.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_id")]
    [StringLength(40, MinimumLength = 1)]
    public string? LocationId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
