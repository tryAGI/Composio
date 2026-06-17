#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class ToolRouterPostToolRouterSessionBySessionIdMountsByMountIdUploadUrlCommandApiCommand
{
    private static Argument<string> SessionId { get; } = new(
        name: @"session-id")
    {
        Description = @"The unique identifier of the tool router session",
    };

    private static Argument<string> MountId { get; } = new(
        name: @"mount-id")
    {
        Description = @"ID of the storage mount",
    };

    private static Option<string> MountRelativePath { get; } = new(
        name: @"--mount-relative-path")
    {
        Description = @"Supports subdirectories (e.g. ""data/output.csv"", ""images/charts/chart.png"")",
        Required = true,
    };

    private static Option<string?> Mimetype { get; } = new(
        name: @"--mimetype")
    {
        Description = @"MIME type of the file being uploaded",
    };
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

                    private static string FormatResponse(ParseResult parseResult, global::Composio.PostToolRouterSessionBySessionIdMountsByMountIdUploadUrlResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Composio.PostToolRouterSessionBySessionIdMountsByMountIdUploadUrlResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"post-tool-router-session-by-session-id-mounts-by-mount-id-upload-url", @"Create a presigned upload URL for a mount file
Generates a presigned upload URL for uploading a file to a workbench session mount. The caller should PUT the file content directly to the returned URL.");
                        command.Arguments.Add(SessionId);
                        command.Arguments.Add(MountId);
                        command.Options.Add(MountRelativePath);
                        command.Options.Add(Mimetype);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Composio.PostToolRouterSessionBySessionIdMountsByMountIdUploadUrlRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Composio.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var sessionId = parseResult.GetRequiredValue(SessionId);
                        var mountId = parseResult.GetRequiredValue(MountId);
                        var mountRelativePath = parseResult.GetRequiredValue(MountRelativePath);
                        var mimetype = CliRuntime.WasSpecified(parseResult, Mimetype) ? parseResult.GetValue(Mimetype) : (__requestBase is { } __MimetypeBaseValue ? __MimetypeBaseValue.Mimetype : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ToolRouter.PostToolRouterSessionBySessionIdMountsByMountIdUploadUrlAsync(
                                    sessionId: sessionId,
                                    mountId: mountId,
                                    mountRelativePath: mountRelativePath,
                                    mimetype: mimetype,
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