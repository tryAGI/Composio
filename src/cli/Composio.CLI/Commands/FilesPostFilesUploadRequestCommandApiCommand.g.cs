#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class FilesPostFilesUploadRequestCommandApiCommand
{
    private static Option<string> ToolkitSlug { get; } = new(
        name: @"--toolkit-slug")
    {
        Description = @"Slug of the app where this file belongs to. Example: ""gmail"", ""slack"", ""github""",
        Required = true,
    };

    private static Option<string> ToolSlug { get; } = new(
        name: @"--tool-slug")
    {
        Description = @"Slug of the action where this file belongs to. Example: ""GMAIL_SEND_EMAIL"", ""SLACK_UPLOAD_FILE""",
        Required = true,
    };

    private static Option<string> Filename { get; } = new(
        name: @"--filename")
    {
        Description = @"Name of the original file. Example: ""quarterly_report.pdf""",
        Required = true,
    };

    private static Option<string> Mimetype { get; } = new(
        name: @"--mimetype")
    {
        Description = @"Mime type of the original file. Example: ""application/pdf"", ""image/png""",
        Required = true,
    };

    private static Option<string> Md5 { get; } = new(
        name: @"--md5")
    {
        Description = @"MD5 hash of the file for deduplication and integrity verification. Example: ""a1b2c3d4e5f6a7b8c9d0e1f2a3b4c5d6""",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::Composio.PostFilesUploadRequestResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Composio.PostFilesUploadRequestResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"post-files-upload-request", @"Create presigned URL for request file upload to S3
Generates a presigned URL for uploading a file to S3. This endpoint handles deduplication by checking if a file with the same MD5 hash already exists.");
                        command.Options.Add(ToolkitSlug);
                        command.Options.Add(ToolSlug);
                        command.Options.Add(Filename);
                        command.Options.Add(Mimetype);
                        command.Options.Add(Md5);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var toolkitSlug = parseResult.GetRequiredValue(ToolkitSlug);
                        var toolSlug = parseResult.GetRequiredValue(ToolSlug);
                        var filename = parseResult.GetRequiredValue(Filename);
                        var mimetype = parseResult.GetRequiredValue(Mimetype);
                        var md5 = parseResult.GetRequiredValue(Md5);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Files.PostFilesUploadRequestAsync(
                                    toolkitSlug: toolkitSlug,
                                    toolSlug: toolSlug,
                                    filename: filename,
                                    mimetype: mimetype,
                                    md5: md5,
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