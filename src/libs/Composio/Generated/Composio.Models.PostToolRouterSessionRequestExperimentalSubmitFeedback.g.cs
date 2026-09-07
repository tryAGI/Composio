
#nullable enable

namespace Composio
{
    /// <summary>
    /// Exposes the COMPOSIO_SUBMIT_FEEDBACK helper tool in this session so the agent can report tool executions with empty, incorrect, or failed results. Defaults to false.
    /// </summary>
    public sealed partial class PostToolRouterSessionRequestExperimentalSubmitFeedback
    {
        /// <summary>
        /// Set to true to expose the COMPOSIO_SUBMIT_FEEDBACK helper tool in this session. Defaults to false.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable")]
        public bool? Enable { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionRequestExperimentalSubmitFeedback" /> class.
        /// </summary>
        /// <param name="enable">
        /// Set to true to expose the COMPOSIO_SUBMIT_FEEDBACK helper tool in this session. Defaults to false.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostToolRouterSessionRequestExperimentalSubmitFeedback(
            bool? enable)
        {
            this.Enable = enable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionRequestExperimentalSubmitFeedback" /> class.
        /// </summary>
        public PostToolRouterSessionRequestExperimentalSubmitFeedback()
        {
        }

    }
}