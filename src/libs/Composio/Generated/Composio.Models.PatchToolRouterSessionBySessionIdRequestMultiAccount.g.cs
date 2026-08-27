
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PatchToolRouterSessionBySessionIdRequestMultiAccount
    {
        /// <summary>
        /// When true, enables multi-account mode for this session. When not set, falls back to org/project-level configuration.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable")]
        public bool? Enable { get; set; }

        /// <summary>
        /// Maximum number of connected accounts allowed per toolkit. Must be between 2 and 10.<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_accounts_per_toolkit")]
        public int? MaxAccountsPerToolkit { get; set; }

        /// <summary>
        /// When true, the agent must explicitly select which account to use. When false (default), the first/default account is used automatically.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("require_explicit_selection")]
        public bool? RequireExplicitSelection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchToolRouterSessionBySessionIdRequestMultiAccount" /> class.
        /// </summary>
        /// <param name="enable">
        /// When true, enables multi-account mode for this session. When not set, falls back to org/project-level configuration.<br/>
        /// Example: true
        /// </param>
        /// <param name="maxAccountsPerToolkit">
        /// Maximum number of connected accounts allowed per toolkit. Must be between 2 and 10.<br/>
        /// Example: 5
        /// </param>
        /// <param name="requireExplicitSelection">
        /// When true, the agent must explicitly select which account to use. When false (default), the first/default account is used automatically.<br/>
        /// Example: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchToolRouterSessionBySessionIdRequestMultiAccount(
            bool? enable,
            int? maxAccountsPerToolkit,
            bool? requireExplicitSelection)
        {
            this.Enable = enable;
            this.MaxAccountsPerToolkit = maxAccountsPerToolkit;
            this.RequireExplicitSelection = requireExplicitSelection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchToolRouterSessionBySessionIdRequestMultiAccount" /> class.
        /// </summary>
        public PatchToolRouterSessionBySessionIdRequestMultiAccount()
        {
        }

    }
}