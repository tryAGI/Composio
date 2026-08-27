#nullable enable

namespace Composio.JsonConverters
{
    /// <inheritdoc />
    public sealed class DeleteOrgOwnerProjectByNanoIdResponseStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Composio.DeleteOrgOwnerProjectByNanoIdResponseStatus?>
    {
        /// <inheritdoc />
        public override global::Composio.DeleteOrgOwnerProjectByNanoIdResponseStatus? Read(
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
                        return global::Composio.DeleteOrgOwnerProjectByNanoIdResponseStatusExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Composio.DeleteOrgOwnerProjectByNanoIdResponseStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Composio.DeleteOrgOwnerProjectByNanoIdResponseStatus?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Composio.DeleteOrgOwnerProjectByNanoIdResponseStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Composio.DeleteOrgOwnerProjectByNanoIdResponseStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
