
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
            typeof(global::Composio.JsonConverters.PatchConnectedAccountBodyConnectionStateAuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PatchConnectedAccountBodyConnectionStateAuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostAuthConfigsRequestAuthConfigVariant1TypeJsonConverter),

            typeof(global::Composio.JsonConverters.PostAuthConfigsRequestAuthConfigVariant1TypeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostAuthConfigsRequestAuthConfigVariant2TypeJsonConverter),

            typeof(global::Composio.JsonConverters.PostAuthConfigsRequestAuthConfigVariant2TypeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostAuthConfigsRequestAuthConfigVariant2AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostAuthConfigsRequestAuthConfigVariant2AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PatchAuthConfigsByNanoidRequestVariant1TypeJsonConverter),

            typeof(global::Composio.JsonConverters.PatchAuthConfigsByNanoidRequestVariant1TypeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PatchAuthConfigsByNanoidRequestVariant2TypeJsonConverter),

            typeof(global::Composio.JsonConverters.PatchAuthConfigsByNanoidRequestVariant2TypeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostCliCreateSessionRequestScopeJsonConverter),

            typeof(global::Composio.JsonConverters.PostCliCreateSessionRequestScopeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostCliCodactFailuresRequestFailureTypeJsonConverter),

            typeof(global::Composio.JsonConverters.PostCliCodactFailuresRequestFailureTypeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant1AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant1AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant1ValVariant1StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant1ValVariant1StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant1ValVariant2StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant1ValVariant2StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant1ValVariant3StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant1ValVariant3StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant1ValVariant4StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant1ValVariant4StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant1ValVariant5StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant1ValVariant5StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant1ValVariant6StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant1ValVariant6StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant2AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant2AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant2ValVariant1StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant2ValVariant1StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant2ValVariant2StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant2ValVariant2StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant2ValVariant3StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant2ValVariant3StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant2ValVariant4StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant2ValVariant4StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant2ValVariant5StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant2ValVariant5StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant2ValVariant6StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant2ValVariant6StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant3AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant3AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant3ValVariant1StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant3ValVariant1StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant3ValVariant2StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant3ValVariant2StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant3ValVariant3StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant3ValVariant3StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant3ValVariant4StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant3ValVariant4StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant4AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant4AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant4ValVariant1StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant4ValVariant1StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant4ValVariant2StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant4ValVariant2StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant4ValVariant3StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant4ValVariant3StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant4ValVariant4StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant4ValVariant4StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant5AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant5AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant5ValVariant1StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant5ValVariant1StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant5ValVariant2StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant5ValVariant2StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant5ValVariant3StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant5ValVariant3StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant5ValVariant4StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant5ValVariant4StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant6AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant6AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant6ValVariant1StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant6ValVariant1StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant6ValVariant2StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant6ValVariant2StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant6ValVariant3StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant6ValVariant3StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant6ValVariant4StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant6ValVariant4StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant7AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant7AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant7ValVariant1StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant7ValVariant1StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant7ValVariant2StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant7ValVariant2StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant7ValVariant3StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant7ValVariant3StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant7ValVariant4StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant7ValVariant4StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant7ValVariant5StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant7ValVariant5StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant7ValVariant6StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant7ValVariant6StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant8AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant8AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant8ValVariant1StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant8ValVariant1StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant8ValVariant2StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant8ValVariant2StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant8ValVariant3StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant8ValVariant3StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant8ValVariant4StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant8ValVariant4StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant8ValVariant5StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant8ValVariant5StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant8ValVariant6StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant8ValVariant6StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant9AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant9AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant9ValVariant1StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant9ValVariant1StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant9ValVariant2StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant9ValVariant2StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant9ValVariant3StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant9ValVariant3StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant9ValVariant4StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant9ValVariant4StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant9ValVariant5StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant9ValVariant5StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant9ValVariant6StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant9ValVariant6StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant10AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant10AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant10ValVariant1StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant10ValVariant1StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant10ValVariant2StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant10ValVariant2StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant10ValVariant3StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant10ValVariant3StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant10ValVariant4StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant10ValVariant4StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant10ValVariant5StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant10ValVariant5StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant10ValVariant6StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant10ValVariant6StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant11AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant11AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant11ValVariant1StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant11ValVariant1StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant11ValVariant2StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant11ValVariant2StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant11ValVariant3StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant11ValVariant3StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant11ValVariant4StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant11ValVariant4StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant12AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant12AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant12ValVariant1StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant12ValVariant1StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant12ValVariant2StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant12ValVariant2StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant12ValVariant3StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant12ValVariant3StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant12ValVariant4StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant12ValVariant4StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant12ValVariant5StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant12ValVariant5StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant12ValVariant6StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant12ValVariant6StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant13AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant13AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant13ValVariant1StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant13ValVariant1StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant13ValVariant2StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant13ValVariant2StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant13ValVariant3StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant13ValVariant3StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant13ValVariant4StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant13ValVariant4StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant13ValVariant5StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant13ValVariant5StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant13ValVariant6StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant13ValVariant6StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant14AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant14AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant14ValVariant1StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant14ValVariant1StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant14ValVariant2StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant14ValVariant2StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant14ValVariant3StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant14ValVariant3StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant14ValVariant4StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant14ValVariant4StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant14ValVariant5StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant14ValVariant5StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant14ValVariant6StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant14ValVariant6StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostInternalTriggerLogsRequestTimeJsonConverter),

            typeof(global::Composio.JsonConverters.PostInternalTriggerLogsRequestTimeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostInternalTriggerLogsRequestStatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostInternalTriggerLogsRequestStatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PatchOrgProjectConfigRequestLogVisibilitySettingJsonConverter),

            typeof(global::Composio.JsonConverters.PatchOrgProjectConfigRequestLogVisibilitySettingNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostOrgOwnerProjectNewRequestConfigLogVisibilitySettingJsonConverter),

            typeof(global::Composio.JsonConverters.PostOrgOwnerProjectNewRequestConfigLogVisibilitySettingNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostWebhookSubscriptionsRequestVersionJsonConverter),

            typeof(global::Composio.JsonConverters.PostWebhookSubscriptionsRequestVersionNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PatchWebhookSubscriptionsByIdRequestVersionJsonConverter),

            typeof(global::Composio.JsonConverters.PatchWebhookSubscriptionsByIdRequestVersionNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolkitsMultiRequestManagedByJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolkitsMultiRequestManagedByNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolkitsMultiRequestSortByJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolkitsMultiRequestSortByNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolsExecuteByToolSlugRequestCustomAuthParamsParameterInJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolsExecuteByToolSlugRequestCustomAuthParamsParameterInNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant1AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant1AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant2AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant2AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant3AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant3AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant4AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant4AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant5AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant5AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant6AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant6AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant7AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant7AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant8AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant8AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant9AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant9AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant10AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant10AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant11AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant11AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolsExecuteProxyRequestMethodJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolsExecuteProxyRequestMethodNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolsExecuteProxyRequestParameterTypeJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolsExecuteProxyRequestParameterTypeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolsExecuteProxyRequestCustomConnectionDataVariant1AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolsExecuteProxyRequestCustomConnectionDataVariant1AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolsExecuteProxyRequestCustomConnectionDataVariant2AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolsExecuteProxyRequestCustomConnectionDataVariant2AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolsExecuteProxyRequestCustomConnectionDataVariant3AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolsExecuteProxyRequestCustomConnectionDataVariant3AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolsExecuteProxyRequestCustomConnectionDataVariant4AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolsExecuteProxyRequestCustomConnectionDataVariant4AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolsExecuteProxyRequestCustomConnectionDataVariant5AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolsExecuteProxyRequestCustomConnectionDataVariant5AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolsExecuteProxyRequestCustomConnectionDataVariant6AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolsExecuteProxyRequestCustomConnectionDataVariant6AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolsExecuteProxyRequestCustomConnectionDataVariant7AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolsExecuteProxyRequestCustomConnectionDataVariant7AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolsExecuteProxyRequestCustomConnectionDataVariant8AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolsExecuteProxyRequestCustomConnectionDataVariant8AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolsExecuteProxyRequestCustomConnectionDataVariant9AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolsExecuteProxyRequestCustomConnectionDataVariant9AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolsExecuteProxyRequestCustomConnectionDataVariant10AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolsExecuteProxyRequestCustomConnectionDataVariant10AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolsExecuteProxyRequestCustomConnectionDataVariant11AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolsExecuteProxyRequestCustomConnectionDataVariant11AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PatchTriggerInstancesManageByTriggerIdRequestStatusJsonConverter),

            typeof(global::Composio.JsonConverters.PatchTriggerInstancesManageByTriggerIdRequestStatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolRouterSessionRequestToolsVariant3TagJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolRouterSessionRequestToolsVariant3TagNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolRouterSessionRequestToolsVariant3TagsEnableItemJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolRouterSessionRequestToolsVariant3TagsEnableItemNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolRouterSessionRequestToolsVariant3TagsDisableItemJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolRouterSessionRequestToolsVariant3TagsDisableItemNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolRouterSessionRequestTagJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolRouterSessionRequestTagNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolRouterSessionRequestTagsEnableItemJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolRouterSessionRequestTagsEnableItemNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolRouterSessionRequestTagsDisableItemJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolRouterSessionRequestTagsDisableItemNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolRouterSessionBySessionIdExecuteMetaRequestSlugJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolRouterSessionBySessionIdExecuteMetaRequestSlugNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolRouterSessionBySessionIdProxyExecuteRequestMethodJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolRouterSessionBySessionIdProxyExecuteRequestMethodNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolRouterSessionBySessionIdProxyExecuteRequestParameterTypeJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolRouterSessionBySessionIdProxyExecuteRequestParameterTypeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant1AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant1AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant2AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant2AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant3AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant3AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant4AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant4AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant5AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant5AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant6AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant6AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant7AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant7AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant8AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant8AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant9AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant9AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant10AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant10AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant11AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant11AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PatchAuthConfigsByNanoidByStatusStatusJsonConverter),

            typeof(global::Composio.JsonConverters.PatchAuthConfigsByNanoidByStatusStatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsStatuseJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsStatuseNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsOrderByJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsOrderByNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsOrderDirectionJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsOrderDirectionNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetToolkitsManagedByJsonConverter),

            typeof(global::Composio.JsonConverters.GetToolkitsManagedByNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetToolkitsSortByJsonConverter),

            typeof(global::Composio.JsonConverters.GetToolkitsSortByNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetToolsImportantJsonConverter),

            typeof(global::Composio.JsonConverters.GetToolsImportantNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetMcpServersOrderByJsonConverter),

            typeof(global::Composio.JsonConverters.GetMcpServersOrderByNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetMcpServersOrderDirectionJsonConverter),

            typeof(global::Composio.JsonConverters.GetMcpServersOrderDirectionNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetMcpAppByAppKeyOrderByJsonConverter),

            typeof(global::Composio.JsonConverters.GetMcpAppByAppKeyOrderByNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetMcpAppByAppKeyOrderDirectionJsonConverter),

            typeof(global::Composio.JsonConverters.GetMcpAppByAppKeyOrderDirectionNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetMcpServersByServerIdInstancesOrderByJsonConverter),

            typeof(global::Composio.JsonConverters.GetMcpServersByServerIdInstancesOrderByNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetMcpServersByServerIdInstancesOrderDirectionJsonConverter),

            typeof(global::Composio.JsonConverters.GetMcpServersByServerIdInstancesOrderDirectionNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetMigrationGetNanoidTypeJsonConverter),

            typeof(global::Composio.JsonConverters.GetMigrationGetNanoidTypeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetAuthSessionInfoResponseProjectWebhookVersionJsonConverter),

            typeof(global::Composio.JsonConverters.GetAuthSessionInfoResponseProjectWebhookVersionNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetAuthConfigsResponseItemTypeJsonConverter),

            typeof(global::Composio.JsonConverters.GetAuthConfigsResponseItemTypeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetAuthConfigsResponseItemAuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.GetAuthConfigsResponseItemAuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetAuthConfigsResponseItemStatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetAuthConfigsResponseItemStatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetAuthConfigsByNanoidResponseTypeJsonConverter),

            typeof(global::Composio.JsonConverters.GetAuthConfigsByNanoidResponseTypeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetAuthConfigsByNanoidResponseAuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.GetAuthConfigsByNanoidResponseAuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetAuthConfigsByNanoidResponseStatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetAuthConfigsByNanoidResponseStatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostCliCreateSessionResponseStatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostCliCreateSessionResponseStatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostCliCreateSessionResponseScopeJsonConverter),

            typeof(global::Composio.JsonConverters.PostCliCreateSessionResponseScopeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetCliGetSessionResponseStatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetCliGetSessionResponseStatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetCliGetSessionResponseScopeJsonConverter),

            typeof(global::Composio.JsonConverters.GetCliGetSessionResponseScopeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemAuthConfigAuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemAuthConfigAuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant1AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant1AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant1ValVariant1StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant1ValVariant1StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant1ValVariant2StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant1ValVariant2StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant1ValVariant3StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant1ValVariant3StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant1ValVariant4StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant1ValVariant4StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant1ValVariant5StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant1ValVariant5StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant1ValVariant6StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant1ValVariant6StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant2AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant2AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant2ValVariant1StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant2ValVariant1StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant2ValVariant2StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant2ValVariant2StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant2ValVariant3StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant2ValVariant3StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant2ValVariant4StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant2ValVariant4StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant2ValVariant5StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant2ValVariant5StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant2ValVariant6StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant2ValVariant6StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant3AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant3AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant3ValVariant1StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant3ValVariant1StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant3ValVariant2StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant3ValVariant2StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant3ValVariant3StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant3ValVariant3StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant3ValVariant4StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant3ValVariant4StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant4AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant4AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant4ValVariant1StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant4ValVariant1StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant4ValVariant2StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant4ValVariant2StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant4ValVariant3StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant4ValVariant3StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant4ValVariant4StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant4ValVariant4StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant5AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant5AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant5ValVariant1StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant5ValVariant1StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant5ValVariant2StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant5ValVariant2StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant5ValVariant3StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant5ValVariant3StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant5ValVariant4StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant5ValVariant4StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant6AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant6AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant6ValVariant1StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant6ValVariant1StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant6ValVariant2StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant6ValVariant2StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant6ValVariant3StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant6ValVariant3StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant6ValVariant4StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant6ValVariant4StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant7AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant7AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant7ValVariant1StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant7ValVariant1StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant7ValVariant2StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant7ValVariant2StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant7ValVariant3StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant7ValVariant3StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant7ValVariant4StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant7ValVariant4StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant7ValVariant5StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant7ValVariant5StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant7ValVariant6StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant7ValVariant6StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant8AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant8AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant8ValVariant1StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant8ValVariant1StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant8ValVariant2StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant8ValVariant2StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant8ValVariant3StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant8ValVariant3StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant8ValVariant4StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant8ValVariant4StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant8ValVariant5StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant8ValVariant5StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant8ValVariant6StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant8ValVariant6StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant9AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant9AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant9ValVariant1StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant9ValVariant1StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant9ValVariant2StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant9ValVariant2StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant9ValVariant3StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant9ValVariant3StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant9ValVariant4StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant9ValVariant4StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant9ValVariant5StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant9ValVariant5StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant9ValVariant6StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant9ValVariant6StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant10AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant10AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant10ValVariant1StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant10ValVariant1StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant10ValVariant2StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant10ValVariant2StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant10ValVariant3StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant10ValVariant3StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant10ValVariant4StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant10ValVariant4StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant10ValVariant5StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant10ValVariant5StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant10ValVariant6StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant10ValVariant6StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant11AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant11AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant11ValVariant1StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant11ValVariant1StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant11ValVariant2StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant11ValVariant2StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant11ValVariant3StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant11ValVariant3StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant11ValVariant4StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant11ValVariant4StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant12AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant12AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant12ValVariant1StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant12ValVariant1StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant12ValVariant2StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant12ValVariant2StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant12ValVariant3StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant12ValVariant3StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant12ValVariant4StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant12ValVariant4StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant12ValVariant5StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant12ValVariant5StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant12ValVariant6StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant12ValVariant6StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant13AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant13AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant13ValVariant1StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant13ValVariant1StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant13ValVariant2StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant13ValVariant2StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant13ValVariant3StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant13ValVariant3StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant13ValVariant4StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant13ValVariant4StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant13ValVariant5StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant13ValVariant5StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant13ValVariant6StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant13ValVariant6StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant14AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant14AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant14ValVariant1StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant14ValVariant1StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant14ValVariant2StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant14ValVariant2StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant14ValVariant3StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant14ValVariant3StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant14ValVariant4StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant14ValVariant4StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant14ValVariant5StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant14ValVariant5StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant14ValVariant6StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant14ValVariant6StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant1AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant1AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant1ValVariant1StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant1ValVariant1StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant1ValVariant2StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant1ValVariant2StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant1ValVariant3StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant1ValVariant3StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant1ValVariant4StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant1ValVariant4StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant1ValVariant5StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant1ValVariant5StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant1ValVariant6StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant1ValVariant6StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant2AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant2AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant2ValVariant1StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant2ValVariant1StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant2ValVariant2StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant2ValVariant2StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant2ValVariant3StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant2ValVariant3StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant2ValVariant4StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant2ValVariant4StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant2ValVariant5StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant2ValVariant5StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant2ValVariant6StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant2ValVariant6StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant3AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant3AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant3ValVariant1StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant3ValVariant1StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant3ValVariant2StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant3ValVariant2StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant3ValVariant3StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant3ValVariant3StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant3ValVariant4StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant3ValVariant4StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant4AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant4AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant4ValVariant1StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant4ValVariant1StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant4ValVariant2StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant4ValVariant2StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant4ValVariant3StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant4ValVariant3StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant4ValVariant4StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant4ValVariant4StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant5AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant5AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant5ValVariant1StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant5ValVariant1StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant5ValVariant2StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant5ValVariant2StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant5ValVariant3StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant5ValVariant3StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant5ValVariant4StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant5ValVariant4StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant6AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant6AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant6ValVariant1StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant6ValVariant1StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant6ValVariant2StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant6ValVariant2StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant6ValVariant3StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant6ValVariant3StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant6ValVariant4StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant6ValVariant4StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant7AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant7AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant7ValVariant1StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant7ValVariant1StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant7ValVariant2StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant7ValVariant2StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant7ValVariant3StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant7ValVariant3StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant7ValVariant4StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant7ValVariant4StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant7ValVariant5StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant7ValVariant5StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant7ValVariant6StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant7ValVariant6StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant8AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant8AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant8ValVariant1StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant8ValVariant1StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant8ValVariant2StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant8ValVariant2StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant8ValVariant3StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant8ValVariant3StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant8ValVariant4StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant8ValVariant4StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant8ValVariant5StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant8ValVariant5StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant8ValVariant6StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant8ValVariant6StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant9AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant9AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant9ValVariant1StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant9ValVariant1StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant9ValVariant2StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant9ValVariant2StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant9ValVariant3StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant9ValVariant3StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant9ValVariant4StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant9ValVariant4StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant9ValVariant5StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant9ValVariant5StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant9ValVariant6StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant9ValVariant6StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant10AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant10AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant10ValVariant1StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant10ValVariant1StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant10ValVariant2StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant10ValVariant2StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant10ValVariant3StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant10ValVariant3StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant10ValVariant4StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant10ValVariant4StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant10ValVariant5StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant10ValVariant5StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant10ValVariant6StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant10ValVariant6StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant11AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant11AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant11ValVariant1StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant11ValVariant1StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant11ValVariant2StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant11ValVariant2StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant11ValVariant3StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant11ValVariant3StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant11ValVariant4StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant11ValVariant4StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant12AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant12AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant12ValVariant1StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant12ValVariant1StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant12ValVariant2StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant12ValVariant2StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant12ValVariant3StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant12ValVariant3StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant12ValVariant4StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant12ValVariant4StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant12ValVariant5StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant12ValVariant5StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant12ValVariant6StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant12ValVariant6StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant13AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant13AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant13ValVariant1StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant13ValVariant1StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant13ValVariant2StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant13ValVariant2StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant13ValVariant3StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant13ValVariant3StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant13ValVariant4StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant13ValVariant4StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant13ValVariant5StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant13ValVariant5StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant13ValVariant6StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant13ValVariant6StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant14AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant14AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant14ValVariant1StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant14ValVariant1StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant14ValVariant2StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant14ValVariant2StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant14ValVariant3StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant14ValVariant3StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant14ValVariant4StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant14ValVariant4StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant14ValVariant5StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant14ValVariant5StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant14ValVariant6StatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant14ValVariant6StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseStatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseStatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseAuthConfigAuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseAuthConfigAuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant1AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant1AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant1StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant1StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant2StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant2StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant3StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant3StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant4StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant4StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant5StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant5StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant6StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant6StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant2AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant2AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant1StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant1StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant2StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant2StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant3StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant3StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant4StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant4StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant5StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant5StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant6StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant6StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant3AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant3AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant1StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant1StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant2StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant2StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant3StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant3StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant4StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant4StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant4AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant4AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant4ValVariant1StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant4ValVariant1StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant4ValVariant2StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant4ValVariant2StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant4ValVariant3StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant4ValVariant3StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant4ValVariant4StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant4ValVariant4StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant5AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant5AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant1StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant1StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant2StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant2StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant3StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant3StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant4StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant4StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant6AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant6AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant1StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant1StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant2StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant2StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant3StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant3StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant4StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant4StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant7AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant7AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant1StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant1StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant2StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant2StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant3StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant3StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant4StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant4StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant5StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant5StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant6StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant6StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant8AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant8AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant1StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant1StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant2StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant2StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant3StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant3StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant4StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant4StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant5StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant5StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant6StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant6StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant9AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant9AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant1StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant1StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant2StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant2StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant3StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant3StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant4StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant4StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant5StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant5StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant6StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant6StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant10AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant10AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant1StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant1StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant2StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant2StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant3StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant3StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant4StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant4StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant5StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant5StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant6StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant6StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant11AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant11AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant1StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant1StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant2StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant2StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant3StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant3StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant4StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant4StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant12AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant12AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant1StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant1StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant2StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant2StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant3StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant3StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant4StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant4StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant5StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant5StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant6StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant6StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant13AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant13AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant1StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant1StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant2StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant2StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant3StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant3StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant4StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant4StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant5StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant5StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant6StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant6StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant14AuthSchemeJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant14AuthSchemeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant1StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant1StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant2StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant2StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant3StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant3StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant4StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant4StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant5StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant5StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant6StatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant6StatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsByNanoidRefreshResponseStatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostConnectedAccountsByNanoidRefreshResponseStatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostInternalTriggerLogsResponseDataItemTypeJsonConverter),

            typeof(global::Composio.JsonConverters.PostInternalTriggerLogsResponseDataItemTypeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostInternalTriggerLogsResponseDataItemMetaTypeJsonConverter),

            typeof(global::Composio.JsonConverters.PostInternalTriggerLogsResponseDataItemMetaTypeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetInternalTriggerLogByIdResponseLogTypeJsonConverter),

            typeof(global::Composio.JsonConverters.GetInternalTriggerLogByIdResponseLogTypeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetInternalTriggerLogByIdResponseLogMetaTypeJsonConverter),

            typeof(global::Composio.JsonConverters.GetInternalTriggerLogByIdResponseLogMetaTypeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostInternalActionExecutionLogsResponseDataItemStatusJsonConverter),

            typeof(global::Composio.JsonConverters.PostInternalActionExecutionLogsResponseDataItemStatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetInternalActionExecutionLogByIdResponseStatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetInternalActionExecutionLogByIdResponseStatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetInternalActionExecutionLogByIdResponseStepTypeJsonConverter),

            typeof(global::Composio.JsonConverters.GetInternalActionExecutionLogByIdResponseStepTypeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetInternalActionExecutionLogByIdResponseStepStatusJsonConverter),

            typeof(global::Composio.JsonConverters.GetInternalActionExecutionLogByIdResponseStepStatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetInternalActionExecutionLogByIdResponseStepLogTypeJsonConverter),

            typeof(global::Composio.JsonConverters.GetInternalActionExecutionLogByIdResponseStepLogTypeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetOrgProjectConfigResponseLogVisibilitySettingJsonConverter),

            typeof(global::Composio.JsonConverters.GetOrgProjectConfigResponseLogVisibilitySettingNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PatchOrgProjectConfigResponseLogVisibilitySettingJsonConverter),

            typeof(global::Composio.JsonConverters.PatchOrgProjectConfigResponseLogVisibilitySettingNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetOrgOwnerProjectListResponseDataItemWebhookVersionJsonConverter),

            typeof(global::Composio.JsonConverters.GetOrgOwnerProjectListResponseDataItemWebhookVersionNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetOrgOwnerProjectByNanoIdResponseWebhookVersionJsonConverter),

            typeof(global::Composio.JsonConverters.GetOrgOwnerProjectByNanoIdResponseWebhookVersionNullableJsonConverter),

            typeof(global::Composio.JsonConverters.DeleteOrgOwnerProjectByNanoIdResponseStatusJsonConverter),

            typeof(global::Composio.JsonConverters.DeleteOrgOwnerProjectByNanoIdResponseStatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostOrgConsumerProjectResolveResponseProjectTypeJsonConverter),

            typeof(global::Composio.JsonConverters.PostOrgConsumerProjectResolveResponseProjectTypeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostWebhookSubscriptionsResponseVersionJsonConverter),

            typeof(global::Composio.JsonConverters.PostWebhookSubscriptionsResponseVersionNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetWebhookSubscriptionsResponseItemVersionJsonConverter),

            typeof(global::Composio.JsonConverters.GetWebhookSubscriptionsResponseItemVersionNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetWebhookSubscriptionsByIdResponseVersionJsonConverter),

            typeof(global::Composio.JsonConverters.GetWebhookSubscriptionsByIdResponseVersionNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PatchWebhookSubscriptionsByIdResponseVersionJsonConverter),

            typeof(global::Composio.JsonConverters.PatchWebhookSubscriptionsByIdResponseVersionNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetWebhookSubscriptionsEventTypesResponseItemSupportedVersionJsonConverter),

            typeof(global::Composio.JsonConverters.GetWebhookSubscriptionsEventTypesResponseItemSupportedVersionNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PatchTriggerInstancesManageByTriggerIdResponseStatusJsonConverter),

            typeof(global::Composio.JsonConverters.PatchTriggerInstancesManageByTriggerIdResponseStatusNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetTriggersTypesBySlugResponseTypeJsonConverter),

            typeof(global::Composio.JsonConverters.GetTriggersTypesBySlugResponseTypeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetTriggersTypesResponseItemTypeJsonConverter),

            typeof(global::Composio.JsonConverters.GetTriggersTypesResponseItemTypeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostFilesUploadRequestResponseTypeJsonConverter),

            typeof(global::Composio.JsonConverters.PostFilesUploadRequestResponseTypeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostFilesUploadRequestResponseMetadataStorageBackendJsonConverter),

            typeof(global::Composio.JsonConverters.PostFilesUploadRequestResponseMetadataStorageBackendNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolRouterSessionResponseMcpTypeJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolRouterSessionResponseMcpTypeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolRouterSessionResponseConfigToolsVariant3TagsEnabledItemJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolRouterSessionResponseConfigToolsVariant3TagsEnabledItemNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolRouterSessionResponseConfigToolsVariant3TagsDisabledItemJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolRouterSessionResponseConfigToolsVariant3TagsDisabledItemNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolRouterSessionResponseConfigTagsEnabledItemJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolRouterSessionResponseConfigTagsEnabledItemNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolRouterSessionResponseConfigTagsDisabledItemJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolRouterSessionResponseConfigTagsDisabledItemNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetToolRouterSessionBySessionIdResponseMcpTypeJsonConverter),

            typeof(global::Composio.JsonConverters.GetToolRouterSessionBySessionIdResponseMcpTypeNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItemJsonConverter),

            typeof(global::Composio.JsonConverters.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItemNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsDisabledItemJsonConverter),

            typeof(global::Composio.JsonConverters.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsDisabledItemNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetToolRouterSessionBySessionIdResponseConfigTagsEnabledItemJsonConverter),

            typeof(global::Composio.JsonConverters.GetToolRouterSessionBySessionIdResponseConfigTagsEnabledItemNullableJsonConverter),

            typeof(global::Composio.JsonConverters.GetToolRouterSessionBySessionIdResponseConfigTagsDisabledItemJsonConverter),

            typeof(global::Composio.JsonConverters.GetToolRouterSessionBySessionIdResponseConfigTagsDisabledItemNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccountSelectionJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccountSelectionNullableJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolRouterSessionBySessionIdSearchResponseToolSchemasSchemaRefToolJsonConverter),

            typeof(global::Composio.JsonConverters.PostToolRouterSessionBySessionIdSearchResponseToolSchemasSchemaRefToolNullableJsonConverter),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<string, global::Composio.ToolScopeRequirementsAllOfItem>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.PostAuthConfigsRequestAuthConfigVariant1, global::Composio.PostAuthConfigsRequestAuthConfigVariant2>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.PatchAuthConfigsByNanoidRequestVariant1, global::Composio.PatchAuthConfigsByNanoidRequestVariant2>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.PostConnectedAccountsRequestConnectionStateVariant1, global::Composio.PostConnectedAccountsRequestConnectionStateVariant2, global::Composio.PostConnectedAccountsRequestConnectionStateVariant3, global::Composio.PostConnectedAccountsRequestConnectionStateVariant4, global::Composio.PostConnectedAccountsRequestConnectionStateVariant5, global::Composio.PostConnectedAccountsRequestConnectionStateVariant6, global::Composio.PostConnectedAccountsRequestConnectionStateVariant7, global::Composio.PostConnectedAccountsRequestConnectionStateVariant8, global::Composio.PostConnectedAccountsRequestConnectionStateVariant9, global::Composio.PostConnectedAccountsRequestConnectionStateVariant10, global::Composio.PostConnectedAccountsRequestConnectionStateVariant11, global::Composio.PostConnectedAccountsRequestConnectionStateVariant12, global::Composio.PostConnectedAccountsRequestConnectionStateVariant13, global::Composio.PostConnectedAccountsRequestConnectionStateVariant14>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.PostConnectedAccountsRequestConnectionStateVariant1ValVariant1, global::Composio.PostConnectedAccountsRequestConnectionStateVariant1ValVariant2, global::Composio.PostConnectedAccountsRequestConnectionStateVariant1ValVariant3, global::Composio.PostConnectedAccountsRequestConnectionStateVariant1ValVariant4, global::Composio.PostConnectedAccountsRequestConnectionStateVariant1ValVariant5, global::Composio.PostConnectedAccountsRequestConnectionStateVariant1ValVariant6>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.PostConnectedAccountsRequestConnectionStateVariant2ValVariant1, global::Composio.PostConnectedAccountsRequestConnectionStateVariant2ValVariant2, global::Composio.PostConnectedAccountsRequestConnectionStateVariant2ValVariant3, global::Composio.PostConnectedAccountsRequestConnectionStateVariant2ValVariant4, global::Composio.PostConnectedAccountsRequestConnectionStateVariant2ValVariant5, global::Composio.PostConnectedAccountsRequestConnectionStateVariant2ValVariant6>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.PostConnectedAccountsRequestConnectionStateVariant3ValVariant1, global::Composio.PostConnectedAccountsRequestConnectionStateVariant3ValVariant2, global::Composio.PostConnectedAccountsRequestConnectionStateVariant3ValVariant3, global::Composio.PostConnectedAccountsRequestConnectionStateVariant3ValVariant4>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.PostConnectedAccountsRequestConnectionStateVariant4ValVariant1, global::Composio.PostConnectedAccountsRequestConnectionStateVariant4ValVariant2, global::Composio.PostConnectedAccountsRequestConnectionStateVariant4ValVariant3, global::Composio.PostConnectedAccountsRequestConnectionStateVariant4ValVariant4>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.PostConnectedAccountsRequestConnectionStateVariant5ValVariant1, global::Composio.PostConnectedAccountsRequestConnectionStateVariant5ValVariant2, global::Composio.PostConnectedAccountsRequestConnectionStateVariant5ValVariant3, global::Composio.PostConnectedAccountsRequestConnectionStateVariant5ValVariant4>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.PostConnectedAccountsRequestConnectionStateVariant6ValVariant1, global::Composio.PostConnectedAccountsRequestConnectionStateVariant6ValVariant2, global::Composio.PostConnectedAccountsRequestConnectionStateVariant6ValVariant3, global::Composio.PostConnectedAccountsRequestConnectionStateVariant6ValVariant4>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.PostConnectedAccountsRequestConnectionStateVariant7ValVariant1, global::Composio.PostConnectedAccountsRequestConnectionStateVariant7ValVariant2, global::Composio.PostConnectedAccountsRequestConnectionStateVariant7ValVariant3, global::Composio.PostConnectedAccountsRequestConnectionStateVariant7ValVariant4, global::Composio.PostConnectedAccountsRequestConnectionStateVariant7ValVariant5, global::Composio.PostConnectedAccountsRequestConnectionStateVariant7ValVariant6>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.PostConnectedAccountsRequestConnectionStateVariant8ValVariant1, global::Composio.PostConnectedAccountsRequestConnectionStateVariant8ValVariant2, global::Composio.PostConnectedAccountsRequestConnectionStateVariant8ValVariant3, global::Composio.PostConnectedAccountsRequestConnectionStateVariant8ValVariant4, global::Composio.PostConnectedAccountsRequestConnectionStateVariant8ValVariant5, global::Composio.PostConnectedAccountsRequestConnectionStateVariant8ValVariant6>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.PostConnectedAccountsRequestConnectionStateVariant9ValVariant1, global::Composio.PostConnectedAccountsRequestConnectionStateVariant9ValVariant2, global::Composio.PostConnectedAccountsRequestConnectionStateVariant9ValVariant3, global::Composio.PostConnectedAccountsRequestConnectionStateVariant9ValVariant4, global::Composio.PostConnectedAccountsRequestConnectionStateVariant9ValVariant5, global::Composio.PostConnectedAccountsRequestConnectionStateVariant9ValVariant6>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant1, global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant2, global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant3, global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant4, global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant5, global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant6>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.PostConnectedAccountsRequestConnectionStateVariant11ValVariant1, global::Composio.PostConnectedAccountsRequestConnectionStateVariant11ValVariant2, global::Composio.PostConnectedAccountsRequestConnectionStateVariant11ValVariant3, global::Composio.PostConnectedAccountsRequestConnectionStateVariant11ValVariant4>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.PostConnectedAccountsRequestConnectionStateVariant12ValVariant1, global::Composio.PostConnectedAccountsRequestConnectionStateVariant12ValVariant2, global::Composio.PostConnectedAccountsRequestConnectionStateVariant12ValVariant3, global::Composio.PostConnectedAccountsRequestConnectionStateVariant12ValVariant4, global::Composio.PostConnectedAccountsRequestConnectionStateVariant12ValVariant5, global::Composio.PostConnectedAccountsRequestConnectionStateVariant12ValVariant6>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.PostConnectedAccountsRequestConnectionStateVariant13ValVariant1, global::Composio.PostConnectedAccountsRequestConnectionStateVariant13ValVariant2, global::Composio.PostConnectedAccountsRequestConnectionStateVariant13ValVariant3, global::Composio.PostConnectedAccountsRequestConnectionStateVariant13ValVariant4, global::Composio.PostConnectedAccountsRequestConnectionStateVariant13ValVariant5, global::Composio.PostConnectedAccountsRequestConnectionStateVariant13ValVariant6>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.PostConnectedAccountsRequestConnectionStateVariant14ValVariant1, global::Composio.PostConnectedAccountsRequestConnectionStateVariant14ValVariant2, global::Composio.PostConnectedAccountsRequestConnectionStateVariant14ValVariant3, global::Composio.PostConnectedAccountsRequestConnectionStateVariant14ValVariant4, global::Composio.PostConnectedAccountsRequestConnectionStateVariant14ValVariant5, global::Composio.PostConnectedAccountsRequestConnectionStateVariant14ValVariant6>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<string, double?>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant1, global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant2, global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant3, global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant4, global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant5, global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant6, global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant7, global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant8, global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant9, global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant10, global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant11>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<global::Composio.PostToolsExecuteProxyRequestBinaryBodyVariant1, global::Composio.PostToolsExecuteProxyRequestBinaryBodyVariant2>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant1, global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant2, global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant3, global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant4, global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant5, global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant6, global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant7, global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant8, global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant9, global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant10, global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant11>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.Dictionary<string, string>, object>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<global::Composio.PostToolRouterSessionRequestToolkitsVariant1, global::Composio.PostToolRouterSessionRequestToolkitsVariant2>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<global::Composio.PostToolRouterSessionRequestToolsVariant1, global::Composio.PostToolRouterSessionRequestToolsVariant2, global::Composio.PostToolRouterSessionRequestToolsVariant3>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionRequestToolsVariant3Tag>, global::Composio.PostToolRouterSessionRequestToolsVariant3Tags>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionRequestTag>, global::Composio.PostToolRouterSessionRequestTags>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestBinaryBodyVariant1, global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestBinaryBodyVariant2>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant1, global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant2, global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant3, global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant4, global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant5, global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant6, global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant7, global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant8, global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant9, global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant10, global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant11>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<string, bool?>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<object, string, global::System.Collections.Generic.Dictionary<string, string>>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<object, string, global::System.Collections.Generic.Dictionary<string, string>>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<object, string, global::System.Collections.Generic.Dictionary<string, string>>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<object, string, global::System.Collections.Generic.Dictionary<string, string>>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.GetConnectedAccountsResponseItemStateVariant1, global::Composio.GetConnectedAccountsResponseItemStateVariant2, global::Composio.GetConnectedAccountsResponseItemStateVariant3, global::Composio.GetConnectedAccountsResponseItemStateVariant4, global::Composio.GetConnectedAccountsResponseItemStateVariant5, global::Composio.GetConnectedAccountsResponseItemStateVariant6, global::Composio.GetConnectedAccountsResponseItemStateVariant7, global::Composio.GetConnectedAccountsResponseItemStateVariant8, global::Composio.GetConnectedAccountsResponseItemStateVariant9, global::Composio.GetConnectedAccountsResponseItemStateVariant10, global::Composio.GetConnectedAccountsResponseItemStateVariant11, global::Composio.GetConnectedAccountsResponseItemStateVariant12, global::Composio.GetConnectedAccountsResponseItemStateVariant13, global::Composio.GetConnectedAccountsResponseItemStateVariant14>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.GetConnectedAccountsResponseItemStateVariant1ValVariant1, global::Composio.GetConnectedAccountsResponseItemStateVariant1ValVariant2, global::Composio.GetConnectedAccountsResponseItemStateVariant1ValVariant3, global::Composio.GetConnectedAccountsResponseItemStateVariant1ValVariant4, global::Composio.GetConnectedAccountsResponseItemStateVariant1ValVariant5, global::Composio.GetConnectedAccountsResponseItemStateVariant1ValVariant6>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant1, global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant2, global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant3, global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant4, global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant5, global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant6>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.GetConnectedAccountsResponseItemStateVariant3ValVariant1, global::Composio.GetConnectedAccountsResponseItemStateVariant3ValVariant2, global::Composio.GetConnectedAccountsResponseItemStateVariant3ValVariant3, global::Composio.GetConnectedAccountsResponseItemStateVariant3ValVariant4>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.GetConnectedAccountsResponseItemStateVariant4ValVariant1, global::Composio.GetConnectedAccountsResponseItemStateVariant4ValVariant2, global::Composio.GetConnectedAccountsResponseItemStateVariant4ValVariant3, global::Composio.GetConnectedAccountsResponseItemStateVariant4ValVariant4>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.GetConnectedAccountsResponseItemStateVariant5ValVariant1, global::Composio.GetConnectedAccountsResponseItemStateVariant5ValVariant2, global::Composio.GetConnectedAccountsResponseItemStateVariant5ValVariant3, global::Composio.GetConnectedAccountsResponseItemStateVariant5ValVariant4>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.GetConnectedAccountsResponseItemStateVariant6ValVariant1, global::Composio.GetConnectedAccountsResponseItemStateVariant6ValVariant2, global::Composio.GetConnectedAccountsResponseItemStateVariant6ValVariant3, global::Composio.GetConnectedAccountsResponseItemStateVariant6ValVariant4>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.GetConnectedAccountsResponseItemStateVariant7ValVariant1, global::Composio.GetConnectedAccountsResponseItemStateVariant7ValVariant2, global::Composio.GetConnectedAccountsResponseItemStateVariant7ValVariant3, global::Composio.GetConnectedAccountsResponseItemStateVariant7ValVariant4, global::Composio.GetConnectedAccountsResponseItemStateVariant7ValVariant5, global::Composio.GetConnectedAccountsResponseItemStateVariant7ValVariant6>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant1, global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant2, global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant3, global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant4, global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant5, global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant6>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant1, global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant2, global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant3, global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant4, global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant5, global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant6>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.GetConnectedAccountsResponseItemStateVariant10ValVariant1, global::Composio.GetConnectedAccountsResponseItemStateVariant10ValVariant2, global::Composio.GetConnectedAccountsResponseItemStateVariant10ValVariant3, global::Composio.GetConnectedAccountsResponseItemStateVariant10ValVariant4, global::Composio.GetConnectedAccountsResponseItemStateVariant10ValVariant5, global::Composio.GetConnectedAccountsResponseItemStateVariant10ValVariant6>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.GetConnectedAccountsResponseItemStateVariant11ValVariant1, global::Composio.GetConnectedAccountsResponseItemStateVariant11ValVariant2, global::Composio.GetConnectedAccountsResponseItemStateVariant11ValVariant3, global::Composio.GetConnectedAccountsResponseItemStateVariant11ValVariant4>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.GetConnectedAccountsResponseItemStateVariant12ValVariant1, global::Composio.GetConnectedAccountsResponseItemStateVariant12ValVariant2, global::Composio.GetConnectedAccountsResponseItemStateVariant12ValVariant3, global::Composio.GetConnectedAccountsResponseItemStateVariant12ValVariant4, global::Composio.GetConnectedAccountsResponseItemStateVariant12ValVariant5, global::Composio.GetConnectedAccountsResponseItemStateVariant12ValVariant6>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.GetConnectedAccountsResponseItemStateVariant13ValVariant1, global::Composio.GetConnectedAccountsResponseItemStateVariant13ValVariant2, global::Composio.GetConnectedAccountsResponseItemStateVariant13ValVariant3, global::Composio.GetConnectedAccountsResponseItemStateVariant13ValVariant4, global::Composio.GetConnectedAccountsResponseItemStateVariant13ValVariant5, global::Composio.GetConnectedAccountsResponseItemStateVariant13ValVariant6>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant1, global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant2, global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant3, global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant4, global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant5, global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant6>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.PostConnectedAccountsResponseConnectionDataVariant1, global::Composio.PostConnectedAccountsResponseConnectionDataVariant2, global::Composio.PostConnectedAccountsResponseConnectionDataVariant3, global::Composio.PostConnectedAccountsResponseConnectionDataVariant4, global::Composio.PostConnectedAccountsResponseConnectionDataVariant5, global::Composio.PostConnectedAccountsResponseConnectionDataVariant6, global::Composio.PostConnectedAccountsResponseConnectionDataVariant7, global::Composio.PostConnectedAccountsResponseConnectionDataVariant8, global::Composio.PostConnectedAccountsResponseConnectionDataVariant9, global::Composio.PostConnectedAccountsResponseConnectionDataVariant10, global::Composio.PostConnectedAccountsResponseConnectionDataVariant11, global::Composio.PostConnectedAccountsResponseConnectionDataVariant12, global::Composio.PostConnectedAccountsResponseConnectionDataVariant13, global::Composio.PostConnectedAccountsResponseConnectionDataVariant14>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant1, global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant2, global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant3, global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant4, global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant5, global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant6>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant1, global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant2, global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant3, global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant4, global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant5, global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant6>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.PostConnectedAccountsResponseConnectionDataVariant3ValVariant1, global::Composio.PostConnectedAccountsResponseConnectionDataVariant3ValVariant2, global::Composio.PostConnectedAccountsResponseConnectionDataVariant3ValVariant3, global::Composio.PostConnectedAccountsResponseConnectionDataVariant3ValVariant4>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.PostConnectedAccountsResponseConnectionDataVariant4ValVariant1, global::Composio.PostConnectedAccountsResponseConnectionDataVariant4ValVariant2, global::Composio.PostConnectedAccountsResponseConnectionDataVariant4ValVariant3, global::Composio.PostConnectedAccountsResponseConnectionDataVariant4ValVariant4>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.PostConnectedAccountsResponseConnectionDataVariant5ValVariant1, global::Composio.PostConnectedAccountsResponseConnectionDataVariant5ValVariant2, global::Composio.PostConnectedAccountsResponseConnectionDataVariant5ValVariant3, global::Composio.PostConnectedAccountsResponseConnectionDataVariant5ValVariant4>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.PostConnectedAccountsResponseConnectionDataVariant6ValVariant1, global::Composio.PostConnectedAccountsResponseConnectionDataVariant6ValVariant2, global::Composio.PostConnectedAccountsResponseConnectionDataVariant6ValVariant3, global::Composio.PostConnectedAccountsResponseConnectionDataVariant6ValVariant4>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant1, global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant2, global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant3, global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant4, global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant5, global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant6>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.PostConnectedAccountsResponseConnectionDataVariant8ValVariant1, global::Composio.PostConnectedAccountsResponseConnectionDataVariant8ValVariant2, global::Composio.PostConnectedAccountsResponseConnectionDataVariant8ValVariant3, global::Composio.PostConnectedAccountsResponseConnectionDataVariant8ValVariant4, global::Composio.PostConnectedAccountsResponseConnectionDataVariant8ValVariant5, global::Composio.PostConnectedAccountsResponseConnectionDataVariant8ValVariant6>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant1, global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant2, global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant3, global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant4, global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant5, global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant6>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.PostConnectedAccountsResponseConnectionDataVariant10ValVariant1, global::Composio.PostConnectedAccountsResponseConnectionDataVariant10ValVariant2, global::Composio.PostConnectedAccountsResponseConnectionDataVariant10ValVariant3, global::Composio.PostConnectedAccountsResponseConnectionDataVariant10ValVariant4, global::Composio.PostConnectedAccountsResponseConnectionDataVariant10ValVariant5, global::Composio.PostConnectedAccountsResponseConnectionDataVariant10ValVariant6>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.PostConnectedAccountsResponseConnectionDataVariant11ValVariant1, global::Composio.PostConnectedAccountsResponseConnectionDataVariant11ValVariant2, global::Composio.PostConnectedAccountsResponseConnectionDataVariant11ValVariant3, global::Composio.PostConnectedAccountsResponseConnectionDataVariant11ValVariant4>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.PostConnectedAccountsResponseConnectionDataVariant12ValVariant1, global::Composio.PostConnectedAccountsResponseConnectionDataVariant12ValVariant2, global::Composio.PostConnectedAccountsResponseConnectionDataVariant12ValVariant3, global::Composio.PostConnectedAccountsResponseConnectionDataVariant12ValVariant4, global::Composio.PostConnectedAccountsResponseConnectionDataVariant12ValVariant5, global::Composio.PostConnectedAccountsResponseConnectionDataVariant12ValVariant6>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.PostConnectedAccountsResponseConnectionDataVariant13ValVariant1, global::Composio.PostConnectedAccountsResponseConnectionDataVariant13ValVariant2, global::Composio.PostConnectedAccountsResponseConnectionDataVariant13ValVariant3, global::Composio.PostConnectedAccountsResponseConnectionDataVariant13ValVariant4, global::Composio.PostConnectedAccountsResponseConnectionDataVariant13ValVariant5, global::Composio.PostConnectedAccountsResponseConnectionDataVariant13ValVariant6>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.PostConnectedAccountsResponseConnectionDataVariant14ValVariant1, global::Composio.PostConnectedAccountsResponseConnectionDataVariant14ValVariant2, global::Composio.PostConnectedAccountsResponseConnectionDataVariant14ValVariant3, global::Composio.PostConnectedAccountsResponseConnectionDataVariant14ValVariant4, global::Composio.PostConnectedAccountsResponseConnectionDataVariant14ValVariant5, global::Composio.PostConnectedAccountsResponseConnectionDataVariant14ValVariant6>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.GetConnectedAccountsByNanoidResponseStateVariant1, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant3, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant4, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant5, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant7, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant9, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant10, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant11, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant12, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant13, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant14>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant1, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant2, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant3, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant4, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant5, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant6>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant1, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant2, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant3, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant4, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant5, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant6>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant1, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant2, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant3, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant4>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.GetConnectedAccountsByNanoidResponseStateVariant4ValVariant1, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant4ValVariant2, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant4ValVariant3, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant4ValVariant4>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant1, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant2, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant3, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant4>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant1, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant2, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant3, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant4>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant1, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant2, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant3, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant4, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant5, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant6>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant1, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant2, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant3, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant4, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant5, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant6>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant1, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant2, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant3, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant4, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant5, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant6>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant1, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant2, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant3, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant4, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant5, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant6>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant1, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant2, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant3, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant4>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant1, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant2, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant3, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant4, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant5, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant6>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant1, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant2, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant3, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant4, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant5, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant6>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant1, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant2, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant3, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant4, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant5, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant6>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<double?, string, object>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<global::Composio.PostToolRouterSessionResponseConfigToolkitsVariant1, global::Composio.PostToolRouterSessionResponseConfigToolkitsVariant2>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<global::Composio.PostToolRouterSessionResponseConfigToolsVariant1, global::Composio.PostToolRouterSessionResponseConfigToolsVariant2, global::Composio.PostToolRouterSessionResponseConfigToolsVariant3>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolkitsVariant1, global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolkitsVariant2>),

            typeof(global::Composio.JsonConverters.AnyOfJsonConverter<global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolsVariant1, global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolsVariant2, global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3>),

            typeof(global::Composio.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.ErrorError1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PatchConnectedAccountBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PatchConnectedAccountBodyConnection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PatchConnectedAccountBodyConnectionState))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PatchConnectedAccountBodyConnectionStateAuthScheme), TypeInfoPropertyName = "PatchConnectedAccountBodyConnectionStateAuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PatchConnectedAccountBodyConnectionStateVal))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.DeprecatedToolkitInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.Tool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.ToolToolkit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.ToolScopeRequirements))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.AnyOf<string, global::Composio.ToolScopeRequirementsAllOfItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.AnyOf<string, global::Composio.ToolScopeRequirementsAllOfItem>), TypeInfoPropertyName = "AnyOfStringToolScopeRequirementsAllOfItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.ToolScopeRequirementsAllOfItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.ToolDeprecated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.ToolDeprecatedToolkit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.ToolsPaginated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.ToolRouterToolkitsListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.ToolRouterToolkitsListResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.ToolRouterToolkitsListResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.ToolRouterToolkitsListResponseItemMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.ToolRouterToolkitsListResponseItemConnectedAccount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.ToolRouterToolkitsListResponseItemConnectedAccountAuthConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostAuthConfigsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostAuthConfigsRequestToolkit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.PostAuthConfigsRequestAuthConfigVariant1, global::Composio.PostAuthConfigsRequestAuthConfigVariant2>), TypeInfoPropertyName = "OneOfPostAuthConfigsRequestAuthConfigVariant1PostAuthConfigsRequestAuthConfigVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostAuthConfigsRequestAuthConfigVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostAuthConfigsRequestAuthConfigVariant1Type), TypeInfoPropertyName = "PostAuthConfigsRequestAuthConfigVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostAuthConfigsRequestAuthConfigVariant1Credentials))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.AnyOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "AnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostAuthConfigsRequestAuthConfigVariant1ToolAccessConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostAuthConfigsRequestAuthConfigVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostAuthConfigsRequestAuthConfigVariant2Type), TypeInfoPropertyName = "PostAuthConfigsRequestAuthConfigVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostAuthConfigsRequestAuthConfigVariant2AuthScheme), TypeInfoPropertyName = "PostAuthConfigsRequestAuthConfigVariant2AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostAuthConfigsRequestAuthConfigVariant2Credentials))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostAuthConfigsRequestAuthConfigVariant2ProxyConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostAuthConfigsRequestAuthConfigVariant2ToolAccessConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.PatchAuthConfigsByNanoidRequestVariant1, global::Composio.PatchAuthConfigsByNanoidRequestVariant2>), TypeInfoPropertyName = "OneOfPatchAuthConfigsByNanoidRequestVariant1PatchAuthConfigsByNanoidRequestVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PatchAuthConfigsByNanoidRequestVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PatchAuthConfigsByNanoidRequestVariant1Type), TypeInfoPropertyName = "PatchAuthConfigsByNanoidRequestVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PatchAuthConfigsByNanoidRequestVariant1Credentials))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PatchAuthConfigsByNanoidRequestVariant1ProxyConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PatchAuthConfigsByNanoidRequestVariant1ToolAccessConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PatchAuthConfigsByNanoidRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PatchAuthConfigsByNanoidRequestVariant2Type), TypeInfoPropertyName = "PatchAuthConfigsByNanoidRequestVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PatchAuthConfigsByNanoidRequestVariant2ToolAccessConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostCliCreateSessionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostCliCreateSessionRequestScope), TypeInfoPropertyName = "PostCliCreateSessionRequestScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostCliCodactFailuresRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostCliCodactFailuresRequestFailureType), TypeInfoPropertyName = "PostCliCodactFailuresRequestFailureType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostCliCodactFailuresRequestToolInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostCliCodactFailuresRequestToolInfoTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostCliRealtimeAuthRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestAuthConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.PostConnectedAccountsRequestConnectionStateVariant1, global::Composio.PostConnectedAccountsRequestConnectionStateVariant2, global::Composio.PostConnectedAccountsRequestConnectionStateVariant3, global::Composio.PostConnectedAccountsRequestConnectionStateVariant4, global::Composio.PostConnectedAccountsRequestConnectionStateVariant5, global::Composio.PostConnectedAccountsRequestConnectionStateVariant6, global::Composio.PostConnectedAccountsRequestConnectionStateVariant7, global::Composio.PostConnectedAccountsRequestConnectionStateVariant8, global::Composio.PostConnectedAccountsRequestConnectionStateVariant9, global::Composio.PostConnectedAccountsRequestConnectionStateVariant10, global::Composio.PostConnectedAccountsRequestConnectionStateVariant11, global::Composio.PostConnectedAccountsRequestConnectionStateVariant12, global::Composio.PostConnectedAccountsRequestConnectionStateVariant13, global::Composio.PostConnectedAccountsRequestConnectionStateVariant14>), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant14_a0f2a0091edf648e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant1AuthScheme), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant1AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.PostConnectedAccountsRequestConnectionStateVariant1ValVariant1, global::Composio.PostConnectedAccountsRequestConnectionStateVariant1ValVariant2, global::Composio.PostConnectedAccountsRequestConnectionStateVariant1ValVariant3, global::Composio.PostConnectedAccountsRequestConnectionStateVariant1ValVariant4, global::Composio.PostConnectedAccountsRequestConnectionStateVariant1ValVariant5, global::Composio.PostConnectedAccountsRequestConnectionStateVariant1ValVariant6>), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant1ValVariant6_18a802f7702a1d7c")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant1ValVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant1ValVariant1Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant1ValVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant1ValVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant1ValVariant2Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant1ValVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant1ValVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant1ValVariant3Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant1ValVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant1ValVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant1ValVariant4Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant1ValVariant4Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant1ValVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant1ValVariant5Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant1ValVariant5Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant1ValVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant1ValVariant6Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant1ValVariant6Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant2AuthScheme), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant2AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.PostConnectedAccountsRequestConnectionStateVariant2ValVariant1, global::Composio.PostConnectedAccountsRequestConnectionStateVariant2ValVariant2, global::Composio.PostConnectedAccountsRequestConnectionStateVariant2ValVariant3, global::Composio.PostConnectedAccountsRequestConnectionStateVariant2ValVariant4, global::Composio.PostConnectedAccountsRequestConnectionStateVariant2ValVariant5, global::Composio.PostConnectedAccountsRequestConnectionStateVariant2ValVariant6>), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant2ValVariant6_0fa0e56b79cedc4e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant2ValVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant2ValVariant1Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant2ValVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant2ValVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant2ValVariant2Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant2ValVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant2ValVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant2ValVariant3Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant2ValVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.AnyOf<double?, string, object>), TypeInfoPropertyName = "AnyOfDoubleStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.AnyOf<string, global::System.Collections.Generic.IList<string>, object>), TypeInfoPropertyName = "AnyOfStringIListStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant2ValVariant3AuthedUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant2ValVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant2ValVariant4Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant2ValVariant4Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant2ValVariant4AuthedUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant2ValVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant2ValVariant5Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant2ValVariant5Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant2ValVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant2ValVariant6Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant2ValVariant6Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant3AuthScheme), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant3AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.PostConnectedAccountsRequestConnectionStateVariant3ValVariant1, global::Composio.PostConnectedAccountsRequestConnectionStateVariant3ValVariant2, global::Composio.PostConnectedAccountsRequestConnectionStateVariant3ValVariant3, global::Composio.PostConnectedAccountsRequestConnectionStateVariant3ValVariant4>), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant3ValVariant4_c1e217f7e446898b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant3ValVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant3ValVariant1Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant3ValVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant3ValVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant3ValVariant2Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant3ValVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant3ValVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant3ValVariant3Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant3ValVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant3ValVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant3ValVariant4Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant3ValVariant4Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant4AuthScheme), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant4AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.PostConnectedAccountsRequestConnectionStateVariant4ValVariant1, global::Composio.PostConnectedAccountsRequestConnectionStateVariant4ValVariant2, global::Composio.PostConnectedAccountsRequestConnectionStateVariant4ValVariant3, global::Composio.PostConnectedAccountsRequestConnectionStateVariant4ValVariant4>), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant4ValVariant4_da85d04d1f0d3bdd")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant4ValVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant4ValVariant1Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant4ValVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant4ValVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant4ValVariant2Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant4ValVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant4ValVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant4ValVariant3Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant4ValVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant4ValVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant4ValVariant4Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant4ValVariant4Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant5AuthScheme), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant5AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.PostConnectedAccountsRequestConnectionStateVariant5ValVariant1, global::Composio.PostConnectedAccountsRequestConnectionStateVariant5ValVariant2, global::Composio.PostConnectedAccountsRequestConnectionStateVariant5ValVariant3, global::Composio.PostConnectedAccountsRequestConnectionStateVariant5ValVariant4>), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant5ValVariant4_0abdb850603729fc")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant5ValVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant5ValVariant1Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant5ValVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant5ValVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant5ValVariant2Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant5ValVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant5ValVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant5ValVariant3Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant5ValVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant5ValVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant5ValVariant4Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant5ValVariant4Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant6AuthScheme), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant6AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.PostConnectedAccountsRequestConnectionStateVariant6ValVariant1, global::Composio.PostConnectedAccountsRequestConnectionStateVariant6ValVariant2, global::Composio.PostConnectedAccountsRequestConnectionStateVariant6ValVariant3, global::Composio.PostConnectedAccountsRequestConnectionStateVariant6ValVariant4>), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant6ValVariant4_ee1244997b34c81c")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant6ValVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant6ValVariant1Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant6ValVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant6ValVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant6ValVariant2Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant6ValVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant6ValVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant6ValVariant3Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant6ValVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant6ValVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant6ValVariant4Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant6ValVariant4Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant7AuthScheme), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant7AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.PostConnectedAccountsRequestConnectionStateVariant7ValVariant1, global::Composio.PostConnectedAccountsRequestConnectionStateVariant7ValVariant2, global::Composio.PostConnectedAccountsRequestConnectionStateVariant7ValVariant3, global::Composio.PostConnectedAccountsRequestConnectionStateVariant7ValVariant4, global::Composio.PostConnectedAccountsRequestConnectionStateVariant7ValVariant5, global::Composio.PostConnectedAccountsRequestConnectionStateVariant7ValVariant6>), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant7ValVariant6_c018a1ad29e3347a")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant7ValVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant7ValVariant1Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant7ValVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant7ValVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant7ValVariant2Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant7ValVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant7ValVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant7ValVariant3Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant7ValVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant7ValVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant7ValVariant4Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant7ValVariant4Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant7ValVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant7ValVariant5Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant7ValVariant5Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant7ValVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant7ValVariant6Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant7ValVariant6Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant8AuthScheme), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant8AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.PostConnectedAccountsRequestConnectionStateVariant8ValVariant1, global::Composio.PostConnectedAccountsRequestConnectionStateVariant8ValVariant2, global::Composio.PostConnectedAccountsRequestConnectionStateVariant8ValVariant3, global::Composio.PostConnectedAccountsRequestConnectionStateVariant8ValVariant4, global::Composio.PostConnectedAccountsRequestConnectionStateVariant8ValVariant5, global::Composio.PostConnectedAccountsRequestConnectionStateVariant8ValVariant6>), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant8ValVariant6_bb78b9ee334769f1")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant8ValVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant8ValVariant1Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant8ValVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant8ValVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant8ValVariant2Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant8ValVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant8ValVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant8ValVariant3Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant8ValVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant8ValVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant8ValVariant4Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant8ValVariant4Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant8ValVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant8ValVariant5Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant8ValVariant5Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant8ValVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant8ValVariant6Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant8ValVariant6Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant9AuthScheme), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant9AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.PostConnectedAccountsRequestConnectionStateVariant9ValVariant1, global::Composio.PostConnectedAccountsRequestConnectionStateVariant9ValVariant2, global::Composio.PostConnectedAccountsRequestConnectionStateVariant9ValVariant3, global::Composio.PostConnectedAccountsRequestConnectionStateVariant9ValVariant4, global::Composio.PostConnectedAccountsRequestConnectionStateVariant9ValVariant5, global::Composio.PostConnectedAccountsRequestConnectionStateVariant9ValVariant6>), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant9ValVariant6_c0bde0ba74244fb9")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant9ValVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant9ValVariant1Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant9ValVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant9ValVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant9ValVariant2Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant9ValVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant9ValVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant9ValVariant3Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant9ValVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant9ValVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant9ValVariant4Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant9ValVariant4Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant9ValVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant9ValVariant5Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant9ValVariant5Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant9ValVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant9ValVariant6Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant9ValVariant6Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant10AuthScheme), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant10AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant1, global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant2, global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant3, global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant4, global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant5, global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant6>), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant10ValVariant6_782248b36592c9a9")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant1Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant10ValVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant2Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant10ValVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant3Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant10ValVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant4Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant10ValVariant4Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant5Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant10ValVariant5Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant6Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant10ValVariant6Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant11AuthScheme), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant11AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.PostConnectedAccountsRequestConnectionStateVariant11ValVariant1, global::Composio.PostConnectedAccountsRequestConnectionStateVariant11ValVariant2, global::Composio.PostConnectedAccountsRequestConnectionStateVariant11ValVariant3, global::Composio.PostConnectedAccountsRequestConnectionStateVariant11ValVariant4>), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant11ValVariant4_9e73b2aa9282f56c")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant11ValVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant11ValVariant1Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant11ValVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant11ValVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant11ValVariant2Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant11ValVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant11ValVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant11ValVariant3Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant11ValVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant11ValVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant11ValVariant4Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant11ValVariant4Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant12AuthScheme), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant12AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.PostConnectedAccountsRequestConnectionStateVariant12ValVariant1, global::Composio.PostConnectedAccountsRequestConnectionStateVariant12ValVariant2, global::Composio.PostConnectedAccountsRequestConnectionStateVariant12ValVariant3, global::Composio.PostConnectedAccountsRequestConnectionStateVariant12ValVariant4, global::Composio.PostConnectedAccountsRequestConnectionStateVariant12ValVariant5, global::Composio.PostConnectedAccountsRequestConnectionStateVariant12ValVariant6>), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant12ValVariant6_a9052e71772dac3b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant12ValVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant12ValVariant1Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant12ValVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant12ValVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant12ValVariant2Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant12ValVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant12ValVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant12ValVariant3Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant12ValVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant12ValVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant12ValVariant4Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant12ValVariant4Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant12ValVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant12ValVariant5Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant12ValVariant5Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant12ValVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant12ValVariant6Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant12ValVariant6Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant13AuthScheme), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant13AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.PostConnectedAccountsRequestConnectionStateVariant13ValVariant1, global::Composio.PostConnectedAccountsRequestConnectionStateVariant13ValVariant2, global::Composio.PostConnectedAccountsRequestConnectionStateVariant13ValVariant3, global::Composio.PostConnectedAccountsRequestConnectionStateVariant13ValVariant4, global::Composio.PostConnectedAccountsRequestConnectionStateVariant13ValVariant5, global::Composio.PostConnectedAccountsRequestConnectionStateVariant13ValVariant6>), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant13ValVariant6_c0af2686513dd634")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant13ValVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant13ValVariant1Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant13ValVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant13ValVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant13ValVariant2Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant13ValVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant13ValVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant13ValVariant3Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant13ValVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant13ValVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant13ValVariant4Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant13ValVariant4Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant13ValVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant13ValVariant5Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant13ValVariant5Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant13ValVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant13ValVariant6Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant13ValVariant6Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant14))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant14AuthScheme), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant14AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.PostConnectedAccountsRequestConnectionStateVariant14ValVariant1, global::Composio.PostConnectedAccountsRequestConnectionStateVariant14ValVariant2, global::Composio.PostConnectedAccountsRequestConnectionStateVariant14ValVariant3, global::Composio.PostConnectedAccountsRequestConnectionStateVariant14ValVariant4, global::Composio.PostConnectedAccountsRequestConnectionStateVariant14ValVariant5, global::Composio.PostConnectedAccountsRequestConnectionStateVariant14ValVariant6>), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant14ValVariant6_03e2dfaa173c7a15")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant14ValVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant14ValVariant1Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant14ValVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant14ValVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant14ValVariant2Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant14ValVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant14ValVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant14ValVariant3Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant14ValVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant14ValVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant14ValVariant4Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant14ValVariant4Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant14ValVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant14ValVariant5Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant14ValVariant5Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant14ValVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsRequestConnectionStateVariant14ValVariant6Status), TypeInfoPropertyName = "PostConnectedAccountsRequestConnectionStateVariant14ValVariant6Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PatchConnectedAccountsByNanoIdStatusRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsByNanoidRefreshRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsLinkRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostInternalTriggerLogsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostInternalTriggerLogsRequestTime), TypeInfoPropertyName = "PostInternalTriggerLogsRequestTime2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostInternalTriggerLogsRequestStatus), TypeInfoPropertyName = "PostInternalTriggerLogsRequestStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.PostInternalTriggerLogsRequestSearchParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostInternalTriggerLogsRequestSearchParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostInternalActionExecutionLogsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.PostInternalActionExecutionLogsRequestSearchParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostInternalActionExecutionLogsRequestSearchParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PatchOrgProjectConfigRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PatchOrgProjectConfigRequestLogVisibilitySetting), TypeInfoPropertyName = "PatchOrgProjectConfigRequestLogVisibilitySetting2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostOrgOwnerProjectNewRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostOrgOwnerProjectNewRequestConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostOrgOwnerProjectNewRequestConfigLogVisibilitySetting), TypeInfoPropertyName = "PostOrgOwnerProjectNewRequestConfigLogVisibilitySetting2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostWebhookSubscriptionsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostWebhookSubscriptionsRequestVersion), TypeInfoPropertyName = "PostWebhookSubscriptionsRequestVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PatchWebhookSubscriptionsByIdRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PatchWebhookSubscriptionsByIdRequestVersion), TypeInfoPropertyName = "PatchWebhookSubscriptionsByIdRequestVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolkitsMultiRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolkitsMultiRequestManagedBy), TypeInfoPropertyName = "PostToolkitsMultiRequestManagedBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolkitsMultiRequestSortBy), TypeInfoPropertyName = "PostToolkitsMultiRequestSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteByToolSlugRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteByToolSlugRequestCustomAuthParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.PostToolsExecuteByToolSlugRequestCustomAuthParamsParameter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteByToolSlugRequestCustomAuthParamsParameter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteByToolSlugRequestCustomAuthParamsParameterIn), TypeInfoPropertyName = "PostToolsExecuteByToolSlugRequestCustomAuthParamsParameterIn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.AnyOf<string, double?>), TypeInfoPropertyName = "AnyOfStringDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant1, global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant2, global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant3, global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant4, global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant5, global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant6, global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant7, global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant8, global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant9, global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant10, global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant11>), TypeInfoPropertyName = "PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant11_6cb6838b4ad2457c")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant1AuthScheme), TypeInfoPropertyName = "PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant1AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant1Val))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant1ValAuthedUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant2AuthScheme), TypeInfoPropertyName = "PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant2AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant2Val))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant3AuthScheme), TypeInfoPropertyName = "PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant3AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant3Val))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant4AuthScheme), TypeInfoPropertyName = "PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant4AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant4Val))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant5AuthScheme), TypeInfoPropertyName = "PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant5AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant5Val))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant6AuthScheme), TypeInfoPropertyName = "PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant6AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant6Val))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant7AuthScheme), TypeInfoPropertyName = "PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant7AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant7Val))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant8AuthScheme), TypeInfoPropertyName = "PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant8AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant8Val))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant9AuthScheme), TypeInfoPropertyName = "PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant9AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant9Val))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant10AuthScheme), TypeInfoPropertyName = "PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant10AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant10Val))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant11AuthScheme), TypeInfoPropertyName = "PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant11AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant11Val))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteByToolSlugInputRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteProxyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteProxyRequestMethod), TypeInfoPropertyName = "PostToolsExecuteProxyRequestMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.AnyOf<global::Composio.PostToolsExecuteProxyRequestBinaryBodyVariant1, global::Composio.PostToolsExecuteProxyRequestBinaryBodyVariant2>), TypeInfoPropertyName = "AnyOfPostToolsExecuteProxyRequestBinaryBodyVariant1PostToolsExecuteProxyRequestBinaryBodyVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteProxyRequestBinaryBodyVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteProxyRequestBinaryBodyVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.PostToolsExecuteProxyRequestParameter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteProxyRequestParameter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteProxyRequestParameterType), TypeInfoPropertyName = "PostToolsExecuteProxyRequestParameterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant1, global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant2, global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant3, global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant4, global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant5, global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant6, global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant7, global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant8, global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant9, global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant10, global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant11>), TypeInfoPropertyName = "PostToolsExecuteProxyRequestCustomConnectionDataVariant11_12c8129e39f8db1d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant1AuthScheme), TypeInfoPropertyName = "PostToolsExecuteProxyRequestCustomConnectionDataVariant1AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant1Val))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant1ValAuthedUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant2AuthScheme), TypeInfoPropertyName = "PostToolsExecuteProxyRequestCustomConnectionDataVariant2AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant2Val))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant3AuthScheme), TypeInfoPropertyName = "PostToolsExecuteProxyRequestCustomConnectionDataVariant3AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant3Val))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant4AuthScheme), TypeInfoPropertyName = "PostToolsExecuteProxyRequestCustomConnectionDataVariant4AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant4Val))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant5AuthScheme), TypeInfoPropertyName = "PostToolsExecuteProxyRequestCustomConnectionDataVariant5AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant5Val))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant6AuthScheme), TypeInfoPropertyName = "PostToolsExecuteProxyRequestCustomConnectionDataVariant6AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant6Val))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant7AuthScheme), TypeInfoPropertyName = "PostToolsExecuteProxyRequestCustomConnectionDataVariant7AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant7Val))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant8AuthScheme), TypeInfoPropertyName = "PostToolsExecuteProxyRequestCustomConnectionDataVariant8AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant8Val))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant9AuthScheme), TypeInfoPropertyName = "PostToolsExecuteProxyRequestCustomConnectionDataVariant9AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant9Val))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant10AuthScheme), TypeInfoPropertyName = "PostToolsExecuteProxyRequestCustomConnectionDataVariant10AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant10Val))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant11AuthScheme), TypeInfoPropertyName = "PostToolsExecuteProxyRequestCustomConnectionDataVariant11AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant11Val))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostTriggerInstancesBySlugUpsertRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.AnyOf<string, global::System.Collections.Generic.Dictionary<string, string>, object>), TypeInfoPropertyName = "AnyOfStringDictionaryStringStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PatchTriggerInstancesManageByTriggerIdRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PatchTriggerInstancesManageByTriggerIdRequestStatus), TypeInfoPropertyName = "PatchTriggerInstancesManageByTriggerIdRequestStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostMcpServersRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostMcpServersCustomRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostMcpServersGenerateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PatchMcpByIdRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostMcpServersByServerIdInstancesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostFilesUploadRequestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostLabsToolRouterSessionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostLabsToolRouterSessionRequestConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.PostLabsToolRouterSessionRequestConfigToolkit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostLabsToolRouterSessionRequestConfigToolkit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.AnyOf<global::Composio.PostToolRouterSessionRequestToolkitsVariant1, global::Composio.PostToolRouterSessionRequestToolkitsVariant2>), TypeInfoPropertyName = "AnyOfPostToolRouterSessionRequestToolkitsVariant1PostToolRouterSessionRequestToolkitsVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionRequestToolkitsVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionRequestToolkitsVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionRequestManageConnections))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.AnyOf<global::Composio.PostToolRouterSessionRequestToolsVariant1, global::Composio.PostToolRouterSessionRequestToolsVariant2, global::Composio.PostToolRouterSessionRequestToolsVariant3>), TypeInfoPropertyName = "PostToolRouterSessionRequestToolsVariant3_8aa3914230f4a32f")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionRequestToolsVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionRequestToolsVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionRequestToolsVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.AnyOf<global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionRequestToolsVariant3Tag>, global::Composio.PostToolRouterSessionRequestToolsVariant3Tags>), TypeInfoPropertyName = "AnyOfIListPostToolRouterSessionRequestToolsVariant3TagPostToolRouterSessionRequestToolsVariant3Tags2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionRequestToolsVariant3Tag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionRequestToolsVariant3Tag), TypeInfoPropertyName = "PostToolRouterSessionRequestToolsVariant3Tag2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionRequestToolsVariant3Tags))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionRequestToolsVariant3TagsEnableItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionRequestToolsVariant3TagsEnableItem), TypeInfoPropertyName = "PostToolRouterSessionRequestToolsVariant3TagsEnableItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionRequestToolsVariant3TagsDisableItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionRequestToolsVariant3TagsDisableItem), TypeInfoPropertyName = "PostToolRouterSessionRequestToolsVariant3TagsDisableItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.AnyOf<global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionRequestTag>, global::Composio.PostToolRouterSessionRequestTags>), TypeInfoPropertyName = "AnyOfIListPostToolRouterSessionRequestTagPostToolRouterSessionRequestTags2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionRequestTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionRequestTag), TypeInfoPropertyName = "PostToolRouterSessionRequestTag2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionRequestTags))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionRequestTagsEnableItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionRequestTagsEnableItem), TypeInfoPropertyName = "PostToolRouterSessionRequestTagsEnableItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionRequestTagsDisableItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionRequestTagsDisableItem), TypeInfoPropertyName = "PostToolRouterSessionRequestTagsDisableItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionRequestWorkbench))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionRequestMultiAccount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionRequestExperimental))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionRequestExperimentalAssistivePromptConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionRequestExperimentalCustomToolkit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionRequestExperimentalCustomToolkit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionRequestExperimentalCustomToolkitTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionRequestExperimentalCustomToolkitTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionRequestExperimentalCustomTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionRequestExperimentalCustomTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdExecuteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdExecuteMetaRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdExecuteMetaRequestSlug), TypeInfoPropertyName = "PostToolRouterSessionBySessionIdExecuteMetaRequestSlug2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdLinkRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestMethod), TypeInfoPropertyName = "PostToolRouterSessionBySessionIdProxyExecuteRequestMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.AnyOf<global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestBinaryBodyVariant1, global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestBinaryBodyVariant2>), TypeInfoPropertyName = "PostToolRouterSessionBySessionIdProxyExecuteRequestBinaryBodyVariant2_54d26f71818beea5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestBinaryBodyVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestBinaryBodyVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestParameter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestParameter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestParameterType), TypeInfoPropertyName = "PostToolRouterSessionBySessionIdProxyExecuteRequestParameterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant1, global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant2, global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant3, global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant4, global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant5, global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant6, global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant7, global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant8, global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant9, global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant10, global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant11>), TypeInfoPropertyName = "PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant11_ef81f483744cff88")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant1AuthScheme), TypeInfoPropertyName = "PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant1AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant1Val))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant1ValAuthedUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant2AuthScheme), TypeInfoPropertyName = "PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant2AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant2Val))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant3AuthScheme), TypeInfoPropertyName = "PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant3AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant3Val))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant4AuthScheme), TypeInfoPropertyName = "PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant4AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant4Val))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant5AuthScheme), TypeInfoPropertyName = "PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant5AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant5Val))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant6AuthScheme), TypeInfoPropertyName = "PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant6AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant6Val))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant7AuthScheme), TypeInfoPropertyName = "PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant7AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant7Val))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant8AuthScheme), TypeInfoPropertyName = "PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant8AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant8Val))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant9AuthScheme), TypeInfoPropertyName = "PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant9AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant9Val))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant10AuthScheme), TypeInfoPropertyName = "PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant10AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant10Val))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant11AuthScheme), TypeInfoPropertyName = "PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant11AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant11Val))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdSearchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionBySessionIdSearchRequestQuerie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdSearchRequestQuerie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdMountsByMountIdDownloadUrlRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdMountsByMountIdUploadUrlRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdMountsByMountIdDeleteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.AnyOf<string, bool?>), TypeInfoPropertyName = "AnyOfStringBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PatchAuthConfigsByNanoidByStatusStatus), TypeInfoPropertyName = "PatchAuthConfigsByNanoidByStatusStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.GetConnectedAccountsStatuse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsStatuse), TypeInfoPropertyName = "GetConnectedAccountsStatuse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsOrderBy), TypeInfoPropertyName = "GetConnectedAccountsOrderBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsOrderDirection), TypeInfoPropertyName = "GetConnectedAccountsOrderDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolkitsManagedBy), TypeInfoPropertyName = "GetToolkitsManagedBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolkitsSortBy), TypeInfoPropertyName = "GetToolkitsSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "OneOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolsImportant), TypeInfoPropertyName = "GetToolsImportant2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<object, string, global::System.Collections.Generic.Dictionary<string, string>>), TypeInfoPropertyName = "OneOfObjectStringDictionaryStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetMcpServersOrderBy), TypeInfoPropertyName = "GetMcpServersOrderBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetMcpServersOrderDirection), TypeInfoPropertyName = "GetMcpServersOrderDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetMcpAppByAppKeyOrderBy), TypeInfoPropertyName = "GetMcpAppByAppKeyOrderBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetMcpAppByAppKeyOrderDirection), TypeInfoPropertyName = "GetMcpAppByAppKeyOrderDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetMcpServersByServerIdInstancesOrderBy), TypeInfoPropertyName = "GetMcpServersByServerIdInstancesOrderBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetMcpServersByServerIdInstancesOrderDirection), TypeInfoPropertyName = "GetMcpServersByServerIdInstancesOrderDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetMigrationGetNanoidType), TypeInfoPropertyName = "GetMigrationGetNanoidType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetAuthSessionInfoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetAuthSessionInfoResponseProject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetAuthSessionInfoResponseProjectWebhookVersion), TypeInfoPropertyName = "GetAuthSessionInfoResponseProjectWebhookVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetAuthSessionInfoResponseProjectOrg))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetAuthSessionInfoResponseApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetAuthSessionInfoResponseOrgMember))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostAuthSessionLogoutResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostAuthSessionLogoutResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostAuthSessionLogoutResponse3))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetAuthConfigsResponseItemToolAccessConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetAuthConfigsResponseItemDeprecatedParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, object?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetAuthConfigsByNanoidResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetAuthConfigsByNanoidResponseType), TypeInfoPropertyName = "GetAuthConfigsByNanoidResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetAuthConfigsByNanoidResponseToolkit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetAuthConfigsByNanoidResponseAuthScheme), TypeInfoPropertyName = "GetAuthConfigsByNanoidResponseAuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetAuthConfigsByNanoidResponseProxyConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetAuthConfigsByNanoidResponseStatus), TypeInfoPropertyName = "GetAuthConfigsByNanoidResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetAuthConfigsByNanoidResponseToolAccessConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetAuthConfigsByNanoidResponseDeprecatedParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostCliCreateSessionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostCliCreateSessionResponseStatus), TypeInfoPropertyName = "PostCliCreateSessionResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostCliCreateSessionResponseScope), TypeInfoPropertyName = "PostCliCreateSessionResponseScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostCliCodactFailuresResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetCliGetSessionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetCliGetSessionResponseStatus), TypeInfoPropertyName = "GetCliGetSessionResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetCliGetSessionResponseAccount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetCliGetSessionResponseScope), TypeInfoPropertyName = "GetCliGetSessionResponseScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetCliRealtimeCredentialsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostCliRealtimeAuthResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.GetConnectedAccountsResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemToolkit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemAuthConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemAuthConfigAuthScheme), TypeInfoPropertyName = "GetConnectedAccountsResponseItemAuthConfigAuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemAuthConfigDeprecated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStatus), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.GetConnectedAccountsResponseItemStateVariant1, global::Composio.GetConnectedAccountsResponseItemStateVariant2, global::Composio.GetConnectedAccountsResponseItemStateVariant3, global::Composio.GetConnectedAccountsResponseItemStateVariant4, global::Composio.GetConnectedAccountsResponseItemStateVariant5, global::Composio.GetConnectedAccountsResponseItemStateVariant6, global::Composio.GetConnectedAccountsResponseItemStateVariant7, global::Composio.GetConnectedAccountsResponseItemStateVariant8, global::Composio.GetConnectedAccountsResponseItemStateVariant9, global::Composio.GetConnectedAccountsResponseItemStateVariant10, global::Composio.GetConnectedAccountsResponseItemStateVariant11, global::Composio.GetConnectedAccountsResponseItemStateVariant12, global::Composio.GetConnectedAccountsResponseItemStateVariant13, global::Composio.GetConnectedAccountsResponseItemStateVariant14>), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant14_40fdd97368f4b0fc")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant1AuthScheme), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant1AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.GetConnectedAccountsResponseItemStateVariant1ValVariant1, global::Composio.GetConnectedAccountsResponseItemStateVariant1ValVariant2, global::Composio.GetConnectedAccountsResponseItemStateVariant1ValVariant3, global::Composio.GetConnectedAccountsResponseItemStateVariant1ValVariant4, global::Composio.GetConnectedAccountsResponseItemStateVariant1ValVariant5, global::Composio.GetConnectedAccountsResponseItemStateVariant1ValVariant6>), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant1ValVariant6_e4d6cba1c93020f5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant1ValVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant1ValVariant1Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant1ValVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant1ValVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant1ValVariant2Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant1ValVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant1ValVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant1ValVariant3Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant1ValVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant1ValVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant1ValVariant4Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant1ValVariant4Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant1ValVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant1ValVariant5Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant1ValVariant5Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant1ValVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant1ValVariant6Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant1ValVariant6Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant2AuthScheme), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant2AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant1, global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant2, global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant3, global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant4, global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant5, global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant6>), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant2ValVariant6_7b0bb5598ab7e0c4")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant1Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant2ValVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant2Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant2ValVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant3Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant2ValVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant3AuthedUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant4Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant2ValVariant4Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant4AuthedUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant5Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant2ValVariant5Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant6Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant2ValVariant6Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant3AuthScheme), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant3AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.GetConnectedAccountsResponseItemStateVariant3ValVariant1, global::Composio.GetConnectedAccountsResponseItemStateVariant3ValVariant2, global::Composio.GetConnectedAccountsResponseItemStateVariant3ValVariant3, global::Composio.GetConnectedAccountsResponseItemStateVariant3ValVariant4>), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant3ValVariant4_418714025ccbc95f")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant3ValVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant3ValVariant1Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant3ValVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant3ValVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant3ValVariant2Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant3ValVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant3ValVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant3ValVariant3Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant3ValVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant3ValVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant3ValVariant4Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant3ValVariant4Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant4AuthScheme), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant4AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.GetConnectedAccountsResponseItemStateVariant4ValVariant1, global::Composio.GetConnectedAccountsResponseItemStateVariant4ValVariant2, global::Composio.GetConnectedAccountsResponseItemStateVariant4ValVariant3, global::Composio.GetConnectedAccountsResponseItemStateVariant4ValVariant4>), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant4ValVariant4_937d5caa841c0dff")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant4ValVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant4ValVariant1Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant4ValVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant4ValVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant4ValVariant2Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant4ValVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant4ValVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant4ValVariant3Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant4ValVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant4ValVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant4ValVariant4Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant4ValVariant4Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant5AuthScheme), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant5AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.GetConnectedAccountsResponseItemStateVariant5ValVariant1, global::Composio.GetConnectedAccountsResponseItemStateVariant5ValVariant2, global::Composio.GetConnectedAccountsResponseItemStateVariant5ValVariant3, global::Composio.GetConnectedAccountsResponseItemStateVariant5ValVariant4>), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant5ValVariant4_19f5700d9c0a62ca")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant5ValVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant5ValVariant1Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant5ValVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant5ValVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant5ValVariant2Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant5ValVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant5ValVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant5ValVariant3Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant5ValVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant5ValVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant5ValVariant4Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant5ValVariant4Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant6AuthScheme), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant6AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.GetConnectedAccountsResponseItemStateVariant6ValVariant1, global::Composio.GetConnectedAccountsResponseItemStateVariant6ValVariant2, global::Composio.GetConnectedAccountsResponseItemStateVariant6ValVariant3, global::Composio.GetConnectedAccountsResponseItemStateVariant6ValVariant4>), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant6ValVariant4_c7f6dccc038ac867")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant6ValVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant6ValVariant1Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant6ValVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant6ValVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant6ValVariant2Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant6ValVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant6ValVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant6ValVariant3Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant6ValVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant6ValVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant6ValVariant4Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant6ValVariant4Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant7AuthScheme), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant7AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.GetConnectedAccountsResponseItemStateVariant7ValVariant1, global::Composio.GetConnectedAccountsResponseItemStateVariant7ValVariant2, global::Composio.GetConnectedAccountsResponseItemStateVariant7ValVariant3, global::Composio.GetConnectedAccountsResponseItemStateVariant7ValVariant4, global::Composio.GetConnectedAccountsResponseItemStateVariant7ValVariant5, global::Composio.GetConnectedAccountsResponseItemStateVariant7ValVariant6>), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant7ValVariant6_ba680de368f297db")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant7ValVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant7ValVariant1Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant7ValVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant7ValVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant7ValVariant2Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant7ValVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant7ValVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant7ValVariant3Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant7ValVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant7ValVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant7ValVariant4Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant7ValVariant4Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant7ValVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant7ValVariant5Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant7ValVariant5Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant7ValVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant7ValVariant6Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant7ValVariant6Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant8AuthScheme), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant8AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant1, global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant2, global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant3, global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant4, global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant5, global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant6>), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant8ValVariant6_555dcf579f3db488")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant1Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant8ValVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant2Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant8ValVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant3Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant8ValVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant4Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant8ValVariant4Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant5Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant8ValVariant5Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant6Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant8ValVariant6Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant9AuthScheme), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant9AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant1, global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant2, global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant3, global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant4, global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant5, global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant6>), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant9ValVariant6_9a1429dc003cffd6")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant1Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant9ValVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant2Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant9ValVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant3Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant9ValVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant4Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant9ValVariant4Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant5Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant9ValVariant5Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant6Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant9ValVariant6Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant10AuthScheme), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant10AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.GetConnectedAccountsResponseItemStateVariant10ValVariant1, global::Composio.GetConnectedAccountsResponseItemStateVariant10ValVariant2, global::Composio.GetConnectedAccountsResponseItemStateVariant10ValVariant3, global::Composio.GetConnectedAccountsResponseItemStateVariant10ValVariant4, global::Composio.GetConnectedAccountsResponseItemStateVariant10ValVariant5, global::Composio.GetConnectedAccountsResponseItemStateVariant10ValVariant6>), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant10ValVariant6_8fb0fb5b458f0f82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant10ValVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant10ValVariant1Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant10ValVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant10ValVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant10ValVariant2Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant10ValVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant10ValVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant10ValVariant3Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant10ValVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant10ValVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant10ValVariant4Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant10ValVariant4Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant10ValVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant10ValVariant5Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant10ValVariant5Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant10ValVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant10ValVariant6Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant10ValVariant6Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant11AuthScheme), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant11AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.GetConnectedAccountsResponseItemStateVariant11ValVariant1, global::Composio.GetConnectedAccountsResponseItemStateVariant11ValVariant2, global::Composio.GetConnectedAccountsResponseItemStateVariant11ValVariant3, global::Composio.GetConnectedAccountsResponseItemStateVariant11ValVariant4>), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant11ValVariant4_38933bef2a16cd1a")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant11ValVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant11ValVariant1Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant11ValVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant11ValVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant11ValVariant2Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant11ValVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant11ValVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant11ValVariant3Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant11ValVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant11ValVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant11ValVariant4Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant11ValVariant4Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant12AuthScheme), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant12AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.GetConnectedAccountsResponseItemStateVariant12ValVariant1, global::Composio.GetConnectedAccountsResponseItemStateVariant12ValVariant2, global::Composio.GetConnectedAccountsResponseItemStateVariant12ValVariant3, global::Composio.GetConnectedAccountsResponseItemStateVariant12ValVariant4, global::Composio.GetConnectedAccountsResponseItemStateVariant12ValVariant5, global::Composio.GetConnectedAccountsResponseItemStateVariant12ValVariant6>), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant12ValVariant6_405361d0c0fd34bf")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant12ValVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant12ValVariant1Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant12ValVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant12ValVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant12ValVariant2Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant12ValVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant12ValVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant12ValVariant3Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant12ValVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant12ValVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant12ValVariant4Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant12ValVariant4Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant12ValVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant12ValVariant5Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant12ValVariant5Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant12ValVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant12ValVariant6Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant12ValVariant6Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant13AuthScheme), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant13AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.GetConnectedAccountsResponseItemStateVariant13ValVariant1, global::Composio.GetConnectedAccountsResponseItemStateVariant13ValVariant2, global::Composio.GetConnectedAccountsResponseItemStateVariant13ValVariant3, global::Composio.GetConnectedAccountsResponseItemStateVariant13ValVariant4, global::Composio.GetConnectedAccountsResponseItemStateVariant13ValVariant5, global::Composio.GetConnectedAccountsResponseItemStateVariant13ValVariant6>), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant13ValVariant6_b4af611d41794f2e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant13ValVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant13ValVariant1Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant13ValVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant13ValVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant13ValVariant2Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant13ValVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant13ValVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant13ValVariant3Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant13ValVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant13ValVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant13ValVariant4Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant13ValVariant4Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant13ValVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant13ValVariant5Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant13ValVariant5Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant13ValVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant13ValVariant6Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant13ValVariant6Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant14))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant14AuthScheme), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant14AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant1, global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant2, global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant3, global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant4, global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant5, global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant6>), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant14ValVariant6_0235d040ed676ecd")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant1Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant14ValVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant2Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant14ValVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant3Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant14ValVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant4Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant14ValVariant4Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant5Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant14ValVariant5Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant6Status), TypeInfoPropertyName = "GetConnectedAccountsResponseItemStateVariant14ValVariant6Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsResponseItemDeprecated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.PostConnectedAccountsResponseConnectionDataVariant1, global::Composio.PostConnectedAccountsResponseConnectionDataVariant2, global::Composio.PostConnectedAccountsResponseConnectionDataVariant3, global::Composio.PostConnectedAccountsResponseConnectionDataVariant4, global::Composio.PostConnectedAccountsResponseConnectionDataVariant5, global::Composio.PostConnectedAccountsResponseConnectionDataVariant6, global::Composio.PostConnectedAccountsResponseConnectionDataVariant7, global::Composio.PostConnectedAccountsResponseConnectionDataVariant8, global::Composio.PostConnectedAccountsResponseConnectionDataVariant9, global::Composio.PostConnectedAccountsResponseConnectionDataVariant10, global::Composio.PostConnectedAccountsResponseConnectionDataVariant11, global::Composio.PostConnectedAccountsResponseConnectionDataVariant12, global::Composio.PostConnectedAccountsResponseConnectionDataVariant13, global::Composio.PostConnectedAccountsResponseConnectionDataVariant14>), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant14_b238e472a09f5a04")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant1AuthScheme), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant1AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant1, global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant2, global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant3, global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant4, global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant5, global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant6>), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant1ValVariant6_d81d3bcca0f14c81")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant1Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant1ValVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant2Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant1ValVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant3Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant1ValVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant4Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant1ValVariant4Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant5Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant1ValVariant5Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant6Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant1ValVariant6Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant2AuthScheme), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant2AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant1, global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant2, global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant3, global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant4, global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant5, global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant6>), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant2ValVariant6_2b2154935282bd05")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant1Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant2ValVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant2Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant2ValVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant3Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant2ValVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant3AuthedUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant4Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant2ValVariant4Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant4AuthedUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant5Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant2ValVariant5Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant6Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant2ValVariant6Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant3AuthScheme), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant3AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.PostConnectedAccountsResponseConnectionDataVariant3ValVariant1, global::Composio.PostConnectedAccountsResponseConnectionDataVariant3ValVariant2, global::Composio.PostConnectedAccountsResponseConnectionDataVariant3ValVariant3, global::Composio.PostConnectedAccountsResponseConnectionDataVariant3ValVariant4>), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant3ValVariant4_5d2f2c950e9b5ba9")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant3ValVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant3ValVariant1Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant3ValVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant3ValVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant3ValVariant2Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant3ValVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant3ValVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant3ValVariant3Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant3ValVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant3ValVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant3ValVariant4Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant3ValVariant4Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant4AuthScheme), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant4AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.PostConnectedAccountsResponseConnectionDataVariant4ValVariant1, global::Composio.PostConnectedAccountsResponseConnectionDataVariant4ValVariant2, global::Composio.PostConnectedAccountsResponseConnectionDataVariant4ValVariant3, global::Composio.PostConnectedAccountsResponseConnectionDataVariant4ValVariant4>), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant4ValVariant4_e086ffd6bfea657c")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant4ValVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant4ValVariant1Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant4ValVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant4ValVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant4ValVariant2Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant4ValVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant4ValVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant4ValVariant3Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant4ValVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant4ValVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant4ValVariant4Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant4ValVariant4Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant5AuthScheme), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant5AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.PostConnectedAccountsResponseConnectionDataVariant5ValVariant1, global::Composio.PostConnectedAccountsResponseConnectionDataVariant5ValVariant2, global::Composio.PostConnectedAccountsResponseConnectionDataVariant5ValVariant3, global::Composio.PostConnectedAccountsResponseConnectionDataVariant5ValVariant4>), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant5ValVariant4_a965b023bef10c16")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant5ValVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant5ValVariant1Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant5ValVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant5ValVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant5ValVariant2Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant5ValVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant5ValVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant5ValVariant3Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant5ValVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant5ValVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant5ValVariant4Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant5ValVariant4Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant6AuthScheme), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant6AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.PostConnectedAccountsResponseConnectionDataVariant6ValVariant1, global::Composio.PostConnectedAccountsResponseConnectionDataVariant6ValVariant2, global::Composio.PostConnectedAccountsResponseConnectionDataVariant6ValVariant3, global::Composio.PostConnectedAccountsResponseConnectionDataVariant6ValVariant4>), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant6ValVariant4_dc430715cdf0f6ed")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant6ValVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant6ValVariant1Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant6ValVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant6ValVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant6ValVariant2Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant6ValVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant6ValVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant6ValVariant3Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant6ValVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant6ValVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant6ValVariant4Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant6ValVariant4Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant7AuthScheme), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant7AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant1, global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant2, global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant3, global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant4, global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant5, global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant6>), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant7ValVariant6_0e5a846ddf8f4ea1")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant1Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant7ValVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant2Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant7ValVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant3Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant7ValVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant4Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant7ValVariant4Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant5Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant7ValVariant5Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant6Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant7ValVariant6Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant8AuthScheme), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant8AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.PostConnectedAccountsResponseConnectionDataVariant8ValVariant1, global::Composio.PostConnectedAccountsResponseConnectionDataVariant8ValVariant2, global::Composio.PostConnectedAccountsResponseConnectionDataVariant8ValVariant3, global::Composio.PostConnectedAccountsResponseConnectionDataVariant8ValVariant4, global::Composio.PostConnectedAccountsResponseConnectionDataVariant8ValVariant5, global::Composio.PostConnectedAccountsResponseConnectionDataVariant8ValVariant6>), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant8ValVariant6_da845793f14c01cc")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant8ValVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant8ValVariant1Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant8ValVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant8ValVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant8ValVariant2Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant8ValVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant8ValVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant8ValVariant3Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant8ValVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant8ValVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant8ValVariant4Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant8ValVariant4Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant8ValVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant8ValVariant5Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant8ValVariant5Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant8ValVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant8ValVariant6Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant8ValVariant6Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant9AuthScheme), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant9AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant1, global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant2, global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant3, global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant4, global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant5, global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant6>), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant9ValVariant6_e6108fa502019e38")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant1Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant9ValVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant2Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant9ValVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant3Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant9ValVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant4Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant9ValVariant4Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant5Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant9ValVariant5Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant6Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant9ValVariant6Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant10AuthScheme), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant10AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.PostConnectedAccountsResponseConnectionDataVariant10ValVariant1, global::Composio.PostConnectedAccountsResponseConnectionDataVariant10ValVariant2, global::Composio.PostConnectedAccountsResponseConnectionDataVariant10ValVariant3, global::Composio.PostConnectedAccountsResponseConnectionDataVariant10ValVariant4, global::Composio.PostConnectedAccountsResponseConnectionDataVariant10ValVariant5, global::Composio.PostConnectedAccountsResponseConnectionDataVariant10ValVariant6>), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant10ValVariant6_0847ef73cfe0fac9")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant10ValVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant10ValVariant1Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant10ValVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant10ValVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant10ValVariant2Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant10ValVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant10ValVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant10ValVariant3Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant10ValVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant10ValVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant10ValVariant4Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant10ValVariant4Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant10ValVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant10ValVariant5Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant10ValVariant5Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant10ValVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant10ValVariant6Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant10ValVariant6Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant11AuthScheme), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant11AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.PostConnectedAccountsResponseConnectionDataVariant11ValVariant1, global::Composio.PostConnectedAccountsResponseConnectionDataVariant11ValVariant2, global::Composio.PostConnectedAccountsResponseConnectionDataVariant11ValVariant3, global::Composio.PostConnectedAccountsResponseConnectionDataVariant11ValVariant4>), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant11ValVariant4_9648faccbe7e3b17")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant11ValVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant11ValVariant1Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant11ValVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant11ValVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant11ValVariant2Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant11ValVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant11ValVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant11ValVariant3Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant11ValVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant11ValVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant11ValVariant4Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant11ValVariant4Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant12AuthScheme), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant12AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.PostConnectedAccountsResponseConnectionDataVariant12ValVariant1, global::Composio.PostConnectedAccountsResponseConnectionDataVariant12ValVariant2, global::Composio.PostConnectedAccountsResponseConnectionDataVariant12ValVariant3, global::Composio.PostConnectedAccountsResponseConnectionDataVariant12ValVariant4, global::Composio.PostConnectedAccountsResponseConnectionDataVariant12ValVariant5, global::Composio.PostConnectedAccountsResponseConnectionDataVariant12ValVariant6>), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant12ValVariant6_72a9219b466111de")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant12ValVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant12ValVariant1Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant12ValVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant12ValVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant12ValVariant2Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant12ValVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant12ValVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant12ValVariant3Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant12ValVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant12ValVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant12ValVariant4Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant12ValVariant4Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant12ValVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant12ValVariant5Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant12ValVariant5Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant12ValVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant12ValVariant6Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant12ValVariant6Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant13AuthScheme), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant13AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.PostConnectedAccountsResponseConnectionDataVariant13ValVariant1, global::Composio.PostConnectedAccountsResponseConnectionDataVariant13ValVariant2, global::Composio.PostConnectedAccountsResponseConnectionDataVariant13ValVariant3, global::Composio.PostConnectedAccountsResponseConnectionDataVariant13ValVariant4, global::Composio.PostConnectedAccountsResponseConnectionDataVariant13ValVariant5, global::Composio.PostConnectedAccountsResponseConnectionDataVariant13ValVariant6>), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant13ValVariant6_827c2e2a691f8b85")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant13ValVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant13ValVariant1Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant13ValVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant13ValVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant13ValVariant2Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant13ValVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant13ValVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant13ValVariant3Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant13ValVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant13ValVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant13ValVariant4Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant13ValVariant4Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant13ValVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant13ValVariant5Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant13ValVariant5Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant13ValVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant13ValVariant6Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant13ValVariant6Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant14))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant14AuthScheme), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant14AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.PostConnectedAccountsResponseConnectionDataVariant14ValVariant1, global::Composio.PostConnectedAccountsResponseConnectionDataVariant14ValVariant2, global::Composio.PostConnectedAccountsResponseConnectionDataVariant14ValVariant3, global::Composio.PostConnectedAccountsResponseConnectionDataVariant14ValVariant4, global::Composio.PostConnectedAccountsResponseConnectionDataVariant14ValVariant5, global::Composio.PostConnectedAccountsResponseConnectionDataVariant14ValVariant6>), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant14ValVariant6_20b7c23189a7bda0")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant14ValVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant14ValVariant1Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant14ValVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant14ValVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant14ValVariant2Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant14ValVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant14ValVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant14ValVariant3Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant14ValVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant14ValVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant14ValVariant4Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant14ValVariant4Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant14ValVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant14ValVariant5Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant14ValVariant5Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant14ValVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseConnectionDataVariant14ValVariant6Status), TypeInfoPropertyName = "PostConnectedAccountsResponseConnectionDataVariant14ValVariant6Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseStatus), TypeInfoPropertyName = "PostConnectedAccountsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsResponseDeprecated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseToolkit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseAuthConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseAuthConfigAuthScheme), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseAuthConfigAuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseAuthConfigDeprecated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStatus), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.GetConnectedAccountsByNanoidResponseStateVariant1, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant3, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant4, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant5, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant7, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant9, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant10, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant11, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant12, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant13, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant14>), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant14_af9939f0e1ca75c5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant1AuthScheme), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant1AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant1, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant2, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant3, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant4, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant5, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant6>), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant1ValVariant6_732a74b52747b9d8")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant1Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant1ValVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant2Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant1ValVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant3Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant1ValVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant4Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant1ValVariant4Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant5Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant1ValVariant5Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant6Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant1ValVariant6Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2AuthScheme), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant2AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant1, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant2, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant3, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant4, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant5, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant6>), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant2ValVariant6_4c75bda15070633b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant1Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant2ValVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant2Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant2ValVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant3Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant2ValVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant3AuthedUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant4Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant2ValVariant4Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant4AuthedUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant5Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant2ValVariant5Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant6Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant2ValVariant6Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant3AuthScheme), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant3AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant1, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant2, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant3, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant4>), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant3ValVariant4_828723f7e645a043")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant1Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant3ValVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant2Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant3ValVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant3Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant3ValVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant4Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant3ValVariant4Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant4AuthScheme), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant4AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.GetConnectedAccountsByNanoidResponseStateVariant4ValVariant1, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant4ValVariant2, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant4ValVariant3, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant4ValVariant4>), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant4ValVariant4_324a4330a293b5a0")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant4ValVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant4ValVariant1Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant4ValVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant4ValVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant4ValVariant2Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant4ValVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant4ValVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant4ValVariant3Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant4ValVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant4ValVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant4ValVariant4Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant4ValVariant4Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant5AuthScheme), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant5AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant1, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant2, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant3, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant4>), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant5ValVariant4_5a56b7327e88e8ca")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant1Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant5ValVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant2Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant5ValVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant3Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant5ValVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant4Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant5ValVariant4Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6AuthScheme), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant6AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant1, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant2, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant3, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant4>), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant6ValVariant4_144e54e8684b96c4")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant1Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant6ValVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant2Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant6ValVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant3Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant6ValVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant4Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant6ValVariant4Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant7AuthScheme), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant7AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant1, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant2, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant3, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant4, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant5, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant6>), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant7ValVariant6_878b43ad288c5970")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant1Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant7ValVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant2Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant7ValVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant3Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant7ValVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant4Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant7ValVariant4Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant5Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant7ValVariant5Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant6Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant7ValVariant6Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8AuthScheme), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant8AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant1, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant2, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant3, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant4, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant5, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant6>), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant8ValVariant6_312d9884dab7c93c")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant1Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant8ValVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant2Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant8ValVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant3Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant8ValVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant4Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant8ValVariant4Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant5Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant8ValVariant5Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant6Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant8ValVariant6Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant9AuthScheme), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant9AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant1, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant2, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant3, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant4, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant5, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant6>), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant9ValVariant6_c3e99c08291a4628")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant1Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant9ValVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant2Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant9ValVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant3Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant9ValVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant4Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant9ValVariant4Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant5Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant9ValVariant5Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant6Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant9ValVariant6Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant10AuthScheme), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant10AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant1, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant2, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant3, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant4, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant5, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant6>), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant10ValVariant6_e391c3cc842867fd")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant1Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant10ValVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant2Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant10ValVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant3Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant10ValVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant4Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant10ValVariant4Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant5Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant10ValVariant5Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant6Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant10ValVariant6Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant11AuthScheme), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant11AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant1, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant2, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant3, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant4>), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant11ValVariant4_9709c00a2c5d4073")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant1Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant11ValVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant2Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant11ValVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant3Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant11ValVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant4Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant11ValVariant4Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant12AuthScheme), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant12AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant1, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant2, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant3, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant4, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant5, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant6>), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant12ValVariant6_92e04db79eb81cde")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant1Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant12ValVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant2Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant12ValVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant3Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant12ValVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant4Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant12ValVariant4Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant5Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant12ValVariant5Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant6Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant12ValVariant6Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant13AuthScheme), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant13AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant1, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant2, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant3, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant4, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant5, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant6>), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant13ValVariant6_d792a589c863fd2c")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant1Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant13ValVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant2Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant13ValVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant3Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant13ValVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant4Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant13ValVariant4Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant5Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant13ValVariant5Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant6Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant13ValVariant6Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant14))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant14AuthScheme), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant14AuthScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<global::Composio.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant1, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant2, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant3, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant4, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant5, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant6>), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant14ValVariant6_23f5217de5c6ab7b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant1Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant14ValVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant2Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant14ValVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant3Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant14ValVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant4Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant14ValVariant4Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant5Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant14ValVariant5Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant6Status), TypeInfoPropertyName = "GetConnectedAccountsByNanoidResponseStateVariant14ValVariant6Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetConnectedAccountsByNanoidResponseDeprecated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.DeleteConnectedAccountsByNanoidResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PatchConnectedAccountsByNanoidResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PatchConnectedAccountsByNanoIdStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsByNanoidRefreshResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsByNanoidRefreshResponseStatus), TypeInfoPropertyName = "PostConnectedAccountsByNanoidRefreshResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostConnectedAccountsLinkResponse))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetOrgProjectConfigResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetOrgProjectConfigResponseLogVisibilitySetting), TypeInfoPropertyName = "GetOrgProjectConfigResponseLogVisibilitySetting2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PatchOrgProjectConfigResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PatchOrgProjectConfigResponseLogVisibilitySetting), TypeInfoPropertyName = "PatchOrgProjectConfigResponseLogVisibilitySetting2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostOrgOwnerProjectNewResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetOrgOwnerProjectListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.GetOrgOwnerProjectListResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetOrgOwnerProjectListResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetOrgOwnerProjectListResponseDataItemWebhookVersion), TypeInfoPropertyName = "GetOrgOwnerProjectListResponseDataItemWebhookVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetOrgOwnerProjectByNanoIdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetOrgOwnerProjectByNanoIdResponseWebhookVersion), TypeInfoPropertyName = "GetOrgOwnerProjectByNanoIdResponseWebhookVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.GetOrgOwnerProjectByNanoIdResponseApiKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetOrgOwnerProjectByNanoIdResponseApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.DeleteOrgOwnerProjectByNanoIdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.DeleteOrgOwnerProjectByNanoIdResponseStatus), TypeInfoPropertyName = "DeleteOrgOwnerProjectByNanoIdResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostOrgOwnerProjectByNanoIdRegenerateApiKeyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostOrgOwnerProjectByNanoIdRegenerateApiKeyResponseApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostOrgConsumerProjectResolveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostOrgConsumerProjectResolveResponseProjectType), TypeInfoPropertyName = "PostOrgConsumerProjectResolveResponseProjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetOrgConsumerConnectedToolkitsResponse))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolkitsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.GetToolkitsResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolkitsResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolkitsResponseItemMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.GetToolkitsResponseItemMetaCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolkitsResponseItemMetaCategorie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolkitsCategoriesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.GetToolkitsCategoriesResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolkitsCategoriesResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolkitsBySlugResponse))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolkitsMultiResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.PostToolkitsMultiResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolkitsMultiResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolkitsMultiResponseItemMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.PostToolkitsMultiResponseItemMetaCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolkitsMultiResponseItemMetaCategorie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteByToolSlugResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteByToolSlugInputResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteProxyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolsExecuteProxyResponseBinaryData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostTriggerInstancesBySlugUpsertResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostTriggerInstancesBySlugUpsertResponseDeprecated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostTriggerInstancesBySlugUpsertResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostTriggerInstancesBySlugUpsertResponseDeprecated2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetTriggerInstancesActiveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.GetTriggerInstancesActiveResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetTriggerInstancesActiveResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetTriggerInstancesActiveResponseItemDeprecated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.DeleteTriggerInstancesManageByTriggerIdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PatchTriggerInstancesManageByTriggerIdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PatchTriggerInstancesManageByTriggerIdResponseStatus), TypeInfoPropertyName = "PatchTriggerInstancesManageByTriggerIdResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetTriggersTypesBySlugResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetTriggersTypesBySlugResponseType), TypeInfoPropertyName = "GetTriggersTypesBySlugResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetTriggersTypesBySlugResponseToolkit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetTriggersTypesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.GetTriggersTypesResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetTriggersTypesResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetTriggersTypesResponseItemType), TypeInfoPropertyName = "GetTriggersTypesResponseItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetTriggersTypesResponseItemToolkit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetMcpServersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.GetMcpServersResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetMcpServersResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetMcpServersResponseItemCommands))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostMcpServersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostMcpServersResponseCommands))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostMcpServersCustomResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostMcpServersCustomResponseCommands))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostMcpServersGenerateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetMcpByIdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetMcpByIdResponseCommands))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PatchMcpByIdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PatchMcpByIdResponseCommands))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.DeleteMcpByIdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetMcpAppByAppKeyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.GetMcpAppByAppKeyResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetMcpAppByAppKeyResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetMcpAppByAppKeyResponseItemCommands))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetMcpServersByServerIdInstancesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.GetMcpServersByServerIdInstancesResponseInstance>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetMcpServersByServerIdInstancesResponseInstance))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostMcpServersByServerIdInstancesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.DeleteMcpServersByServerIdInstancesByInstanceIdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetFilesListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.GetFilesListResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetFilesListResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostFilesUploadRequestResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostFilesUploadRequestResponseType), TypeInfoPropertyName = "PostFilesUploadRequestResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostFilesUploadRequestResponseMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostFilesUploadRequestResponseMetadataStorageBackend), TypeInfoPropertyName = "PostFilesUploadRequestResponseMetadataStorageBackend2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetMigrationGetNanoidResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostLabsToolRouterSessionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionResponseMcp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionResponseMcpType), TypeInfoPropertyName = "PostToolRouterSessionResponseMcpType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionResponseConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.AnyOf<global::Composio.PostToolRouterSessionResponseConfigToolkitsVariant1, global::Composio.PostToolRouterSessionResponseConfigToolkitsVariant2>), TypeInfoPropertyName = "AnyOfPostToolRouterSessionResponseConfigToolkitsVariant1PostToolRouterSessionResponseConfigToolkitsVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionResponseConfigToolkitsVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionResponseConfigToolkitsVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionResponseConfigManageConnections))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.AnyOf<global::Composio.PostToolRouterSessionResponseConfigToolsVariant1, global::Composio.PostToolRouterSessionResponseConfigToolsVariant2, global::Composio.PostToolRouterSessionResponseConfigToolsVariant3>), TypeInfoPropertyName = "PostToolRouterSessionResponseConfigToolsVariant3_bcde873ceefac084")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionResponseConfigToolsVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionResponseConfigToolsVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionResponseConfigToolsVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionResponseConfigToolsVariant3Tags))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionResponseConfigToolsVariant3TagsEnabledItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionResponseConfigToolsVariant3TagsEnabledItem), TypeInfoPropertyName = "PostToolRouterSessionResponseConfigToolsVariant3TagsEnabledItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionResponseConfigToolsVariant3TagsDisabledItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionResponseConfigToolsVariant3TagsDisabledItem), TypeInfoPropertyName = "PostToolRouterSessionResponseConfigToolsVariant3TagsDisabledItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionResponseConfigTags))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionResponseConfigTagsEnabledItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionResponseConfigTagsEnabledItem), TypeInfoPropertyName = "PostToolRouterSessionResponseConfigTagsEnabledItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionResponseConfigTagsDisabledItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionResponseConfigTagsDisabledItem), TypeInfoPropertyName = "PostToolRouterSessionResponseConfigTagsDisabledItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionResponseConfigWorkbench))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionResponseConfigMultiAccount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionResponseExperimental))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionResponseExperimentalCustomToolkit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionResponseExperimentalCustomToolkit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionResponseExperimentalCustomToolkitTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionResponseExperimentalCustomToolkitTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionResponseExperimentalCustomTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionResponseExperimentalCustomTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdExecuteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdExecuteMetaResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolRouterSessionBySessionIdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolRouterSessionBySessionIdResponseMcp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolRouterSessionBySessionIdResponseMcpType), TypeInfoPropertyName = "GetToolRouterSessionBySessionIdResponseMcpType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolRouterSessionBySessionIdResponseConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.AnyOf<global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolkitsVariant1, global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolkitsVariant2>), TypeInfoPropertyName = "GetToolRouterSessionBySessionIdResponseConfigToolkitsVariant2_5e289d1ff45c5a4b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolkitsVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolkitsVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolRouterSessionBySessionIdResponseConfigManageConnections))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.AnyOf<global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolsVariant1, global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolsVariant2, global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3>), TypeInfoPropertyName = "GetToolRouterSessionBySessionIdResponseConfigToolsVariant3_c5e8393f39417354")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolsVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolsVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3Tags))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItem), TypeInfoPropertyName = "GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsDisabledItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsDisabledItem), TypeInfoPropertyName = "GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsDisabledItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolRouterSessionBySessionIdResponseConfigTags))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.GetToolRouterSessionBySessionIdResponseConfigTagsEnabledItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolRouterSessionBySessionIdResponseConfigTagsEnabledItem), TypeInfoPropertyName = "GetToolRouterSessionBySessionIdResponseConfigTagsEnabledItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.GetToolRouterSessionBySessionIdResponseConfigTagsDisabledItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolRouterSessionBySessionIdResponseConfigTagsDisabledItem), TypeInfoPropertyName = "GetToolRouterSessionBySessionIdResponseConfigTagsDisabledItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolRouterSessionBySessionIdResponseConfigWorkbench))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolRouterSessionBySessionIdResponseConfigMultiAccount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolRouterSessionBySessionIdResponseExperimental))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.GetToolRouterSessionBySessionIdResponseExperimentalCustomToolkit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolRouterSessionBySessionIdResponseExperimentalCustomToolkit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.GetToolRouterSessionBySessionIdResponseExperimentalCustomToolkitTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolRouterSessionBySessionIdResponseExperimentalCustomToolkitTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.GetToolRouterSessionBySessionIdResponseExperimentalCustomTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolRouterSessionBySessionIdResponseExperimentalCustomTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdLinkResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdProxyExecuteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdProxyExecuteResponseBinaryData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolRouterSessionBySessionIdToolsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdSearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionBySessionIdSearchResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdSearchResponseResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionBySessionIdSearchResponseResultReferenceWorkbenchSnippet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdSearchResponseResultReferenceWorkbenchSnippet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccountSelection), TypeInfoPropertyName = "PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccountSelection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Composio.PostToolRouterSessionBySessionIdSearchResponseToolSchemas2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdSearchResponseToolSchemas2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdSearchResponseToolSchemasSchemaRef))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdSearchResponseToolSchemasSchemaRefTool), TypeInfoPropertyName = "PostToolRouterSessionBySessionIdSearchResponseToolSchemasSchemaRefTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdSearchResponseToolSchemasSchemaRefArgs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdSearchResponseTimeInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdSearchResponseSession))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolRouterSessionBySessionIdMountsByMountIdItemsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.GetToolRouterSessionBySessionIdMountsByMountIdItemsResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolRouterSessionBySessionIdMountsByMountIdItemsResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdMountsByMountIdDownloadUrlResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdMountsByMountIdUploadUrlResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.PostToolRouterSessionBySessionIdMountsByMountIdDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolkitsChangelogResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.GetToolkitsChangelogResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolkitsChangelogResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Composio.GetToolkitsChangelogResponseItemVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.GetToolkitsChangelogResponseItemVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.AnyOf<string, global::Composio.ToolScopeRequirementsAllOfItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.ToolRouterToolkitsListResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.AnyOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.AnyOf<string, global::System.Collections.Generic.List<string>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.PostInternalTriggerLogsRequestSearchParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.PostInternalActionExecutionLogsRequestSearchParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.PostToolsExecuteByToolSlugRequestCustomAuthParamsParameter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.PostToolsExecuteProxyRequestParameter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.PostLabsToolRouterSessionRequestConfigToolkit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.AnyOf<global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionRequestToolsVariant3Tag>, global::Composio.PostToolRouterSessionRequestToolsVariant3Tags>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionRequestToolsVariant3Tag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionRequestToolsVariant3TagsEnableItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionRequestToolsVariant3TagsDisableItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.AnyOf<global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionRequestTag>, global::Composio.PostToolRouterSessionRequestTags>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionRequestTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionRequestTagsEnableItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionRequestTagsDisableItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionRequestExperimentalCustomToolkit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionRequestExperimentalCustomToolkitTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionRequestExperimentalCustomTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestParameter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionBySessionIdSearchRequestQuerie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.GetConnectedAccountsStatuse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Composio.OneOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.GetAuthConfigsResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, object?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.GetConnectedAccountsResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.PostInternalTriggerLogsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.PostInternalActionExecutionLogsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Composio.GetInternalActionExecutionFieldsResponseField>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.GetInternalActionExecutionFieldsResponseField>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.GetInternalActionExecutionLogByIdResponseStep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.GetInternalActionExecutionLogByIdResponseStepLog>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.GetOrgOwnerProjectListResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.GetOrgOwnerProjectByNanoIdResponseApiKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.GetWebhookSubscriptionsResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.GetWebhookSubscriptionsEventTypesResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.GetWebhookSubscriptionsEventTypesResponseItemSupportedVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.GetToolkitsResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.GetToolkitsResponseItemMetaCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.GetToolkitsCategoriesResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.GetToolkitsBySlugResponseAuthConfigDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.GetToolkitsBySlugResponseAuthConfigDetailFieldsAuthConfigCreationRequiredItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.GetToolkitsBySlugResponseAuthConfigDetailFieldsAuthConfigCreationOptionalItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.GetToolkitsBySlugResponseAuthConfigDetailFieldsConnectedAccountInitiationRequiredItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.GetToolkitsBySlugResponseAuthConfigDetailFieldsConnectedAccountInitiationOptionalItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.GetToolkitsBySlugResponseMetaCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.PostToolkitsMultiResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.PostToolkitsMultiResponseItemMetaCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.GetTriggerInstancesActiveResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.GetTriggersTypesResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.GetMcpServersResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.GetMcpAppByAppKeyResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.GetMcpServersByServerIdInstancesResponseInstance>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.GetFilesListResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionResponseConfigToolsVariant3TagsEnabledItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionResponseConfigToolsVariant3TagsDisabledItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionResponseConfigTagsEnabledItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionResponseConfigTagsDisabledItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionResponseExperimentalCustomToolkit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionResponseExperimentalCustomToolkitTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionResponseExperimentalCustomTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsDisabledItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.GetToolRouterSessionBySessionIdResponseConfigTagsEnabledItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.GetToolRouterSessionBySessionIdResponseConfigTagsDisabledItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.GetToolRouterSessionBySessionIdResponseExperimentalCustomToolkit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.GetToolRouterSessionBySessionIdResponseExperimentalCustomToolkitTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.GetToolRouterSessionBySessionIdResponseExperimentalCustomTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionBySessionIdSearchResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionBySessionIdSearchResponseResultReferenceWorkbenchSnippet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.GetToolRouterSessionBySessionIdMountsByMountIdItemsResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.GetToolkitsChangelogResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Composio.GetToolkitsChangelogResponseItemVersion>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}