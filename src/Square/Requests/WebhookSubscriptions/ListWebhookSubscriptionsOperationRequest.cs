namespace Square.Requests.WebhookSubscriptions;

/// <summary>
/// The inputs of the ListWebhookSubscriptions operation.
/// </summary>
public sealed record ListWebhookSubscriptionsOperationRequest
{
    /// <summary>
    /// A pagination cursor returned by a previous call to this endpoint.
    /// Provide this to retrieve the next set of results for your original query.
    /// <para>
    /// For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>.
    /// </para>
    /// </summary>
    public string? Cursor { get; init; }

    /// <summary>
    /// Includes disabled <see href="https://developer.squareup.com/reference/square_2024-04-17/objects/WebhookSubscription">Subscription</see>s.
    /// By default, all enabled <see href="https://developer.squareup.com/reference/square_2024-04-17/objects/WebhookSubscription">Subscription</see>s are returned.
    /// </summary>
    public bool? IncludeDisabled { get; init; }

    /// <summary>
    /// Sorts the returned list by when the <see href="https://developer.squareup.com/reference/square_2024-04-17/objects/WebhookSubscription">Subscription</see> was created with the specified order.
    /// This field defaults to ASC.
    /// </summary>
    public string? SortOrder { get; init; }

    /// <summary>
    /// The maximum number of results to be returned in a single page.
    /// It is possible to receive fewer results than the specified limit on a given page.
    /// The default value of 100 is also the maximum allowed value.
    /// <para>
    /// Default: 100
    /// </para>
    /// </summary>
    public int? Limit { get; init; }
}
