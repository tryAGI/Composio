#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Composio.JsonConverters
{
    /// <inheritdoc />
    public class PostToolRouterSessionBySessionIdProxyExecuteResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Composio.PostToolRouterSessionBySessionIdProxyExecuteResponse>
    {
        /// <inheritdoc />
        public override global::Composio.PostToolRouterSessionBySessionIdProxyExecuteResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Composio.PostToolRouterSessionBySessionIdProxyExecuteResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Composio.PostToolRouterSessionBySessionIdProxyExecuteResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Composio.PostToolRouterSessionBySessionIdProxyExecuteResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Composio.ProxyExecuteCompleted? completed = default;
            if (discriminator?.ResultType == global::Composio.PostToolRouterSessionBySessionIdProxyExecuteResponseDiscriminatorResultType.Completed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Composio.ProxyExecuteCompleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Composio.ProxyExecuteCompleted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Composio.ProxyExecuteCompleted)}");
                completed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Composio.ExecuteRequiresUserInput? inputRequired = default;
            if (discriminator?.ResultType == global::Composio.PostToolRouterSessionBySessionIdProxyExecuteResponseDiscriminatorResultType.InputRequired)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Composio.ExecuteRequiresUserInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Composio.ExecuteRequiresUserInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Composio.ExecuteRequiresUserInput)}");
                inputRequired = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Composio.PostToolRouterSessionBySessionIdProxyExecuteResponse(
                discriminator?.ResultType,
                completed,

                inputRequired
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Composio.PostToolRouterSessionBySessionIdProxyExecuteResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Composio.ProxyExecuteCompleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Composio.ProxyExecuteCompleted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Composio.ProxyExecuteCompleted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickCompleted(), typeInfo);
            }
            else if (value.IsInputRequired)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Composio.ExecuteRequiresUserInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Composio.ExecuteRequiresUserInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Composio.ExecuteRequiresUserInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickInputRequired(), typeInfo);
            }
        }
    }
}