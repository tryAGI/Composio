
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.OneOf<global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant1, global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2, global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant3>>), TypeInfoPropertyName = "PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant3_3e7b1732ce8298c1")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant1, global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2, global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant3>), TypeInfoPropertyName = "PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant3_b1795d7896aec69f")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant1, global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2, global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant3>?), TypeInfoPropertyName = "PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant3_87ddc77a128f0e8d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.OneOf<global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant1, global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2, global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant3>>), TypeInfoPropertyName = "PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant3_7a4cbab879def31a")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>), TypeInfoPropertyName = "DictionaryStringObject_System_Collections_Generic_Dictionary_string_object")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.ErrorError1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object?>), TypeInfoPropertyName = "DictionaryStringObject_System_Collections_Generic_Dictionary_string_object_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.DeprecatedToolkitInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostCustomToolkitsUpsertRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostCustomToolkitsUpsertRequestToolkitConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigLogoFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigLogoFileMimeType), TypeInfoPropertyName = "PostCustomToolkitsUpsertRequestToolkitConfigLogoFileMimeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant1Mode), TypeInfoPropertyName = "PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant1Mode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2Mode), TypeInfoPropertyName = "PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2Mode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2ApiKeyField))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant3Mode), TypeInfoPropertyName = "PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant3Mode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostCustomToolkitsSyncRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolkitsMultiRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolkitsMultiRequestManagedBy), TypeInfoPropertyName = "PostToolkitsMultiRequestManagedBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolkitsMultiRequestSortBy), TypeInfoPropertyName = "PostToolkitsMultiRequestSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolkitsManagedBy), TypeInfoPropertyName = "GetToolkitsManagedBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolkitsType), TypeInfoPropertyName = "GetToolkitsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolkitsSortBy), TypeInfoPropertyName = "GetToolkitsSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolkitsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.GetToolkitsResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolkitsResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolkitsResponseItemType), TypeInfoPropertyName = "GetToolkitsResponseItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolkitsResponseItemMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.GetToolkitsResponseItemMetaCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolkitsResponseItemMetaCategorie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolkitsCategoriesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.GetToolkitsCategoriesResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolkitsCategoriesResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostCustomToolkitsUpsertResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostCustomToolkitsSyncResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolkitsBySlugResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolkitsBySlugResponseType), TypeInfoPropertyName = "GetToolkitsBySlugResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.GetToolkitsBySlugResponseComposioManagedAuthItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolkitsBySlugResponseComposioManagedAuthItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolkitsBySlugResponseComposioManagedAuthItemScopes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolkitsBySlugResponseComposioManagedAuthItemUserScopes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.GetToolkitsBySlugResponseAuthConfigDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolkitsBySlugResponseAuthConfigDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolkitsBySlugResponseAuthConfigDetailFields))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolkitsBySlugResponseAuthConfigDetailFieldsAuthConfigCreation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.GetToolkitsBySlugResponseAuthConfigDetailFieldsAuthConfigCreationRequiredItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolkitsBySlugResponseAuthConfigDetailFieldsAuthConfigCreationRequiredItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.GetToolkitsBySlugResponseAuthConfigDetailFieldsAuthConfigCreationOptionalItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolkitsBySlugResponseAuthConfigDetailFieldsAuthConfigCreationOptionalItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolkitsBySlugResponseAuthConfigDetailFieldsConnectedAccountInitiation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.GetToolkitsBySlugResponseAuthConfigDetailFieldsConnectedAccountInitiationRequiredItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolkitsBySlugResponseAuthConfigDetailFieldsConnectedAccountInitiationRequiredItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.GetToolkitsBySlugResponseAuthConfigDetailFieldsConnectedAccountInitiationOptionalItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolkitsBySlugResponseAuthConfigDetailFieldsConnectedAccountInitiationOptionalItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolkitsBySlugResponseAuthConfigDetailProxy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolkitsBySlugResponseAuthConfigDetailDeprecatedAuthProviderDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolkitsBySlugResponseMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.GetToolkitsBySlugResponseMetaCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolkitsBySlugResponseMetaCategorie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolkitsBySlugResponseDeprecated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, object?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolkitsMultiResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.PostToolkitsMultiResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolkitsMultiResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolkitsMultiResponseItemType), TypeInfoPropertyName = "PostToolkitsMultiResponseItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolkitsMultiResponseItemMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.PostToolkitsMultiResponseItemMetaCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolkitsMultiResponseItemMetaCategorie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolkitsChangelogResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.GetToolkitsChangelogResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolkitsChangelogResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.GetToolkitsChangelogResponseItemVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolkitsChangelogResponseItemVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigLogoFileMimeType?), TypeInfoPropertyName = "NullablePostCustomToolkitsUpsertRequestToolkitConfigLogoFileMimeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant1Mode?), TypeInfoPropertyName = "NullablePostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant1Mode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2Mode?), TypeInfoPropertyName = "NullablePostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2Mode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant3Mode?), TypeInfoPropertyName = "NullablePostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant3Mode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolkitsMultiRequestManagedBy?), TypeInfoPropertyName = "NullablePostToolkitsMultiRequestManagedBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolkitsMultiRequestSortBy?), TypeInfoPropertyName = "NullablePostToolkitsMultiRequestSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolkitsManagedBy?), TypeInfoPropertyName = "NullableGetToolkitsManagedBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolkitsType?), TypeInfoPropertyName = "NullableGetToolkitsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolkitsSortBy?), TypeInfoPropertyName = "NullableGetToolkitsSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolkitsResponseItemType?), TypeInfoPropertyName = "NullableGetToolkitsResponseItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolkitsBySlugResponseType?), TypeInfoPropertyName = "NullableGetToolkitsBySlugResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolkitsMultiResponseItemType?), TypeInfoPropertyName = "NullablePostToolkitsMultiResponseItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.GetToolkitsResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.GetToolkitsResponseItemMetaCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.GetToolkitsCategoriesResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.GetToolkitsBySlugResponseComposioManagedAuthItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.GetToolkitsBySlugResponseAuthConfigDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.GetToolkitsBySlugResponseAuthConfigDetailFieldsAuthConfigCreationRequiredItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.GetToolkitsBySlugResponseAuthConfigDetailFieldsAuthConfigCreationOptionalItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.GetToolkitsBySlugResponseAuthConfigDetailFieldsConnectedAccountInitiationRequiredItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.GetToolkitsBySlugResponseAuthConfigDetailFieldsConnectedAccountInitiationOptionalItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.GetToolkitsBySlugResponseMetaCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, object?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.PostToolkitsMultiResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.PostToolkitsMultiResponseItemMetaCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.GetToolkitsChangelogResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.GetToolkitsChangelogResponseItemVersion>))]
    internal sealed partial class ToolkitsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ToolkitsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ToolkitsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ToolkitsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant1, global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2, global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant3>());
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
                    typeToConvert == typeof(global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigLogoFileMimeType)

                    || typeToConvert == typeof(global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigLogoFileMimeType?)

                    || typeToConvert == typeof(global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant1Mode)

                    || typeToConvert == typeof(global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant1Mode?)

                    || typeToConvert == typeof(global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2Mode)

                    || typeToConvert == typeof(global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2Mode?)

                    || typeToConvert == typeof(global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant3Mode)

                    || typeToConvert == typeof(global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant3Mode?)

                    || typeToConvert == typeof(global::Composio.PostToolkitsMultiRequestManagedBy)

                    || typeToConvert == typeof(global::Composio.PostToolkitsMultiRequestManagedBy?)

                    || typeToConvert == typeof(global::Composio.PostToolkitsMultiRequestSortBy)

                    || typeToConvert == typeof(global::Composio.PostToolkitsMultiRequestSortBy?)

                    || typeToConvert == typeof(global::Composio.GetToolkitsManagedBy)

                    || typeToConvert == typeof(global::Composio.GetToolkitsManagedBy?)

                    || typeToConvert == typeof(global::Composio.GetToolkitsType)

                    || typeToConvert == typeof(global::Composio.GetToolkitsType?)

                    || typeToConvert == typeof(global::Composio.GetToolkitsSortBy)

                    || typeToConvert == typeof(global::Composio.GetToolkitsSortBy?)

                    || typeToConvert == typeof(global::Composio.GetToolkitsResponseItemType)

                    || typeToConvert == typeof(global::Composio.GetToolkitsResponseItemType?)

                    || typeToConvert == typeof(global::Composio.GetToolkitsBySlugResponseType)

                    || typeToConvert == typeof(global::Composio.GetToolkitsBySlugResponseType?)

                    || typeToConvert == typeof(global::Composio.PostToolkitsMultiResponseItemType)

                    || typeToConvert == typeof(global::Composio.PostToolkitsMultiResponseItemType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigLogoFileMimeType))
                {
                    return new global::Composio.JsonConverters.PostCustomToolkitsUpsertRequestToolkitConfigLogoFileMimeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigLogoFileMimeType?))
                {
                    return new global::Composio.JsonConverters.PostCustomToolkitsUpsertRequestToolkitConfigLogoFileMimeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant1Mode))
                {
                    return new global::Composio.JsonConverters.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant1ModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant1Mode?))
                {
                    return new global::Composio.JsonConverters.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant1ModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2Mode))
                {
                    return new global::Composio.JsonConverters.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2ModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2Mode?))
                {
                    return new global::Composio.JsonConverters.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2ModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant3Mode))
                {
                    return new global::Composio.JsonConverters.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant3ModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant3Mode?))
                {
                    return new global::Composio.JsonConverters.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant3ModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.PostToolkitsMultiRequestManagedBy))
                {
                    return new global::Composio.JsonConverters.PostToolkitsMultiRequestManagedByJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.PostToolkitsMultiRequestManagedBy?))
                {
                    return new global::Composio.JsonConverters.PostToolkitsMultiRequestManagedByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.PostToolkitsMultiRequestSortBy))
                {
                    return new global::Composio.JsonConverters.PostToolkitsMultiRequestSortByJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.PostToolkitsMultiRequestSortBy?))
                {
                    return new global::Composio.JsonConverters.PostToolkitsMultiRequestSortByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.GetToolkitsManagedBy))
                {
                    return new global::Composio.JsonConverters.GetToolkitsManagedByJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.GetToolkitsManagedBy?))
                {
                    return new global::Composio.JsonConverters.GetToolkitsManagedByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.GetToolkitsType))
                {
                    return new global::Composio.JsonConverters.GetToolkitsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.GetToolkitsType?))
                {
                    return new global::Composio.JsonConverters.GetToolkitsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.GetToolkitsSortBy))
                {
                    return new global::Composio.JsonConverters.GetToolkitsSortByJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.GetToolkitsSortBy?))
                {
                    return new global::Composio.JsonConverters.GetToolkitsSortByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.GetToolkitsResponseItemType))
                {
                    return new global::Composio.JsonConverters.GetToolkitsResponseItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.GetToolkitsResponseItemType?))
                {
                    return new global::Composio.JsonConverters.GetToolkitsResponseItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.GetToolkitsBySlugResponseType))
                {
                    return new global::Composio.JsonConverters.GetToolkitsBySlugResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.GetToolkitsBySlugResponseType?))
                {
                    return new global::Composio.JsonConverters.GetToolkitsBySlugResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.PostToolkitsMultiResponseItemType))
                {
                    return new global::Composio.JsonConverters.PostToolkitsMultiResponseItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.PostToolkitsMultiResponseItemType?))
                {
                    return new global::Composio.JsonConverters.PostToolkitsMultiResponseItemTypeNullableJsonConverter();
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
                    0 => new ToolkitsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}