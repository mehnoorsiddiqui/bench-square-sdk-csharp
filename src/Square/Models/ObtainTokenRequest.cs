using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record ObtainTokenRequest
{
    /// <summary>
    /// The Square-issued ID of your application, which is available on the <b>OAuth</b> page in the
    /// <see href="https://developer.squareup.com/apps">Developer Dashboard</see>.
    /// </summary>
    [JsonPropertyName("client_id")]
    [MaxLength(191)]
    public required string ClientId { get; init; }

    /// <summary>
    /// The Square-issued application secret for your application, which is available on the <b>OAuth</b> page
    /// in the <see href="https://developer.squareup.com/apps">Developer Dashboard</see>. This parameter is only required when
    /// you're not using the <see href="https://developer.squareup.com/docs/oauth-api/overview#pkce-flow">OAuth PKCE (Proof Key for Code Exchange) flow</see>.
    /// The PKCE flow requires a <c>code_verifier</c> instead of a <c>client_secret</c> when <c>grant_type</c> is set to <c>authorization_code</c>.
    /// If <c>grant_type</c> is set to <c>refresh_token</c> and the <c>refresh_token</c> is obtained uaing PKCE, the PKCE flow only requires <c>client_id</c>,
    /// <c>grant_type</c>, and <c>refresh_token</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_secret")]
    [StringLength(1024, MinimumLength = 2)]
    public string? ClientSecret { get; init; }

    /// <summary>
    /// The authorization code to exchange.
    /// This code is required if <c>grant_type</c> is set to <c>authorization_code</c> to indicate that
    /// the application wants to exchange an authorization code for an OAuth access token.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("code")]
    [StringLength(191, MinimumLength = 0)]
    public string? Code { get; init; }

    /// <summary>
    /// The redirect URL assigned on the <b>OAuth</b> page for your application in the <see href="https://developer.squareup.com/apps">Developer Dashboard</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("redirect_uri")]
    [StringLength(2048, MinimumLength = 0)]
    public string? RedirectUri { get; init; }

    /// <summary>
    /// Specifies the method to request an OAuth access token.
    /// Valid values are <c>authorization_code</c>, <c>refresh_token</c>, and <c>migration_token</c>.
    /// </summary>
    [JsonPropertyName("grant_type")]
    [StringLength(20, MinimumLength = 10)]
    public required string GrantType { get; init; }

    /// <summary>
    /// A valid refresh token for generating a new OAuth access token.
    /// <para>
    /// A valid refresh token is required if <c>grant_type</c> is set to <c>refresh_token</c>
    /// to indicate that the application wants a replacement for an expired OAuth access token.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("refresh_token")]
    [StringLength(1024, MinimumLength = 2)]
    public string? RefreshToken { get; init; }

    /// <summary>
    /// A legacy OAuth access token obtained using a Connect API version prior
    /// to 2019-03-13. This parameter is required if <c>grant_type</c> is set to
    /// <c>migration_token</c> to indicate that the application wants to get a replacement
    /// OAuth access token. The response also returns a refresh token.
    /// For more information, see <see href="https://developer.squareup.com/docs/oauth-api/migrate-to-refresh-tokens">Migrate to Using Refresh Tokens</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("migration_token")]
    [StringLength(1024, MinimumLength = 2)]
    public string? MigrationToken { get; init; }

    /// <summary>
    /// A JSON list of strings representing the permissions that the application is requesting.
    /// For example, "<c>["MERCHANT_PROFILE_READ","PAYMENTS_READ","BANK_ACCOUNTS_READ"]</c>".
    /// <para>
    /// The access token returned in the response is granted the permissions
    /// that comprise the intersection between the requested list of permissions and those
    /// that belong to the provided refresh token.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scopes")]
    public IReadOnlyList<string>? Scopes { get; init; }

    /// <summary>
    /// A Boolean indicating a request for a short-lived access token.
    /// <para>
    /// The short-lived access token returned in the response expires in 24 hours.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("short_lived")]
    public bool? ShortLived { get; init; }

    /// <summary>
    /// Must be provided when using the PKCE OAuth flow if <c>grant_type</c> is set to <c>authorization_code</c>. The <c>code_verifier</c> is used to verify against the
    /// <c>code_challenge</c> associated with the <c>authorization_code</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("code_verifier")]
    public string? CodeVerifier { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
