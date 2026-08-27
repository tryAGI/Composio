#nullable enable

namespace Composio.JsonConverters
{
    /// <inheritdoc />
    public sealed class PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant3ModeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant3Mode?>
    {
        /// <inheritdoc />
        public override global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant3Mode? Read(
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
                        return global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant3ModeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant3Mode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant3Mode?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant3Mode? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant3ModeExtensions.ToValueString(value.Value));
            }
        }
    }
}
