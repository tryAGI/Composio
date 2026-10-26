#nullable enable

namespace Composio.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetToolRouterSessionBySessionIdResponseConfigHookVariant2TypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Composio.GetToolRouterSessionBySessionIdResponseConfigHookVariant2Type>
    {
        /// <inheritdoc />
        public override global::Composio.GetToolRouterSessionBySessionIdResponseConfigHookVariant2Type Read(
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
                        return global::Composio.GetToolRouterSessionBySessionIdResponseConfigHookVariant2TypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Composio.GetToolRouterSessionBySessionIdResponseConfigHookVariant2Type)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Composio.GetToolRouterSessionBySessionIdResponseConfigHookVariant2Type);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Composio.GetToolRouterSessionBySessionIdResponseConfigHookVariant2Type value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Composio.GetToolRouterSessionBySessionIdResponseConfigHookVariant2TypeExtensions.ToValueString(value));
        }
    }
}
