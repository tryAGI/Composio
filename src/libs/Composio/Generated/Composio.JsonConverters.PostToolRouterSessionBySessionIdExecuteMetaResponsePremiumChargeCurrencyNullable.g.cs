#nullable enable

namespace Composio.JsonConverters
{
    /// <inheritdoc />
    public sealed class PostToolRouterSessionBySessionIdExecuteMetaResponsePremiumChargeCurrencyNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Composio.PostToolRouterSessionBySessionIdExecuteMetaResponsePremiumChargeCurrency?>
    {
        /// <inheritdoc />
        public override global::Composio.PostToolRouterSessionBySessionIdExecuteMetaResponsePremiumChargeCurrency? Read(
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
                        return global::Composio.PostToolRouterSessionBySessionIdExecuteMetaResponsePremiumChargeCurrencyExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Composio.PostToolRouterSessionBySessionIdExecuteMetaResponsePremiumChargeCurrency)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Composio.PostToolRouterSessionBySessionIdExecuteMetaResponsePremiumChargeCurrency?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Composio.PostToolRouterSessionBySessionIdExecuteMetaResponsePremiumChargeCurrency? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Composio.PostToolRouterSessionBySessionIdExecuteMetaResponsePremiumChargeCurrencyExtensions.ToValueString(value.Value));
            }
        }
    }
}
