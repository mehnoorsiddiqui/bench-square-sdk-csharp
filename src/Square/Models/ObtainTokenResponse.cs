using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record ObtainTokenResponse
{
    /// <summary>
    /// A valid OAuth access token.
    /// Provide the access token in a header with every request to Connect API
    /// endpoints. For more information, see <see href="https://developer.squareup.com/docs/oauth-api/walkthrough">OAuth API: Walkthrough</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("access_token")]
    [StringLength(1024, MinimumLength = 2)]
    public string? AccessToken { get; init; }

    /// <summary>
    /// This value is always _bearer_.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("token_type")]
    [StringLength(10, MinimumLength = 2)]
    public string? TokenType { get; init; }

    /// <summary>
    /// The date when the <c>access_token</c> expires, in <see href="http://www.iso.org/iso/home/standards/iso8601.htm">ISO 8601</see> format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expires_at")]
    [StringLength(48, MinimumLength = 20)]
    public string? ExpiresAt { get; init; }

    /// <summary>
    /// The ID of the authorizing merchant's business.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchant_id")]
    [StringLength(191, MinimumLength = 8)]
    public string? MerchantId { get; init; }

    /// <summary>
    /// __LEGACY FIELD__. The ID of a subscription plan the merchant signed up
    /// for. The ID is only present if the merchant signed up for a subscription plan during authorization.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subscription_id")]
    public string? SubscriptionId { get; init; }

    /// <summary>
    /// __LEGACY FIELD__. The ID of the subscription plan the merchant signed
    /// up for. The ID is only present if the merchant signed up for a subscription plan during
    /// authorization.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("plan_id")]
    public string? PlanId { get; init; }

    /// <summary>
    /// The OpenID token belonging to this person. This token is only present if the
    /// OPENID scope is included in the authorization request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id_token")]
    public string? IdToken { get; init; }

    /// <summary>
    /// A refresh token.
    /// For more information, see <see href="https://developer.squareup.com/docs/oauth-api/refresh-revoke-limit-scope">Refresh, Revoke, and Limit the Scope of OAuth Tokens</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("refresh_token")]
    [StringLength(1024, MinimumLength = 2)]
    public string? RefreshToken { get; init; }

    /// <summary>
    /// A Boolean indicating that the access token is a short-lived access token.
    /// The short-lived access token returned in the response expires in 24 hours.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("short_lived")]
    public bool? ShortLived { get; init; }

    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// The date when the <c>refresh_token</c> expires, in <see href="http://www.iso.org/iso/home/standards/iso8601.htm">ISO 8601</see> format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("refresh_token_expires_at")]
    [StringLength(48, MinimumLength = 20)]
    public string? RefreshTokenExpiresAt { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
