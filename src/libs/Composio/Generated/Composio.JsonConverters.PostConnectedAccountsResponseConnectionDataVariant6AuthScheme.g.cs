#nullable enable

namespace Composio.JsonConverters
{
    /// <inheritdoc />
    public sealed class PostConnectedAccountsResponseConnectionDataVariant6AuthSchemeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Composio.PostConnectedAccountsResponseConnectionDataVariant6AuthScheme>
    {
        /// <inheritdoc />
        public override global::Composio.PostConnectedAccountsResponseConnectionDataVariant6AuthScheme Read(
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
                        return global::Composio.PostConnectedAccountsResponseConnectionDataVariant6AuthSchemeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Composio.PostConnectedAccountsResponseConnectionDataVariant6AuthScheme)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Composio.PostConnectedAccountsResponseConnectionDataVariant6AuthScheme);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Composio.PostConnectedAccountsResponseConnectionDataVariant6AuthScheme value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Composio.PostConnectedAccountsResponseConnectionDataVariant6AuthSchemeExtensions.ToValueString(value));
        }
    }
}
