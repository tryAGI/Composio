#nullable enable

namespace Composio.JsonConverters
{
    /// <inheritdoc />
    public sealed class PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant11AuthSchemeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Composio.PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant11AuthScheme?>
    {
        /// <inheritdoc />
        public override global::Composio.PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant11AuthScheme? Read(
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
                        return global::Composio.PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant11AuthSchemeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Composio.PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant11AuthScheme)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Composio.PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant11AuthScheme?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Composio.PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant11AuthScheme? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Composio.PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant11AuthSchemeExtensions.ToValueString(value.Value));
            }
        }
    }
}
