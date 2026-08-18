#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Composio.JsonConverters
{
    /// <inheritdoc />
    public class AuthConfigJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Composio.AuthConfig>
    {
        /// <inheritdoc />
        public override global::Composio.AuthConfig Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Composio.PostAuthConfigsRequestAuthConfigDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Composio.PostAuthConfigsRequestAuthConfigDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Composio.PostAuthConfigsRequestAuthConfigDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Composio.ComposioManagedAuthConfigCreate? useComposioManagedAuth = default;
            if (discriminator?.Type == global::Composio.PostAuthConfigsRequestAuthConfigDiscriminatorType.UseComposioManagedAuth)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Composio.ComposioManagedAuthConfigCreate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Composio.ComposioManagedAuthConfigCreate> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Composio.ComposioManagedAuthConfigCreate)}");
                useComposioManagedAuth = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Composio.CustomAuthConfigCreate? useCustomAuth = default;
            if (discriminator?.Type == global::Composio.PostAuthConfigsRequestAuthConfigDiscriminatorType.UseCustomAuth)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Composio.CustomAuthConfigCreate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Composio.CustomAuthConfigCreate> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Composio.CustomAuthConfigCreate)}");
                useCustomAuth = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Composio.AuthConfig(
                discriminator?.Type,
                useComposioManagedAuth,

                useCustomAuth
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Composio.AuthConfig value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsUseComposioManagedAuth)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Composio.ComposioManagedAuthConfigCreate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Composio.ComposioManagedAuthConfigCreate?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Composio.ComposioManagedAuthConfigCreate).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UseComposioManagedAuth!, typeInfo);
            }
            else if (value.IsUseCustomAuth)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Composio.CustomAuthConfigCreate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Composio.CustomAuthConfigCreate?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Composio.CustomAuthConfigCreate).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UseCustomAuth!, typeInfo);
            }
        }
    }
}