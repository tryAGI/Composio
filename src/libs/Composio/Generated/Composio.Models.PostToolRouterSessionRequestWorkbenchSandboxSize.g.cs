
#nullable enable

namespace Composio
{
    /// <summary>
    /// Sandbox compute tier: standard (1 vCPU / 1 GB), medium (2 vCPU / 2 GB), large (4 vCPU / 4 GB), xlarge (8 vCPU / 8 GB). Defaults to standard.<br/>
    /// Default Value: standard<br/>
    /// Example: standard
    /// </summary>
    public enum PostToolRouterSessionRequestWorkbenchSandboxSize
    {
        /// <summary>
        /// standard (1 vCPU / 1 GB), medium (2 vCPU / 2 GB), large (4 vCPU / 4 GB), xlarge (8 vCPU / 8 GB). Defaults to standard.
        /// </summary>
        Large,
        /// <summary>
        /// standard (1 vCPU / 1 GB), medium (2 vCPU / 2 GB), large (4 vCPU / 4 GB), xlarge (8 vCPU / 8 GB). Defaults to standard.
        /// </summary>
        Medium,
        /// <summary>
        /// standard (1 vCPU / 1 GB), medium (2 vCPU / 2 GB), large (4 vCPU / 4 GB), xlarge (8 vCPU / 8 GB). Defaults to standard.
        /// </summary>
        Standard,
        /// <summary>
        /// standard (1 vCPU / 1 GB), medium (2 vCPU / 2 GB), large (4 vCPU / 4 GB), xlarge (8 vCPU / 8 GB). Defaults to standard.
        /// </summary>
        Xlarge,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostToolRouterSessionRequestWorkbenchSandboxSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolRouterSessionRequestWorkbenchSandboxSize value)
        {
            return value switch
            {
                PostToolRouterSessionRequestWorkbenchSandboxSize.Large => "large",
                PostToolRouterSessionRequestWorkbenchSandboxSize.Medium => "medium",
                PostToolRouterSessionRequestWorkbenchSandboxSize.Standard => "standard",
                PostToolRouterSessionRequestWorkbenchSandboxSize.Xlarge => "xlarge",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolRouterSessionRequestWorkbenchSandboxSize? ToEnum(string value)
        {
            return value switch
            {
                "large" => PostToolRouterSessionRequestWorkbenchSandboxSize.Large,
                "medium" => PostToolRouterSessionRequestWorkbenchSandboxSize.Medium,
                "standard" => PostToolRouterSessionRequestWorkbenchSandboxSize.Standard,
                "xlarge" => PostToolRouterSessionRequestWorkbenchSandboxSize.Xlarge,
                _ => null,
            };
        }
    }
}