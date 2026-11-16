using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record CheckoutLocationSettingsBranding
{
    /// <summary>
    /// Show the location logo on the checkout page.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("header_type")]
    public string? HeaderType { get; init; }

    /// <summary>
    /// The HTML-supported hex color for the button on the checkout page (for example, "#FFFFFF").
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("button_color")]
    [StringLength(7, MinimumLength = 7)]
    public string? ButtonColor { get; init; }

    /// <summary>
    /// The shape of the button on the checkout page.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("button_shape")]
    public string? ButtonShape { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
