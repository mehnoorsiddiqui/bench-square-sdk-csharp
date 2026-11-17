using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// The wrapper object for the catalog entries of a given object type.
/// <para>
/// Depending on the <c>type</c> attribute value, a <c>CatalogObject</c> instance assumes a type-specific data to yield the corresponding type of catalog object.
/// </para>
/// <para>
/// For example, if <c>type=ITEM</c>, the <c>CatalogObject</c> instance must have the ITEM-specific data set on the <c>item_data</c> attribute. The resulting <c>CatalogObject</c> instance is also a <c>CatalogItem</c> instance.
/// </para>
/// <para>
/// In general, if <c>type=&lt;OBJECT_TYPE&gt;</c>, the <c>CatalogObject</c> instance must have the <c>&lt;OBJECT_TYPE&gt;</c>-specific data set on the <c>&lt;object_type&gt;_data</c> attribute. The resulting <c>CatalogObject</c> instance is also a <c>Catalog&lt;ObjectType&gt;</c> instance.
/// </para>
/// <para>
/// For a more detailed discussion of the Catalog data model, please see the
/// <see href="https://developer.squareup.com/docs/catalog-api/design-a-catalog">Design a Catalog</see> guide.
/// </para>
/// </summary>
public record CatalogObject
{
    /// <summary>
    /// Possible types of CatalogObjects returned from the catalog, each
    /// containing type-specific properties in the <c>*_data</c> field corresponding to the specified object type.
    /// </summary>
    [JsonPropertyName("type")]
    public required CatalogObjectType Type { get; init; }

    /// <summary>
    /// An identifier to reference this object in the catalog. When a new <c>CatalogObject</c>
    /// is inserted, the client should set the id to a temporary identifier starting with
    /// a "<c>#</c>" character. Other objects being inserted or updated within the same request
    /// may use this identifier to refer to the new object.
    /// <para>
    /// When the server receives the new object, it will supply a unique identifier that
    /// replaces the temporary identifier for all future references.
    /// </para>
    /// </summary>
    [JsonPropertyName("id")]
    [MinLength(1)]
    public required string Id { get; init; }

    /// <summary>
    /// Last modification <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">timestamp</see> in RFC 3339 format, e.g., <c>"2016-08-15T23:59:33.123Z"</c>
    /// would indicate the UTC time (denoted by <c>Z</c>) of August 15, 2016 at 23:59:33 and 123 milliseconds.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updated_at")]
    public string? UpdatedAt { get; init; }

    /// <summary>
    /// The version of the object. When updating an object, the version supplied
    /// must match the version in the database, otherwise the write will be rejected as conflicting.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version")]
    public long? Version { get; init; }

    /// <summary>
    /// If <c>true</c>, the object has been deleted from the database. Must be <c>false</c> for new objects
    /// being inserted. When deleted, the <c>updated_at</c> field will equal the deletion time.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_deleted")]
    public bool? IsDeleted { get; init; }

