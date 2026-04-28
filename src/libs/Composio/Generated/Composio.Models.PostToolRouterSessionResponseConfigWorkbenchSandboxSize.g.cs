
#nullable enable

namespace Composio
{
    /// <summary>
    /// Sandbox compute tier: standard (1 vCPU / 1 GB), medium (2 vCPU / 2 GB), large (4 vCPU / 4 GB), xlarge (8 vCPU / 8 GB). Defaults to standard.
    /// </summary>
    public enum PostToolRouterSessionResponseConfigWorkbenchSandboxSize
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
    public static class PostToolRouterSessionResponseConfigWorkbenchSandboxSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolRouterSessionResponseConfigWorkbenchSandboxSize value)
        {
            return value switch
            {
                PostToolRouterSessionResponseConfigWorkbenchSandboxSize.Large => "large",
                PostToolRouterSessionResponseConfigWorkbenchSandboxSize.Medium => "medium",
                PostToolRouterSessionResponseConfigWorkbenchSandboxSize.Standard => "standard",
                PostToolRouterSessionResponseConfigWorkbenchSandboxSize.Xlarge => "xlarge",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolRouterSessionResponseConfigWorkbenchSandboxSize? ToEnum(string value)
        {
            return value switch
            {
                "large" => PostToolRouterSessionResponseConfigWorkbenchSandboxSize.Large,
                "medium" => PostToolRouterSessionResponseConfigWorkbenchSandboxSize.Medium,
                "standard" => PostToolRouterSessionResponseConfigWorkbenchSandboxSize.Standard,
                "xlarge" => PostToolRouterSessionResponseConfigWorkbenchSandboxSize.Xlarge,
                _ => null,
            };
        }
    }
}