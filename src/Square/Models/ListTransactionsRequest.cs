using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Defines the query parameters that can be included in
/// a request to the <see href="api-endpoint:Transactions-ListTransactions">ListTransactions</see> endpoint.
/// <para>
/// Deprecated - recommend using <see href="api-endpoint:Orders-SearchOrders">SearchOrders</see>
/// </para>
/// </summary>
public record ListTransactionsRequest
{
    /// <summary>
    /// The beginning of the requested reporting period, in RFC 3339 format.
    /// <para>
    /// See <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">Date ranges</see> for details on date inclusivity/exclusivity.
    /// </para>
    /// <para>
    /// Default value: The current time minus one year.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("begin_time")]
    public string? BeginTime { get; init; }

    /// <summary>
    /// The end of the requested reporting period, in RFC 3339 format.
    /// <para>
    /// See <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">Date ranges</see> for details on date inclusivity/exclusivity.
    /// </para>
    /// <para>
    /// Default value: The current time.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("end_time")]
    public string? EndTime { get; init; }

    /// <summary>
    /// The order (e.g., chronological or alphabetical) in which results from a request are returned.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sort_order")]
    public SortOrder? SortOrder { get; init; }

    /// <summary>
    /// A pagination cursor returned by a previous call to this endpoint.
    /// Provide this to retrieve the next set of results for your original query.
    /// <para>
    /// See <see href="https://developer.squareup.com/docs/working-with-apis/pagination">Paginating results</see> for more information.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
