#nullable enable

namespace Composio.JsonConverters
{
    /// <inheritdoc />
    public sealed class PostToolRouterSessionBySessionIdLinkResponseExperimentalAccountTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Composio.PostToolRouterSessionBySessionIdLinkResponseExperimentalAccountType?>
    {
        /// <inheritdoc />
        public override global::Composio.PostToolRouterSessionBySessionIdLinkResponseExperimentalAccountType? Read(
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
                        return global::Composio.PostToolRouterSessionBySessionIdLinkResponseExperimentalAccountTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Composio.PostToolRouterSessionBySessionIdLinkResponseExperimentalAccountType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Composio.PostToolRouterSessionBySessionIdLinkResponseExperimentalAccountType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Composio.PostToolRouterSessionBySessionIdLinkResponseExperimentalAccountType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Composio.PostToolRouterSessionBySessionIdLinkResponseExperimentalAccountTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
