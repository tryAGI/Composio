#nullable enable

namespace Composio.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetToolRouterSessionBySessionIdResponseConfigWorkbenchSandboxSizeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Composio.GetToolRouterSessionBySessionIdResponseConfigWorkbenchSandboxSize>
    {
        /// <inheritdoc />
        public override global::Composio.GetToolRouterSessionBySessionIdResponseConfigWorkbenchSandboxSize Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Composio.GetToolRouterSessionBySessionIdResponseConfigWorkbenchSandboxSizeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Composio.GetToolRouterSessionBySessionIdResponseConfigWorkbenchSandboxSize)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Composio.GetToolRouterSessionBySessionIdResponseConfigWorkbenchSandboxSize);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Composio.GetToolRouterSessionBySessionIdResponseConfigWorkbenchSandboxSize value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Composio.GetToolRouterSessionBySessionIdResponseConfigWorkbenchSandboxSizeExtensions.ToValueString(value));
        }
    }
}
