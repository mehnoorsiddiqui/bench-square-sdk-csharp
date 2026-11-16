using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record V1ListOrdersRequest
{
    /// <summary>
    /// The order in which payments are listed in the response.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order")]
    public string? Order { get; init; }

    /// <summary>
    /// The maximum number of payments to return in a single response. This value cannot exceed 200.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("limit")]
    public int? Limit { get; init; }

    /// <summary>
    /// A pagination cursor to retrieve the next set of results for your
    /// original query to the endpoint.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("batch_token")]
    public string? BatchToken { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
