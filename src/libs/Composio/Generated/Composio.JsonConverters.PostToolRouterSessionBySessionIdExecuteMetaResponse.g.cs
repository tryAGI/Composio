#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Composio.JsonConverters
{
    /// <inheritdoc />
    public class PostToolRouterSessionBySessionIdExecuteMetaResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Composio.PostToolRouterSessionBySessionIdExecuteMetaResponse>
    {
        /// <inheritdoc />
        public override global::Composio.PostToolRouterSessionBySessionIdExecuteMetaResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Composio.PostToolRouterSessionBySessionIdExecuteMetaResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Composio.PostToolRouterSessionBySessionIdExecuteMetaResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Composio.PostToolRouterSessionBySessionIdExecuteMetaResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Composio.ExecuteCompleted? completed = default;
            if (discriminator?.ResultType == global::Composio.PostToolRouterSessionBySessionIdExecuteMetaResponseDiscriminatorResultType.Completed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Composio.ExecuteCompleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Composio.ExecuteCompleted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Composio.ExecuteCompleted)}");
                completed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Composio.ExecuteFailed? failed = default;
            if (discriminator?.ResultType == global::Composio.PostToolRouterSessionBySessionIdExecuteMetaResponseDiscriminatorResultType.Failed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Composio.ExecuteFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Composio.ExecuteFailed> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Composio.ExecuteFailed)}");
                failed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Composio.ExecuteRequiresUserInput? inputRequired = default;
            if (discriminator?.ResultType == global::Composio.PostToolRouterSessionBySessionIdExecuteMetaResponseDiscriminatorResultType.InputRequired)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Composio.ExecuteRequiresUserInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Composio.ExecuteRequiresUserInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Composio.ExecuteRequiresUserInput)}");
                inputRequired = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Composio.PostToolRouterSessionBySessionIdExecuteMetaResponse(
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
            global::Composio.PostToolRouterSessionBySessionIdExecuteMetaResponse value,
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