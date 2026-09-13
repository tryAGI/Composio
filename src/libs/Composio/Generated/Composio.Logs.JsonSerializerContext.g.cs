
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object?>), TypeInfoPropertyName = "DictionaryStringObject_System_Collections_Generic_Dictionary_string_object_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostInternalTriggerLogsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostInternalTriggerLogsRequestTime), TypeInfoPropertyName = "PostInternalTriggerLogsRequestTime2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostInternalTriggerLogsRequestStatus), TypeInfoPropertyName = "PostInternalTriggerLogsRequestStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.PostInternalTriggerLogsRequestSearchParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostInternalTriggerLogsRequestSearchParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostInternalActionExecutionLogsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.PostInternalActionExecutionLogsRequestSearchParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostInternalActionExecutionLogsRequestSearchParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostInternalTriggerLogsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.PostInternalTriggerLogsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostInternalTriggerLogsResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostInternalTriggerLogsResponseDataItemType), TypeInfoPropertyName = "PostInternalTriggerLogsResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostInternalTriggerLogsResponseDataItemMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostInternalTriggerLogsResponseDataItemMetaType), TypeInfoPropertyName = "PostInternalTriggerLogsResponseDataItemMetaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetInternalTriggerLogByIdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetInternalTriggerLogByIdResponseLog))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetInternalTriggerLogByIdResponseLogType), TypeInfoPropertyName = "GetInternalTriggerLogByIdResponseLogType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetInternalTriggerLogByIdResponseLogMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetInternalTriggerLogByIdResponseLogMetaType), TypeInfoPropertyName = "GetInternalTriggerLogByIdResponseLogMetaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostInternalActionExecutionLogsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.PostInternalActionExecutionLogsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostInternalActionExecutionLogsResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostInternalActionExecutionLogsResponseDataItemApp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostInternalActionExecutionLogsResponseDataItemStatus), TypeInfoPropertyName = "PostInternalActionExecutionLogsResponseDataItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostInternalActionExecutionLogsResponseDataItemMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetInternalActionExecutionFieldsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Composio.GetInternalActionExecutionFieldsResponseField>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.GetInternalActionExecutionFieldsResponseField>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetInternalActionExecutionFieldsResponseField))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetInternalActionExecutionLogByIdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetInternalActionExecutionLogByIdResponseStatus), TypeInfoPropertyName = "GetInternalActionExecutionLogByIdResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetInternalActionExecutionLogByIdResponseApp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetInternalActionExecutionLogByIdResponseConnection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.GetInternalActionExecutionLogByIdResponseStep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetInternalActionExecutionLogByIdResponseStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetInternalActionExecutionLogByIdResponseStepType), TypeInfoPropertyName = "GetInternalActionExecutionLogByIdResponseStepType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetInternalActionExecutionLogByIdResponseStepStatus), TypeInfoPropertyName = "GetInternalActionExecutionLogByIdResponseStepStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetInternalActionExecutionLogByIdResponseStepMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.GetInternalActionExecutionLogByIdResponseStepLog>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetInternalActionExecutionLogByIdResponseStepLog))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetInternalActionExecutionLogByIdResponseStepLogType), TypeInfoPropertyName = "GetInternalActionExecutionLogByIdResponseStepLogType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetInternalActionExecutionLogByIdResponseStepLogRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetInternalActionExecutionLogByIdResponseStepLogResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostInternalTriggerLogsRequestTime?), TypeInfoPropertyName = "NullablePostInternalTriggerLogsRequestTime2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostInternalTriggerLogsRequestStatus?), TypeInfoPropertyName = "NullablePostInternalTriggerLogsRequestStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostInternalTriggerLogsResponseDataItemType?), TypeInfoPropertyName = "NullablePostInternalTriggerLogsResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostInternalTriggerLogsResponseDataItemMetaType?), TypeInfoPropertyName = "NullablePostInternalTriggerLogsResponseDataItemMetaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetInternalTriggerLogByIdResponseLogType?), TypeInfoPropertyName = "NullableGetInternalTriggerLogByIdResponseLogType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetInternalTriggerLogByIdResponseLogMetaType?), TypeInfoPropertyName = "NullableGetInternalTriggerLogByIdResponseLogMetaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostInternalActionExecutionLogsResponseDataItemStatus?), TypeInfoPropertyName = "NullablePostInternalActionExecutionLogsResponseDataItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetInternalActionExecutionLogByIdResponseStatus?), TypeInfoPropertyName = "NullableGetInternalActionExecutionLogByIdResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetInternalActionExecutionLogByIdResponseStepType?), TypeInfoPropertyName = "NullableGetInternalActionExecutionLogByIdResponseStepType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetInternalActionExecutionLogByIdResponseStepStatus?), TypeInfoPropertyName = "NullableGetInternalActionExecutionLogByIdResponseStepStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetInternalActionExecutionLogByIdResponseStepLogType?), TypeInfoPropertyName = "NullableGetInternalActionExecutionLogByIdResponseStepLogType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.PostInternalTriggerLogsRequestSearchParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.PostInternalActionExecutionLogsRequestSearchParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.PostInternalTriggerLogsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.PostInternalActionExecutionLogsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Composio.GetInternalActionExecutionFieldsResponseField>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.GetInternalActionExecutionFieldsResponseField>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.GetInternalActionExecutionLogByIdResponseStep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.GetInternalActionExecutionLogByIdResponseStepLog>))]
    internal sealed partial class LogsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LogsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static LogsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private LogsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Composio.PostInternalTriggerLogsRequestTime)

                    || typeToConvert == typeof(global::Composio.PostInternalTriggerLogsRequestTime?)

                    || typeToConvert == typeof(global::Composio.PostInternalTriggerLogsRequestStatus)

                    || typeToConvert == typeof(global::Composio.PostInternalTriggerLogsRequestStatus?)

                    || typeToConvert == typeof(global::Composio.PostInternalTriggerLogsResponseDataItemType)

                    || typeToConvert == typeof(global::Composio.PostInternalTriggerLogsResponseDataItemType?)

                    || typeToConvert == typeof(global::Composio.PostInternalTriggerLogsResponseDataItemMetaType)

                    || typeToConvert == typeof(global::Composio.PostInternalTriggerLogsResponseDataItemMetaType?)

                    || typeToConvert == typeof(global::Composio.GetInternalTriggerLogByIdResponseLogType)

                    || typeToConvert == typeof(global::Composio.GetInternalTriggerLogByIdResponseLogType?)

                    || typeToConvert == typeof(global::Composio.GetInternalTriggerLogByIdResponseLogMetaType)

                    || typeToConvert == typeof(global::Composio.GetInternalTriggerLogByIdResponseLogMetaType?)

                    || typeToConvert == typeof(global::Composio.PostInternalActionExecutionLogsResponseDataItemStatus)

                    || typeToConvert == typeof(global::Composio.PostInternalActionExecutionLogsResponseDataItemStatus?)

                    || typeToConvert == typeof(global::Composio.GetInternalActionExecutionLogByIdResponseStatus)

                    || typeToConvert == typeof(global::Composio.GetInternalActionExecutionLogByIdResponseStatus?)

                    || typeToConvert == typeof(global::Composio.GetInternalActionExecutionLogByIdResponseStepType)

                    || typeToConvert == typeof(global::Composio.GetInternalActionExecutionLogByIdResponseStepType?)

                    || typeToConvert == typeof(global::Composio.GetInternalActionExecutionLogByIdResponseStepStatus)

                    || typeToConvert == typeof(global::Composio.GetInternalActionExecutionLogByIdResponseStepStatus?)

                    || typeToConvert == typeof(global::Composio.GetInternalActionExecutionLogByIdResponseStepLogType)

                    || typeToConvert == typeof(global::Composio.GetInternalActionExecutionLogByIdResponseStepLogType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Composio.PostInternalTriggerLogsRequestTime))
                {
                    return new global::Composio.JsonConverters.PostInternalTriggerLogsRequestTimeJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.PostInternalTriggerLogsRequestTime?))
                {
                    return new global::Composio.JsonConverters.PostInternalTriggerLogsRequestTimeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.PostInternalTriggerLogsRequestStatus))
                {
                    return new global::Composio.JsonConverters.PostInternalTriggerLogsRequestStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.PostInternalTriggerLogsRequestStatus?))
                {
                    return new global::Composio.JsonConverters.PostInternalTriggerLogsRequestStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.PostInternalTriggerLogsResponseDataItemType))
                {
                    return new global::Composio.JsonConverters.PostInternalTriggerLogsResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.PostInternalTriggerLogsResponseDataItemType?))
                {
                    return new global::Composio.JsonConverters.PostInternalTriggerLogsResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.PostInternalTriggerLogsResponseDataItemMetaType))
                {
                    return new global::Composio.JsonConverters.PostInternalTriggerLogsResponseDataItemMetaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.PostInternalTriggerLogsResponseDataItemMetaType?))
                {
                    return new global::Composio.JsonConverters.PostInternalTriggerLogsResponseDataItemMetaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.GetInternalTriggerLogByIdResponseLogType))
                {
                    return new global::Composio.JsonConverters.GetInternalTriggerLogByIdResponseLogTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.GetInternalTriggerLogByIdResponseLogType?))
                {
                    return new global::Composio.JsonConverters.GetInternalTriggerLogByIdResponseLogTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.GetInternalTriggerLogByIdResponseLogMetaType))
                {
                    return new global::Composio.JsonConverters.GetInternalTriggerLogByIdResponseLogMetaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.GetInternalTriggerLogByIdResponseLogMetaType?))
                {
                    return new global::Composio.JsonConverters.GetInternalTriggerLogByIdResponseLogMetaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.PostInternalActionExecutionLogsResponseDataItemStatus))
                {
                    return new global::Composio.JsonConverters.PostInternalActionExecutionLogsResponseDataItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.PostInternalActionExecutionLogsResponseDataItemStatus?))
                {
                    return new global::Composio.JsonConverters.PostInternalActionExecutionLogsResponseDataItemStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.GetInternalActionExecutionLogByIdResponseStatus))
                {
                    return new global::Composio.JsonConverters.GetInternalActionExecutionLogByIdResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.GetInternalActionExecutionLogByIdResponseStatus?))
                {
                    return new global::Composio.JsonConverters.GetInternalActionExecutionLogByIdResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.GetInternalActionExecutionLogByIdResponseStepType))
                {
                    return new global::Composio.JsonConverters.GetInternalActionExecutionLogByIdResponseStepTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.GetInternalActionExecutionLogByIdResponseStepType?))
                {
                    return new global::Composio.JsonConverters.GetInternalActionExecutionLogByIdResponseStepTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.GetInternalActionExecutionLogByIdResponseStepStatus))
                {
                    return new global::Composio.JsonConverters.GetInternalActionExecutionLogByIdResponseStepStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.GetInternalActionExecutionLogByIdResponseStepStatus?))
                {
                    return new global::Composio.JsonConverters.GetInternalActionExecutionLogByIdResponseStepStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.GetInternalActionExecutionLogByIdResponseStepLogType))
                {
                    return new global::Composio.JsonConverters.GetInternalActionExecutionLogByIdResponseStepLogTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Composio.GetInternalActionExecutionLogByIdResponseStepLogType?))
                {
                    return new global::Composio.JsonConverters.GetInternalActionExecutionLogByIdResponseStepLogTypeNullableJsonConverter();
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
                    0 => new LogsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}