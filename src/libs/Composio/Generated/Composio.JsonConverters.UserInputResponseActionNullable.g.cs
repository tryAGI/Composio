#nullable enable

namespace Composio.JsonConverters
{
    /// <inheritdoc />
    public sealed class UserInputResponseActionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Composio.UserInputResponseAction?>
    {
        /// <inheritdoc />
        public override global::Composio.UserInputResponseAction? Read(
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
                        return global::Composio.UserInputResponseActionExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Composio.UserInputResponseAction)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Composio.UserInputResponseAction?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Composio.UserInputResponseAction? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Composio.UserInputResponseActionExtensions.ToValueString(value.Value));
            }
        }
    }
}
