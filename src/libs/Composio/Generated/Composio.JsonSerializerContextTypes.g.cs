
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Composio.Error? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ErrorError1? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ComposioManagedAuthConfigCreate? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ComposioManagedAuthConfigCreateType? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ComposioManagedAuthConfigCreateCredentials? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.AnyOf<string, global::System.Collections.Generic.IList<string>>? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ComposioManagedAuthConfigCreateToolAccessConfig? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object?>? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.CustomAuthConfigCreate? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.CustomAuthConfigCreateType? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.CustomAuthConfigCreateAuthScheme? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.CustomAuthConfigCreateCredentials? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.CustomAuthConfigCreateProxyConfig? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.CustomAuthConfigCreateToolAccessConfig? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.CustomAuthConfigUpdate? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.CustomAuthConfigUpdateType? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.CustomAuthConfigUpdateCredentials? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.CustomAuthConfigUpdateProxyConfig? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.CustomAuthConfigUpdateToolAccessConfig? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.DefaultAuthConfigUpdate? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.DefaultAuthConfigUpdateType? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.DefaultAuthConfigUpdateToolAccessConfig? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchConnectedAccountBody? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchConnectedAccountBodyConnection? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchConnectedAccountBodyConnectionState? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchConnectedAccountBodyConnectionStateAuthScheme? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchConnectedAccountBodyConnectionStateVal? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchConnectedAccountBodyExperimental? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchConnectedAccountBodyExperimentalAclConfigForShared? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.DeprecatedToolkitInfo? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ToolPricing? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.InstantAccount? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.Tool? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ToolToolkit? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ToolScopeRequirements? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.AnyOf<string, global::Composio.ToolScopeRequirementsAllOfItem>>? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.AnyOf<string, global::Composio.ToolScopeRequirementsAllOfItem>? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ToolScopeRequirementsAllOfItem? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.AnyOf<string, global::Composio.ToolScopeRequirementsAllOfItemAnyOfItem>>? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.AnyOf<string, global::Composio.ToolScopeRequirementsAllOfItemAnyOfItem>? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ToolScopeRequirementsAllOfItemAnyOfItem? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ToolDeprecated? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ToolDeprecatedToolkit? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ToolsPaginated? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.Tool>? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ToolDetails? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ToolDetailsToolkit? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ToolDetailsScopeRequirements? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.AnyOf<string, global::Composio.ToolDetailsScopeRequirementsAllOfItem>>? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.AnyOf<string, global::Composio.ToolDetailsScopeRequirementsAllOfItem>? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ToolDetailsScopeRequirementsAllOfItem? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.AnyOf<string, global::Composio.ToolDetailsScopeRequirementsAllOfItemAnyOfItem>>? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.AnyOf<string, global::Composio.ToolDetailsScopeRequirementsAllOfItemAnyOfItem>? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ToolDetailsScopeRequirementsAllOfItemAnyOfItem? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ToolDetailsDeprecated? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ToolDetailsDeprecatedToolkit? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.HookResult? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.HookResultVariant1? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.HookResultVariant1Status? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.HookResultVariant1Outcome? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.HookResultVariant2? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.HookResultVariant2Status? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ExecuteCompleted? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ExecuteCompletedResultType? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ExecuteCompletedInstantCharge? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ExecuteCompletedInstantChargeCurrency? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ExecuteCompletedInstantChargeChargedBy? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.HookResult>? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ExecuteFailed? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ExecuteFailedResultType? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ExecuteFailedInstantCharge? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ExecuteFailedInstantChargeCurrency? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ExecuteFailedInstantChargeChargedBy? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.BlockReason? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.BlockReasonVariant1? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.BlockReasonVariant1Type? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.BlockReasonVariant2? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.BlockReasonVariant2Type? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ExecuteBlocked? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ExecuteBlockedResultType? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ExecuteBlockedInstantCharge? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ExecuteBlockedInstantChargeCurrency? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ExecuteBlockedInstantChargeChargedBy? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.UserInputRequest? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.UserInputRequestType? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.UserInputRequestMode? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ExecuteRequiresUserInput? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ExecuteRequiresUserInputResultType? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Composio.UserInputRequest>? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.UserInputResponse? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.UserInputResponseAction? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ProxyExecuteCompleted? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ProxyExecuteCompletedResultType? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ProxyExecuteCompletedBinaryData? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ProxyExecuteBlocked? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ProxyExecuteBlockedResultType? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ToolRouterToolkitsListResponse? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.ToolRouterToolkitsListResponseItem>? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ToolRouterToolkitsListResponseItem? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ToolRouterToolkitsListResponseItemMeta? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ToolRouterToolkitsListResponseItemConnectedAccount? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ToolRouterToolkitsListResponseItemConnectedAccountAuthConfig? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostAuthConfigsRequest? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostAuthConfigsRequestToolkit? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.AuthConfig? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostAuthConfigsRequestAuthConfigDiscriminator? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostAuthConfigsRequestAuthConfigDiscriminatorType? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchAuthConfigsByNanoidRequest? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchAuthConfigsByNanoidRequestDiscriminator? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchAuthConfigsByNanoidRequestDiscriminatorType? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostCliCreateSessionRequest? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostCliCreateSessionRequestScope? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostCliCreateSessionRequestCodeChallengeMethod? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostCliCodactFailuresRequest? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostCliCodactFailuresRequestFailureType? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostCliCodactFailuresRequestToolInfo? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostCliCodactFailuresRequestToolInfoTool? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostCliRealtimeAuthRequest? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequest? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestAuthConfig? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnection? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant1? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant1AuthScheme? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant1ValVariant1? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant1ValVariant1Status? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant1ValVariant2? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant1ValVariant2Status? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant1ValVariant3? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant1ValVariant3Status? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant1ValVariant4? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant1ValVariant4Status? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant1ValVariant5? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant1ValVariant5Status? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant1ValVariant6? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant1ValVariant6Status? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant2? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant2AuthScheme? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant2ValVariant1? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant2ValVariant1Status? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant2ValVariant2? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant2ValVariant2Status? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant2ValVariant3? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant2ValVariant3Status? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.AnyOf<double?, string>? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant2ValVariant3AuthedUser? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant2ValVariant4? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant2ValVariant4Status? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant2ValVariant4AuthedUser? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant2ValVariant5? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant2ValVariant5Status? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant2ValVariant6? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant2ValVariant6Status? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant2ValVariant7? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant2ValVariant7Status? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant3? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant3AuthScheme? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant3ValVariant1? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant3ValVariant1Status? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant3ValVariant2? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant3ValVariant2Status? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant3ValVariant3? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant3ValVariant3Status? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant3ValVariant4? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant3ValVariant4Status? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant3ValVariant5? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant3ValVariant5Status? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant3ValVariant6? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant3ValVariant6Status? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant4? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant4AuthScheme? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant4ValVariant1? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant4ValVariant1Status? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant4ValVariant2? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant4ValVariant2Status? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant4ValVariant3? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant4ValVariant3Status? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant4ValVariant4? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant4ValVariant4Status? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant4ValVariant5? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant4ValVariant5Status? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant5? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant5AuthScheme? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant5ValVariant1? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant5ValVariant1Status? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant5ValVariant2? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant5ValVariant2Status? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant5ValVariant3? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant5ValVariant3Status? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant5ValVariant4? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant5ValVariant4Status? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant5ValVariant5? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant5ValVariant5Status? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant6? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant6AuthScheme? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant6ValVariant1? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant6ValVariant1Status? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant6ValVariant2? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant6ValVariant2Status? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant6ValVariant3? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant6ValVariant3Status? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant6ValVariant4? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant6ValVariant4Status? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant6ValVariant5? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant6ValVariant5Status? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant7? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant7AuthScheme? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant7ValVariant1? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant7ValVariant1Status? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant7ValVariant2? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant7ValVariant2Status? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant7ValVariant3? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant7ValVariant3Status? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant7ValVariant4? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant7ValVariant4Status? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant7ValVariant5? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant7ValVariant5Status? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant7ValVariant6? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant7ValVariant6Status? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant8? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant8AuthScheme? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant8ValVariant1? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant8ValVariant1Status? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant8ValVariant2? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant8ValVariant2Status? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant8ValVariant3? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant8ValVariant3Status? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant8ValVariant4? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant8ValVariant4Status? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant8ValVariant5? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant8ValVariant5Status? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant8ValVariant6? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant8ValVariant6Status? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant9? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant9AuthScheme? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant9ValVariant1? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant9ValVariant1Status? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant9ValVariant2? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant9ValVariant2Status? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant9ValVariant3? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant9ValVariant3Status? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant9ValVariant4? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant9ValVariant4Status? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant9ValVariant5? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant9ValVariant5Status? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant9ValVariant6? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant9ValVariant6Status? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant10? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant10AuthScheme? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant1? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant1Status? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant2? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant2Status? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant3? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant3Status? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant4? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant4Status? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant5? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant5Status? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant6? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant6Status? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant11? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant11AuthScheme? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant11ValVariant1? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant11ValVariant1Status? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant11ValVariant2? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant11ValVariant2Status? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant11ValVariant3? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant11ValVariant3Status? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant11ValVariant4? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant11ValVariant4Status? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant11ValVariant5? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant11ValVariant5Status? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant12? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant12AuthScheme? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant12ValVariant1? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant12ValVariant1Status? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant12ValVariant2? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant12ValVariant2Status? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant12ValVariant3? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant12ValVariant3Status? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant12ValVariant4? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant12ValVariant4Status? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant12ValVariant5? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant12ValVariant5Status? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant12ValVariant6? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant12ValVariant6Status? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant13? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant13AuthScheme? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant13ValVariant1? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant13ValVariant1Status? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant13ValVariant2? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant13ValVariant2Status? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant13ValVariant3? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant13ValVariant3Status? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant13ValVariant4? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant13ValVariant4Status? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant13ValVariant5? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant13ValVariant5Status? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant13ValVariant6? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant13ValVariant6Status? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant14? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant14AuthScheme? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant14ValVariant1? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant14ValVariant1Status? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant14ValVariant2? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant14ValVariant2Status? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant14ValVariant3? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant14ValVariant3Status? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant14ValVariant4? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant14ValVariant4Status? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant14ValVariant5? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant14ValVariant5Status? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant14ValVariant6? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant14ValVariant6Status? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant15? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant15AuthScheme? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant15ValVariant1? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant15ValVariant1Status? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant15ValVariant2? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant15ValVariant2Status? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant15ValVariant3? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant15ValVariant3Status? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant15ValVariant4? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant15ValVariant4Status? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant15ValVariant5? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant15ValVariant5Status? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant15ValVariant6? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant15ValVariant6Status? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionExperimental? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionExperimentalAccountType? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionExperimentalAclConfigForShared? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchConnectedAccountsByNanoIdStatusRequest? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsByNanoidRefreshRequest? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsLinkRequest? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsLinkRequestExperimental? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsLinkRequestExperimentalAccountType? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsLinkRequestExperimentalAclConfigForShared? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostInternalTriggerLogsRequest? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostInternalTriggerLogsRequestTime? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostInternalTriggerLogsRequestStatus? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostInternalTriggerLogsRequestSearchParam>? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostInternalTriggerLogsRequestSearchParam? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostInternalActionExecutionLogsRequest? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostInternalActionExecutionLogsRequestSearchParam>? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostInternalActionExecutionLogsRequestSearchParam? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostOrgOwnerProjectNewRequest? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostOrgOwnerProjectNewRequestApiKeyPermission>? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostOrgOwnerProjectNewRequestApiKeyPermission? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostOrgOwnerProjectNewRequestApiKeyPermissionPreset? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostOrgOwnerProjectNewRequestApiKeyPermissionAccess? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostOrgOwnerProjectNewRequestConfig? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostOrgOwnerProjectNewRequestConfigLogVisibilitySetting? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostWebhookSubscriptionsRequest? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostWebhookSubscriptionsRequestVersion? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchWebhookSubscriptionsByIdRequest? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchWebhookSubscriptionsByIdRequestVersion? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostWebhookEndpointsRequest? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostWebhookEndpointsByNanoIdRequest? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchWebhookEndpointsByNanoIdRequest? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostCustomToolkitsUpsertRequest? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostCustomToolkitsUpsertRequestToolkitConfig? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigLogoFile? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigLogoFileMimeType? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant1? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant1Mode? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2Mode? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2ApiKeyField? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2AdditionalFields? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2AdditionalFieldsGenericId? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant3? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant3Mode? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostCustomToolkitsSyncRequest? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolkitsMultiRequest? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolkitsMultiRequestManagedBy? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolkitsMultiRequestSortBy? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequest? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.AnyOf<global::Composio.PostToolsExecuteByToolSlugRequestConnectedAccountId?, string>? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestConnectedAccountId? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomAuthParams? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolsExecuteByToolSlugRequestCustomAuthParamsParameter>? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomAuthParamsParameter? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomAuthParamsParameterIn? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.AnyOf<string, double?>? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant1? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant1AuthScheme? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant1Val? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant1ValAuthedUser? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant2? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant2AuthScheme? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant2Val? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant3? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant3AuthScheme? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant3Val? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant4? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant4AuthScheme? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant4Val? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant5? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant5AuthScheme? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant5Val? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant6? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant6AuthScheme? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant6Val? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant7? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant7AuthScheme? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant7Val? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant8? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant8AuthScheme? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant8Val? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant9? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant9AuthScheme? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant9Val? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant10? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant10AuthScheme? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant10Val? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant11? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant11AuthScheme? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant11Val? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugInputRequest? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequest? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestMethod? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.AnyOf<global::Composio.PostToolsExecuteProxyRequestBinaryBodyVariant1, global::Composio.PostToolsExecuteProxyRequestBinaryBodyVariant2>? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestBinaryBodyVariant1? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestBinaryBodyVariant2? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolsExecuteProxyRequestParameter>? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestParameter? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestParameterType? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant1? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant1AuthScheme? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant1Val? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant1ValAuthedUser? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant2? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant2AuthScheme? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant2Val? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant3? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant3AuthScheme? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant3Val? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant4? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant4AuthScheme? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant4Val? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant5? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant5AuthScheme? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant5Val? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant6? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant6AuthScheme? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant6Val? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant7? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant7AuthScheme? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant7Val? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant8? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant8AuthScheme? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant8Val? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant9? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant9AuthScheme? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant9Val? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant10? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant10AuthScheme? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant10Val? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant11? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant11AuthScheme? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant11Val? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostTriggerInstancesBySlugUpsertRequest? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostTriggerInstancesBySlugUpsertRequestType? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.AnyOf<string, global::System.Collections.Generic.Dictionary<string, string>>? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchTriggerInstancesManageByTriggerIdRequest? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchTriggerInstancesManageByTriggerIdRequestStatus? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostMcpServersRequest? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostMcpServersCustomRequest? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostMcpServersGenerateRequest? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchMcpByIdRequest? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostMcpServersByServerIdInstancesRequest? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostFilesUploadRequestRequest? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequest? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestToolkitsVariant1? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestToolkitsVariant2? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestToolkitsVariant3? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.AnyOf<bool?, global::Composio.PostToolRouterSessionRequestInstant>? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestInstant? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.AnyOf<global::Composio.PostToolRouterSessionRequestInstantToolkitsVariant1, global::Composio.PostToolRouterSessionRequestInstantToolkitsVariant2>? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestInstantToolkitsVariant1? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestInstantToolkitsVariant2? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.AnyOf<global::Composio.PostToolRouterSessionRequestInstantToolsVariant1, global::Composio.PostToolRouterSessionRequestInstantToolsVariant2>? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestInstantToolsVariant1? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestInstantToolsVariant2? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestManageConnections? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestToolsVariant1? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestToolsVariant2? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestToolsVariant3? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.AnyOf<global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionRequestToolsVariant3Tag>, global::Composio.PostToolRouterSessionRequestToolsVariant3Tags>? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionRequestToolsVariant3Tag>? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestToolsVariant3Tag? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestToolsVariant3Tags? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionRequestToolsVariant3TagsEnableItem>? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestToolsVariant3TagsEnableItem? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionRequestToolsVariant3TagsDisableItem>? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestToolsVariant3TagsDisableItem? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionRequestToolsVariant3TagsRequireApprovalItem>? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestToolsVariant3TagsRequireApprovalItem? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestToolsVariant4? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.AnyOf<global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionRequestTag>, global::Composio.PostToolRouterSessionRequestTags>? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionRequestTag>? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestTag? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestTags? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionRequestTagsEnableItem>? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestTagsEnableItem? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionRequestTagsDisableItem>? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestTagsDisableItem? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionRequestTagsRequireApprovalItem>? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestTagsRequireApprovalItem? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestWorkbench? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestWorkbenchSandboxSize? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestProxyExecute? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestMultiAccount? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestExperimental? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestExperimentalAssistivePromptConfig? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionRequestExperimentalCustomToolkit>? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestExperimentalCustomToolkit? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionRequestExperimentalCustomToolkitTool>? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestExperimentalCustomToolkitTool? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionRequestExperimentalCustomTool>? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestExperimentalCustomTool? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestExperimentalPermissions? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestExperimentalPermissionsDefault? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Composio.PostToolRouterSessionRequestExperimentalPermissionsOverrides2>? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestExperimentalPermissionsOverrides2? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestExperimentalSubmitFeedback? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestExperimentalNoElicitationSupportFallback? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestPreload? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.OneOf<global::Composio.PostToolRouterSessionRequestHookVariant1, global::Composio.PostToolRouterSessionRequestHookVariant2>>? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.OneOf<global::Composio.PostToolRouterSessionRequestHookVariant1, global::Composio.PostToolRouterSessionRequestHookVariant2>? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestHookVariant1? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestHookVariant1Type? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.AnyOf<global::Composio.PostToolRouterSessionRequestHookVariant1AppliesToEnum?, global::Composio.PostToolRouterSessionRequestHookVariant1AppliesToEnum2>? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestHookVariant1AppliesToEnum? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestHookVariant1AppliesToEnum2? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestHookVariant1HandlerVariant1? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestHookVariant1HandlerVariant1Type? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestHookVariant1HandlerVariant1Action? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestHookVariant1HandlerVariant2? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestHookVariant1HandlerVariant2Type? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestHookVariant1HandlerVariant2FallbackAction? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestHookVariant2? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestHookVariant2Type? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.AnyOf<global::Composio.PostToolRouterSessionRequestHookVariant2AppliesToEnum?, global::Composio.PostToolRouterSessionRequestHookVariant2AppliesToEnum2>? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestHookVariant2AppliesToEnum? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestHookVariant2AppliesToEnum2? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestHookVariant2HandlerVariant1? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestHookVariant2HandlerVariant1Type? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestHookVariant2HandlerVariant1Action? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestHookVariant2HandlerVariant2? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestHookVariant2HandlerVariant2Type? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestHookVariant2HandlerVariant2Action? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestHookVariant2HandlerVariant3? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestHookVariant2HandlerVariant3Type? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestHookVariant2HandlerVariant3FallbackAction? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdExecuteRequest? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Composio.UserInputResponse>? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdExecuteMetaRequest? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdExecuteMetaRequestSlug? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequest? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestToolkitsVariant1? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestToolkitsVariant2? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestToolkitsVariant3? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.AnyOf<bool?, global::Composio.PatchToolRouterSessionBySessionIdRequestInstant>? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestInstant? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestInstantToolkitsVariant1? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestInstantToolkitsVariant2? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestInstantToolsVariant1? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestInstantToolsVariant2? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestManageConnections? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestToolsVariant1? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestToolsVariant2? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestToolsVariant3? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PatchToolRouterSessionBySessionIdRequestToolsVariant3Tag>? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestToolsVariant3Tag? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestToolsVariant3Tags? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsEnableItem>? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsEnableItem? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsDisableItem>? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsDisableItem? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsRequireApprovalItem>? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsRequireApprovalItem? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestToolsVariant4? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.AnyOf<global::System.Collections.Generic.IList<global::Composio.PatchToolRouterSessionBySessionIdRequestTag>, global::Composio.PatchToolRouterSessionBySessionIdRequestTags>? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PatchToolRouterSessionBySessionIdRequestTag>? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestTag? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestTags? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PatchToolRouterSessionBySessionIdRequestTagsEnableItem>? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestTagsEnableItem? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PatchToolRouterSessionBySessionIdRequestTagsDisableItem>? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestTagsDisableItem? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PatchToolRouterSessionBySessionIdRequestTagsRequireApprovalItem>? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestTagsRequireApprovalItem? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestWorkbench? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestWorkbenchSandboxSize? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestMultiAccount? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestProxyExecute? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestPreload? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.OneOf<global::Composio.PatchToolRouterSessionBySessionIdRequestHookVariant1, global::Composio.PatchToolRouterSessionBySessionIdRequestHookVariant2>? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestHookVariant1? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestHookVariant1Type? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestHookVariant1AppliesToEnum? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestHookVariant1AppliesToEnum2? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestHookVariant1HandlerVariant1? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestHookVariant1HandlerVariant1Type? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestHookVariant1HandlerVariant1Action? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestHookVariant1HandlerVariant2? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestHookVariant1HandlerVariant2Type? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestHookVariant1HandlerVariant2FallbackAction? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestHookVariant2? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestHookVariant2Type? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestHookVariant2AppliesToEnum? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestHookVariant2AppliesToEnum2? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestHookVariant2HandlerVariant1? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestHookVariant2HandlerVariant1Type? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestHookVariant2HandlerVariant1Action? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestHookVariant2HandlerVariant2? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestHookVariant2HandlerVariant2Type? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestHookVariant2HandlerVariant2Action? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestHookVariant2HandlerVariant3? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestHookVariant2HandlerVariant3Type? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestHookVariant2HandlerVariant3FallbackAction? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestExperimental? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestExperimentalPermissions? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestExperimentalPermissionsDefault? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Composio.PatchToolRouterSessionBySessionIdRequestExperimentalPermissionsOverrides2>? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestExperimentalPermissionsOverrides2? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestExperimentalSubmitFeedback? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestExperimentalNoElicitationSupportFallback? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdLinkRequest? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdLinkRequestExperimental? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdLinkRequestExperimentalAccountType? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdLinkRequestExperimentalAclConfigForShared? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequest? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestMethod? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestBinaryBodyVariant1? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestBinaryBodyVariant2? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestParameter>? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestParameter? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestParameterType? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant1? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant1AuthScheme? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant1Val? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant1ValAuthedUser? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant2? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant2AuthScheme? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant2Val? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant3? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant3AuthScheme? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant3Val? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant4? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant4AuthScheme? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant4Val? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant5? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant5AuthScheme? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant5Val? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant6? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant6AuthScheme? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant6Val? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant7? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant7AuthScheme? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant7Val? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant8? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant8AuthScheme? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant8Val? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant9? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant9AuthScheme? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant9Val? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant10? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant10AuthScheme? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant10Val? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant11? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant11AuthScheme? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant11Val? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdSearchRequest? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionBySessionIdSearchRequestQuerie>? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdSearchRequestQuerie? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdSearchRequestSearchStrategy? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdMountsByMountIdDownloadUrlRequest? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdMountsByMountIdUploadUrlRequest? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdMountsByMountIdDeleteRequest? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.AnyOf<string, bool?>? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchAuthConfigsByNanoidByStatusStatus? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetConnectedAccountsStatuse>? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsStatuse? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsOrderBy? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsOrderDirection? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsAccountType? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsManagedBy? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsType? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsSortBy? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.OneOf<string, global::System.Collections.Generic.IList<string>>? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolsImportant? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.OneOf<string, global::System.Collections.Generic.Dictionary<string, string>>? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetMcpServersOrderBy? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetMcpServersOrderDirection? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetMcpAppByAppKeyOrderBy? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetMcpAppByAppKeyOrderDirection? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetMcpServersByServerIdInstancesOrderBy? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetMcpServersByServerIdInstancesOrderDirection? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetAuthSessionInfoResponse? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetAuthSessionInfoResponseProject? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetAuthSessionInfoResponseProjectWebhookVersion? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetAuthSessionInfoResponseProjectOrg? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetAuthSessionInfoResponseApiKey? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetAuthSessionInfoResponseOrgMember? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetAuthSessionInfoResponseOrgMemberMetadata? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.AnyOf<string, bool?, double?>? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetAuthSessionInfoResponseOrgMemberMetadataOnboardingPlatform? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostAuthConfigsResponse? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostAuthConfigsResponseToolkit? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostAuthConfigsResponseAuthConfig? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetAuthConfigsResponse? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetAuthConfigsResponseItem>? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetAuthConfigsResponseItem? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetAuthConfigsResponseItemType? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetAuthConfigsResponseItemToolkit? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetAuthConfigsResponseItemAuthScheme? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetAuthConfigsResponseItemProxyConfig? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetAuthConfigsResponseItemStatus? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetAuthConfigsResponseItemExpectedInputField>? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetAuthConfigsResponseItemExpectedInputField? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetAuthConfigsResponseItemToolAccessConfig? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetAuthConfigsByNanoidResponse? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetAuthConfigsByNanoidResponseType? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetAuthConfigsByNanoidResponseToolkit? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetAuthConfigsByNanoidResponseAuthScheme? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetAuthConfigsByNanoidResponseProxyConfig? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetAuthConfigsByNanoidResponseStatus? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetAuthConfigsByNanoidResponseExpectedInputField>? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetAuthConfigsByNanoidResponseExpectedInputField? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetAuthConfigsByNanoidResponseToolAccessConfig? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchAuthConfigsByNanoidResponse? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.DeleteAuthConfigsByNanoidResponse? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchAuthConfigsByNanoidByStatusResponse? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostCliCreateSessionResponse? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostCliCreateSessionResponseStatus? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostCliCreateSessionResponseScope? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostCliCreateSessionResponseCodeChallengeMethod? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostCliCodactFailuresResponse? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetCliGetSessionResponse? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetCliGetSessionResponseStatus? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetCliGetSessionResponseAccount? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetCliGetSessionResponseScope? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetCliRealtimeCredentialsResponse? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostCliRealtimeAuthResponse? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponse? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetConnectedAccountsResponseItem>? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItem? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemToolkit? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemAuthConfig? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemAuthConfigAuthScheme? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemAuthScheme? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStatus? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemExperimental? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemExperimentalAccountType? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemExperimentalAclConfigForShared? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant1? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant1AuthScheme? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant1ValVariant1? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant1ValVariant1Status? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant1ValVariant2? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant1ValVariant2Status? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant1ValVariant3? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant1ValVariant3Status? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant1ValVariant4? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant1ValVariant4Status? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant1ValVariant5? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant1ValVariant5Status? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant1ValVariant6? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant1ValVariant6Status? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant2? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant2AuthScheme? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant1? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant1Status? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant2? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant2Status? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant3? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant3Status? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant3AuthedUser? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant4? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant4Status? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant4AuthedUser? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant5? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant5Status? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant6? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant6Status? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant7? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant7Status? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant3? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant3AuthScheme? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant3ValVariant1? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant3ValVariant1Status? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant3ValVariant2? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant3ValVariant2Status? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant3ValVariant3? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant3ValVariant3Status? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant3ValVariant4? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant3ValVariant4Status? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant3ValVariant5? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant3ValVariant5Status? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant3ValVariant6? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant3ValVariant6Status? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant4? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant4AuthScheme? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant4ValVariant1? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant4ValVariant1Status? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant4ValVariant2? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant4ValVariant2Status? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant4ValVariant3? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant4ValVariant3Status? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant4ValVariant4? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant4ValVariant4Status? Type822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant4ValVariant5? Type823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant4ValVariant5Status? Type824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant5? Type825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant5AuthScheme? Type826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant5ValVariant1? Type827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant5ValVariant1Status? Type828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant5ValVariant2? Type829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant5ValVariant2Status? Type830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant5ValVariant3? Type831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant5ValVariant3Status? Type832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant5ValVariant4? Type833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant5ValVariant4Status? Type834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant5ValVariant5? Type835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant5ValVariant5Status? Type836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant6? Type837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant6AuthScheme? Type838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant6ValVariant1? Type839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant6ValVariant1Status? Type840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant6ValVariant2? Type841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant6ValVariant2Status? Type842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant6ValVariant3? Type843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant6ValVariant3Status? Type844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant6ValVariant4? Type845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant6ValVariant4Status? Type846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant6ValVariant5? Type847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant6ValVariant5Status? Type848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant7? Type849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant7AuthScheme? Type850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant7ValVariant1? Type851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant7ValVariant1Status? Type852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant7ValVariant2? Type853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant7ValVariant2Status? Type854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant7ValVariant3? Type855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant7ValVariant3Status? Type856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant7ValVariant4? Type857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant7ValVariant4Status? Type858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant7ValVariant5? Type859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant7ValVariant5Status? Type860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant7ValVariant6? Type861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant7ValVariant6Status? Type862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant8? Type863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant8AuthScheme? Type864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant1? Type865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant1Status? Type866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant2? Type867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant2Status? Type868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant3? Type869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant3Status? Type870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant4? Type871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant4Status? Type872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant5? Type873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant5Status? Type874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant6? Type875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant6Status? Type876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant9? Type877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant9AuthScheme? Type878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant1? Type879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant1Status? Type880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant2? Type881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant2Status? Type882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant3? Type883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant3Status? Type884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant4? Type885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant4Status? Type886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant5? Type887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant5Status? Type888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant6? Type889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant6Status? Type890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant10? Type891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant10AuthScheme? Type892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant10ValVariant1? Type893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant10ValVariant1Status? Type894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant10ValVariant2? Type895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant10ValVariant2Status? Type896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant10ValVariant3? Type897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant10ValVariant3Status? Type898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant10ValVariant4? Type899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant10ValVariant4Status? Type900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant10ValVariant5? Type901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant10ValVariant5Status? Type902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant10ValVariant6? Type903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant10ValVariant6Status? Type904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant11? Type905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant11AuthScheme? Type906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant11ValVariant1? Type907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant11ValVariant1Status? Type908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant11ValVariant2? Type909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant11ValVariant2Status? Type910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant11ValVariant3? Type911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant11ValVariant3Status? Type912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant11ValVariant4? Type913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant11ValVariant4Status? Type914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant11ValVariant5? Type915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant11ValVariant5Status? Type916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant12? Type917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant12AuthScheme? Type918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant12ValVariant1? Type919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant12ValVariant1Status? Type920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant12ValVariant2? Type921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant12ValVariant2Status? Type922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant12ValVariant3? Type923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant12ValVariant3Status? Type924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant12ValVariant4? Type925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant12ValVariant4Status? Type926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant12ValVariant5? Type927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant12ValVariant5Status? Type928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant12ValVariant6? Type929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant12ValVariant6Status? Type930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant13? Type931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant13AuthScheme? Type932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant13ValVariant1? Type933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant13ValVariant1Status? Type934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant13ValVariant2? Type935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant13ValVariant2Status? Type936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant13ValVariant3? Type937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant13ValVariant3Status? Type938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant13ValVariant4? Type939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant13ValVariant4Status? Type940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant13ValVariant5? Type941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant13ValVariant5Status? Type942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant13ValVariant6? Type943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant13ValVariant6Status? Type944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant14? Type945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant14AuthScheme? Type946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant1? Type947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant1Status? Type948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant2? Type949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant2Status? Type950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant3? Type951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant3Status? Type952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant4? Type953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant4Status? Type954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant5? Type955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant5Status? Type956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant6? Type957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant6Status? Type958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant15? Type959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant15AuthScheme? Type960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant15ValVariant1? Type961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant15ValVariant1Status? Type962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant15ValVariant2? Type963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant15ValVariant2Status? Type964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant15ValVariant3? Type965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant15ValVariant3Status? Type966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant15ValVariant4? Type967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant15ValVariant4Status? Type968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant15ValVariant5? Type969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant15ValVariant5Status? Type970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant15ValVariant6? Type971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant15ValVariant6Status? Type972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponse? Type973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant1? Type974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant1AuthScheme? Type975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant1? Type976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant1Status? Type977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant2? Type978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant2Status? Type979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant3? Type980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant3Status? Type981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant4? Type982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant4Status? Type983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant5? Type984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant5Status? Type985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant6? Type986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant6Status? Type987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant2? Type988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant2AuthScheme? Type989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant1? Type990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant1Status? Type991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant2? Type992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant2Status? Type993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant3? Type994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant3Status? Type995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant3AuthedUser? Type996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant4? Type997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant4Status? Type998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant4AuthedUser? Type999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant5? Type1000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant5Status? Type1001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant6? Type1002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant6Status? Type1003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant7? Type1004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant7Status? Type1005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant3? Type1006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant3AuthScheme? Type1007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant3ValVariant1? Type1008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant3ValVariant1Status? Type1009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant3ValVariant2? Type1010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant3ValVariant2Status? Type1011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant3ValVariant3? Type1012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant3ValVariant3Status? Type1013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant3ValVariant4? Type1014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant3ValVariant4Status? Type1015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant3ValVariant5? Type1016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant3ValVariant5Status? Type1017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant3ValVariant6? Type1018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant3ValVariant6Status? Type1019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant4? Type1020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant4AuthScheme? Type1021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant4ValVariant1? Type1022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant4ValVariant1Status? Type1023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant4ValVariant2? Type1024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant4ValVariant2Status? Type1025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant4ValVariant3? Type1026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant4ValVariant3Status? Type1027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant4ValVariant4? Type1028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant4ValVariant4Status? Type1029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant4ValVariant5? Type1030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant4ValVariant5Status? Type1031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant5? Type1032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant5AuthScheme? Type1033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant5ValVariant1? Type1034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant5ValVariant1Status? Type1035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant5ValVariant2? Type1036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant5ValVariant2Status? Type1037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant5ValVariant3? Type1038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant5ValVariant3Status? Type1039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant5ValVariant4? Type1040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant5ValVariant4Status? Type1041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant5ValVariant5? Type1042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant5ValVariant5Status? Type1043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant6? Type1044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant6AuthScheme? Type1045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant6ValVariant1? Type1046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant6ValVariant1Status? Type1047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant6ValVariant2? Type1048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant6ValVariant2Status? Type1049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant6ValVariant3? Type1050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant6ValVariant3Status? Type1051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant6ValVariant4? Type1052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant6ValVariant4Status? Type1053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant6ValVariant5? Type1054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant6ValVariant5Status? Type1055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant7? Type1056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant7AuthScheme? Type1057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant1? Type1058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant1Status? Type1059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant2? Type1060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant2Status? Type1061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant3? Type1062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant3Status? Type1063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant4? Type1064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant4Status? Type1065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant5? Type1066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant5Status? Type1067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant6? Type1068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant6Status? Type1069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant8? Type1070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant8AuthScheme? Type1071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant8ValVariant1? Type1072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant8ValVariant1Status? Type1073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant8ValVariant2? Type1074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant8ValVariant2Status? Type1075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant8ValVariant3? Type1076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant8ValVariant3Status? Type1077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant8ValVariant4? Type1078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant8ValVariant4Status? Type1079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant8ValVariant5? Type1080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant8ValVariant5Status? Type1081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant8ValVariant6? Type1082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant8ValVariant6Status? Type1083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant9? Type1084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant9AuthScheme? Type1085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant1? Type1086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant1Status? Type1087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant2? Type1088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant2Status? Type1089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant3? Type1090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant3Status? Type1091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant4? Type1092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant4Status? Type1093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant5? Type1094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant5Status? Type1095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant6? Type1096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant6Status? Type1097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant10? Type1098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant10AuthScheme? Type1099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant10ValVariant1? Type1100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant10ValVariant1Status? Type1101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant10ValVariant2? Type1102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant10ValVariant2Status? Type1103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant10ValVariant3? Type1104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant10ValVariant3Status? Type1105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant10ValVariant4? Type1106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant10ValVariant4Status? Type1107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant10ValVariant5? Type1108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant10ValVariant5Status? Type1109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant10ValVariant6? Type1110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant10ValVariant6Status? Type1111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant11? Type1112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant11AuthScheme? Type1113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant11ValVariant1? Type1114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant11ValVariant1Status? Type1115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant11ValVariant2? Type1116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant11ValVariant2Status? Type1117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant11ValVariant3? Type1118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant11ValVariant3Status? Type1119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant11ValVariant4? Type1120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant11ValVariant4Status? Type1121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant11ValVariant5? Type1122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant11ValVariant5Status? Type1123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant12? Type1124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant12AuthScheme? Type1125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant12ValVariant1? Type1126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant12ValVariant1Status? Type1127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant12ValVariant2? Type1128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant12ValVariant2Status? Type1129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant12ValVariant3? Type1130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant12ValVariant3Status? Type1131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant12ValVariant4? Type1132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant12ValVariant4Status? Type1133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant12ValVariant5? Type1134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant12ValVariant5Status? Type1135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant12ValVariant6? Type1136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant12ValVariant6Status? Type1137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant13? Type1138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant13AuthScheme? Type1139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant13ValVariant1? Type1140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant13ValVariant1Status? Type1141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant13ValVariant2? Type1142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant13ValVariant2Status? Type1143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant13ValVariant3? Type1144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant13ValVariant3Status? Type1145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant13ValVariant4? Type1146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant13ValVariant4Status? Type1147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant13ValVariant5? Type1148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant13ValVariant5Status? Type1149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant13ValVariant6? Type1150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant13ValVariant6Status? Type1151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant14? Type1152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant14AuthScheme? Type1153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant14ValVariant1? Type1154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant14ValVariant1Status? Type1155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant14ValVariant2? Type1156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant14ValVariant2Status? Type1157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant14ValVariant3? Type1158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant14ValVariant3Status? Type1159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant14ValVariant4? Type1160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant14ValVariant4Status? Type1161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant14ValVariant5? Type1162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant14ValVariant5Status? Type1163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant14ValVariant6? Type1164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant14ValVariant6Status? Type1165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant15? Type1166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant15AuthScheme? Type1167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant15ValVariant1? Type1168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant15ValVariant1Status? Type1169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant15ValVariant2? Type1170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant15ValVariant2Status? Type1171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant15ValVariant3? Type1172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant15ValVariant3Status? Type1173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant15ValVariant4? Type1174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant15ValVariant4Status? Type1175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant15ValVariant5? Type1176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant15ValVariant5Status? Type1177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant15ValVariant6? Type1178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant15ValVariant6Status? Type1179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseStatus? Type1180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseExperimental? Type1181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseExperimentalAccountType? Type1182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseExperimentalAclConfigForShared? Type1183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponse? Type1184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseToolkit? Type1185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseAuthConfig? Type1186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseAuthConfigAuthScheme? Type1187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseAuthScheme? Type1188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStatus? Type1189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseExperimental? Type1190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseExperimentalAccountType? Type1191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseExperimentalAclConfigForShared? Type1192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant1? Type1193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant1AuthScheme? Type1194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant1? Type1195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant1Status? Type1196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant2? Type1197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant2Status? Type1198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant3? Type1199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant3Status? Type1200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant4? Type1201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant4Status? Type1202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant5? Type1203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant5Status? Type1204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant6? Type1205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant6Status? Type1206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2? Type1207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2AuthScheme? Type1208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant1? Type1209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant1Status? Type1210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant2? Type1211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant2Status? Type1212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant3? Type1213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant3Status? Type1214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant3AuthedUser? Type1215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant4? Type1216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant4Status? Type1217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant4AuthedUser? Type1218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant5? Type1219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant5Status? Type1220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant6? Type1221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant6Status? Type1222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant7? Type1223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant7Status? Type1224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant3? Type1225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant3AuthScheme? Type1226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant1? Type1227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant1Status? Type1228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant2? Type1229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant2Status? Type1230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant3? Type1231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant3Status? Type1232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant4? Type1233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant4Status? Type1234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant5? Type1235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant5Status? Type1236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant6? Type1237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant6Status? Type1238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant4? Type1239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant4AuthScheme? Type1240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant4ValVariant1? Type1241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant4ValVariant1Status? Type1242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant4ValVariant2? Type1243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant4ValVariant2Status? Type1244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant4ValVariant3? Type1245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant4ValVariant3Status? Type1246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant4ValVariant4? Type1247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant4ValVariant4Status? Type1248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant4ValVariant5? Type1249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant4ValVariant5Status? Type1250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant5? Type1251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant5AuthScheme? Type1252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant1? Type1253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant1Status? Type1254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant2? Type1255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant2Status? Type1256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant3? Type1257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant3Status? Type1258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant4? Type1259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant4Status? Type1260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant5? Type1261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant5Status? Type1262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6? Type1263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6AuthScheme? Type1264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant1? Type1265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant1Status? Type1266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant2? Type1267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant2Status? Type1268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant3? Type1269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant3Status? Type1270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant4? Type1271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant4Status? Type1272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant5? Type1273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant5Status? Type1274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant7? Type1275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant7AuthScheme? Type1276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant1? Type1277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant1Status? Type1278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant2? Type1279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant2Status? Type1280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant3? Type1281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant3Status? Type1282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant4? Type1283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant4Status? Type1284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant5? Type1285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant5Status? Type1286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant6? Type1287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant6Status? Type1288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8? Type1289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8AuthScheme? Type1290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant1? Type1291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant1Status? Type1292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant2? Type1293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant2Status? Type1294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant3? Type1295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant3Status? Type1296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant4? Type1297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant4Status? Type1298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant5? Type1299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant5Status? Type1300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant6? Type1301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant6Status? Type1302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant9? Type1303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant9AuthScheme? Type1304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant1? Type1305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant1Status? Type1306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant2? Type1307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant2Status? Type1308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant3? Type1309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant3Status? Type1310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant4? Type1311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant4Status? Type1312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant5? Type1313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant5Status? Type1314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant6? Type1315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant6Status? Type1316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant10? Type1317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant10AuthScheme? Type1318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant1? Type1319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant1Status? Type1320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant2? Type1321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant2Status? Type1322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant3? Type1323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant3Status? Type1324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant4? Type1325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant4Status? Type1326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant5? Type1327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant5Status? Type1328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant6? Type1329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant6Status? Type1330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant11? Type1331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant11AuthScheme? Type1332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant1? Type1333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant1Status? Type1334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant2? Type1335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant2Status? Type1336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant3? Type1337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant3Status? Type1338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant4? Type1339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant4Status? Type1340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant5? Type1341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant5Status? Type1342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant12? Type1343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant12AuthScheme? Type1344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant1? Type1345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant1Status? Type1346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant2? Type1347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant2Status? Type1348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant3? Type1349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant3Status? Type1350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant4? Type1351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant4Status? Type1352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant5? Type1353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant5Status? Type1354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant6? Type1355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant6Status? Type1356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant13? Type1357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant13AuthScheme? Type1358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant1? Type1359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant1Status? Type1360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant2? Type1361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant2Status? Type1362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant3? Type1363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant3Status? Type1364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant4? Type1365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant4Status? Type1366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant5? Type1367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant5Status? Type1368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant6? Type1369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant6Status? Type1370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant14? Type1371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant14AuthScheme? Type1372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant1? Type1373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant1Status? Type1374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant2? Type1375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant2Status? Type1376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant3? Type1377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant3Status? Type1378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant4? Type1379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant4Status? Type1380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant5? Type1381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant5Status? Type1382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant6? Type1383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant6Status? Type1384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant15? Type1385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant15AuthScheme? Type1386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant15ValVariant1? Type1387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant15ValVariant1Status? Type1388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant15ValVariant2? Type1389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant15ValVariant2Status? Type1390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant15ValVariant3? Type1391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant15ValVariant3Status? Type1392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant15ValVariant4? Type1393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant15ValVariant4Status? Type1394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant15ValVariant5? Type1395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant15ValVariant5Status? Type1396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant15ValVariant6? Type1397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant15ValVariant6Status? Type1398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.DeleteConnectedAccountsByNanoidResponse? Type1399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchConnectedAccountsByNanoidResponse? Type1400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchConnectedAccountsByNanoIdStatusResponse? Type1401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsByNanoidRefreshResponse? Type1402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsByNanoidRefreshResponseStatus? Type1403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsLinkResponse? Type1404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsLinkResponseExperimental? Type1405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsLinkResponseExperimentalAccountType? Type1406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsLinkResponseExperimentalAclConfigForShared? Type1407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostInternalTriggerLogsResponse? Type1408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostInternalTriggerLogsResponseDataItem>? Type1409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostInternalTriggerLogsResponseDataItem? Type1410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostInternalTriggerLogsResponseDataItemType? Type1411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostInternalTriggerLogsResponseDataItemMeta? Type1412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostInternalTriggerLogsResponseDataItemMetaType? Type1413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetInternalTriggerLogByIdResponse? Type1414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetInternalTriggerLogByIdResponseLog? Type1415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetInternalTriggerLogByIdResponseLogType? Type1416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetInternalTriggerLogByIdResponseLogMeta? Type1417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetInternalTriggerLogByIdResponseLogMetaType? Type1418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostInternalActionExecutionLogsResponse? Type1419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostInternalActionExecutionLogsResponseDataItem>? Type1420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostInternalActionExecutionLogsResponseDataItem? Type1421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostInternalActionExecutionLogsResponseDataItemApp? Type1422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostInternalActionExecutionLogsResponseDataItemStatus? Type1423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostInternalActionExecutionLogsResponseDataItemMetadata? Type1424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostInternalActionExecutionLogsResponseDataItemCredentialSource? Type1425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetInternalActionExecutionFieldsResponse? Type1426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Composio.GetInternalActionExecutionFieldsResponseField>>? Type1427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetInternalActionExecutionFieldsResponseField>? Type1428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetInternalActionExecutionFieldsResponseField? Type1429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetInternalActionExecutionLogByIdResponse? Type1430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetInternalActionExecutionLogByIdResponseStatus? Type1431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetInternalActionExecutionLogByIdResponseApp? Type1432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetInternalActionExecutionLogByIdResponseConnection? Type1433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetInternalActionExecutionLogByIdResponseCredentialSource? Type1434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetInternalActionExecutionLogByIdResponseStep>? Type1435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetInternalActionExecutionLogByIdResponseStep? Type1436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetInternalActionExecutionLogByIdResponseStepType? Type1437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetInternalActionExecutionLogByIdResponseStepStatus? Type1438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetInternalActionExecutionLogByIdResponseStepMetadata? Type1439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetInternalActionExecutionLogByIdResponseStepLog>? Type1440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetInternalActionExecutionLogByIdResponseStepLog? Type1441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetInternalActionExecutionLogByIdResponseStepLogType? Type1442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetInternalActionExecutionLogByIdResponseStepLogRequest? Type1443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetInternalActionExecutionLogByIdResponseStepLogResponse? Type1444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetOrgListResponse? Type1445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetOrgListResponseOrganization>? Type1446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetOrgListResponseOrganization? Type1447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetOrgProjectListResponse? Type1448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetOrgProjectListResponseDataItem>? Type1449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetOrgProjectListResponseDataItem? Type1450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetOrgProjectListResponseDataItemWebhookVersion? Type1451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostOrgOwnerProjectNewResponse? Type1452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetOrgOwnerProjectListResponse? Type1453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetOrgOwnerProjectListResponseDataItem>? Type1454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetOrgOwnerProjectListResponseDataItem? Type1455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetOrgOwnerProjectListResponseDataItemWebhookVersion? Type1456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetOrgOwnerProjectByNanoIdResponse? Type1457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetOrgOwnerProjectByNanoIdResponseWebhookVersion? Type1458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetOrgOwnerProjectByNanoIdResponseApiKey>? Type1459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetOrgOwnerProjectByNanoIdResponseApiKey? Type1460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.DeleteOrgOwnerProjectByNanoIdResponse? Type1461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.DeleteOrgOwnerProjectByNanoIdResponseStatus? Type1462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostOrgOwnerProjectByNanoIdRegenerateApiKeyResponse? Type1463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostOrgOwnerProjectByNanoIdRegenerateApiKeyResponseApiKey? Type1464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostOrgConsumerProjectResolveResponse? Type1465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostOrgConsumerProjectResolveResponseProjectType? Type1466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostOrgConsumerProjectResolveResponseConfig? Type1467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetOrgConsumerConnectedToolkitsResponse? Type1468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostWebhookSubscriptionsResponse? Type1469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostWebhookSubscriptionsResponseVersion? Type1470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetWebhookSubscriptionsResponse? Type1471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetWebhookSubscriptionsResponseItem>? Type1472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetWebhookSubscriptionsResponseItem? Type1473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetWebhookSubscriptionsResponseItemVersion? Type1474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetWebhookSubscriptionsByIdResponse? Type1475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetWebhookSubscriptionsByIdResponseVersion? Type1476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchWebhookSubscriptionsByIdResponse? Type1477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchWebhookSubscriptionsByIdResponseVersion? Type1478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.DeleteWebhookSubscriptionsByIdResponse? Type1479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostWebhookSubscriptionsByIdRotateSecretResponse? Type1480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetWebhookSubscriptionsEventTypesResponse? Type1481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetWebhookSubscriptionsEventTypesResponseItem>? Type1482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetWebhookSubscriptionsEventTypesResponseItem? Type1483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetWebhookSubscriptionsEventTypesResponseItemSupportedVersion>? Type1484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetWebhookSubscriptionsEventTypesResponseItemSupportedVersion? Type1485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostWebhookEndpointsResponse? Type1486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetWebhookEndpointsResponse? Type1487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetWebhookEndpointsResponseItem>? Type1488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetWebhookEndpointsResponseItem? Type1489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetWebhookEndpointsByNanoIdResponse? Type1490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostWebhookEndpointsByNanoIdResponse? Type1491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchWebhookEndpointsByNanoIdResponse? Type1492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsResponse? Type1493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetToolkitsResponseItem>? Type1494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsResponseItem? Type1495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsResponseItemType? Type1496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsResponseItemToolkitType? Type1497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsResponseItemInstant? Type1498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsResponseItemAccess? Type1499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsResponseItemMeta? Type1500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetToolkitsResponseItemMetaCategorie>? Type1501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsResponseItemMetaCategorie? Type1502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsCategoriesResponse? Type1503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetToolkitsCategoriesResponseItem>? Type1504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsCategoriesResponseItem? Type1505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostCustomToolkitsUpsertResponse? Type1506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostCustomToolkitsSyncResponse? Type1507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsBySlugResponse? Type1508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsBySlugResponseType? Type1509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsBySlugResponseToolkitType? Type1510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsBySlugResponseInstant? Type1511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsBySlugResponseAccess? Type1512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetToolkitsBySlugResponseComposioManagedAuthItem>? Type1513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsBySlugResponseComposioManagedAuthItem? Type1514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsBySlugResponseComposioManagedAuthItemScopes? Type1515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsBySlugResponseComposioManagedAuthItemUserScopes? Type1516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetToolkitsBySlugResponseAuthConfigDetail>? Type1517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsBySlugResponseAuthConfigDetail? Type1518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsBySlugResponseAuthConfigDetailMode? Type1519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsBySlugResponseAuthConfigDetailFields? Type1520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsBySlugResponseAuthConfigDetailFieldsAuthConfigCreation? Type1521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetToolkitsBySlugResponseAuthConfigDetailFieldsAuthConfigCreationRequiredItem>? Type1522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsBySlugResponseAuthConfigDetailFieldsAuthConfigCreationRequiredItem? Type1523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetToolkitsBySlugResponseAuthConfigDetailFieldsAuthConfigCreationOptionalItem>? Type1524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsBySlugResponseAuthConfigDetailFieldsAuthConfigCreationOptionalItem? Type1525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsBySlugResponseAuthConfigDetailFieldsConnectedAccountInitiation? Type1526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetToolkitsBySlugResponseAuthConfigDetailFieldsConnectedAccountInitiationRequiredItem>? Type1527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsBySlugResponseAuthConfigDetailFieldsConnectedAccountInitiationRequiredItem? Type1528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetToolkitsBySlugResponseAuthConfigDetailFieldsConnectedAccountInitiationOptionalItem>? Type1529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsBySlugResponseAuthConfigDetailFieldsConnectedAccountInitiationOptionalItem? Type1530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsBySlugResponseAuthConfigDetailProxy? Type1531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsBySlugResponseAuthConfigDetailDeprecatedAuthProviderDetails? Type1532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsBySlugResponseMeta? Type1533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetToolkitsBySlugResponseMetaCategorie>? Type1534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsBySlugResponseMetaCategorie? Type1535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsBySlugResponseDeprecated? Type1536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, object?>>? Type1537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolkitsMultiResponse? Type1538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolkitsMultiResponseItem>? Type1539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolkitsMultiResponseItem? Type1540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolkitsMultiResponseItemType? Type1541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolkitsMultiResponseItemToolkitType? Type1542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolkitsMultiResponseItemInstant? Type1543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolkitsMultiResponseItemAccess? Type1544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolkitsMultiResponseItemMeta? Type1545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolkitsMultiResponseItemMetaCategorie>? Type1546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolkitsMultiResponseItemMetaCategorie? Type1547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugResponse? Type1548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugInputResponse? Type1549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyResponse? Type1550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyResponseBinaryData? Type1551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostTriggerInstancesBySlugUpsertResponse? Type1552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostTriggerInstancesBySlugUpsertResponseType? Type1553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetTriggerInstancesActiveResponse? Type1554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetTriggerInstancesActiveResponseItem>? Type1555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetTriggerInstancesActiveResponseItem? Type1556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetTriggerInstancesActiveResponseItemType? Type1557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetTriggerInstancesActiveResponseItemDeprecated? Type1558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.DeleteTriggerInstancesManageByTriggerIdResponse? Type1559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchTriggerInstancesManageByTriggerIdResponse? Type1560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchTriggerInstancesManageByTriggerIdResponseStatus? Type1561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetTriggersTypesBySlugResponse? Type1562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetTriggersTypesBySlugResponseType? Type1563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetTriggersTypesBySlugResponseType>? Type1564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetTriggersTypesBySlugResponseToolkit? Type1565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetTriggersTypesResponse? Type1566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetTriggersTypesResponseItem>? Type1567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetTriggersTypesResponseItem? Type1568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetTriggersTypesResponseItemType? Type1569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetTriggersTypesResponseItemType>? Type1570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetTriggersTypesResponseItemToolkit? Type1571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetMcpServersResponse? Type1572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetMcpServersResponseItem>? Type1573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetMcpServersResponseItem? Type1574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetMcpServersResponseItemCommands? Type1575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostMcpServersResponse? Type1576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostMcpServersResponseCommands? Type1577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostMcpServersCustomResponse? Type1578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostMcpServersCustomResponseCommands? Type1579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostMcpServersGenerateResponse? Type1580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetMcpByIdResponse? Type1581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetMcpByIdResponseCommands? Type1582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchMcpByIdResponse? Type1583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchMcpByIdResponseCommands? Type1584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.DeleteMcpByIdResponse? Type1585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetMcpAppByAppKeyResponse? Type1586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetMcpAppByAppKeyResponseItem>? Type1587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetMcpAppByAppKeyResponseItem? Type1588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetMcpAppByAppKeyResponseItemCommands? Type1589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetMcpServersByServerIdInstancesResponse? Type1590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetMcpServersByServerIdInstancesResponseInstance>? Type1591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetMcpServersByServerIdInstancesResponseInstance? Type1592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostMcpServersByServerIdInstancesResponse? Type1593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.DeleteMcpServersByServerIdInstancesByInstanceIdResponse? Type1594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetFilesListResponse? Type1595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetFilesListResponseItem>? Type1596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetFilesListResponseItem? Type1597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostFilesUploadRequestResponse? Type1598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostFilesUploadRequestResponseType? Type1599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostFilesUploadRequestResponseMetadata? Type1600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostFilesUploadRequestResponseMetadataStorageBackend? Type1601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponse? Type1602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseMcp? Type1603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseMcpType? Type1604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfig? Type1605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigToolkitsVariant1? Type1606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigToolkitsVariant2? Type1607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigToolkitsVariant3? Type1608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.AnyOf<bool?, global::Composio.PostToolRouterSessionResponseConfigInstant>? Type1609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigInstant? Type1610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigInstantToolkitsVariant1? Type1611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigInstantToolkitsVariant2? Type1612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigInstantToolsVariant1? Type1613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigInstantToolsVariant2? Type1614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigManageConnections? Type1615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigToolsVariant1? Type1616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigToolsVariant2? Type1617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigToolsVariant3? Type1618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigToolsVariant3Tags? Type1619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionResponseConfigToolsVariant3TagsEnabledItem>? Type1620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigToolsVariant3TagsEnabledItem? Type1621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionResponseConfigToolsVariant3TagsDisabledItem>? Type1622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigToolsVariant3TagsDisabledItem? Type1623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionResponseConfigToolsVariant3TagsRequireApprovalItem>? Type1624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigToolsVariant3TagsRequireApprovalItem? Type1625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigToolsVariant4? Type1626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigTags? Type1627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionResponseConfigTagsEnabledItem>? Type1628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigTagsEnabledItem? Type1629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionResponseConfigTagsDisabledItem>? Type1630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigTagsDisabledItem? Type1631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionResponseConfigTagsRequireApprovalItem>? Type1632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigTagsRequireApprovalItem? Type1633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigWorkbench? Type1634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigWorkbenchSandboxSize? Type1635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigMultiAccount? Type1636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigProxyExecute? Type1637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.OneOf<global::Composio.PostToolRouterSessionResponseConfigHookVariant1, global::Composio.PostToolRouterSessionResponseConfigHookVariant2>>? Type1638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.OneOf<global::Composio.PostToolRouterSessionResponseConfigHookVariant1, global::Composio.PostToolRouterSessionResponseConfigHookVariant2>? Type1639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigHookVariant1? Type1640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigHookVariant1Type? Type1641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigHookVariant1AppliesToEnum? Type1642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigHookVariant1AppliesToEnum2? Type1643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigHookVariant1HandlerVariant1? Type1644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigHookVariant1HandlerVariant1Type? Type1645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigHookVariant1HandlerVariant1Action? Type1646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigHookVariant1HandlerVariant2? Type1647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigHookVariant1HandlerVariant2Type? Type1648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigHookVariant1HandlerVariant2FallbackAction? Type1649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigHookVariant2? Type1650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigHookVariant2Type? Type1651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigHookVariant2AppliesToEnum? Type1652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigHookVariant2AppliesToEnum2? Type1653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigHookVariant2HandlerVariant1? Type1654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigHookVariant2HandlerVariant1Type? Type1655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigHookVariant2HandlerVariant1Action? Type1656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigHookVariant2HandlerVariant2? Type1657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigHookVariant2HandlerVariant2Type? Type1658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigHookVariant2HandlerVariant2Action? Type1659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigHookVariant2HandlerVariant3? Type1660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigHookVariant2HandlerVariant3Type? Type1661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigHookVariant2HandlerVariant3FallbackAction? Type1662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigPreload? Type1663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseExperimental? Type1664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionResponseExperimentalCustomToolkit>? Type1665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseExperimentalCustomToolkit? Type1666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionResponseExperimentalCustomToolkitTool>? Type1667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseExperimentalCustomToolkitTool? Type1668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionResponseExperimentalCustomTool>? Type1669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseExperimentalCustomTool? Type1670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseExperimentalNoElicitationSupportFallback? Type1671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionResponseWarning>? Type1672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseWarning? Type1673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseWarningCode? Type1674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdExecuteResponse? Type1675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdExecuteResponseDiscriminator? Type1676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdExecuteResponseDiscriminatorResultType? Type1677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdExecuteMetaResponse? Type1678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdExecuteMetaResponseDiscriminator? Type1679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdExecuteMetaResponseDiscriminatorResultType? Type1680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponse? Type1681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseMcp? Type1682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseMcpType? Type1683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfig? Type1684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolkitsVariant1? Type1685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolkitsVariant2? Type1686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolkitsVariant3? Type1687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.AnyOf<bool?, global::Composio.GetToolRouterSessionBySessionIdResponseConfigInstant>? Type1688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigInstant? Type1689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigInstantToolkitsVariant1? Type1690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigInstantToolkitsVariant2? Type1691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigInstantToolsVariant1? Type1692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigInstantToolsVariant2? Type1693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigManageConnections? Type1694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolsVariant1? Type1695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolsVariant2? Type1696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3? Type1697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3Tags? Type1698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItem>? Type1699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItem? Type1700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsDisabledItem>? Type1701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsDisabledItem? Type1702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsRequireApprovalItem>? Type1703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsRequireApprovalItem? Type1704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolsVariant4? Type1705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigTags? Type1706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetToolRouterSessionBySessionIdResponseConfigTagsEnabledItem>? Type1707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigTagsEnabledItem? Type1708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetToolRouterSessionBySessionIdResponseConfigTagsDisabledItem>? Type1709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigTagsDisabledItem? Type1710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetToolRouterSessionBySessionIdResponseConfigTagsRequireApprovalItem>? Type1711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigTagsRequireApprovalItem? Type1712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigWorkbench? Type1713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigWorkbenchSandboxSize? Type1714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigMultiAccount? Type1715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigProxyExecute? Type1716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigHookVariant1? Type1717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigHookVariant1Type? Type1718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigHookVariant1AppliesToEnum? Type1719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigHookVariant1AppliesToEnum2? Type1720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigHookVariant1HandlerVariant1? Type1721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigHookVariant1HandlerVariant1Type? Type1722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigHookVariant1HandlerVariant1Action? Type1723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigHookVariant1HandlerVariant2? Type1724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigHookVariant1HandlerVariant2Type? Type1725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigHookVariant1HandlerVariant2FallbackAction? Type1726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigHookVariant2? Type1727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigHookVariant2Type? Type1728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigHookVariant2AppliesToEnum? Type1729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigHookVariant2AppliesToEnum2? Type1730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigHookVariant2HandlerVariant1? Type1731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigHookVariant2HandlerVariant1Type? Type1732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigHookVariant2HandlerVariant1Action? Type1733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigHookVariant2HandlerVariant2? Type1734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigHookVariant2HandlerVariant2Type? Type1735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigHookVariant2HandlerVariant2Action? Type1736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigHookVariant2HandlerVariant3? Type1737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigHookVariant2HandlerVariant3Type? Type1738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigHookVariant2HandlerVariant3FallbackAction? Type1739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigPreload? Type1740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseExperimental? Type1741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetToolRouterSessionBySessionIdResponseExperimentalCustomToolkit>? Type1742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseExperimentalCustomToolkit? Type1743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetToolRouterSessionBySessionIdResponseExperimentalCustomToolkitTool>? Type1744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseExperimentalCustomToolkitTool? Type1745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetToolRouterSessionBySessionIdResponseExperimentalCustomTool>? Type1746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseExperimentalCustomTool? Type1747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseExperimentalNoElicitationSupportFallback? Type1748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetToolRouterSessionBySessionIdResponseWarning>? Type1749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseWarning? Type1750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseWarningCode? Type1751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponse? Type1752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseMcp? Type1753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseMcpType? Type1754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfig? Type1755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigToolkitsVariant1? Type1756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigToolkitsVariant2? Type1757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigToolkitsVariant3? Type1758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.AnyOf<bool?, global::Composio.PatchToolRouterSessionBySessionIdResponseConfigInstant>? Type1759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigInstant? Type1760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigInstantToolkitsVariant1? Type1761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigInstantToolkitsVariant2? Type1762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigInstantToolsVariant1? Type1763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigInstantToolsVariant2? Type1764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigManageConnections? Type1765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigToolsVariant1? Type1766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigToolsVariant2? Type1767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigToolsVariant3? Type1768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigToolsVariant3Tags? Type1769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PatchToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItem>? Type1770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItem? Type1771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PatchToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsDisabledItem>? Type1772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsDisabledItem? Type1773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PatchToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsRequireApprovalItem>? Type1774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsRequireApprovalItem? Type1775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigToolsVariant4? Type1776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigTags? Type1777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PatchToolRouterSessionBySessionIdResponseConfigTagsEnabledItem>? Type1778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigTagsEnabledItem? Type1779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PatchToolRouterSessionBySessionIdResponseConfigTagsDisabledItem>? Type1780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigTagsDisabledItem? Type1781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PatchToolRouterSessionBySessionIdResponseConfigTagsRequireApprovalItem>? Type1782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigTagsRequireApprovalItem? Type1783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigWorkbench? Type1784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigWorkbenchSandboxSize? Type1785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigMultiAccount? Type1786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigProxyExecute? Type1787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigHookVariant1? Type1788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigHookVariant1Type? Type1789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigHookVariant1AppliesToEnum? Type1790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigHookVariant1AppliesToEnum2? Type1791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigHookVariant1HandlerVariant1? Type1792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigHookVariant1HandlerVariant1Type? Type1793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigHookVariant1HandlerVariant1Action? Type1794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigHookVariant1HandlerVariant2? Type1795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigHookVariant1HandlerVariant2Type? Type1796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigHookVariant1HandlerVariant2FallbackAction? Type1797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigHookVariant2? Type1798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigHookVariant2Type? Type1799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigHookVariant2AppliesToEnum? Type1800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigHookVariant2AppliesToEnum2? Type1801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigHookVariant2HandlerVariant1? Type1802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigHookVariant2HandlerVariant1Type? Type1803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigHookVariant2HandlerVariant1Action? Type1804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigHookVariant2HandlerVariant2? Type1805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigHookVariant2HandlerVariant2Type? Type1806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigHookVariant2HandlerVariant2Action? Type1807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigHookVariant2HandlerVariant3? Type1808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigHookVariant2HandlerVariant3Type? Type1809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigHookVariant2HandlerVariant3FallbackAction? Type1810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigPreload? Type1811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseExperimental? Type1812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PatchToolRouterSessionBySessionIdResponseExperimentalCustomToolkit>? Type1813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseExperimentalCustomToolkit? Type1814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PatchToolRouterSessionBySessionIdResponseExperimentalCustomToolkitTool>? Type1815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseExperimentalCustomToolkitTool? Type1816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PatchToolRouterSessionBySessionIdResponseExperimentalCustomTool>? Type1817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseExperimentalCustomTool? Type1818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseExperimentalNoElicitationSupportFallback? Type1819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PatchToolRouterSessionBySessionIdResponseWarning>? Type1820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseWarning? Type1821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseWarningCode? Type1822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdLinkResponse? Type1823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdLinkResponseExperimental? Type1824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdLinkResponseExperimentalAccountType? Type1825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdLinkResponseExperimentalAclConfigForShared? Type1826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteResponse? Type1827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteResponseDiscriminator? Type1828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteResponseDiscriminatorResultType? Type1829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdToolsResponse? Type1830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdSearchResponse? Type1831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionBySessionIdSearchResponseResult>? Type1832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdSearchResponseResult? Type1833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionBySessionIdSearchResponseResultReferenceWorkbenchSnippet>? Type1834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdSearchResponseResultReferenceWorkbenchSnippet? Type1835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuse>? Type1836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuse? Type1837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccountType? Type1838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccount>? Type1839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccount? Type1840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccountAccountType? Type1841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccountSelection? Type1842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseInstantAccount? Type1843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Composio.ToolPricing>? Type1844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Composio.PostToolRouterSessionBySessionIdSearchResponseToolSchemas2>? Type1845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdSearchResponseToolSchemas2? Type1846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdSearchResponseToolSchemasSchemaRef? Type1847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdSearchResponseToolSchemasSchemaRefTool? Type1848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdSearchResponseToolSchemasSchemaRefArgs? Type1849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdSearchResponseTimeInfo? Type1850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdSearchResponseSession? Type1851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdMountsByMountIdItemsResponse? Type1852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetToolRouterSessionBySessionIdMountsByMountIdItemsResponseItem>? Type1853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdMountsByMountIdItemsResponseItem? Type1854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdMountsByMountIdDownloadUrlResponse? Type1855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdMountsByMountIdUploadUrlResponse? Type1856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdMountsByMountIdDeleteResponse? Type1857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsChangelogResponse? Type1858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetToolkitsChangelogResponseItem>? Type1859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsChangelogResponseItem? Type1860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetToolkitsChangelogResponseItemVersion>? Type1861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsChangelogResponseItemVersion? Type1862 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.AnyOf<string, global::System.Collections.Generic.List<string>>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.AnyOf<string, global::Composio.ToolScopeRequirementsAllOfItem>>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.AnyOf<string, global::Composio.ToolScopeRequirementsAllOfItemAnyOfItem>>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.Tool>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.AnyOf<string, global::Composio.ToolDetailsScopeRequirementsAllOfItem>>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.AnyOf<string, global::Composio.ToolDetailsScopeRequirementsAllOfItemAnyOfItem>>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.HookResult>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.ToolRouterToolkitsListResponseItem>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostInternalTriggerLogsRequestSearchParam>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostInternalActionExecutionLogsRequestSearchParam>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostOrgOwnerProjectNewRequestApiKeyPermission>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolsExecuteByToolSlugRequestCustomAuthParamsParameter>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolsExecuteProxyRequestParameter>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.AnyOf<global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionRequestToolsVariant3Tag>, global::Composio.PostToolRouterSessionRequestToolsVariant3Tags>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionRequestToolsVariant3Tag>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionRequestToolsVariant3TagsEnableItem>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionRequestToolsVariant3TagsDisableItem>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionRequestToolsVariant3TagsRequireApprovalItem>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.AnyOf<global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionRequestTag>, global::Composio.PostToolRouterSessionRequestTags>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionRequestTag>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionRequestTagsEnableItem>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionRequestTagsDisableItem>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionRequestTagsRequireApprovalItem>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionRequestExperimentalCustomToolkit>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionRequestExperimentalCustomToolkitTool>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionRequestExperimentalCustomTool>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.OneOf<global::Composio.PostToolRouterSessionRequestHookVariant1, global::Composio.PostToolRouterSessionRequestHookVariant2>>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PatchToolRouterSessionBySessionIdRequestToolsVariant3Tag>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsEnableItem>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsDisableItem>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsRequireApprovalItem>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.AnyOf<global::System.Collections.Generic.List<global::Composio.PatchToolRouterSessionBySessionIdRequestTag>, global::Composio.PatchToolRouterSessionBySessionIdRequestTags>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PatchToolRouterSessionBySessionIdRequestTag>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PatchToolRouterSessionBySessionIdRequestTagsEnableItem>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PatchToolRouterSessionBySessionIdRequestTagsDisableItem>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PatchToolRouterSessionBySessionIdRequestTagsRequireApprovalItem>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestParameter>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionBySessionIdSearchRequestQuerie>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetConnectedAccountsStatuse>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.OneOf<string, global::System.Collections.Generic.List<string>>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetAuthConfigsResponseItem>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetAuthConfigsResponseItemExpectedInputField>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetAuthConfigsByNanoidResponseExpectedInputField>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetConnectedAccountsResponseItem>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostInternalTriggerLogsResponseDataItem>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostInternalActionExecutionLogsResponseDataItem>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Composio.GetInternalActionExecutionFieldsResponseField>>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetInternalActionExecutionFieldsResponseField>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetInternalActionExecutionLogByIdResponseStep>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetInternalActionExecutionLogByIdResponseStepLog>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetOrgListResponseOrganization>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetOrgProjectListResponseDataItem>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetOrgOwnerProjectListResponseDataItem>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetOrgOwnerProjectByNanoIdResponseApiKey>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetWebhookSubscriptionsResponseItem>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetWebhookSubscriptionsEventTypesResponseItem>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetWebhookSubscriptionsEventTypesResponseItemSupportedVersion>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetWebhookEndpointsResponseItem>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetToolkitsResponseItem>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetToolkitsResponseItemMetaCategorie>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetToolkitsCategoriesResponseItem>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetToolkitsBySlugResponseComposioManagedAuthItem>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetToolkitsBySlugResponseAuthConfigDetail>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetToolkitsBySlugResponseAuthConfigDetailFieldsAuthConfigCreationRequiredItem>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetToolkitsBySlugResponseAuthConfigDetailFieldsAuthConfigCreationOptionalItem>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetToolkitsBySlugResponseAuthConfigDetailFieldsConnectedAccountInitiationRequiredItem>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetToolkitsBySlugResponseAuthConfigDetailFieldsConnectedAccountInitiationOptionalItem>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetToolkitsBySlugResponseMetaCategorie>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, object?>>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolkitsMultiResponseItem>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolkitsMultiResponseItemMetaCategorie>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetTriggerInstancesActiveResponseItem>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetTriggersTypesBySlugResponseType>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetTriggersTypesResponseItem>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetTriggersTypesResponseItemType>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetMcpServersResponseItem>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetMcpAppByAppKeyResponseItem>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetMcpServersByServerIdInstancesResponseInstance>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetFilesListResponseItem>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionResponseConfigToolsVariant3TagsEnabledItem>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionResponseConfigToolsVariant3TagsDisabledItem>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionResponseConfigToolsVariant3TagsRequireApprovalItem>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionResponseConfigTagsEnabledItem>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionResponseConfigTagsDisabledItem>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionResponseConfigTagsRequireApprovalItem>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.OneOf<global::Composio.PostToolRouterSessionResponseConfigHookVariant1, global::Composio.PostToolRouterSessionResponseConfigHookVariant2>>? ListType87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionResponseExperimentalCustomToolkit>? ListType88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionResponseExperimentalCustomToolkitTool>? ListType89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionResponseExperimentalCustomTool>? ListType90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionResponseWarning>? ListType91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItem>? ListType92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsDisabledItem>? ListType93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsRequireApprovalItem>? ListType94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetToolRouterSessionBySessionIdResponseConfigTagsEnabledItem>? ListType95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetToolRouterSessionBySessionIdResponseConfigTagsDisabledItem>? ListType96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetToolRouterSessionBySessionIdResponseConfigTagsRequireApprovalItem>? ListType97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetToolRouterSessionBySessionIdResponseExperimentalCustomToolkit>? ListType98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetToolRouterSessionBySessionIdResponseExperimentalCustomToolkitTool>? ListType99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetToolRouterSessionBySessionIdResponseExperimentalCustomTool>? ListType100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetToolRouterSessionBySessionIdResponseWarning>? ListType101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PatchToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItem>? ListType102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PatchToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsDisabledItem>? ListType103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PatchToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsRequireApprovalItem>? ListType104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PatchToolRouterSessionBySessionIdResponseConfigTagsEnabledItem>? ListType105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PatchToolRouterSessionBySessionIdResponseConfigTagsDisabledItem>? ListType106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PatchToolRouterSessionBySessionIdResponseConfigTagsRequireApprovalItem>? ListType107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PatchToolRouterSessionBySessionIdResponseExperimentalCustomToolkit>? ListType108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PatchToolRouterSessionBySessionIdResponseExperimentalCustomToolkitTool>? ListType109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PatchToolRouterSessionBySessionIdResponseExperimentalCustomTool>? ListType110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PatchToolRouterSessionBySessionIdResponseWarning>? ListType111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionBySessionIdSearchResponseResult>? ListType112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionBySessionIdSearchResponseResultReferenceWorkbenchSnippet>? ListType113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuse>? ListType114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccount>? ListType115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetToolRouterSessionBySessionIdMountsByMountIdItemsResponseItem>? ListType116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetToolkitsChangelogResponseItem>? ListType117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetToolkitsChangelogResponseItemVersion>? ListType118 { get; set; }
    }
}