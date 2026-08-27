#nullable enable

namespace Composio.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetConnectedAccountsResponseItemStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Composio.GetConnectedAccountsResponseItemStatus?>
    {
        /// <inheritdoc />
        public override global::Composio.GetConnectedAccountsResponseItemStatus? Read(
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
                        return global::Composio.GetConnectedAccountsResponseItemStatusExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Composio.GetConnectedAccountsResponseItemStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Composio.GetConnectedAccountsResponseItemStatus?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Composio.GetConnectedAccountsResponseItemStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Composio.GetConnectedAccountsResponseItemStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
