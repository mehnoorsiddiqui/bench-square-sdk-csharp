using Square.Core;
using Square.Core.Authentication;
using Square.Core.Authentication.ApiKey;
using Square.Core.Authentication.Bearer;

namespace Square;

internal sealed class AuthSchemes
{
    public IAuthScheme BearerAuth { get; }
    public IAuthScheme Oauth2ClientSecret { get; }

    public AuthSchemes(SquareClientOptions options)
    {
        BearerAuth =
            BearerAuthScheme.Create(
                "BearerAuth",
                options.BearerAuthProvider,
                options.BearerAuth ?? EnvironmentVariables.Get("SQUARE_BEARER_AUTH"));
        Oauth2ClientSecret =
            ApiKeyHeaderScheme.Create(
                "Oauth2ClientSecret",
                "Authorization",
                options.Oauth2ClientSecretProvider,
                options.Oauth2ClientSecret ?? EnvironmentVariables.Get("SQUARE_OAUTH2_CLIENT_SECRET"));
    }
}
