using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record RetrieveCashDrawerShiftRequest
{
    /// <summary>
    /// The ID of the location to retrieve cash drawer shifts from.
    /// </summary>
    [JsonPropertyName("location_id")]
    [MinLength(1)]
    public required string LocationId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
