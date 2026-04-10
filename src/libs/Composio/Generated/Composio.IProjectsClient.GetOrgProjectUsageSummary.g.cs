#nullable enable

namespace Composio
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Project usage summary<br/>
        /// Aggregated metering usage for the authenticated project only. Requires ClickHouse logging (`USE_CLICKHOUSE_FOR_LOGS`). Values are summed from raw metering events grouped by `entity_type`.
        /// </summary>
        /// <param name="startTime">
        /// Inclusive range start (ISO 8601). Defaults to 30 days before end_time.
        /// </param>
        /// <param name="endTime">
        /// Exclusive range end (ISO 8601). Defaults to now.
        /// </param>
        /// <param name="entityTypes">
        /// Filter to these metering entity types (comma-separated or repeated query keys). Omit for all types.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.GetOrgProjectUsageSummaryResponse> GetOrgProjectUsageSummaryAsync(
            string? startTime = default,
            string? endTime = default,
            global::System.Collections.Generic.IList<string>? entityTypes = default,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}