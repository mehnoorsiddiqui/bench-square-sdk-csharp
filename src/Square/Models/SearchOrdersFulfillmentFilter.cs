using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Filter based on <see href="https://developer.squareup.com/reference/square_2024-04-17/objects/Fulfillment">order fulfillment</see> information.
/// </summary>
public record SearchOrdersFulfillmentFilter
{
    /// <summary>
    /// A list of <see href="https://developer.squareup.com/reference/square_2024-04-17/enums/FulfillmentType">fulfillment types</see> to filter
    /// for. The list returns orders if any of its fulfillments match any of the fulfillment types
    /// listed in this field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fulfillment_types")]
    public IReadOnlyList<string>? FulfillmentTypes { get; init; }

    /// <summary>
    /// A list of <see href="https://developer.squareup.com/reference/square_2024-04-17/enums/FulfillmentState">fulfillment states</see> to filter
    /// for. The list returns orders if any of its fulfillments match any of the
    /// fulfillment states listed in this field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fulfillment_states")]
    public IReadOnlyList<string>? FulfillmentStates { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
