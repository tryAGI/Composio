
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.ErrorError1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostWebhookSubscriptionsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostWebhookSubscriptionsRequestVersion), TypeInfoPropertyName = "PostWebhookSubscriptionsRequestVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PatchWebhookSubscriptionsByIdRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PatchWebhookSubscriptionsByIdRequestVersion), TypeInfoPropertyName = "PatchWebhookSubscriptionsByIdRequestVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostWebhookSubscriptionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostWebhookSubscriptionsResponseVersion), TypeInfoPropertyName = "PostWebhookSubscriptionsResponseVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetWebhookSubscriptionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.GetWebhookSubscriptionsResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetWebhookSubscriptionsResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetWebhookSubscriptionsResponseItemVersion), TypeInfoPropertyName = "GetWebhookSubscriptionsResponseItemVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetWebhookSubscriptionsByIdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetWebhookSubscriptionsByIdResponseVersion), TypeInfoPropertyName = "GetWebhookSubscriptionsByIdResponseVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PatchWebhookSubscriptionsByIdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PatchWebhookSubscriptionsByIdResponseVersion), TypeInfoPropertyName = "PatchWebhookSubscriptionsByIdResponseVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.DeleteWebhookSubscriptionsByIdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostWebhookSubscriptionsByIdRotateSecretResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetWebhookSubscriptionsEventTypesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.GetWebhookSubscriptionsEventTypesResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetWebhookSubscriptionsEventTypesResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.GetWebhookSubscriptionsEventTypesResponseItemSupportedVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetWebhookSubscriptionsEventTypesResponseItemSupportedVersion), TypeInfoPropertyName = "GetWebhookSubscriptionsEventTypesResponseItemSupportedVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostWebhookSubscriptionsRequestVersion?), TypeInfoPropertyName = "NullablePostWebhookSubscriptionsRequestVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PatchWebhookSubscriptionsByIdRequestVersion?), TypeInfoPropertyName = "NullablePatchWebhookSubscriptionsByIdRequestVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostWebhookSubscriptionsResponseVersion?), TypeInfoPropertyName = "NullablePostWebhookSubscriptionsResponseVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetWebhookSubscriptionsResponseItemVersion?), TypeInfoPropertyName = "NullableGetWebhookSubscriptionsResponseItemVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetWebhookSubscriptionsByIdResponseVersion?), TypeInfoPropertyName = "NullableGetWebhookSubscriptionsByIdResponseVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PatchWebhookSubscriptionsByIdResponseVersion?), TypeInfoPropertyName = "NullablePatchWebhookSubscriptionsByIdResponseVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetWebhookSubscriptionsEventTypesResponseItemSupportedVersion?), TypeInfoPropertyName = "NullableGetWebhookSubscriptionsEventTypesResponseItemSupportedVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.GetWebhookSubscriptionsResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.GetWebhookSubscriptionsEventTypesResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.GetWebhookSubscriptionsEventTypesResponseItemSupportedVersion>))]
    internal sealed partial class WebhookSubscriptionsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WebhookSubscriptionsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static WebhookSubscriptionsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private WebhookSubscriptionsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.Dictionary<string, string>, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<string, bool?>());
            options.Converters.Add(new global::Composio.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Composio.JsonConverters.OneOfJsonConverter<object, string, global::System.Collections.Generic.Dictionary<string, string>>());
            options.Converters.Add(new global::Composio.JsonConverters.OneOfJsonConverter<object, string, global::System.Collections.Generic.Dictionary<string, string>>());
            options.Converters.Add(new global::Composio.JsonConverters.OneOfJsonConverter<object, string, global::System.Collections.Generic.Dictionary<string, string>>());
            options.Converters.Add(new global::Composio.JsonConverters.OneOfJsonConverter<object, string, global::System.Collections.Generic.Dictionary<string, string>>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<string, bool?, double?>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>());
            options.Converters.Add(new global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Composio.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Composio.PostWebhookSubscriptionsRequestVersion)

                    || typeToConvert == typeof(global::Composio.PostWebhookSubscriptionsRequestVersion?)

                    || typeToConvert == typeof(global::Composio.PatchWebhookSubscriptionsByIdRequestVersion)

                    || typeToConvert == typeof(global::Composio.PatchWebhookSubscriptionsByIdRequestVersion?)

                    || typeToConvert == typeof(global::Composio.PostWebhookSubscriptionsResponseVersion)

                    || typeToConvert == typeof(global::Composio.PostWebhookSubscriptionsResponseVersion?)

                    || typeToConvert == typeof(global::Composio.GetWebhookSubscriptionsResponseItemVersion)

                    || typeToConvert == typeof(global::Composio.GetWebhookSubscriptionsResponseItemVersion?)

                    || typeToConvert == typeof(global::Composio.GetWebhookSubscriptionsByIdResponseVersion)

                    || typeToConvert == typeof(global::Composio.GetWebhookSubscriptionsByIdResponseVersion?)

                    || typeToConvert == typeof(global::Composio.PatchWebhookSubscriptionsByIdResponseVersion)

                    || typeToConvert == typeof(global::Composio.PatchWebhookSubscriptionsByIdResponseVersion?)

                    || typeToConvert == typeof(global::Composio.GetWebhookSubscriptionsEventTypesResponseItemSupportedVersion)

                    || typeToConvert == typeof(global::Composio.GetWebhookSubscriptionsEventTypesResponseItemSupportedVersion?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Composio.PostWebhookSubscriptionsRequestVersion))
                {
                    return new global::Composio.JsonConverters.PostWebhookSubscriptionsRequestVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.PostWebhookSubscriptionsRequestVersion?))
                {
                    return new global::Composio.JsonConverters.PostWebhookSubscriptionsRequestVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.PatchWebhookSubscriptionsByIdRequestVersion))
                {
                    return new global::Composio.JsonConverters.PatchWebhookSubscriptionsByIdRequestVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.PatchWebhookSubscriptionsByIdRequestVersion?))
                {
                    return new global::Composio.JsonConverters.PatchWebhookSubscriptionsByIdRequestVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.PostWebhookSubscriptionsResponseVersion))
                {
                    return new global::Composio.JsonConverters.PostWebhookSubscriptionsResponseVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.PostWebhookSubscriptionsResponseVersion?))
                {
                    return new global::Composio.JsonConverters.PostWebhookSubscriptionsResponseVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.GetWebhookSubscriptionsResponseItemVersion))
                {
                    return new global::Composio.JsonConverters.GetWebhookSubscriptionsResponseItemVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.GetWebhookSubscriptionsResponseItemVersion?))
                {
                    return new global::Composio.JsonConverters.GetWebhookSubscriptionsResponseItemVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.GetWebhookSubscriptionsByIdResponseVersion))
                {
                    return new global::Composio.JsonConverters.GetWebhookSubscriptionsByIdResponseVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.GetWebhookSubscriptionsByIdResponseVersion?))
                {
                    return new global::Composio.JsonConverters.GetWebhookSubscriptionsByIdResponseVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.PatchWebhookSubscriptionsByIdResponseVersion))
                {
                    return new global::Composio.JsonConverters.PatchWebhookSubscriptionsByIdResponseVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.PatchWebhookSubscriptionsByIdResponseVersion?))
                {
                    return new global::Composio.JsonConverters.PatchWebhookSubscriptionsByIdResponseVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.GetWebhookSubscriptionsEventTypesResponseItemSupportedVersion))
                {
                    return new global::Composio.JsonConverters.GetWebhookSubscriptionsEventTypesResponseItemSupportedVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.GetWebhookSubscriptionsEventTypesResponseItemSupportedVersion?))
                {
                    return new global::Composio.JsonConverters.GetWebhookSubscriptionsEventTypesResponseItemSupportedVersionNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new WebhookSubscriptionsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}