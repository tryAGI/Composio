#nullable enable

namespace Composio.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetToolkitsBySlugResponseTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Composio.GetToolkitsBySlugResponseType?>
    {
        /// <inheritdoc />
        public override global::Composio.GetToolkitsBySlugResponseType? Read(
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
                        return global::Composio.GetToolkitsBySlugResponseTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Composio.GetToolkitsBySlugResponseType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Composio.GetToolkitsBySlugResponseType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Composio.GetToolkitsBySlugResponseType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Composio.GetToolkitsBySlugResponseTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
