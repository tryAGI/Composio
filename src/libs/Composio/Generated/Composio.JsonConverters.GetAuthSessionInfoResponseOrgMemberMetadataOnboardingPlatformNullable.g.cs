#nullable enable

namespace Composio.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetAuthSessionInfoResponseOrgMemberMetadataOnboardingPlatformNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Composio.GetAuthSessionInfoResponseOrgMemberMetadataOnboardingPlatform?>
    {
        /// <inheritdoc />
        public override global::Composio.GetAuthSessionInfoResponseOrgMemberMetadataOnboardingPlatform? Read(
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
                        return global::Composio.GetAuthSessionInfoResponseOrgMemberMetadataOnboardingPlatformExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Composio.GetAuthSessionInfoResponseOrgMemberMetadataOnboardingPlatform)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Composio.GetAuthSessionInfoResponseOrgMemberMetadataOnboardingPlatform?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Composio.GetAuthSessionInfoResponseOrgMemberMetadataOnboardingPlatform? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Composio.GetAuthSessionInfoResponseOrgMemberMetadataOnboardingPlatformExtensions.ToValueString(value.Value));
            }
        }
    }
}
