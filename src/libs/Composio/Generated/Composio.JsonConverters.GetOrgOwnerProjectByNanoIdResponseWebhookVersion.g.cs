#nullable enable

namespace Composio.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetOrgOwnerProjectByNanoIdResponseWebhookVersionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Composio.GetOrgOwnerProjectByNanoIdResponseWebhookVersion>
    {
        /// <inheritdoc />
        public override global::Composio.GetOrgOwnerProjectByNanoIdResponseWebhookVersion Read(
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
                        return global::Composio.GetOrgOwnerProjectByNanoIdResponseWebhookVersionExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Composio.GetOrgOwnerProjectByNanoIdResponseWebhookVersion)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Composio.GetOrgOwnerProjectByNanoIdResponseWebhookVersion);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Composio.GetOrgOwnerProjectByNanoIdResponseWebhookVersion value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Composio.GetOrgOwnerProjectByNanoIdResponseWebhookVersionExtensions.ToValueString(value));
        }
    }
}
