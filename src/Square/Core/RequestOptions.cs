using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using Square.Core.Hooks;
using Square.Core.Models;

namespace Square.Core;

public sealed record RequestOptions
{
    public LogLevel? LogLevel { get; init; }

    public IReadOnlyList<HeaderParam>? Headers { get; init; }

    public IReadOnlyList<SdkHook>? Hooks { get; init; }
}
