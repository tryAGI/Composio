#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class TriggersGetTriggersTypesBySlugCommandApiCommand
{
    private static Argument<string> Slug { get; } = new(
        name: @"slug")
    {
        Description = @"The unique slug identifier for the trigger type. Case-insensitive (internally normalized to uppercase).",
    };

    private static Option<global::Composio.OneOf<object, string, global::System.Collections.Generic.Dictionary<string, string>>?> ToolkitVersions { get; } = new(
        name: @"--toolkit-versions")
    {
        Description = @"Toolkit version specification. Use ""latest"" for latest versions or bracket notation for specific versions per toolkit.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Composio.GetTriggersTypesBySlugResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Composio.GetTriggersTypesBySlugResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-triggers-types-by-slug", @"Get trigger type by slug
Retrieve detailed information about a specific trigger type using its slug identifier");
                        command.Arguments.Add(Slug);
                        command.Options.Add(ToolkitVersions);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var slug = parseResult.GetRequiredValue(Slug);
                        var toolkitVersions = parseResult.GetValue(ToolkitVersions);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Triggers.GetTriggersTypesBySlugAsync(
                                    slug: slug,
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