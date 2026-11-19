using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Square.Core;
using Square.Core.ErrorResponse;
using Square.Core.Exceptions;
using Square.Core.Models;
using Square.Core.Request;
using Square.Core.Response;
using Square.Models;
using Square.Requests.MobileAuthorization;

namespace Square.Api;

public sealed class MobileAuthorization
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal MobileAuthorization(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// CreateMobileAuthorizationCode
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateMobileAuthorizationCodeResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// __Note:__ This endpoint is used by the deprecated Reader SDK.
    /// Developers should update their integration to use the <see href="https://developer.squareup.com/docs/mobile-payments-sdk">Mobile Payments SDK</see>, which includes its own authorization methods.
    /// <para>
    /// Generates code to authorize a mobile application to connect to a Square card reader.
    /// </para>
    /// <para>
    /// Authorization codes are one-time-use codes and expire 60 minutes after being issued.
    /// </para>
    /// <para>
    /// The <c>Authorization</c> header you provide to this endpoint must have the following format:
    /// </para>
    /// <code>
    /// Authorization: Bearer ACCESS_TOKEN
    /// </code>
    /// <para>
    /// Replace <c>ACCESS_TOKEN</c> with a
    /// <see href="https://developer.squareup.com/docs/build-basics/access-tokens">valid production authorization credential</see>.
    /// </para>
    /// </remarks>
    public Task<CreateMobileAuthorizationCodeResponse> CreateMobileAuthorizationCode(CreateMobileAuthorizationCodeOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/mobile/authorization-code"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<CreateMobileAuthorizationCodeResponse>(),
            RawErrorResponse.Instance,
            _auth.BearerAuth,
            requestOptions,
            cancellationToken);
}
