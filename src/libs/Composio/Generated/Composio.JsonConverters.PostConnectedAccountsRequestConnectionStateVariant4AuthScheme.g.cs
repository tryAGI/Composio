#nullable enable

namespace Composio.JsonConverters
{
    /// <inheritdoc />
    public sealed class PostConnectedAccountsRequestConnectionStateVariant4AuthSchemeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Composio.PostConnectedAccountsRequestConnectionStateVariant4AuthScheme>
    {
        /// <inheritdoc />
        public override global::Composio.PostConnectedAccountsRequestConnectionStateVariant4AuthScheme Read(
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
                        return global::Composio.PostConnectedAccountsRequestConnectionStateVariant4AuthSchemeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Composio.PostConnectedAccountsRequestConnectionStateVariant4AuthScheme)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Composio.PostConnectedAccountsRequestConnectionStateVariant4AuthScheme);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Composio.PostConnectedAccountsRequestConnectionStateVariant4AuthScheme value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Composio.PostConnectedAccountsRequestConnectionStateVariant4AuthSchemeExtensions.ToValueString(value));
        }
    }
}
