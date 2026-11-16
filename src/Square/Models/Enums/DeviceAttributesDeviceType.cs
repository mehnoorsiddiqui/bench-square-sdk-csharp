using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// An enum identifier of the device type.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DeviceAttributesDeviceType>))]
public sealed record DeviceAttributesDeviceType : OpenStringEnum<DeviceAttributesDeviceType>
{
    private DeviceAttributesDeviceType(string value) : base(value)
    {
    }

    public static readonly DeviceAttributesDeviceType Terminal = new("TERMINAL");

    public TResult Match<TResult>(Func<TResult> onTerminal, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Terminal => onTerminal(),
            _ => otherwise(Value)
        };

    public void Match(Action onTerminal, Action<string> otherwise)
    {
        if (this == Terminal) onTerminal();
        else otherwise(Value);
    }
}
