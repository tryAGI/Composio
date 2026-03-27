using System.Text.Json;
using Microsoft.Extensions.AI;

namespace Composio;

/// <summary>
/// Extensions for using ComposioClient operations as MEAI tools with any IChatClient.
/// </summary>
public static class ComposioToolExtensions
{
    /// <summary>
    /// Creates an <see cref="AIFunction"/> that executes a Composio tool by slug.
    /// </summary>
    /// <param name="client">The Composio client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsExecuteToolTool(this ComposioClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string toolSlug, string connectedAccountId, string? text, string? arguments, CancellationToken cancellationToken) =>
            {
                Dictionary<string, object?>? parsedArgs = null;
                if (arguments is { Length: > 0 })
                {
                    parsedArgs = JsonSerializer.Deserialize<Dictionary<string, object?>>(arguments);
                }

                var response = await client.Tools.PostToolsExecuteByToolSlugAsync(
                    toolSlug: toolSlug,
                    connectedAccountId: connectedAccountId,
                    text: text,
                    arguments: parsedArgs,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return JsonSerializer.Serialize(new
                {
                    successful = response.Successful,
                    error = response.Error,
                    data = response.Data,
                    log_id = response.LogId,
                });
            },
            name: "ExecuteComposioTool",
            description: "Executes a Composio tool by its slug (e.g., 'github-actions', 'gmail-send-email'). Provide either structured JSON arguments or a natural language text description of the task. Requires a connectedAccountId for authenticated tools.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists available Composio tools.
    /// </summary>
    /// <param name="client">The Composio client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsListToolsTool(this ComposioClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string? toolkitSlug, string? search, CancellationToken cancellationToken) =>
            {
                var response = await client.Tools.GetToolsAsync(
                    toolkitSlug: toolkitSlug,
                    search: search,
                    limit: 20,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return JsonSerializer.Serialize(new
                {
                    total_items = response.TotalItems,
                    items = response.Items.Select(t => new
                    {
                        slug = t.Slug,
                        name = t.Name,
                        description = t.Description,
                        no_auth = t.NoAuth,
                        version = t.Version,
                    }),
                });
            },
            name: "ListComposioTools",
            description: "Lists available Composio tools with optional filtering by toolkit slug (e.g., 'github', 'gmail') or search query. Returns tool slugs, names, descriptions, and auth requirements.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists available Composio toolkits (integrations).
    /// </summary>
    /// <param name="client">The Composio client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsListToolkitsTool(this ComposioClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string? search, string? category, CancellationToken cancellationToken) =>
            {
                var response = await client.Toolkits.GetToolkitsAsync(
                    search: search,
                    category: category,
                    limit: 20,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return JsonSerializer.Serialize(new
                {
                    total_items = response.TotalItems,
                    items = response.Items.Select(t => new
                    {
                        slug = t.Slug,
                        name = t.Name,
                        auth_schemes = t.AuthSchemes,
                        no_auth = t.NoAuth,
                    }),
                });
            },
            name: "ListComposioToolkits",
            description: "Lists available Composio toolkits (integrations like GitHub, Gmail, Slack). Optionally filter by search query or category. Returns toolkit slugs, names, and auth schemes.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists connected accounts.
    /// </summary>
    /// <param name="client">The Composio client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsListConnectedAccountsTool(this ComposioClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var response = await client.ConnectedAccounts.GetConnectedAccountsAsync(
                    limit: 50,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return JsonSerializer.Serialize(new
                {
                    total_items = response.TotalItems,
                    items = response.Items.Select(a => new
                    {
                        id = a.Id,
                        toolkit_slug = a.Toolkit.Slug,
                        status = a.Status.ToString(),
                        created_at = a.CreatedAt,
                    }),
                });
            },
            name: "ListConnectedAccounts",
            description: "Lists all connected accounts (authenticated integrations) for the current project. Returns account IDs, toolkit slugs, statuses, and creation dates. Use the account ID when executing tools.");
    }
}
