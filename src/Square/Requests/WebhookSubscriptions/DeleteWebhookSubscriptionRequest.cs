namespace Square.Requests.WebhookSubscriptions;

/// <summary>
/// The inputs of the DeleteWebhookSubscription operation.
/// </summary>
public sealed record DeleteWebhookSubscriptionRequest
{
    /// <summary>
    /// [REQUIRED] The ID of the <see href="https://developer.squareup.com/reference/square_2024-04-17/objects/WebhookSubscription">Subscription</see> to delete.
    /// </summary>
    public required string SubscriptionId { get; init; }
}
