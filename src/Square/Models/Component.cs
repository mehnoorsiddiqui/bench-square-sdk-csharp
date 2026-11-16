using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// The wrapper object for the component entries of a given component type.
/// </summary>
public record Component
{
    /// <summary>
    /// The type of this component. Each component type has expected properties expressed
    /// in a structured format within its corresponding <c>*_details</c> field.
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("application_details")]
    public DeviceComponentDetailsApplicationDetails? ApplicationDetails { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("card_reader_details")]
    public DeviceComponentDetailsCardReaderDetails? CardReaderDetails { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("battery_details")]
    public DeviceComponentDetailsBatteryDetails? BatteryDetails { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("wifi_details")]
    public DeviceComponentDetailsWiFiDetails? WifiDetails { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ethernet_details")]
    public DeviceComponentDetailsEthernetDetails? EthernetDetails { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
