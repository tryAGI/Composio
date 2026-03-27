#nullable enable

namespace Composio.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetConnectedAccountsOrderDirectionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Composio.GetConnectedAccountsOrderDirection>
    {
        /// <inheritdoc />
        public override global::Composio.GetConnectedAccountsOrderDirection Read(
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
                        return global::Composio.GetConnectedAccountsOrderDirectionExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Composio.GetConnectedAccountsOrderDirection)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Composio.GetConnectedAccountsOrderDirection);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Composio.GetConnectedAccountsOrderDirection value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Composio.GetConnectedAccountsOrderDirectionExtensions.ToValueString(value));
        }
    }
}
