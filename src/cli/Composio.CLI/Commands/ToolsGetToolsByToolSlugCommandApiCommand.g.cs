#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class ToolsGetToolsByToolSlugCommandApiCommand
{
    private static Argument<string> ToolSlug { get; } = new(
        name: @"tool-slug")
    {
        Description = @"The unique slug identifier of the tool",
    };

    private static Option<string?> Version { get; } = new(
        name: @"--version")
    {
        Description = @"Optional version of the tool to retrieve",
    };

    private static Option<global::Composio.OneOf<object, string, global::System.Collections.Generic.Dictionary<string, string>>?> ToolkitVersions { get; } = new(
        name: @"--toolkit-versions")
    {
        Description = @"Toolkit version specification. Use ""latest"" for latest versions or bracket notation for specific versions per toolkit.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Composio.Tool value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Composio.Tool value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-tools-by-tool-slug", @"Get tool by slug
Retrieve detailed information about a specific tool using its slug identifier. This endpoint returns full metadata about a tool including input/output parameters, versions, and toolkit information.");
                        command.Arguments.Add(ToolSlug);
                        command.Options.Add(Version);
                        command.Options.Add(ToolkitVersions);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var toolSlug = parseResult.GetRequiredValue(ToolSlug);
                        var version = parseResult.GetValue(Version);
                        var toolkitVersions = parseResult.GetValue(ToolkitVersions);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Tools.GetToolsByToolSlugAsync(
                                    toolSlug: toolSlug,
                                    version: version,
                                    toolkitVersions: toolkitVersions,
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