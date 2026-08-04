#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class ToolkitsPostCustomToolkitsUpsertCommandApiCommand
{
    private static Argument<string> Slug { get; } = new(
        name: @"slug")
    {
        Description = @"Unique slug identifier for the toolkit. Your slug will be prefixed with CUSTOM_ to avoid collision with composio managed toolkits. Spaces will be converted to underscores.",
    };

    private static Option<global::Composio.PostCustomToolkitsUpsertRequestToolkitConfig> ToolkitConfig { get; } = new(
        name: @"--toolkit-config")
    {
        Description = @"",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::Composio.PostCustomToolkitsUpsertResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Composio.PostCustomToolkitsUpsertResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"post-custom-toolkits-upsert", @"Upsert a new custom toolkit
Experimental: custom toolkits are in pilot and this contract may change. Registers a custom toolkit for the project with the provided slug. Registration is insert-only: a slug that already exists returns 409; delete the toolkit and re-register it to replace it.");
                        command.Arguments.Add(Slug);
                        command.Options.Add(ToolkitConfig);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var slug = parseResult.GetRequiredValue(Slug);
                        var toolkitConfig = parseResult.GetRequiredValue(ToolkitConfig);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Toolkits.PostCustomToolkitsUpsertAsync(
                                    slug: slug,
                                    toolkitConfig: toolkitConfig,
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