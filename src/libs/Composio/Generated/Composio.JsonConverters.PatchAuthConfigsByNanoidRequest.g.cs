#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Composio.JsonConverters
{
    /// <inheritdoc />
    public class PatchAuthConfigsByNanoidRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Composio.PatchAuthConfigsByNanoidRequest>
    {
        /// <inheritdoc />
        public override global::Composio.PatchAuthConfigsByNanoidRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Composio.PatchAuthConfigsByNanoidRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Composio.PatchAuthConfigsByNanoidRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Composio.PatchAuthConfigsByNanoidRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Composio.CustomAuthConfigUpdate? custom = default;
            if (discriminator?.Type == global::Composio.PatchAuthConfigsByNanoidRequestDiscriminatorType.Custom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Composio.CustomAuthConfigUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Composio.CustomAuthConfigUpdate> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Composio.CustomAuthConfigUpdate)}");
                custom = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Composio.DefaultAuthConfigUpdate? @default = default;
            if (discriminator?.Type == global::Composio.PatchAuthConfigsByNanoidRequestDiscriminatorType.Default)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Composio.DefaultAuthConfigUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Composio.DefaultAuthConfigUpdate> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Composio.DefaultAuthConfigUpdate)}");
                @default = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Composio.PatchAuthConfigsByNanoidRequest(
                discriminator?.Type,
                custom,

                @default
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Composio.PatchAuthConfigsByNanoidRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCustom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Composio.CustomAuthConfigUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Composio.CustomAuthConfigUpdate?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Composio.CustomAuthConfigUpdate).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Custom!, typeInfo);
            }
            else if (value.IsDefault)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Composio.DefaultAuthConfigUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Composio.DefaultAuthConfigUpdate?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Composio.DefaultAuthConfigUpdate).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Default!, typeInfo);
            }
        }
    }
}