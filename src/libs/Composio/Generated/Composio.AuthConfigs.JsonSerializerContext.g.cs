
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>), TypeInfoPropertyName = "DictionaryStringObject_System_Collections_Generic_Dictionary_string_object")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.ErrorError1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.ComposioManagedAuthConfigCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.ComposioManagedAuthConfigCreateType), TypeInfoPropertyName = "ComposioManagedAuthConfigCreateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.ComposioManagedAuthConfigCreateCredentials))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.AnyOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "AnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.ComposioManagedAuthConfigCreateToolAccessConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object?>), TypeInfoPropertyName = "DictionaryStringObject_System_Collections_Generic_Dictionary_string_object_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.CustomAuthConfigCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.CustomAuthConfigCreateType), TypeInfoPropertyName = "CustomAuthConfigCreateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.CustomAuthConfigCreateAuthScheme), TypeInfoPropertyName = "CustomAuthConfigCreateAuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.CustomAuthConfigCreateCredentials))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.CustomAuthConfigCreateProxyConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.CustomAuthConfigCreateToolAccessConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.CustomAuthConfigUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.CustomAuthConfigUpdateType), TypeInfoPropertyName = "CustomAuthConfigUpdateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.CustomAuthConfigUpdateCredentials))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.CustomAuthConfigUpdateProxyConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.CustomAuthConfigUpdateToolAccessConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.DefaultAuthConfigUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.DefaultAuthConfigUpdateType), TypeInfoPropertyName = "DefaultAuthConfigUpdateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.DefaultAuthConfigUpdateToolAccessConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostAuthConfigsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostAuthConfigsRequestToolkit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.AuthConfig), TypeInfoPropertyName = "AuthConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostAuthConfigsRequestAuthConfigDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostAuthConfigsRequestAuthConfigDiscriminatorType), TypeInfoPropertyName = "PostAuthConfigsRequestAuthConfigDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PatchAuthConfigsByNanoidRequest), TypeInfoPropertyName = "PatchAuthConfigsByNanoidRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PatchAuthConfigsByNanoidRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PatchAuthConfigsByNanoidRequestDiscriminatorType), TypeInfoPropertyName = "PatchAuthConfigsByNanoidRequestDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.AnyOf<string, bool?>), TypeInfoPropertyName = "AnyOfStringBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PatchAuthConfigsByNanoidByStatusStatus), TypeInfoPropertyName = "PatchAuthConfigsByNanoidByStatusStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostAuthConfigsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostAuthConfigsResponseToolkit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostAuthConfigsResponseAuthConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetAuthConfigsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.GetAuthConfigsResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetAuthConfigsResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetAuthConfigsResponseItemType), TypeInfoPropertyName = "GetAuthConfigsResponseItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetAuthConfigsResponseItemToolkit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetAuthConfigsResponseItemAuthScheme), TypeInfoPropertyName = "GetAuthConfigsResponseItemAuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetAuthConfigsResponseItemProxyConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetAuthConfigsResponseItemStatus), TypeInfoPropertyName = "GetAuthConfigsResponseItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.GetAuthConfigsResponseItemExpectedInputField>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetAuthConfigsResponseItemExpectedInputField))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetAuthConfigsResponseItemToolAccessConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetAuthConfigsByNanoidResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetAuthConfigsByNanoidResponseType), TypeInfoPropertyName = "GetAuthConfigsByNanoidResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetAuthConfigsByNanoidResponseToolkit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetAuthConfigsByNanoidResponseAuthScheme), TypeInfoPropertyName = "GetAuthConfigsByNanoidResponseAuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetAuthConfigsByNanoidResponseProxyConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetAuthConfigsByNanoidResponseStatus), TypeInfoPropertyName = "GetAuthConfigsByNanoidResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.GetAuthConfigsByNanoidResponseExpectedInputField>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetAuthConfigsByNanoidResponseExpectedInputField))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetAuthConfigsByNanoidResponseToolAccessConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PatchAuthConfigsByNanoidResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.DeleteAuthConfigsByNanoidResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PatchAuthConfigsByNanoidByStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.ComposioManagedAuthConfigCreateType?), TypeInfoPropertyName = "NullableComposioManagedAuthConfigCreateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.AnyOf<string, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableAnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.CustomAuthConfigCreateType?), TypeInfoPropertyName = "NullableCustomAuthConfigCreateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.CustomAuthConfigCreateAuthScheme?), TypeInfoPropertyName = "NullableCustomAuthConfigCreateAuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.CustomAuthConfigUpdateType?), TypeInfoPropertyName = "NullableCustomAuthConfigUpdateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.DefaultAuthConfigUpdateType?), TypeInfoPropertyName = "NullableDefaultAuthConfigUpdateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.AuthConfig?), TypeInfoPropertyName = "NullableAuthConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostAuthConfigsRequestAuthConfigDiscriminatorType?), TypeInfoPropertyName = "NullablePostAuthConfigsRequestAuthConfigDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PatchAuthConfigsByNanoidRequest?), TypeInfoPropertyName = "NullablePatchAuthConfigsByNanoidRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PatchAuthConfigsByNanoidRequestDiscriminatorType?), TypeInfoPropertyName = "NullablePatchAuthConfigsByNanoidRequestDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.AnyOf<string, bool?>?), TypeInfoPropertyName = "NullableAnyOfStringBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PatchAuthConfigsByNanoidByStatusStatus?), TypeInfoPropertyName = "NullablePatchAuthConfigsByNanoidByStatusStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetAuthConfigsResponseItemType?), TypeInfoPropertyName = "NullableGetAuthConfigsResponseItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetAuthConfigsResponseItemAuthScheme?), TypeInfoPropertyName = "NullableGetAuthConfigsResponseItemAuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetAuthConfigsResponseItemStatus?), TypeInfoPropertyName = "NullableGetAuthConfigsResponseItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetAuthConfigsByNanoidResponseType?), TypeInfoPropertyName = "NullableGetAuthConfigsByNanoidResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetAuthConfigsByNanoidResponseAuthScheme?), TypeInfoPropertyName = "NullableGetAuthConfigsByNanoidResponseAuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetAuthConfigsByNanoidResponseStatus?), TypeInfoPropertyName = "NullableGetAuthConfigsByNanoidResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.AnyOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.GetAuthConfigsResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.GetAuthConfigsResponseItemExpectedInputField>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.GetAuthConfigsByNanoidResponseExpectedInputField>))]
    internal sealed partial class AuthConfigsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AuthConfigsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AuthConfigsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AuthConfigsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Composio.JsonConverters.AuthConfigJsonConverter());
            options.Converters.Add(new global::Composio.JsonConverters.PatchAuthConfigsByNanoidRequestJsonConverter());
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
                    typeToConvert == typeof(global::Composio.ComposioManagedAuthConfigCreateType)

                    || typeToConvert == typeof(global::Composio.ComposioManagedAuthConfigCreateType?)

                    || typeToConvert == typeof(global::Composio.CustomAuthConfigCreateType)

                    || typeToConvert == typeof(global::Composio.CustomAuthConfigCreateType?)

                    || typeToConvert == typeof(global::Composio.CustomAuthConfigCreateAuthScheme)

                    || typeToConvert == typeof(global::Composio.CustomAuthConfigCreateAuthScheme?)

                    || typeToConvert == typeof(global::Composio.CustomAuthConfigUpdateType)

                    || typeToConvert == typeof(global::Composio.CustomAuthConfigUpdateType?)

                    || typeToConvert == typeof(global::Composio.DefaultAuthConfigUpdateType)

                    || typeToConvert == typeof(global::Composio.DefaultAuthConfigUpdateType?)

                    || typeToConvert == typeof(global::Composio.PostAuthConfigsRequestAuthConfigDiscriminatorType)

                    || typeToConvert == typeof(global::Composio.PostAuthConfigsRequestAuthConfigDiscriminatorType?)

                    || typeToConvert == typeof(global::Composio.PatchAuthConfigsByNanoidRequestDiscriminatorType)

                    || typeToConvert == typeof(global::Composio.PatchAuthConfigsByNanoidRequestDiscriminatorType?)

                    || typeToConvert == typeof(global::Composio.PatchAuthConfigsByNanoidByStatusStatus)

                    || typeToConvert == typeof(global::Composio.PatchAuthConfigsByNanoidByStatusStatus?)

                    || typeToConvert == typeof(global::Composio.GetAuthConfigsResponseItemType)

                    || typeToConvert == typeof(global::Composio.GetAuthConfigsResponseItemType?)

                    || typeToConvert == typeof(global::Composio.GetAuthConfigsResponseItemAuthScheme)

                    || typeToConvert == typeof(global::Composio.GetAuthConfigsResponseItemAuthScheme?)

                    || typeToConvert == typeof(global::Composio.GetAuthConfigsResponseItemStatus)

                    || typeToConvert == typeof(global::Composio.GetAuthConfigsResponseItemStatus?)

                    || typeToConvert == typeof(global::Composio.GetAuthConfigsByNanoidResponseType)

                    || typeToConvert == typeof(global::Composio.GetAuthConfigsByNanoidResponseType?)

                    || typeToConvert == typeof(global::Composio.GetAuthConfigsByNanoidResponseAuthScheme)

                    || typeToConvert == typeof(global::Composio.GetAuthConfigsByNanoidResponseAuthScheme?)

                    || typeToConvert == typeof(global::Composio.GetAuthConfigsByNanoidResponseStatus)

                    || typeToConvert == typeof(global::Composio.GetAuthConfigsByNanoidResponseStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Composio.ComposioManagedAuthConfigCreateType))
                {
                    return new global::Composio.JsonConverters.ComposioManagedAuthConfigCreateTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.ComposioManagedAuthConfigCreateType?))
                {
                    return new global::Composio.JsonConverters.ComposioManagedAuthConfigCreateTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.CustomAuthConfigCreateType))
                {
                    return new global::Composio.JsonConverters.CustomAuthConfigCreateTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.CustomAuthConfigCreateType?))
                {
                    return new global::Composio.JsonConverters.CustomAuthConfigCreateTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.CustomAuthConfigCreateAuthScheme))
                {
                    return new global::Composio.JsonConverters.CustomAuthConfigCreateAuthSchemeJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.CustomAuthConfigCreateAuthScheme?))
                {
                    return new global::Composio.JsonConverters.CustomAuthConfigCreateAuthSchemeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.CustomAuthConfigUpdateType))
                {
                    return new global::Composio.JsonConverters.CustomAuthConfigUpdateTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.CustomAuthConfigUpdateType?))
                {
                    return new global::Composio.JsonConverters.CustomAuthConfigUpdateTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.DefaultAuthConfigUpdateType))
                {
                    return new global::Composio.JsonConverters.DefaultAuthConfigUpdateTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.DefaultAuthConfigUpdateType?))
                {
                    return new global::Composio.JsonConverters.DefaultAuthConfigUpdateTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.PostAuthConfigsRequestAuthConfigDiscriminatorType))
                {
                    return new global::Composio.JsonConverters.PostAuthConfigsRequestAuthConfigDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.PostAuthConfigsRequestAuthConfigDiscriminatorType?))
                {
                    return new global::Composio.JsonConverters.PostAuthConfigsRequestAuthConfigDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.PatchAuthConfigsByNanoidRequestDiscriminatorType))
                {
                    return new global::Composio.JsonConverters.PatchAuthConfigsByNanoidRequestDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.PatchAuthConfigsByNanoidRequestDiscriminatorType?))
                {
                    return new global::Composio.JsonConverters.PatchAuthConfigsByNanoidRequestDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.PatchAuthConfigsByNanoidByStatusStatus))
                {
                    return new global::Composio.JsonConverters.PatchAuthConfigsByNanoidByStatusStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.PatchAuthConfigsByNanoidByStatusStatus?))
                {
                    return new global::Composio.JsonConverters.PatchAuthConfigsByNanoidByStatusStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.GetAuthConfigsResponseItemType))
                {
                    return new global::Composio.JsonConverters.GetAuthConfigsResponseItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.GetAuthConfigsResponseItemType?))
                {
                    return new global::Composio.JsonConverters.GetAuthConfigsResponseItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.GetAuthConfigsResponseItemAuthScheme))
                {
                    return new global::Composio.JsonConverters.GetAuthConfigsResponseItemAuthSchemeJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.GetAuthConfigsResponseItemAuthScheme?))
                {
                    return new global::Composio.JsonConverters.GetAuthConfigsResponseItemAuthSchemeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.GetAuthConfigsResponseItemStatus))
                {
                    return new global::Composio.JsonConverters.GetAuthConfigsResponseItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.GetAuthConfigsResponseItemStatus?))
                {
                    return new global::Composio.JsonConverters.GetAuthConfigsResponseItemStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.GetAuthConfigsByNanoidResponseType))
                {
                    return new global::Composio.JsonConverters.GetAuthConfigsByNanoidResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.GetAuthConfigsByNanoidResponseType?))
                {
                    return new global::Composio.JsonConverters.GetAuthConfigsByNanoidResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.GetAuthConfigsByNanoidResponseAuthScheme))
                {
                    return new global::Composio.JsonConverters.GetAuthConfigsByNanoidResponseAuthSchemeJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.GetAuthConfigsByNanoidResponseAuthScheme?))
                {
                    return new global::Composio.JsonConverters.GetAuthConfigsByNanoidResponseAuthSchemeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.GetAuthConfigsByNanoidResponseStatus))
                {
                    return new global::Composio.JsonConverters.GetAuthConfigsByNanoidResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.GetAuthConfigsByNanoidResponseStatus?))
                {
                    return new global::Composio.JsonConverters.GetAuthConfigsByNanoidResponseStatusNullableJsonConverter();
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
                    0 => new AuthConfigsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}