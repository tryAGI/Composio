using System.Text.Json;
using Microsoft.Extensions.AI;

namespace Composio;

/// <summary>
/// Extensions for using ComposioClient operations as MEAI tools with any IChatClient.
/// </summary>
public static class ComposioToolExtensions
{
    /// <summary>
    /// Creates an <see cref="AIFunction"/> that executes a Composio tool by its slug.
    /// </summary>
    /// <param name="client">The Composio client.</param>
    /// <param name="connectedAccountId">Optional default connected account ID for authentication.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsExecuteToolTool(
        this ComposioClient client,
        string? connectedAccountId = null)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string toolSlug, string? arguments, string? text, CancellationToken cancellationToken) =>
            {
                var parsedArgs = arguments is not null
                    ? JsonSerializer.Deserialize<Dictionary<string, object?>>(arguments)
                    : null;

                var response = await client.Tools.PostToolsExecuteByToolSlugAsync(
                    toolSlug: toolSlug,
                    connectedAccountId: connectedAccountId,
                    arguments: parsedArgs,
                    text: text,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return JsonSerializer.Serialize(new
                {
                    successful = response.Successful,
                    data = response.Data,
                    error = response.Error,
                });
            },
            name: "ExecuteComposioTool",
            description: "Executes a Composio tool by its slug (e.g., 'github-issues-create', 'slack-send-message'). Accepts structured JSON arguments or a natural language text description of the action to perform.");
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
                        toolkit = t.Toolkit.Name,
                        no_auth = t.NoAuth,
                        tags = t.Tags,
                    }),
                });
            },
            name: "ListComposioTools",
            description: "Lists available Composio tools with their slugs, names, descriptions, and required parameters. Filter by toolkit slug (e.g., 'github', 'slack') or search by keyword.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists available Composio toolkits (apps/integrations).
    /// </summary>
    /// <param name="client">The Composio client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsListToolkitsTool(this ComposioClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string? search, CancellationToken cancellationToken) =>
            {
                var response = await client.Toolkits.GetToolkitsAsync(
                    search: search,
                    limit: 20,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return JsonSerializer.Serialize(response.Items.Select(t => new
                {
                    slug = t.Slug,
                    name = t.Name,
                    auth_schemes = t.AuthSchemes,
                    no_auth = t.NoAuth,
                }));
            },
            name: "ListComposioToolkits",
            description: "Lists available Composio toolkits (integrations like GitHub, Slack, Gmail, etc.) with their slugs and supported authentication methods. Search by name to find specific integrations.");
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
                    limit: 20,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return JsonSerializer.Serialize(new
                {
                    total_items = response.TotalItems,
                    items = response.Items.Select(a => new
                    {
                        id = a.Id,
                        toolkit = a.Toolkit.Slug,
                        status = a.Status.ToString(),
                        created_at = a.CreatedAt,
                        is_disabled = a.IsDisabled,
                    }),
                });
            },
            name: "ListComposioConnectedAccounts",
            description: "Lists connected accounts (authenticated integrations) in Composio. Returns account IDs, toolkit names, statuses, and whether they are disabled. Use the account ID when executing tools that require authentication.");
    }
}
