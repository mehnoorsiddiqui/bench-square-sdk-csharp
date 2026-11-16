using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// The type of fulfillment.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FulfillmentType>))]
public sealed record FulfillmentType : OpenStringEnum<FulfillmentType>
{
    private FulfillmentType(string value) : base(value)
    {
    }

    /// <summary>
    /// A recipient to pick up the fulfillment from a physical <see href="https://developer.squareup.com/reference/square_2024-05-15/objects/Location">location</see>.
    /// </summary>
    public static readonly FulfillmentType Pickup = new("PICKUP");

    /// <summary>
    /// A shipping carrier to ship the fulfillment.
    /// </summary>
    public static readonly FulfillmentType Shipment = new("SHIPMENT");

    /// <summary>
    /// A courier to deliver the fulfillment.
    /// </summary>
    public static readonly FulfillmentType Delivery = new("DELIVERY");

    public TResult Match<TResult>(Func<TResult> onPickup,
        Func<TResult> onShipment,
        Func<TResult> onDelivery,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Pickup => onPickup(),
            _ when this == Shipment => onShipment(),
            _ when this == Delivery => onDelivery(),
            _ => otherwise(Value)
        };

    public void Match(Action onPickup, Action onShipment, Action onDelivery, Action<string> otherwise)
    {
        if (this == Pickup) onPickup();
        else if (this == Shipment) onShipment();
        else if (this == Delivery) onDelivery();
        else otherwise(Value);
    }
}
