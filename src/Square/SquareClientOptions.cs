using System;
using System.Collections.Generic;
using Square.Core.Authentication;
using Square.Core.Configuration;
using Square.Core.Hooks;
using Square.Servers;

namespace Square;

public class SquareClientOptions
{
    public ServerEnvironment Environment { get; set; } = ServerEnvironment.Default();
    public RetryOptions Retry { get; set; } = RetryOptions.Default();
    public LoggingOptions Logging { get; set; } = new();
    public TimeProvider TimeProvider { get; set; } = TimeProvider.System;
    public ServerOptions Server { get; set; } = new();
    /// <summary>
    /// Maximum time to wait for the next frame of a streaming (SSE) response before the stream is
    /// torn down with a timeout. Bounds only the wait for the server between frames, never the
    /// caller's own processing time. Set to null to wait indefinitely.
    /// </summary>
    public TimeSpan? StreamReadTimeout { get; set; } = TimeSpan.FromSeconds(60);
    public IReadOnlyList<SdkHook> Hooks { get; set; } = [];
    /// <summary>
    /// A Square OAuth access token or personal access token, sent as <c>Authorization: Bearer &lt;token&gt;</c>.
    /// </summary>
    public string? BearerAuth { get; set; }
    public CredentialProvider<string>? BearerAuthProvider { get; set; }
    public string? Oauth2ClientSecret { get; set; }
    public CredentialProvider<string>? Oauth2ClientSecretProvider { get; set; }
}
