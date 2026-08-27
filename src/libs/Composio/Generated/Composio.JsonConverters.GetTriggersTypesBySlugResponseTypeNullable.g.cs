#nullable enable

namespace Composio.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetTriggersTypesBySlugResponseTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Composio.GetTriggersTypesBySlugResponseType?>
    {
        /// <inheritdoc />
        public override global::Composio.GetTriggersTypesBySlugResponseType? Read(
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
                        return global::Composio.GetTriggersTypesBySlugResponseTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Composio.GetTriggersTypesBySlugResponseType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Composio.GetTriggersTypesBySlugResponseType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Composio.GetTriggersTypesBySlugResponseType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Composio.GetTriggersTypesBySlugResponseTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
