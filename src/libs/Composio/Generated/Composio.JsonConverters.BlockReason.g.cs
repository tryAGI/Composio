#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Composio.JsonConverters
{
    /// <inheritdoc />
    public class BlockReasonJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Composio.BlockReason>
    {
        /// <inheritdoc />
        public override global::Composio.BlockReason Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("hook_id")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("hook_id")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Composio.BlockReasonVariant1? blockReasonVariant1 = default;
            global::Composio.BlockReasonVariant2? blockReasonVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Composio.BlockReasonVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Composio.BlockReasonVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Composio.BlockReasonVariant1).Name}");
                        blockReasonVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Composio.BlockReasonVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Composio.BlockReasonVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Composio.BlockReasonVariant2).Name}");
                        blockReasonVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
            }

            if (blockReasonVariant1 == null && blockReasonVariant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Composio.BlockReasonVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Composio.BlockReasonVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Composio.BlockReasonVariant1).Name}");
                    blockReasonVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (blockReasonVariant1 == null && blockReasonVariant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Composio.BlockReasonVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Composio.BlockReasonVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Composio.BlockReasonVariant2).Name}");
                    blockReasonVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            var __value = new global::Composio.BlockReason(
                blockReasonVariant1,

                blockReasonVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Composio.BlockReason value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBlockReasonVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Composio.BlockReasonVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Composio.BlockReasonVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Composio.BlockReasonVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBlockReasonVariant1(), typeInfo);
            }
            else if (value.IsBlockReasonVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Composio.BlockReasonVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Composio.BlockReasonVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Composio.BlockReasonVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBlockReasonVariant2(), typeInfo);
            }
        }
    }
}