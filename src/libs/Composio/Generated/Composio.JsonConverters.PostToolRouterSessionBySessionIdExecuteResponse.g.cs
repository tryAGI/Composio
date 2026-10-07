#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Composio.JsonConverters
{
    /// <inheritdoc />
    public class PostToolRouterSessionBySessionIdExecuteResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Composio.PostToolRouterSessionBySessionIdExecuteResponse>
    {
        /// <inheritdoc />
        public override global::Composio.PostToolRouterSessionBySessionIdExecuteResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Composio.PostToolRouterSessionBySessionIdExecuteResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Composio.PostToolRouterSessionBySessionIdExecuteResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Composio.PostToolRouterSessionBySessionIdExecuteResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Composio.ExecuteCompleted? completed = default;
            if (discriminator?.ResultType == global::Composio.PostToolRouterSessionBySessionIdExecuteResponseDiscriminatorResultType.Completed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Composio.ExecuteCompleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Composio.ExecuteCompleted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Composio.ExecuteCompleted)}");
                completed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Composio.ExecuteFailed? failed = default;
            if (discriminator?.ResultType == global::Composio.PostToolRouterSessionBySessionIdExecuteResponseDiscriminatorResultType.Failed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Composio.ExecuteFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Composio.ExecuteFailed> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Composio.ExecuteFailed)}");
                failed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Composio.ExecuteRequiresUserInput? inputRequired = default;
            if (discriminator?.ResultType == global::Composio.PostToolRouterSessionBySessionIdExecuteResponseDiscriminatorResultType.InputRequired)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Composio.ExecuteRequiresUserInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Composio.ExecuteRequiresUserInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Composio.ExecuteRequiresUserInput)}");
                inputRequired = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Composio.PostToolRouterSessionBySessionIdExecuteResponse(
                discriminator?.ResultType,
                completed,

                failed,

                inputRequired
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Composio.PostToolRouterSessionBySessionIdExecuteResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Composio.ExecuteCompleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Composio.ExecuteCompleted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Composio.ExecuteCompleted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickCompleted(), typeInfo);
            }
            else if (value.IsFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Composio.ExecuteFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Composio.ExecuteFailed?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Composio.ExecuteFailed).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickFailed(), typeInfo);
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