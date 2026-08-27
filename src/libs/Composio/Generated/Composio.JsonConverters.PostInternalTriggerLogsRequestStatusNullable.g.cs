#nullable enable

namespace Composio.JsonConverters
{
    /// <inheritdoc />
    public sealed class PostInternalTriggerLogsRequestStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Composio.PostInternalTriggerLogsRequestStatus?>
    {
        /// <inheritdoc />
        public override global::Composio.PostInternalTriggerLogsRequestStatus? Read(
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
                        return global::Composio.PostInternalTriggerLogsRequestStatusExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Composio.PostInternalTriggerLogsRequestStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Composio.PostInternalTriggerLogsRequestStatus?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Composio.PostInternalTriggerLogsRequestStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Composio.PostInternalTriggerLogsRequestStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
