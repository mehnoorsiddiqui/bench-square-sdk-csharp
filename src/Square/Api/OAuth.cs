using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Square.Core;
using Square.Core.Authentication;
using Square.Core.ErrorResponse;
using Square.Core.Exceptions;
using Square.Core.Models;
using Square.Core.Request;
using Square.Core.Response;
using Square.Models;
using Square.Requests.OAuth;

namespace Square.Api;

public sealed class OAuth
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal OAuth(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// ObtainToken
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ObtainTokenResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns an OAuth access token and a refresh token unless the
    /// <c>short_lived</c> parameter is set to <c>true</c>, in which case the endpoint
    /// returns only an access token.
    /// <para>
    /// The <c>grant_type</c> parameter specifies the type of OAuth request. If
    /// <c>grant_type</c> is <c>authorization_code</c>, you must include the authorization
    /// code you received when a seller granted you authorization. If <c>grant_type</c>
    /// is <c>refresh_token</c>, you must provide a valid refresh token. If you're using
    /// an old version of the Square APIs (prior to March 13, 2019), <c>grant_type</c>
    /// can be <c>migration_token</c> and you must provide a valid migration token.
    /// </para>
    /// <para>
    /// You can use the <c>scopes</c> parameter to limit the set of permissions granted
    /// to the access token and refresh token. You can use the <c>short_lived</c> parameter
    /// to create an access token that expires in 24 hours.
    /// </para>
    /// <para>
    /// __Note:__ OAuth tokens should be encrypted and stored on a secure server.
    /// Application clients should never interact directly with OAuth tokens.
    /// </para>
    /// </remarks>
    public Task<ObtainTokenResponse> ObtainToken(ObtainTokenOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/oauth2/token"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ObtainTokenResponse>(),
            RawErrorResponse.Instance,
            AuthScheme.None,
            requestOptions,
            cancellationToken);

    /// <summary>
    /// RetrieveTokenStatus
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveTokenStatusResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns information about an <see href="https://developer.squareup.com/docs/build-basics/access-tokens#get-an-oauth-access-token">OAuth access token</see> or an application’s <see href="https://developer.squareup.com/docs/build-basics/access-tokens#get-a-personal-access-token">personal access token</see>.
    /// <para>
    /// Add the access token to the Authorization header of the request.
    /// </para>
    /// <para>
    /// __Important:__ The <c>Authorization</c> header you provide to this endpoint must have the following format:
    /// </para>
    /// <code>
    /// Authorization: Bearer ACCESS_TOKEN
    /// </code>
    /// <para>
    /// where <c>ACCESS_TOKEN</c> is a
    /// <see href="https://developer.squareup.com/docs/build-basics/access-tokens">valid production authorization credential</see>.
    /// </para>
    /// <para>
    /// If the access token is expired or not a valid access token, the endpoint returns an <c>UNAUTHORIZED</c> error.
    /// </para>
    /// </remarks>
    public Task<RetrieveTokenStatusResponse> RetrieveTokenStatus(RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/oauth2/token/status"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveTokenStatusResponse>(),
            RawErrorResponse.Instance,
            _auth.BearerAuth,
            requestOptions,
            cancellationToken);

    /// <summary>
    /// RevokeToken
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RevokeTokenResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Revokes an access token generated with the OAuth flow.
    /// <para>
    /// If an account has more than one OAuth access token for your application, this
    /// endpoint revokes all of them, regardless of which token you specify.
    /// </para>
    /// <para>
    /// __Important:__ The <c>Authorization</c> header for this endpoint must have the
    /// following format:
    /// </para>
    /// <code>
    /// Authorization: Client APPLICATION_SECRET
    /// </code>
    /// <para>
    /// Replace <c>APPLICATION_SECRET</c> with the application secret on the <b>OAuth</b>
    /// page for your application in the Developer Dashboard.
    /// </para>
    /// </remarks>
    public Task<RevokeTokenResponse> RevokeToken(RevokeTokenOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/oauth2/revoke"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<RevokeTokenResponse>(),
            RawErrorResponse.Instance,
            _auth.Oauth2ClientSecret,
            requestOptions,
            cancellationToken);
}