    /// <summary>
    /// A map (key-value pairs) of application-defined custom attribute values. The value of a key-value pair
    /// is a <see href="entity:CatalogCustomAttributeValue">CatalogCustomAttributeValue</see> object. The key is the <c>key</c> attribute
    /// value defined in the associated <see href="entity:CatalogCustomAttributeDefinition">CatalogCustomAttributeDefinition</see>
    /// object defined by the application making the request.
    /// <para>
    /// If the <c>CatalogCustomAttributeDefinition</c> object is
    /// defined by another application, the <c>CatalogCustomAttributeDefinition</c>'s key attribute value is prefixed by
    /// the defining application ID. For example, if the <c>CatalogCustomAttributeDefinition</c> has a <c>key</c> attribute of
    /// <c>"cocoa_brand"</c> and the defining application ID is <c>"abcd1234"</c>, the key in the map is <c>"abcd1234:cocoa_brand"</c>
    /// if the application making the request is different from the application defining the custom attribute definition.
    /// Otherwise, the key used in the map is simply <c>"cocoa_brand"</c>.
    /// </para>
    /// <para>
    /// Application-defined custom attributes are set at a global (location-independent) level.
    /// Custom attribute values are intended to store additional information about a catalog object
    /// or associations with an entity in another system. Do not use custom attributes
    /// to store any sensitive information (personally identifiable information, card details, etc.).
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("custom_attribute_values")]
    public IReadOnlyDictionary<string, CatalogCustomAttributeValue>? CustomAttributeValues { get; init; }

    /// <summary>
    /// The Connect v1 IDs for this object at each location where it is present, where they
    /// differ from the object's Connect V2 ID. The field will only be present for objects that
    /// have been created or modified by legacy APIs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("catalog_v1_ids")]
    public IReadOnlyList<CatalogV1Id>? CatalogV1Ids { get; init; }

    /// <summary>
    /// If <c>true</c>, this object is present at all locations (including future locations), except where specified in
    /// the <c>absent_at_location_ids</c> field. If <c>false</c>, this object is not present at any locations (including future locations),
    /// except where specified in the <c>present_at_location_ids</c> field. If not specified, defaults to <c>true</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("present_at_all_locations")]
    public bool? PresentAtAllLocations { get; init; }

    /// <summary>
    /// A list of locations where the object is present, even if <c>present_at_all_locations</c> is <c>false</c>.
    /// This can include locations that are deactivated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("present_at_location_ids")]
    public IReadOnlyList<string>? PresentAtLocationIds { get; init; }

    /// <summary>
    /// A list of locations where the object is not present, even if <c>present_at_all_locations</c> is <c>true</c>.
    /// This can include locations that are deactivated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("absent_at_location_ids")]
    public IReadOnlyList<string>? AbsentAtLocationIds { get; init; }

    /// <summary>
    /// A <see href="$m/CatalogObject">CatalogObject</see> instance of the <c>ITEM</c> type, also referred to as an item, in the catalog.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("item_data")]
    public CatalogItem? ItemData { get; init; }

    /// <summary>
    /// A category to which a <c>CatalogItem</c> instance belongs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("category_data")]
    public CatalogCategory? CategoryData { get; init; }

    /// <summary>
    /// An item variation, representing a product for sale, in the Catalog object model. Each <see href="$m/CatalogItem">item</see> must have at least one
    /// item variation and can have at most 250 item variations.
    /// <para>
    /// An item variation can be sellable, stockable, or both if it has a unit of measure for its count for the sold number of the variation, the stocked
    /// number of the variation, or both. For example, when a variation representing wine is stocked and sold by the bottle, the variation is both
    /// stockable and sellable. But when a variation of the wine is sold by the glass, the sold units cannot be used as a measure of the stocked units. This by-the-glass
    /// variation is sellable, but not stockable. To accurately keep track of the wine's inventory count at any time, the sellable count must be
    /// converted to stockable count. Typically, the seller defines this unit conversion. For example, 1 bottle equals 5 glasses. The Square API exposes
    /// the <c>stockable_conversion</c> property on the variation to specify the conversion. Thus, when two glasses of the wine are sold, the sellable count
    /// decreases by 2, and the stockable count automatically decreases by 0.4 bottle according to the conversion.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("item_variation_data")]
    public CatalogItemVariation? ItemVariationData { get; init; }

    /// <summary>
    /// A tax applicable to an item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tax_data")]
    public CatalogTax? TaxData { get; init; }

    /// <summary>
    /// A discount applicable to items.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("discount_data")]
    public CatalogDiscount? DiscountData { get; init; }

    /// <summary>
    /// For a text-based modifier, this encapsulates the modifier's text when its <c>modifier_type</c> is <c>TEXT</c>.
    /// For example, to sell T-shirts with custom prints, a text-based modifier can be used to capture the buyer-supplied
    /// text string to be selected for the T-shirt at the time of sale.
    /// <para>
    /// For non text-based modifiers, this encapsulates a non-empty list of modifiers applicable to items
    /// at the time of sale. Each element of the modifier list is a <c>CatalogObject</c> instance of the <c>MODIFIER</c> type.
    /// For example, a "Condiments" modifier list applicable to a "Hot Dog" item
    /// may contain "Ketchup", "Mustard", and "Relish" modifiers.
    /// </para>
    /// <para>
    /// A non text-based modifier can be applied to the modified item once or multiple times, if the <c>selection_type</c> field
    /// is set to <c>SINGLE</c> or <c>MULTIPLE</c>, respectively. On the other hand, a text-based modifier can be applied to the item
    /// only once and the <c>selection_type</c> field is always set to <c>SINGLE</c>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("modifier_list_data")]
    public CatalogModifierList? ModifierListData { get; init; }

    /// <summary>
    /// A modifier applicable to items at the time of sale. An example of a modifier is a Cheese add-on to a Burger item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("modifier_data")]
    public CatalogModifier? ModifierData { get; init; }

    /// <summary>
    /// Represents a time period - either a single period or a repeating period.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("time_period_data")]
    public CatalogTimePeriod? TimePeriodData { get; init; }

    /// <summary>
    /// Represents a collection of catalog objects for the purpose of applying a
    /// <c>PricingRule</c>. Including a catalog object will include all of its subtypes.
    /// For example, including a category in a product set will include all of its
    /// items and associated item variations in the product set. Including an item in
    /// a product set will also include its item variations.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("product_set_data")]
    public CatalogProductSet? ProductSetData { get; init; }

    /// <summary>
    /// Defines how discounts are automatically applied to a set of items that match the pricing rule
    /// during the active time period.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pricing_rule_data")]
    public CatalogPricingRule? PricingRuleData { get; init; }

    /// <summary>
    /// An image file to use in Square catalogs. It can be associated with
    /// <c>CatalogItem</c>, <c>CatalogItemVariation</c>, <c>CatalogCategory</c>, and <c>CatalogModifierList</c> objects.
    /// Only the images on items and item variations are exposed in Dashboard.
    /// Only the first image on an item is displayed in Square Point of Sale (SPOS).
    /// Images on items and variations are displayed through Square Online Store.
    /// Images on other object types are for use by 3rd party application developers.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("image_data")]
    public CatalogImage? ImageData { get; init; }

    /// <summary>
    /// Represents the unit used to measure a <c>CatalogItemVariation</c> and
    /// specifies the precision for decimal quantities.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("measurement_unit_data")]
    public CatalogMeasurementUnit? MeasurementUnitData { get; init; }

    /// <summary>
    /// Describes a subscription plan. A subscription plan represents what you want to sell in a subscription model, and includes references to each of the associated subscription plan variations.
    /// For more information, see <see href="https://developer.squareup.com/docs/subscriptions-api/plans-and-variations">Subscription Plans and Variations</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subscription_plan_data")]
    public CatalogSubscriptionPlan? SubscriptionPlanData { get; init; }

    /// <summary>
    /// A group of variations for a <c>CatalogItem</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("item_option_data")]
    public CatalogItemOption? ItemOptionData { get; init; }

    /// <summary>
    /// An enumerated value that can link a
    /// <c>CatalogItemVariation</c> to an item option as one of
    /// its item option values.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("item_option_value_data")]
    public CatalogItemOptionValue? ItemOptionValueData { get; init; }

    /// <summary>
    /// Contains information defining a custom attribute. Custom attributes are
    /// intended to store additional information about a catalog object or to associate a
    /// catalog object with an entity in another system. Do not use custom attributes
    /// to store any sensitive information (personally identifiable information, card details, etc.).
    /// <see href="https://developer.squareup.com/docs/catalog-api/add-custom-attributes">Read more about custom attributes</see>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("custom_attribute_definition_data")]
    public CatalogCustomAttributeDefinition? CustomAttributeDefinitionData { get; init; }

    /// <summary>
    /// A parent Catalog Object model represents a set of Quick Amounts and the settings control the amounts.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("quick_amounts_settings_data")]
    public CatalogQuickAmountsSettings? QuickAmountsSettingsData { get; init; }

    /// <summary>
    /// Describes a subscription plan variation. A subscription plan variation represents how the subscription for a product or service is sold.
    /// For more information, see <see href="https://developer.squareup.com/docs/subscriptions-api/plans-and-variations">Subscription Plans and Variations</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subscription_plan_variation_data")]
    public CatalogSubscriptionPlanVariation? SubscriptionPlanVariationData { get; init; }

    /// <summary>
    /// Represents a time period of availability.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("availability_period_data")]
    public CatalogAvailabilityPeriod? AvailabilityPeriodData { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
