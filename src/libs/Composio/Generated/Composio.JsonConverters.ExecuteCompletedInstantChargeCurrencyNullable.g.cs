#nullable enable

namespace Composio.JsonConverters
{
    /// <inheritdoc />
    public sealed class ExecuteCompletedInstantChargeCurrencyNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Composio.ExecuteCompletedInstantChargeCurrency?>
    {
        /// <inheritdoc />
        public override global::Composio.ExecuteCompletedInstantChargeCurrency? Read(
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
                        return global::Composio.ExecuteCompletedInstantChargeCurrencyExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Composio.ExecuteCompletedInstantChargeCurrency)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Composio.ExecuteCompletedInstantChargeCurrency?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Composio.ExecuteCompletedInstantChargeCurrency? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Composio.ExecuteCompletedInstantChargeCurrencyExtensions.ToValueString(value.Value));
            }
        }
    }
}
