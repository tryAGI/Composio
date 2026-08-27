#nullable enable

namespace Composio.JsonConverters
{
    /// <inheritdoc />
    public sealed class PostConnectedAccountsRequestConnectionStateVariant13AuthSchemeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Composio.PostConnectedAccountsRequestConnectionStateVariant13AuthScheme?>
    {
        /// <inheritdoc />
        public override global::Composio.PostConnectedAccountsRequestConnectionStateVariant13AuthScheme? Read(
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
                        return global::Composio.PostConnectedAccountsRequestConnectionStateVariant13AuthSchemeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Composio.PostConnectedAccountsRequestConnectionStateVariant13AuthScheme)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Composio.PostConnectedAccountsRequestConnectionStateVariant13AuthScheme?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Composio.PostConnectedAccountsRequestConnectionStateVariant13AuthScheme? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Composio.PostConnectedAccountsRequestConnectionStateVariant13AuthSchemeExtensions.ToValueString(value.Value));
            }
        }
    }
}
