
#nullable enable

namespace Composio
{
    /// <summary>
    /// Multi-account configuration for this session.
    /// </summary>
    public sealed partial class PatchToolRouterSessionBySessionIdResponseConfigMultiAccount
    {
        /// <summary>
        /// When true, enables multi-account mode for this session. When not set, falls back to org/project-level configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable")]
        public bool? Enable { get; set; }

        /// <summary>
        /// Maximum number of connected accounts allowed per toolkit. Defaults to 5 when multi-account is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_accounts_per_toolkit")]
        public int? MaxAccountsPerToolkit { get; set; }

        /// <summary>
        /// When true, require explicit account selection when multiple accounts are connected. When false (default), use the first/default account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("require_explicit_selection")]
        public bool? RequireExplicitSelection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchToolRouterSessionBySessionIdResponseConfigMultiAccount" /> class.
        /// </summary>
        /// <param name="enable">
        /// When true, enables multi-account mode for this session. When not set, falls back to org/project-level configuration.
        /// </param>
        /// <param name="maxAccountsPerToolkit">
        /// Maximum number of connected accounts allowed per toolkit. Defaults to 5 when multi-account is enabled.
        /// </param>
        /// <param name="requireExplicitSelection">
        /// When true, require explicit account selection when multiple accounts are connected. When false (default), use the first/default account.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchToolRouterSessionBySessionIdResponseConfigMultiAccount(
            bool? enable,
            int? maxAccountsPerToolkit,
            bool? requireExplicitSelection)
        {
            this.Enable = enable;
            this.MaxAccountsPerToolkit = maxAccountsPerToolkit;
            this.RequireExplicitSelection = requireExplicitSelection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchToolRouterSessionBySessionIdResponseConfigMultiAccount" /> class.
        /// </summary>
        public PatchToolRouterSessionBySessionIdResponseConfigMultiAccount()
        {
        }
    }
}