#nullable enable

namespace Composio.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsDisabledItemNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsDisabledItem?>
    {
        /// <inheritdoc />
        public override global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsDisabledItem? Read(
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
                        return global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsDisabledItemExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsDisabledItem)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsDisabledItem?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsDisabledItem? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsDisabledItemExtensions.ToValueString(value.Value));
            }
        }
    }
}
