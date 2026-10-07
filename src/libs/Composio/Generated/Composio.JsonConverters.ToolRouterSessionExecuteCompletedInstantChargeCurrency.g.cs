#nullable enable

namespace Composio.JsonConverters
{
    /// <inheritdoc />
    public sealed class ToolRouterSessionExecuteCompletedInstantChargeCurrencyJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Composio.ToolRouterSessionExecuteCompletedInstantChargeCurrency>
    {
        /// <inheritdoc />
        public override global::Composio.ToolRouterSessionExecuteCompletedInstantChargeCurrency Read(
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
                        return global::Composio.ToolRouterSessionExecuteCompletedInstantChargeCurrencyExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Composio.ToolRouterSessionExecuteCompletedInstantChargeCurrency)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Composio.ToolRouterSessionExecuteCompletedInstantChargeCurrency);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Composio.ToolRouterSessionExecuteCompletedInstantChargeCurrency value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Composio.ToolRouterSessionExecuteCompletedInstantChargeCurrencyExtensions.ToValueString(value));
        }
    }
}
