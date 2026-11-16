using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Core.Validation.Attributes;

namespace Square.Models;

/// <summary>
/// A request to list gift cards. You can optionally specify a filter to retrieve a subset of
/// gift cards.
/// </summary>
public record ListGiftCardsRequest
{
    /// <summary>
    /// If a <see href="https://developer.squareup.com/reference/square_2024-04-17/enums/GiftCardType">type</see> is provided, the endpoint returns gift cards of the specified type.
    /// Otherwise, the endpoint returns gift cards of all types.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    /// <summary>
    /// If a <see href="https://developer.squareup.com/reference/square_2024-04-17/enums/GiftCardStatus">state</see> is provided, the endpoint returns the gift cards in the specified state.
    /// Otherwise, the endpoint returns the gift cards of all states.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("state")]
    public string? State { get; init; }

    /// <summary>
    /// If a limit is provided, the endpoint returns only the specified number of results per page.
    /// The maximum value is 200. The default value is 30.
    /// For more information, see <see href="https://developer.squareup.com/docs/working-with-apis/pagination">Pagination</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("limit")]
    [Minimum(1)]
    [Maximum(200)]
    public int? Limit { get; init; }

    /// <summary>
    /// A pagination cursor returned by a previous call to this endpoint.
    /// Provide this cursor to retrieve the next set of results for the original query.
    /// If a cursor is not provided, the endpoint returns the first page of the results.
    /// For more information, see <see href="https://developer.squareup.com/docs/working-with-apis/pagination">Pagination</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    /// <summary>
    /// If a customer ID is provided, the endpoint returns only the gift cards linked to the specified customer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customer_id")]
    [MaxLength(191)]
    public string? CustomerId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
