using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record DeviceComponentDetailsNetworkInterfaceDetails
{
    /// <summary>
    /// The string representation of the device’s IPv4 address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ip_address_v4")]
    public string? IpAddressV4 { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
