#nullable enable

namespace Composio.JsonConverters
{
    /// <inheritdoc />
    public sealed class PatchToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Composio.PatchToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItem>
    {
        /// <inheritdoc />
        public override global::Composio.PatchToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItem Read(
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
                        return global::Composio.PatchToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItemExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Composio.PatchToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItem)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Composio.PatchToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItem);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Composio.PatchToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Composio.PatchToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItemExtensions.ToValueString(value));
        }
    }
}
