#nullable enable

namespace Composio.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetConnectedAccountsResponseItemStateVariant10ValVariant1StatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Composio.GetConnectedAccountsResponseItemStateVariant10ValVariant1Status?>
    {
        /// <inheritdoc />
        public override global::Composio.GetConnectedAccountsResponseItemStateVariant10ValVariant1Status? Read(
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
                        return global::Composio.GetConnectedAccountsResponseItemStateVariant10ValVariant1StatusExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Composio.GetConnectedAccountsResponseItemStateVariant10ValVariant1Status)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Composio.GetConnectedAccountsResponseItemStateVariant10ValVariant1Status?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Composio.GetConnectedAccountsResponseItemStateVariant10ValVariant1Status? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Composio.GetConnectedAccountsResponseItemStateVariant10ValVariant1StatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
