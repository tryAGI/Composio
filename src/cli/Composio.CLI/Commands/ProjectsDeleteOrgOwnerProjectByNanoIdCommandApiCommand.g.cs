#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class ProjectsDeleteOrgOwnerProjectByNanoIdCommandApiCommand
{
    private static Argument<string> NanoId { get; } = new(
        name: @"nano-id")
    {
        Description = @"Unique identifier (Nano ID) of the project to delete",
    };

    private static Option<bool?> RevokeOnDelete { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--revoke-on-delete",
        description: @"When `true`, the delete also starts a background job that revokes the upstream credentials of every connected account in scope, and the response carries a `revoke_job_id`. Defaults to `false`. Revocation is irreversible — recovering a deleted entity does not restore working credentials.");

                    private static string FormatResponse(ParseResult parseResult, global::Composio.DeleteOrgOwnerProjectByNanoIdResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Composio.DeleteOrgOwnerProjectByNanoIdResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"delete-org-owner-project-by-nano-id", @"Delete a project
Deletes a project within the organization by its unique identifier. This affects every resource belonging to the project, including its API keys, webhook configurations, and connected services. The action cannot be undone. Pass `?revoke_on_delete=true` to also revoke the upstream credentials of every connection in the project.");
                        command.Arguments.Add(NanoId);
                        command.Options.Add(RevokeOnDelete);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var nanoId = parseResult.GetRequiredValue(NanoId);
                        var revokeOnDelete = parseResult.GetValue(RevokeOnDelete);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Projects.DeleteOrgOwnerProjectByNanoIdAsync(
                                    nanoId: nanoId,
                                    revokeOnDelete: revokeOnDelete,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Composio.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}