
#nullable enable

namespace Composio
{
    /// <summary>
    /// Exposes the COMPOSIO_SUBMIT_FEEDBACK helper tool in this session so the agent can report tool executions with empty, incorrect, or failed results. Replaces the stored block when provided; `enable` is required when the block is sent.
    /// </summary>
    public sealed partial class PatchToolRouterSessionBySessionIdRequestExperimentalSubmitFeedback
    {
        /// <summary>
        /// Set to true to expose the COMPOSIO_SUBMIT_FEEDBACK helper tool in this session, false to hide it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enable { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchToolRouterSessionBySessionIdRequestExperimentalSubmitFeedback" /> class.
        /// </summary>
        /// <param name="enable">
        /// Set to true to expose the COMPOSIO_SUBMIT_FEEDBACK helper tool in this session, false to hide it.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchToolRouterSessionBySessionIdRequestExperimentalSubmitFeedback(
            bool enable)
        {
            this.Enable = enable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchToolRouterSessionBySessionIdRequestExperimentalSubmitFeedback" /> class.
        /// </summary>
        public PatchToolRouterSessionBySessionIdRequestExperimentalSubmitFeedback()
        {
        }

    }
}