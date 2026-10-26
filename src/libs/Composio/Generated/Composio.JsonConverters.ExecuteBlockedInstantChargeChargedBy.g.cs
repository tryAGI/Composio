#nullable enable

namespace Composio.JsonConverters
{
    /// <inheritdoc />
    public sealed class ExecuteBlockedInstantChargeChargedByJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Composio.ExecuteBlockedInstantChargeChargedBy>
    {
        /// <inheritdoc />
        public override global::Composio.ExecuteBlockedInstantChargeChargedBy Read(
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
                        return global::Composio.ExecuteBlockedInstantChargeChargedByExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Composio.ExecuteBlockedInstantChargeChargedBy)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Composio.ExecuteBlockedInstantChargeChargedBy);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Composio.ExecuteBlockedInstantChargeChargedBy value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Composio.ExecuteBlockedInstantChargeChargedByExtensions.ToValueString(value));
        }
    }
}
