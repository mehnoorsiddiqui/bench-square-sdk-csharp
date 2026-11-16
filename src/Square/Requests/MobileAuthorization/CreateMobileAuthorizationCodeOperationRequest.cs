using Square.Models;

namespace Square.Requests.MobileAuthorization;

/// <summary>
/// The inputs of the CreateMobileAuthorizationCode operation.
/// </summary>
public sealed record CreateMobileAuthorizationCodeOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required CreateMobileAuthorizationCodeRequest Body { get; init; }
}
