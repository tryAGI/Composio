
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum PostOrgOwnerProjectNewRequestApiKeyPermissionPreset
    {
        /// <summary>
        ///
        /// </summary>
        AuthConfigs,
        /// <summary>
        ///
        /// </summary>
        ConnectedAccounts,
        /// <summary>
        ///
        /// </summary>
        LegacyMcp,
        /// <summary>
        ///
        /// </summary>
        Observability,
        /// <summary>
        ///
        /// </summary>
        ProxyExecute,
        /// <summary>
        ///
        /// </summary>
        SessionManagement,
        /// <summary>
        ///
        /// </summary>
        SessionToolExecution,
        /// <summary>
        ///
        /// </summary>
        Sessions,
        /// <summary>
        ///
        /// </summary>
        ToolExecution,
        /// <summary>
        ///
        /// </summary>
        Toolkits,
        /// <summary>
        ///
        /// </summary>
        Tools,
        /// <summary>
        ///
        /// </summary>
        Triggers,
        /// <summary>
        ///
        /// </summary>
        Webhooks,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostOrgOwnerProjectNewRequestApiKeyPermissionPresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostOrgOwnerProjectNewRequestApiKeyPermissionPreset value)
        {
            return value switch
            {
                PostOrgOwnerProjectNewRequestApiKeyPermissionPreset.AuthConfigs => "auth_configs",
                PostOrgOwnerProjectNewRequestApiKeyPermissionPreset.ConnectedAccounts => "connected_accounts",
                PostOrgOwnerProjectNewRequestApiKeyPermissionPreset.LegacyMcp => "legacy_mcp",
                PostOrgOwnerProjectNewRequestApiKeyPermissionPreset.Observability => "observability",
                PostOrgOwnerProjectNewRequestApiKeyPermissionPreset.ProxyExecute => "proxy_execute",
                PostOrgOwnerProjectNewRequestApiKeyPermissionPreset.SessionManagement => "session_management",
                PostOrgOwnerProjectNewRequestApiKeyPermissionPreset.SessionToolExecution => "session_tool_execution",
                PostOrgOwnerProjectNewRequestApiKeyPermissionPreset.Sessions => "sessions",
                PostOrgOwnerProjectNewRequestApiKeyPermissionPreset.ToolExecution => "tool_execution",
                PostOrgOwnerProjectNewRequestApiKeyPermissionPreset.Toolkits => "toolkits",
                PostOrgOwnerProjectNewRequestApiKeyPermissionPreset.Tools => "tools",
                PostOrgOwnerProjectNewRequestApiKeyPermissionPreset.Triggers => "triggers",
                PostOrgOwnerProjectNewRequestApiKeyPermissionPreset.Webhooks => "webhooks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostOrgOwnerProjectNewRequestApiKeyPermissionPreset? ToEnum(string value)
        {
            return value switch
            {
                "auth_configs" => PostOrgOwnerProjectNewRequestApiKeyPermissionPreset.AuthConfigs,
                "connected_accounts" => PostOrgOwnerProjectNewRequestApiKeyPermissionPreset.ConnectedAccounts,
                "legacy_mcp" => PostOrgOwnerProjectNewRequestApiKeyPermissionPreset.LegacyMcp,
                "observability" => PostOrgOwnerProjectNewRequestApiKeyPermissionPreset.Observability,
                "proxy_execute" => PostOrgOwnerProjectNewRequestApiKeyPermissionPreset.ProxyExecute,
                "session_management" => PostOrgOwnerProjectNewRequestApiKeyPermissionPreset.SessionManagement,
                "session_tool_execution" => PostOrgOwnerProjectNewRequestApiKeyPermissionPreset.SessionToolExecution,
                "sessions" => PostOrgOwnerProjectNewRequestApiKeyPermissionPreset.Sessions,
                "tool_execution" => PostOrgOwnerProjectNewRequestApiKeyPermissionPreset.ToolExecution,
                "toolkits" => PostOrgOwnerProjectNewRequestApiKeyPermissionPreset.Toolkits,
                "tools" => PostOrgOwnerProjectNewRequestApiKeyPermissionPreset.Tools,
                "triggers" => PostOrgOwnerProjectNewRequestApiKeyPermissionPreset.Triggers,
                "webhooks" => PostOrgOwnerProjectNewRequestApiKeyPermissionPreset.Webhooks,
                _ => null,
            };
        }
    }
}