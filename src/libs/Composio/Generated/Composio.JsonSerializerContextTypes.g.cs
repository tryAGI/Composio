
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
        public global::Composio.ExecuteCompleted? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ExecuteCompletedResultType? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ExecuteCompletedInstantCharge? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ExecuteCompletedInstantChargeCurrency? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ExecuteCompletedInstantChargeChargedBy? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ExecuteFailed? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ExecuteFailedResultType? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ExecuteFailedInstantCharge? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ExecuteFailedInstantChargeCurrency? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ExecuteFailedInstantChargeChargedBy? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.UserInputRequest? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.UserInputRequestType? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.UserInputRequestMode? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ExecuteRequiresUserInput? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ExecuteRequiresUserInputResultType? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Composio.UserInputRequest>? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.UserInputResponse? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.UserInputResponseAction? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ProxyExecuteCompleted? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ProxyExecuteCompletedResultType? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ProxyExecuteCompletedBinaryData? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ToolRouterToolkitsListResponse? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.ToolRouterToolkitsListResponseItem>? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ToolRouterToolkitsListResponseItem? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ToolRouterToolkitsListResponseItemMeta? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ToolRouterToolkitsListResponseItemConnectedAccount? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.ToolRouterToolkitsListResponseItemConnectedAccountAuthConfig? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostAuthConfigsRequest? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostAuthConfigsRequestToolkit? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.AuthConfig? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostAuthConfigsRequestAuthConfigDiscriminator? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostAuthConfigsRequestAuthConfigDiscriminatorType? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchAuthConfigsByNanoidRequest? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchAuthConfigsByNanoidRequestDiscriminator? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchAuthConfigsByNanoidRequestDiscriminatorType? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostCliCreateSessionRequest? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostCliCreateSessionRequestScope? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostCliCodactFailuresRequest? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostCliCodactFailuresRequestFailureType? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostCliCodactFailuresRequestToolInfo? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostCliCodactFailuresRequestToolInfoTool? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostCliRealtimeAuthRequest? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequest? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestAuthConfig? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnection? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant1? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant1AuthScheme? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant1ValVariant1? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant1ValVariant1Status? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant1ValVariant2? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant1ValVariant2Status? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant1ValVariant3? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant1ValVariant3Status? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant1ValVariant4? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant1ValVariant4Status? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant1ValVariant5? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant1ValVariant5Status? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant1ValVariant6? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant1ValVariant6Status? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant2? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant2AuthScheme? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant2ValVariant1? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant2ValVariant1Status? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant2ValVariant2? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant2ValVariant2Status? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant2ValVariant3? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant2ValVariant3Status? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.AnyOf<double?, string>? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant2ValVariant3AuthedUser? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant2ValVariant4? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant2ValVariant4Status? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant2ValVariant4AuthedUser? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant2ValVariant5? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant2ValVariant5Status? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant2ValVariant6? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant2ValVariant6Status? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant2ValVariant7? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant2ValVariant7Status? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant3? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant3AuthScheme? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant3ValVariant1? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant3ValVariant1Status? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant3ValVariant2? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant3ValVariant2Status? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant3ValVariant3? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant3ValVariant3Status? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant3ValVariant4? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant3ValVariant4Status? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant3ValVariant5? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant3ValVariant5Status? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant3ValVariant6? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant3ValVariant6Status? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant4? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant4AuthScheme? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant4ValVariant1? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant4ValVariant1Status? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant4ValVariant2? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant4ValVariant2Status? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant4ValVariant3? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant4ValVariant3Status? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant4ValVariant4? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant4ValVariant4Status? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant4ValVariant5? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant4ValVariant5Status? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant5? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant5AuthScheme? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant5ValVariant1? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant5ValVariant1Status? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant5ValVariant2? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant5ValVariant2Status? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant5ValVariant3? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant5ValVariant3Status? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant5ValVariant4? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant5ValVariant4Status? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant5ValVariant5? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant5ValVariant5Status? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant6? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant6AuthScheme? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant6ValVariant1? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant6ValVariant1Status? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant6ValVariant2? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant6ValVariant2Status? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant6ValVariant3? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant6ValVariant3Status? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant6ValVariant4? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant6ValVariant4Status? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant6ValVariant5? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant6ValVariant5Status? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant7? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant7AuthScheme? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant7ValVariant1? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant7ValVariant1Status? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant7ValVariant2? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant7ValVariant2Status? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant7ValVariant3? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant7ValVariant3Status? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant7ValVariant4? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant7ValVariant4Status? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant7ValVariant5? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant7ValVariant5Status? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant7ValVariant6? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant7ValVariant6Status? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant8? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant8AuthScheme? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant8ValVariant1? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant8ValVariant1Status? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant8ValVariant2? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant8ValVariant2Status? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant8ValVariant3? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant8ValVariant3Status? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant8ValVariant4? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant8ValVariant4Status? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant8ValVariant5? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant8ValVariant5Status? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant8ValVariant6? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant8ValVariant6Status? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant9? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant9AuthScheme? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant9ValVariant1? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant9ValVariant1Status? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant9ValVariant2? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant9ValVariant2Status? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant9ValVariant3? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant9ValVariant3Status? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant9ValVariant4? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant9ValVariant4Status? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant9ValVariant5? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant9ValVariant5Status? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant9ValVariant6? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant9ValVariant6Status? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant10? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant10AuthScheme? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant1? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant1Status? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant2? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant2Status? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant3? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant3Status? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant4? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant4Status? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant5? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant5Status? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant6? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant6Status? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant11? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant11AuthScheme? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant11ValVariant1? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant11ValVariant1Status? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant11ValVariant2? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant11ValVariant2Status? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant11ValVariant3? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant11ValVariant3Status? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant11ValVariant4? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant11ValVariant4Status? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant11ValVariant5? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant11ValVariant5Status? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant12? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant12AuthScheme? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant12ValVariant1? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant12ValVariant1Status? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant12ValVariant2? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant12ValVariant2Status? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant12ValVariant3? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant12ValVariant3Status? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant12ValVariant4? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant12ValVariant4Status? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant12ValVariant5? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant12ValVariant5Status? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant12ValVariant6? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant12ValVariant6Status? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant13? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant13AuthScheme? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant13ValVariant1? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant13ValVariant1Status? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant13ValVariant2? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant13ValVariant2Status? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant13ValVariant3? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant13ValVariant3Status? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant13ValVariant4? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant13ValVariant4Status? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant13ValVariant5? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant13ValVariant5Status? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant13ValVariant6? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant13ValVariant6Status? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant14? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant14AuthScheme? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant14ValVariant1? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant14ValVariant1Status? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant14ValVariant2? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant14ValVariant2Status? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant14ValVariant3? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant14ValVariant3Status? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant14ValVariant4? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant14ValVariant4Status? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant14ValVariant5? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant14ValVariant5Status? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant14ValVariant6? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant14ValVariant6Status? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant15? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant15AuthScheme? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant15ValVariant1? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant15ValVariant1Status? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant15ValVariant2? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant15ValVariant2Status? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant15ValVariant3? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant15ValVariant3Status? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant15ValVariant4? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant15ValVariant4Status? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant15ValVariant5? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant15ValVariant5Status? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant15ValVariant6? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant15ValVariant6Status? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionExperimental? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionExperimentalAccountType? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsRequestConnectionExperimentalAclConfigForShared? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchConnectedAccountsByNanoIdStatusRequest? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsByNanoidRefreshRequest? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsLinkRequest? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsLinkRequestExperimental? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsLinkRequestExperimentalAccountType? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsLinkRequestExperimentalAclConfigForShared? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostInternalTriggerLogsRequest? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostInternalTriggerLogsRequestTime? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostInternalTriggerLogsRequestStatus? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostInternalTriggerLogsRequestSearchParam>? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostInternalTriggerLogsRequestSearchParam? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostInternalActionExecutionLogsRequest? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostInternalActionExecutionLogsRequestSearchParam>? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostInternalActionExecutionLogsRequestSearchParam? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostOrgOwnerProjectNewRequest? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostOrgOwnerProjectNewRequestApiKeyPermission>? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostOrgOwnerProjectNewRequestApiKeyPermission? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostOrgOwnerProjectNewRequestApiKeyPermissionPreset? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostOrgOwnerProjectNewRequestApiKeyPermissionAccess? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostOrgOwnerProjectNewRequestConfig? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostOrgOwnerProjectNewRequestConfigLogVisibilitySetting? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostWebhookSubscriptionsRequest? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostWebhookSubscriptionsRequestVersion? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchWebhookSubscriptionsByIdRequest? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchWebhookSubscriptionsByIdRequestVersion? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostWebhookEndpointsRequest? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostWebhookEndpointsByNanoIdRequest? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchWebhookEndpointsByNanoIdRequest? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostCustomToolkitsUpsertRequest? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostCustomToolkitsUpsertRequestToolkitConfig? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigLogoFile? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigLogoFileMimeType? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant1? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant1Mode? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2Mode? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2ApiKeyField? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant3? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant3Mode? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostCustomToolkitsSyncRequest? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolkitsMultiRequest? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolkitsMultiRequestManagedBy? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolkitsMultiRequestSortBy? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequest? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.AnyOf<global::Composio.PostToolsExecuteByToolSlugRequestConnectedAccountId?, string>? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestConnectedAccountId? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomAuthParams? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolsExecuteByToolSlugRequestCustomAuthParamsParameter>? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomAuthParamsParameter? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomAuthParamsParameterIn? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.AnyOf<string, double?>? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant1? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant1AuthScheme? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant1Val? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant1ValAuthedUser? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant2? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant2AuthScheme? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant2Val? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant3? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant3AuthScheme? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant3Val? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant4? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant4AuthScheme? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant4Val? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant5? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant5AuthScheme? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant5Val? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant6? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant6AuthScheme? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant6Val? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant7? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant7AuthScheme? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant7Val? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant8? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant8AuthScheme? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant8Val? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant9? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant9AuthScheme? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant9Val? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant10? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant10AuthScheme? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant10Val? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant11? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant11AuthScheme? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant11Val? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugInputRequest? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequest? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestMethod? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.AnyOf<global::Composio.PostToolsExecuteProxyRequestBinaryBodyVariant1, global::Composio.PostToolsExecuteProxyRequestBinaryBodyVariant2>? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestBinaryBodyVariant1? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestBinaryBodyVariant2? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolsExecuteProxyRequestParameter>? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestParameter? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestParameterType? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant1? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant1AuthScheme? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant1Val? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant1ValAuthedUser? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant2? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant2AuthScheme? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant2Val? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant3? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant3AuthScheme? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant3Val? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant4? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant4AuthScheme? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant4Val? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant5? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant5AuthScheme? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant5Val? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant6? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant6AuthScheme? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant6Val? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant7? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant7AuthScheme? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant7Val? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant8? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant8AuthScheme? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant8Val? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant9? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant9AuthScheme? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant9Val? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant10? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant10AuthScheme? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant10Val? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant11? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant11AuthScheme? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant11Val? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostTriggerInstancesBySlugUpsertRequest? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.AnyOf<string, global::System.Collections.Generic.Dictionary<string, string>>? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchTriggerInstancesManageByTriggerIdRequest? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchTriggerInstancesManageByTriggerIdRequestStatus? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostMcpServersRequest? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostMcpServersCustomRequest? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostMcpServersGenerateRequest? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchMcpByIdRequest? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostMcpServersByServerIdInstancesRequest? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostFilesUploadRequestRequest? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequest? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestToolkitsVariant1? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestToolkitsVariant2? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestToolkitsVariant3? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.AnyOf<bool?, global::Composio.PostToolRouterSessionRequestInstant>? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestInstant? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.AnyOf<global::Composio.PostToolRouterSessionRequestInstantToolkitsVariant1, global::Composio.PostToolRouterSessionRequestInstantToolkitsVariant2>? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestInstantToolkitsVariant1? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestInstantToolkitsVariant2? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.AnyOf<global::Composio.PostToolRouterSessionRequestInstantToolsVariant1, global::Composio.PostToolRouterSessionRequestInstantToolsVariant2>? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestInstantToolsVariant1? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestInstantToolsVariant2? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestManageConnections? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestToolsVariant1? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestToolsVariant2? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestToolsVariant3? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.AnyOf<global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionRequestToolsVariant3Tag>, global::Composio.PostToolRouterSessionRequestToolsVariant3Tags>? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionRequestToolsVariant3Tag>? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestToolsVariant3Tag? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestToolsVariant3Tags? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionRequestToolsVariant3TagsEnableItem>? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestToolsVariant3TagsEnableItem? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionRequestToolsVariant3TagsDisableItem>? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestToolsVariant3TagsDisableItem? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionRequestToolsVariant3TagsRequireApprovalItem>? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestToolsVariant3TagsRequireApprovalItem? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestToolsVariant4? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.AnyOf<global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionRequestTag>, global::Composio.PostToolRouterSessionRequestTags>? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionRequestTag>? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestTag? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestTags? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionRequestTagsEnableItem>? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestTagsEnableItem? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionRequestTagsDisableItem>? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestTagsDisableItem? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionRequestTagsRequireApprovalItem>? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestTagsRequireApprovalItem? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestWorkbench? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestWorkbenchSandboxSize? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestProxyExecute? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestMultiAccount? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestExperimental? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestExperimentalAssistivePromptConfig? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionRequestExperimentalCustomToolkit>? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestExperimentalCustomToolkit? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionRequestExperimentalCustomToolkitTool>? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestExperimentalCustomToolkitTool? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionRequestExperimentalCustomTool>? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestExperimentalCustomTool? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestExperimentalPermissions? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestExperimentalPermissionsDefault? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Composio.PostToolRouterSessionRequestExperimentalPermissionsOverrides2>? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestExperimentalPermissionsOverrides2? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestExperimentalSubmitFeedback? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestExperimentalNoElicitationSupportFallback? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionRequestPreload? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdExecuteRequest? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Composio.UserInputResponse>? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdExecuteMetaRequest? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdExecuteMetaRequestSlug? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequest? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestToolkitsVariant1? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestToolkitsVariant2? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestToolkitsVariant3? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.AnyOf<bool?, global::Composio.PatchToolRouterSessionBySessionIdRequestInstant>? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestInstant? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestInstantToolkitsVariant1? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestInstantToolkitsVariant2? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestInstantToolsVariant1? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestInstantToolsVariant2? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestManageConnections? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestToolsVariant1? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestToolsVariant2? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestToolsVariant3? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PatchToolRouterSessionBySessionIdRequestToolsVariant3Tag>? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestToolsVariant3Tag? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestToolsVariant3Tags? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsEnableItem>? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsEnableItem? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsDisableItem>? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsDisableItem? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsRequireApprovalItem>? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsRequireApprovalItem? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestToolsVariant4? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.AnyOf<global::System.Collections.Generic.IList<global::Composio.PatchToolRouterSessionBySessionIdRequestTag>, global::Composio.PatchToolRouterSessionBySessionIdRequestTags>? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PatchToolRouterSessionBySessionIdRequestTag>? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestTag? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestTags? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PatchToolRouterSessionBySessionIdRequestTagsEnableItem>? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestTagsEnableItem? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PatchToolRouterSessionBySessionIdRequestTagsDisableItem>? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestTagsDisableItem? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PatchToolRouterSessionBySessionIdRequestTagsRequireApprovalItem>? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestTagsRequireApprovalItem? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestWorkbench? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestWorkbenchSandboxSize? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestMultiAccount? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestProxyExecute? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestPreload? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestExperimental? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestExperimentalPermissions? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestExperimentalPermissionsDefault? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Composio.PatchToolRouterSessionBySessionIdRequestExperimentalPermissionsOverrides2>? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestExperimentalPermissionsOverrides2? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestExperimentalSubmitFeedback? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdRequestExperimentalNoElicitationSupportFallback? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdLinkRequest? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdLinkRequestExperimental? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdLinkRequestExperimentalAccountType? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdLinkRequestExperimentalAclConfigForShared? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequest? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestMethod? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestBinaryBodyVariant1? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestBinaryBodyVariant2? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestParameter>? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestParameter? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestParameterType? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant1? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant1AuthScheme? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant1Val? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant1ValAuthedUser? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant2? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant2AuthScheme? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant2Val? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant3? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant3AuthScheme? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant3Val? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant4? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant4AuthScheme? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant4Val? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant5? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant5AuthScheme? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant5Val? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant6? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant6AuthScheme? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant6Val? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant7? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant7AuthScheme? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant7Val? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant8? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant8AuthScheme? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant8Val? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant9? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant9AuthScheme? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant9Val? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant10? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant10AuthScheme? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant10Val? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant11? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant11AuthScheme? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant11Val? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdSearchRequest? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionBySessionIdSearchRequestQuerie>? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdSearchRequestQuerie? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdSearchRequestSearchStrategy? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdMountsByMountIdDownloadUrlRequest? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdMountsByMountIdUploadUrlRequest? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdMountsByMountIdDeleteRequest? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.AnyOf<string, bool?>? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchAuthConfigsByNanoidByStatusStatus? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetConnectedAccountsStatuse>? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsStatuse? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsOrderBy? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsOrderDirection? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsAccountType? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsManagedBy? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsType? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsSortBy? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.OneOf<string, global::System.Collections.Generic.IList<string>>? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolsImportant? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.OneOf<string, global::System.Collections.Generic.Dictionary<string, string>>? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetMcpServersOrderBy? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetMcpServersOrderDirection? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetMcpAppByAppKeyOrderBy? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetMcpAppByAppKeyOrderDirection? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetMcpServersByServerIdInstancesOrderBy? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetMcpServersByServerIdInstancesOrderDirection? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetAuthSessionInfoResponse? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetAuthSessionInfoResponseProject? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetAuthSessionInfoResponseProjectWebhookVersion? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetAuthSessionInfoResponseProjectOrg? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetAuthSessionInfoResponseApiKey? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetAuthSessionInfoResponseOrgMember? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetAuthSessionInfoResponseOrgMemberMetadata? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.AnyOf<string, bool?, double?>? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetAuthSessionInfoResponseOrgMemberMetadataOnboardingPlatform? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostAuthConfigsResponse? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostAuthConfigsResponseToolkit? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostAuthConfigsResponseAuthConfig? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetAuthConfigsResponse? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetAuthConfigsResponseItem>? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetAuthConfigsResponseItem? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetAuthConfigsResponseItemType? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetAuthConfigsResponseItemToolkit? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetAuthConfigsResponseItemAuthScheme? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetAuthConfigsResponseItemProxyConfig? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetAuthConfigsResponseItemStatus? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetAuthConfigsResponseItemExpectedInputField>? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetAuthConfigsResponseItemExpectedInputField? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetAuthConfigsResponseItemToolAccessConfig? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetAuthConfigsByNanoidResponse? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetAuthConfigsByNanoidResponseType? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetAuthConfigsByNanoidResponseToolkit? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetAuthConfigsByNanoidResponseAuthScheme? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetAuthConfigsByNanoidResponseProxyConfig? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetAuthConfigsByNanoidResponseStatus? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetAuthConfigsByNanoidResponseExpectedInputField>? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetAuthConfigsByNanoidResponseExpectedInputField? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetAuthConfigsByNanoidResponseToolAccessConfig? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchAuthConfigsByNanoidResponse? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.DeleteAuthConfigsByNanoidResponse? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchAuthConfigsByNanoidByStatusResponse? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostCliCreateSessionResponse? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostCliCreateSessionResponseStatus? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostCliCreateSessionResponseScope? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostCliCodactFailuresResponse? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetCliGetSessionResponse? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetCliGetSessionResponseStatus? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetCliGetSessionResponseAccount? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetCliGetSessionResponseScope? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetCliRealtimeCredentialsResponse? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostCliRealtimeAuthResponse? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponse? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetConnectedAccountsResponseItem>? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItem? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemToolkit? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemAuthConfig? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemAuthConfigAuthScheme? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemAuthScheme? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStatus? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemExperimental? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemExperimentalAccountType? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemExperimentalAclConfigForShared? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant1? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant1AuthScheme? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant1ValVariant1? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant1ValVariant1Status? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant1ValVariant2? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant1ValVariant2Status? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant1ValVariant3? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant1ValVariant3Status? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant1ValVariant4? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant1ValVariant4Status? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant1ValVariant5? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant1ValVariant5Status? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant1ValVariant6? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant1ValVariant6Status? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant2? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant2AuthScheme? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant1? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant1Status? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant2? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant2Status? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant3? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant3Status? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant3AuthedUser? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant4? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant4Status? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant4AuthedUser? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant5? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant5Status? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant6? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant6Status? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant7? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant7Status? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant3? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant3AuthScheme? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant3ValVariant1? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant3ValVariant1Status? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant3ValVariant2? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant3ValVariant2Status? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant3ValVariant3? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant3ValVariant3Status? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant3ValVariant4? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant3ValVariant4Status? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant3ValVariant5? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant3ValVariant5Status? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant3ValVariant6? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant3ValVariant6Status? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant4? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant4AuthScheme? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant4ValVariant1? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant4ValVariant1Status? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant4ValVariant2? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant4ValVariant2Status? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant4ValVariant3? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant4ValVariant3Status? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant4ValVariant4? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant4ValVariant4Status? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant4ValVariant5? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant4ValVariant5Status? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant5? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant5AuthScheme? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant5ValVariant1? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant5ValVariant1Status? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant5ValVariant2? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant5ValVariant2Status? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant5ValVariant3? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant5ValVariant3Status? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant5ValVariant4? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant5ValVariant4Status? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant5ValVariant5? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant5ValVariant5Status? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant6? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant6AuthScheme? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant6ValVariant1? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant6ValVariant1Status? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant6ValVariant2? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant6ValVariant2Status? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant6ValVariant3? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant6ValVariant3Status? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant6ValVariant4? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant6ValVariant4Status? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant6ValVariant5? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant6ValVariant5Status? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant7? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant7AuthScheme? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant7ValVariant1? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant7ValVariant1Status? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant7ValVariant2? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant7ValVariant2Status? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant7ValVariant3? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant7ValVariant3Status? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant7ValVariant4? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant7ValVariant4Status? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant7ValVariant5? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant7ValVariant5Status? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant7ValVariant6? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant7ValVariant6Status? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant8? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant8AuthScheme? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant1? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant1Status? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant2? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant2Status? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant3? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant3Status? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant4? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant4Status? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant5? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant5Status? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant6? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant6Status? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant9? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant9AuthScheme? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant1? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant1Status? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant2? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant2Status? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant3? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant3Status? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant4? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant4Status? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant5? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant5Status? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant6? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant6Status? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant10? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant10AuthScheme? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant10ValVariant1? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant10ValVariant1Status? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant10ValVariant2? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant10ValVariant2Status? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant10ValVariant3? Type822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant10ValVariant3Status? Type823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant10ValVariant4? Type824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant10ValVariant4Status? Type825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant10ValVariant5? Type826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant10ValVariant5Status? Type827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant10ValVariant6? Type828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant10ValVariant6Status? Type829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant11? Type830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant11AuthScheme? Type831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant11ValVariant1? Type832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant11ValVariant1Status? Type833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant11ValVariant2? Type834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant11ValVariant2Status? Type835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant11ValVariant3? Type836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant11ValVariant3Status? Type837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant11ValVariant4? Type838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant11ValVariant4Status? Type839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant11ValVariant5? Type840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant11ValVariant5Status? Type841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant12? Type842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant12AuthScheme? Type843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant12ValVariant1? Type844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant12ValVariant1Status? Type845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant12ValVariant2? Type846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant12ValVariant2Status? Type847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant12ValVariant3? Type848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant12ValVariant3Status? Type849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant12ValVariant4? Type850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant12ValVariant4Status? Type851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant12ValVariant5? Type852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant12ValVariant5Status? Type853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant12ValVariant6? Type854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant12ValVariant6Status? Type855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant13? Type856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant13AuthScheme? Type857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant13ValVariant1? Type858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant13ValVariant1Status? Type859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant13ValVariant2? Type860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant13ValVariant2Status? Type861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant13ValVariant3? Type862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant13ValVariant3Status? Type863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant13ValVariant4? Type864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant13ValVariant4Status? Type865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant13ValVariant5? Type866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant13ValVariant5Status? Type867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant13ValVariant6? Type868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant13ValVariant6Status? Type869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant14? Type870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant14AuthScheme? Type871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant1? Type872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant1Status? Type873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant2? Type874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant2Status? Type875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant3? Type876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant3Status? Type877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant4? Type878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant4Status? Type879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant5? Type880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant5Status? Type881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant6? Type882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant6Status? Type883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant15? Type884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant15AuthScheme? Type885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant15ValVariant1? Type886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant15ValVariant1Status? Type887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant15ValVariant2? Type888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant15ValVariant2Status? Type889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant15ValVariant3? Type890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant15ValVariant3Status? Type891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant15ValVariant4? Type892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant15ValVariant4Status? Type893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant15ValVariant5? Type894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant15ValVariant5Status? Type895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant15ValVariant6? Type896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsResponseItemStateVariant15ValVariant6Status? Type897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponse? Type898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant1? Type899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant1AuthScheme? Type900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant1? Type901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant1Status? Type902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant2? Type903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant2Status? Type904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant3? Type905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant3Status? Type906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant4? Type907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant4Status? Type908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant5? Type909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant5Status? Type910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant6? Type911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant6Status? Type912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant2? Type913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant2AuthScheme? Type914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant1? Type915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant1Status? Type916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant2? Type917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant2Status? Type918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant3? Type919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant3Status? Type920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant3AuthedUser? Type921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant4? Type922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant4Status? Type923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant4AuthedUser? Type924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant5? Type925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant5Status? Type926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant6? Type927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant6Status? Type928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant7? Type929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant7Status? Type930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant3? Type931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant3AuthScheme? Type932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant3ValVariant1? Type933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant3ValVariant1Status? Type934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant3ValVariant2? Type935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant3ValVariant2Status? Type936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant3ValVariant3? Type937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant3ValVariant3Status? Type938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant3ValVariant4? Type939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant3ValVariant4Status? Type940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant3ValVariant5? Type941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant3ValVariant5Status? Type942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant3ValVariant6? Type943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant3ValVariant6Status? Type944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant4? Type945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant4AuthScheme? Type946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant4ValVariant1? Type947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant4ValVariant1Status? Type948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant4ValVariant2? Type949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant4ValVariant2Status? Type950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant4ValVariant3? Type951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant4ValVariant3Status? Type952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant4ValVariant4? Type953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant4ValVariant4Status? Type954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant4ValVariant5? Type955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant4ValVariant5Status? Type956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant5? Type957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant5AuthScheme? Type958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant5ValVariant1? Type959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant5ValVariant1Status? Type960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant5ValVariant2? Type961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant5ValVariant2Status? Type962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant5ValVariant3? Type963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant5ValVariant3Status? Type964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant5ValVariant4? Type965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant5ValVariant4Status? Type966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant5ValVariant5? Type967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant5ValVariant5Status? Type968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant6? Type969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant6AuthScheme? Type970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant6ValVariant1? Type971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant6ValVariant1Status? Type972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant6ValVariant2? Type973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant6ValVariant2Status? Type974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant6ValVariant3? Type975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant6ValVariant3Status? Type976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant6ValVariant4? Type977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant6ValVariant4Status? Type978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant6ValVariant5? Type979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant6ValVariant5Status? Type980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant7? Type981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant7AuthScheme? Type982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant1? Type983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant1Status? Type984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant2? Type985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant2Status? Type986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant3? Type987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant3Status? Type988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant4? Type989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant4Status? Type990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant5? Type991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant5Status? Type992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant6? Type993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant6Status? Type994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant8? Type995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant8AuthScheme? Type996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant8ValVariant1? Type997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant8ValVariant1Status? Type998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant8ValVariant2? Type999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant8ValVariant2Status? Type1000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant8ValVariant3? Type1001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant8ValVariant3Status? Type1002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant8ValVariant4? Type1003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant8ValVariant4Status? Type1004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant8ValVariant5? Type1005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant8ValVariant5Status? Type1006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant8ValVariant6? Type1007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant8ValVariant6Status? Type1008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant9? Type1009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant9AuthScheme? Type1010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant1? Type1011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant1Status? Type1012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant2? Type1013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant2Status? Type1014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant3? Type1015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant3Status? Type1016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant4? Type1017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant4Status? Type1018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant5? Type1019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant5Status? Type1020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant6? Type1021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant6Status? Type1022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant10? Type1023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant10AuthScheme? Type1024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant10ValVariant1? Type1025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant10ValVariant1Status? Type1026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant10ValVariant2? Type1027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant10ValVariant2Status? Type1028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant10ValVariant3? Type1029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant10ValVariant3Status? Type1030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant10ValVariant4? Type1031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant10ValVariant4Status? Type1032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant10ValVariant5? Type1033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant10ValVariant5Status? Type1034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant10ValVariant6? Type1035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant10ValVariant6Status? Type1036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant11? Type1037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant11AuthScheme? Type1038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant11ValVariant1? Type1039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant11ValVariant1Status? Type1040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant11ValVariant2? Type1041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant11ValVariant2Status? Type1042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant11ValVariant3? Type1043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant11ValVariant3Status? Type1044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant11ValVariant4? Type1045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant11ValVariant4Status? Type1046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant11ValVariant5? Type1047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant11ValVariant5Status? Type1048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant12? Type1049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant12AuthScheme? Type1050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant12ValVariant1? Type1051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant12ValVariant1Status? Type1052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant12ValVariant2? Type1053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant12ValVariant2Status? Type1054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant12ValVariant3? Type1055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant12ValVariant3Status? Type1056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant12ValVariant4? Type1057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant12ValVariant4Status? Type1058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant12ValVariant5? Type1059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant12ValVariant5Status? Type1060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant12ValVariant6? Type1061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant12ValVariant6Status? Type1062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant13? Type1063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant13AuthScheme? Type1064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant13ValVariant1? Type1065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant13ValVariant1Status? Type1066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant13ValVariant2? Type1067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant13ValVariant2Status? Type1068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant13ValVariant3? Type1069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant13ValVariant3Status? Type1070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant13ValVariant4? Type1071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant13ValVariant4Status? Type1072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant13ValVariant5? Type1073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant13ValVariant5Status? Type1074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant13ValVariant6? Type1075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant13ValVariant6Status? Type1076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant14? Type1077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant14AuthScheme? Type1078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant14ValVariant1? Type1079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant14ValVariant1Status? Type1080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant14ValVariant2? Type1081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant14ValVariant2Status? Type1082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant14ValVariant3? Type1083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant14ValVariant3Status? Type1084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant14ValVariant4? Type1085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant14ValVariant4Status? Type1086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant14ValVariant5? Type1087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant14ValVariant5Status? Type1088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant14ValVariant6? Type1089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant14ValVariant6Status? Type1090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant15? Type1091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant15AuthScheme? Type1092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant15ValVariant1? Type1093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant15ValVariant1Status? Type1094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant15ValVariant2? Type1095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant15ValVariant2Status? Type1096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant15ValVariant3? Type1097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant15ValVariant3Status? Type1098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant15ValVariant4? Type1099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant15ValVariant4Status? Type1100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant15ValVariant5? Type1101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant15ValVariant5Status? Type1102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant15ValVariant6? Type1103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant15ValVariant6Status? Type1104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseStatus? Type1105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseExperimental? Type1106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseExperimentalAccountType? Type1107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsResponseExperimentalAclConfigForShared? Type1108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponse? Type1109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseToolkit? Type1110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseAuthConfig? Type1111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseAuthConfigAuthScheme? Type1112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseAuthScheme? Type1113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStatus? Type1114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseExperimental? Type1115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseExperimentalAccountType? Type1116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseExperimentalAclConfigForShared? Type1117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant1? Type1118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant1AuthScheme? Type1119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant1? Type1120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant1Status? Type1121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant2? Type1122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant2Status? Type1123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant3? Type1124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant3Status? Type1125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant4? Type1126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant4Status? Type1127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant5? Type1128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant5Status? Type1129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant6? Type1130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant6Status? Type1131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2? Type1132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2AuthScheme? Type1133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant1? Type1134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant1Status? Type1135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant2? Type1136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant2Status? Type1137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant3? Type1138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant3Status? Type1139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant3AuthedUser? Type1140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant4? Type1141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant4Status? Type1142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant4AuthedUser? Type1143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant5? Type1144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant5Status? Type1145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant6? Type1146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant6Status? Type1147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant7? Type1148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant7Status? Type1149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant3? Type1150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant3AuthScheme? Type1151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant1? Type1152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant1Status? Type1153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant2? Type1154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant2Status? Type1155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant3? Type1156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant3Status? Type1157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant4? Type1158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant4Status? Type1159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant5? Type1160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant5Status? Type1161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant6? Type1162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant6Status? Type1163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant4? Type1164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant4AuthScheme? Type1165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant4ValVariant1? Type1166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant4ValVariant1Status? Type1167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant4ValVariant2? Type1168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant4ValVariant2Status? Type1169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant4ValVariant3? Type1170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant4ValVariant3Status? Type1171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant4ValVariant4? Type1172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant4ValVariant4Status? Type1173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant4ValVariant5? Type1174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant4ValVariant5Status? Type1175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant5? Type1176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant5AuthScheme? Type1177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant1? Type1178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant1Status? Type1179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant2? Type1180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant2Status? Type1181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant3? Type1182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant3Status? Type1183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant4? Type1184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant4Status? Type1185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant5? Type1186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant5Status? Type1187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6? Type1188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6AuthScheme? Type1189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant1? Type1190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant1Status? Type1191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant2? Type1192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant2Status? Type1193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant3? Type1194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant3Status? Type1195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant4? Type1196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant4Status? Type1197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant5? Type1198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant5Status? Type1199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant7? Type1200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant7AuthScheme? Type1201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant1? Type1202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant1Status? Type1203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant2? Type1204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant2Status? Type1205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant3? Type1206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant3Status? Type1207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant4? Type1208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant4Status? Type1209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant5? Type1210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant5Status? Type1211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant6? Type1212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant6Status? Type1213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8? Type1214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8AuthScheme? Type1215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant1? Type1216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant1Status? Type1217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant2? Type1218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant2Status? Type1219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant3? Type1220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant3Status? Type1221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant4? Type1222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant4Status? Type1223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant5? Type1224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant5Status? Type1225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant6? Type1226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant6Status? Type1227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant9? Type1228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant9AuthScheme? Type1229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant1? Type1230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant1Status? Type1231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant2? Type1232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant2Status? Type1233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant3? Type1234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant3Status? Type1235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant4? Type1236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant4Status? Type1237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant5? Type1238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant5Status? Type1239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant6? Type1240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant6Status? Type1241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant10? Type1242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant10AuthScheme? Type1243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant1? Type1244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant1Status? Type1245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant2? Type1246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant2Status? Type1247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant3? Type1248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant3Status? Type1249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant4? Type1250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant4Status? Type1251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant5? Type1252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant5Status? Type1253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant6? Type1254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant6Status? Type1255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant11? Type1256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant11AuthScheme? Type1257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant1? Type1258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant1Status? Type1259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant2? Type1260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant2Status? Type1261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant3? Type1262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant3Status? Type1263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant4? Type1264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant4Status? Type1265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant5? Type1266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant5Status? Type1267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant12? Type1268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant12AuthScheme? Type1269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant1? Type1270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant1Status? Type1271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant2? Type1272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant2Status? Type1273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant3? Type1274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant3Status? Type1275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant4? Type1276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant4Status? Type1277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant5? Type1278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant5Status? Type1279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant6? Type1280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant6Status? Type1281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant13? Type1282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant13AuthScheme? Type1283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant1? Type1284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant1Status? Type1285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant2? Type1286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant2Status? Type1287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant3? Type1288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant3Status? Type1289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant4? Type1290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant4Status? Type1291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant5? Type1292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant5Status? Type1293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant6? Type1294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant6Status? Type1295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant14? Type1296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant14AuthScheme? Type1297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant1? Type1298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant1Status? Type1299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant2? Type1300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant2Status? Type1301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant3? Type1302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant3Status? Type1303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant4? Type1304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant4Status? Type1305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant5? Type1306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant5Status? Type1307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant6? Type1308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant6Status? Type1309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant15? Type1310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant15AuthScheme? Type1311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant15ValVariant1? Type1312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant15ValVariant1Status? Type1313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant15ValVariant2? Type1314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant15ValVariant2Status? Type1315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant15ValVariant3? Type1316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant15ValVariant3Status? Type1317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant15ValVariant4? Type1318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant15ValVariant4Status? Type1319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant15ValVariant5? Type1320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant15ValVariant5Status? Type1321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant15ValVariant6? Type1322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant15ValVariant6Status? Type1323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.DeleteConnectedAccountsByNanoidResponse? Type1324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchConnectedAccountsByNanoidResponse? Type1325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchConnectedAccountsByNanoIdStatusResponse? Type1326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsByNanoidRefreshResponse? Type1327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsByNanoidRefreshResponseStatus? Type1328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsLinkResponse? Type1329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsLinkResponseExperimental? Type1330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsLinkResponseExperimentalAccountType? Type1331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostConnectedAccountsLinkResponseExperimentalAclConfigForShared? Type1332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostInternalTriggerLogsResponse? Type1333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostInternalTriggerLogsResponseDataItem>? Type1334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostInternalTriggerLogsResponseDataItem? Type1335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostInternalTriggerLogsResponseDataItemType? Type1336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostInternalTriggerLogsResponseDataItemMeta? Type1337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostInternalTriggerLogsResponseDataItemMetaType? Type1338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetInternalTriggerLogByIdResponse? Type1339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetInternalTriggerLogByIdResponseLog? Type1340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetInternalTriggerLogByIdResponseLogType? Type1341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetInternalTriggerLogByIdResponseLogMeta? Type1342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetInternalTriggerLogByIdResponseLogMetaType? Type1343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostInternalActionExecutionLogsResponse? Type1344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostInternalActionExecutionLogsResponseDataItem>? Type1345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostInternalActionExecutionLogsResponseDataItem? Type1346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostInternalActionExecutionLogsResponseDataItemApp? Type1347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostInternalActionExecutionLogsResponseDataItemStatus? Type1348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostInternalActionExecutionLogsResponseDataItemMetadata? Type1349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostInternalActionExecutionLogsResponseDataItemCredentialSource? Type1350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetInternalActionExecutionFieldsResponse? Type1351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Composio.GetInternalActionExecutionFieldsResponseField>>? Type1352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetInternalActionExecutionFieldsResponseField>? Type1353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetInternalActionExecutionFieldsResponseField? Type1354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetInternalActionExecutionLogByIdResponse? Type1355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetInternalActionExecutionLogByIdResponseStatus? Type1356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetInternalActionExecutionLogByIdResponseApp? Type1357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetInternalActionExecutionLogByIdResponseConnection? Type1358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetInternalActionExecutionLogByIdResponseCredentialSource? Type1359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetInternalActionExecutionLogByIdResponseStep>? Type1360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetInternalActionExecutionLogByIdResponseStep? Type1361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetInternalActionExecutionLogByIdResponseStepType? Type1362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetInternalActionExecutionLogByIdResponseStepStatus? Type1363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetInternalActionExecutionLogByIdResponseStepMetadata? Type1364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetInternalActionExecutionLogByIdResponseStepLog>? Type1365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetInternalActionExecutionLogByIdResponseStepLog? Type1366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetInternalActionExecutionLogByIdResponseStepLogType? Type1367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetInternalActionExecutionLogByIdResponseStepLogRequest? Type1368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetInternalActionExecutionLogByIdResponseStepLogResponse? Type1369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetOrgListResponse? Type1370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetOrgListResponseOrganization>? Type1371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetOrgListResponseOrganization? Type1372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetOrgProjectListResponse? Type1373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetOrgProjectListResponseDataItem>? Type1374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetOrgProjectListResponseDataItem? Type1375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetOrgProjectListResponseDataItemWebhookVersion? Type1376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostOrgOwnerProjectNewResponse? Type1377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetOrgOwnerProjectListResponse? Type1378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetOrgOwnerProjectListResponseDataItem>? Type1379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetOrgOwnerProjectListResponseDataItem? Type1380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetOrgOwnerProjectListResponseDataItemWebhookVersion? Type1381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetOrgOwnerProjectByNanoIdResponse? Type1382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetOrgOwnerProjectByNanoIdResponseWebhookVersion? Type1383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetOrgOwnerProjectByNanoIdResponseApiKey>? Type1384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetOrgOwnerProjectByNanoIdResponseApiKey? Type1385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.DeleteOrgOwnerProjectByNanoIdResponse? Type1386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.DeleteOrgOwnerProjectByNanoIdResponseStatus? Type1387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostOrgOwnerProjectByNanoIdRegenerateApiKeyResponse? Type1388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostOrgOwnerProjectByNanoIdRegenerateApiKeyResponseApiKey? Type1389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostOrgConsumerProjectResolveResponse? Type1390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostOrgConsumerProjectResolveResponseProjectType? Type1391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostOrgConsumerProjectResolveResponseConfig? Type1392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetOrgConsumerConnectedToolkitsResponse? Type1393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostWebhookSubscriptionsResponse? Type1394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostWebhookSubscriptionsResponseVersion? Type1395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetWebhookSubscriptionsResponse? Type1396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetWebhookSubscriptionsResponseItem>? Type1397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetWebhookSubscriptionsResponseItem? Type1398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetWebhookSubscriptionsResponseItemVersion? Type1399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetWebhookSubscriptionsByIdResponse? Type1400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetWebhookSubscriptionsByIdResponseVersion? Type1401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchWebhookSubscriptionsByIdResponse? Type1402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchWebhookSubscriptionsByIdResponseVersion? Type1403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.DeleteWebhookSubscriptionsByIdResponse? Type1404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostWebhookSubscriptionsByIdRotateSecretResponse? Type1405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetWebhookSubscriptionsEventTypesResponse? Type1406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetWebhookSubscriptionsEventTypesResponseItem>? Type1407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetWebhookSubscriptionsEventTypesResponseItem? Type1408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetWebhookSubscriptionsEventTypesResponseItemSupportedVersion>? Type1409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetWebhookSubscriptionsEventTypesResponseItemSupportedVersion? Type1410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostWebhookEndpointsResponse? Type1411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostWebhookEndpointsResponse2? Type1412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetWebhookEndpointsResponse? Type1413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetWebhookEndpointsResponseItem>? Type1414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetWebhookEndpointsResponseItem? Type1415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetWebhookEndpointsByNanoIdResponse? Type1416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostWebhookEndpointsByNanoIdResponse? Type1417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchWebhookEndpointsByNanoIdResponse? Type1418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsResponse? Type1419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetToolkitsResponseItem>? Type1420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsResponseItem? Type1421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsResponseItemType? Type1422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsResponseItemInstant? Type1423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsResponseItemAccess? Type1424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsResponseItemMeta? Type1425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetToolkitsResponseItemMetaCategorie>? Type1426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsResponseItemMetaCategorie? Type1427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsCategoriesResponse? Type1428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetToolkitsCategoriesResponseItem>? Type1429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsCategoriesResponseItem? Type1430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostCustomToolkitsUpsertResponse? Type1431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostCustomToolkitsSyncResponse? Type1432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsBySlugResponse? Type1433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsBySlugResponseType? Type1434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsBySlugResponseAccess? Type1435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetToolkitsBySlugResponseComposioManagedAuthItem>? Type1436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsBySlugResponseComposioManagedAuthItem? Type1437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsBySlugResponseComposioManagedAuthItemScopes? Type1438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsBySlugResponseComposioManagedAuthItemUserScopes? Type1439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetToolkitsBySlugResponseAuthConfigDetail>? Type1440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsBySlugResponseAuthConfigDetail? Type1441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsBySlugResponseAuthConfigDetailFields? Type1442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsBySlugResponseAuthConfigDetailFieldsAuthConfigCreation? Type1443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetToolkitsBySlugResponseAuthConfigDetailFieldsAuthConfigCreationRequiredItem>? Type1444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsBySlugResponseAuthConfigDetailFieldsAuthConfigCreationRequiredItem? Type1445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetToolkitsBySlugResponseAuthConfigDetailFieldsAuthConfigCreationOptionalItem>? Type1446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsBySlugResponseAuthConfigDetailFieldsAuthConfigCreationOptionalItem? Type1447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsBySlugResponseAuthConfigDetailFieldsConnectedAccountInitiation? Type1448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetToolkitsBySlugResponseAuthConfigDetailFieldsConnectedAccountInitiationRequiredItem>? Type1449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsBySlugResponseAuthConfigDetailFieldsConnectedAccountInitiationRequiredItem? Type1450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetToolkitsBySlugResponseAuthConfigDetailFieldsConnectedAccountInitiationOptionalItem>? Type1451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsBySlugResponseAuthConfigDetailFieldsConnectedAccountInitiationOptionalItem? Type1452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsBySlugResponseAuthConfigDetailProxy? Type1453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsBySlugResponseAuthConfigDetailDeprecatedAuthProviderDetails? Type1454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsBySlugResponseMeta? Type1455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetToolkitsBySlugResponseMetaCategorie>? Type1456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsBySlugResponseMetaCategorie? Type1457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsBySlugResponseDeprecated? Type1458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, object?>>? Type1459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolkitsMultiResponse? Type1460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolkitsMultiResponseItem>? Type1461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolkitsMultiResponseItem? Type1462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolkitsMultiResponseItemType? Type1463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolkitsMultiResponseItemInstant? Type1464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolkitsMultiResponseItemAccess? Type1465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolkitsMultiResponseItemMeta? Type1466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolkitsMultiResponseItemMetaCategorie>? Type1467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolkitsMultiResponseItemMetaCategorie? Type1468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugResponse? Type1469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteByToolSlugInputResponse? Type1470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyResponse? Type1471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolsExecuteProxyResponseBinaryData? Type1472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostTriggerInstancesBySlugUpsertResponse? Type1473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostTriggerInstancesBySlugUpsertResponse2? Type1474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetTriggerInstancesActiveResponse? Type1475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetTriggerInstancesActiveResponseItem>? Type1476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetTriggerInstancesActiveResponseItem? Type1477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetTriggerInstancesActiveResponseItemDeprecated? Type1478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.DeleteTriggerInstancesManageByTriggerIdResponse? Type1479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchTriggerInstancesManageByTriggerIdResponse? Type1480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchTriggerInstancesManageByTriggerIdResponseStatus? Type1481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetTriggersTypesBySlugResponse? Type1482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetTriggersTypesBySlugResponseType? Type1483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetTriggersTypesBySlugResponseToolkit? Type1484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetTriggersTypesResponse? Type1485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetTriggersTypesResponseItem>? Type1486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetTriggersTypesResponseItem? Type1487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetTriggersTypesResponseItemType? Type1488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetTriggersTypesResponseItemToolkit? Type1489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetMcpServersResponse? Type1490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetMcpServersResponseItem>? Type1491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetMcpServersResponseItem? Type1492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetMcpServersResponseItemCommands? Type1493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostMcpServersResponse? Type1494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostMcpServersResponseCommands? Type1495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostMcpServersCustomResponse? Type1496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostMcpServersCustomResponseCommands? Type1497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostMcpServersGenerateResponse? Type1498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetMcpByIdResponse? Type1499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetMcpByIdResponseCommands? Type1500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchMcpByIdResponse? Type1501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchMcpByIdResponseCommands? Type1502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.DeleteMcpByIdResponse? Type1503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetMcpAppByAppKeyResponse? Type1504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetMcpAppByAppKeyResponseItem>? Type1505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetMcpAppByAppKeyResponseItem? Type1506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetMcpAppByAppKeyResponseItemCommands? Type1507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetMcpServersByServerIdInstancesResponse? Type1508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetMcpServersByServerIdInstancesResponseInstance>? Type1509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetMcpServersByServerIdInstancesResponseInstance? Type1510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostMcpServersByServerIdInstancesResponse? Type1511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.DeleteMcpServersByServerIdInstancesByInstanceIdResponse? Type1512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetFilesListResponse? Type1513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetFilesListResponseItem>? Type1514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetFilesListResponseItem? Type1515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostFilesUploadRequestResponse? Type1516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostFilesUploadRequestResponseType? Type1517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostFilesUploadRequestResponseMetadata? Type1518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostFilesUploadRequestResponseMetadataStorageBackend? Type1519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponse? Type1520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseMcp? Type1521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseMcpType? Type1522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfig? Type1523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigToolkitsVariant1? Type1524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigToolkitsVariant2? Type1525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigToolkitsVariant3? Type1526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.AnyOf<bool?, global::Composio.PostToolRouterSessionResponseConfigInstant>? Type1527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigInstant? Type1528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigInstantToolkitsVariant1? Type1529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigInstantToolkitsVariant2? Type1530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigInstantToolsVariant1? Type1531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigInstantToolsVariant2? Type1532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigManageConnections? Type1533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigToolsVariant1? Type1534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigToolsVariant2? Type1535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigToolsVariant3? Type1536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigToolsVariant3Tags? Type1537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionResponseConfigToolsVariant3TagsEnabledItem>? Type1538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigToolsVariant3TagsEnabledItem? Type1539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionResponseConfigToolsVariant3TagsDisabledItem>? Type1540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigToolsVariant3TagsDisabledItem? Type1541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionResponseConfigToolsVariant3TagsRequireApprovalItem>? Type1542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigToolsVariant3TagsRequireApprovalItem? Type1543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigToolsVariant4? Type1544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigTags? Type1545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionResponseConfigTagsEnabledItem>? Type1546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigTagsEnabledItem? Type1547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionResponseConfigTagsDisabledItem>? Type1548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigTagsDisabledItem? Type1549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionResponseConfigTagsRequireApprovalItem>? Type1550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigTagsRequireApprovalItem? Type1551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigWorkbench? Type1552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigWorkbenchSandboxSize? Type1553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigMultiAccount? Type1554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigProxyExecute? Type1555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseConfigPreload? Type1556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseExperimental? Type1557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionResponseExperimentalCustomToolkit>? Type1558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseExperimentalCustomToolkit? Type1559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionResponseExperimentalCustomToolkitTool>? Type1560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseExperimentalCustomToolkitTool? Type1561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionResponseExperimentalCustomTool>? Type1562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseExperimentalCustomTool? Type1563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseExperimentalNoElicitationSupportFallback? Type1564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionResponseWarning>? Type1565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseWarning? Type1566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionResponseWarningCode? Type1567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdExecuteResponse? Type1568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdExecuteResponseDiscriminator? Type1569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdExecuteResponseDiscriminatorResultType? Type1570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdExecuteMetaResponse? Type1571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdExecuteMetaResponseDiscriminator? Type1572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdExecuteMetaResponseDiscriminatorResultType? Type1573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponse? Type1574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseMcp? Type1575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseMcpType? Type1576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfig? Type1577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolkitsVariant1? Type1578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolkitsVariant2? Type1579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolkitsVariant3? Type1580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.AnyOf<bool?, global::Composio.GetToolRouterSessionBySessionIdResponseConfigInstant>? Type1581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigInstant? Type1582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigInstantToolkitsVariant1? Type1583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigInstantToolkitsVariant2? Type1584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigInstantToolsVariant1? Type1585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigInstantToolsVariant2? Type1586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigManageConnections? Type1587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolsVariant1? Type1588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolsVariant2? Type1589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3? Type1590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3Tags? Type1591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItem>? Type1592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItem? Type1593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsDisabledItem>? Type1594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsDisabledItem? Type1595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsRequireApprovalItem>? Type1596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsRequireApprovalItem? Type1597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolsVariant4? Type1598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigTags? Type1599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetToolRouterSessionBySessionIdResponseConfigTagsEnabledItem>? Type1600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigTagsEnabledItem? Type1601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetToolRouterSessionBySessionIdResponseConfigTagsDisabledItem>? Type1602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigTagsDisabledItem? Type1603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetToolRouterSessionBySessionIdResponseConfigTagsRequireApprovalItem>? Type1604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigTagsRequireApprovalItem? Type1605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigWorkbench? Type1606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigWorkbenchSandboxSize? Type1607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigMultiAccount? Type1608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigProxyExecute? Type1609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigPreload? Type1610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseExperimental? Type1611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetToolRouterSessionBySessionIdResponseExperimentalCustomToolkit>? Type1612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseExperimentalCustomToolkit? Type1613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetToolRouterSessionBySessionIdResponseExperimentalCustomToolkitTool>? Type1614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseExperimentalCustomToolkitTool? Type1615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetToolRouterSessionBySessionIdResponseExperimentalCustomTool>? Type1616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseExperimentalCustomTool? Type1617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseExperimentalNoElicitationSupportFallback? Type1618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetToolRouterSessionBySessionIdResponseWarning>? Type1619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseWarning? Type1620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdResponseWarningCode? Type1621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponse? Type1622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseMcp? Type1623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseMcpType? Type1624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfig? Type1625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigToolkitsVariant1? Type1626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigToolkitsVariant2? Type1627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigToolkitsVariant3? Type1628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.AnyOf<bool?, global::Composio.PatchToolRouterSessionBySessionIdResponseConfigInstant>? Type1629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigInstant? Type1630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigInstantToolkitsVariant1? Type1631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigInstantToolkitsVariant2? Type1632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigInstantToolsVariant1? Type1633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigInstantToolsVariant2? Type1634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigManageConnections? Type1635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigToolsVariant1? Type1636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigToolsVariant2? Type1637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigToolsVariant3? Type1638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigToolsVariant3Tags? Type1639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PatchToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItem>? Type1640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItem? Type1641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PatchToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsDisabledItem>? Type1642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsDisabledItem? Type1643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PatchToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsRequireApprovalItem>? Type1644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsRequireApprovalItem? Type1645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigToolsVariant4? Type1646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigTags? Type1647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PatchToolRouterSessionBySessionIdResponseConfigTagsEnabledItem>? Type1648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigTagsEnabledItem? Type1649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PatchToolRouterSessionBySessionIdResponseConfigTagsDisabledItem>? Type1650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigTagsDisabledItem? Type1651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PatchToolRouterSessionBySessionIdResponseConfigTagsRequireApprovalItem>? Type1652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigTagsRequireApprovalItem? Type1653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigWorkbench? Type1654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigWorkbenchSandboxSize? Type1655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigMultiAccount? Type1656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigProxyExecute? Type1657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigPreload? Type1658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseExperimental? Type1659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PatchToolRouterSessionBySessionIdResponseExperimentalCustomToolkit>? Type1660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseExperimentalCustomToolkit? Type1661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PatchToolRouterSessionBySessionIdResponseExperimentalCustomToolkitTool>? Type1662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseExperimentalCustomToolkitTool? Type1663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PatchToolRouterSessionBySessionIdResponseExperimentalCustomTool>? Type1664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseExperimentalCustomTool? Type1665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseExperimentalNoElicitationSupportFallback? Type1666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PatchToolRouterSessionBySessionIdResponseWarning>? Type1667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseWarning? Type1668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchToolRouterSessionBySessionIdResponseWarningCode? Type1669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdLinkResponse? Type1670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdLinkResponseExperimental? Type1671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdLinkResponseExperimentalAccountType? Type1672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdLinkResponseExperimentalAclConfigForShared? Type1673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteResponse? Type1674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteResponseDiscriminator? Type1675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteResponseDiscriminatorResultType? Type1676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdToolsResponse? Type1677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdSearchResponse? Type1678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionBySessionIdSearchResponseResult>? Type1679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdSearchResponseResult? Type1680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionBySessionIdSearchResponseResultReferenceWorkbenchSnippet>? Type1681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdSearchResponseResultReferenceWorkbenchSnippet? Type1682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuse>? Type1683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuse? Type1684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccountType? Type1685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccount>? Type1686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccount? Type1687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccountAccountType? Type1688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccountSelection? Type1689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseInstantAccount? Type1690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Composio.PostToolRouterSessionBySessionIdSearchResponseToolSchemas2>? Type1691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdSearchResponseToolSchemas2? Type1692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdSearchResponseToolSchemasSchemaRef? Type1693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdSearchResponseToolSchemasSchemaRefTool? Type1694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdSearchResponseToolSchemasSchemaRefArgs? Type1695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdSearchResponseTimeInfo? Type1696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdSearchResponseSession? Type1697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdMountsByMountIdItemsResponse? Type1698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetToolRouterSessionBySessionIdMountsByMountIdItemsResponseItem>? Type1699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolRouterSessionBySessionIdMountsByMountIdItemsResponseItem? Type1700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdMountsByMountIdDownloadUrlResponse? Type1701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdMountsByMountIdUploadUrlResponse? Type1702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdMountsByMountIdDeleteResponse? Type1703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsChangelogResponse? Type1704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetToolkitsChangelogResponseItem>? Type1705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsChangelogResponseItem? Type1706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Composio.GetToolkitsChangelogResponseItemVersion>? Type1707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.GetToolkitsChangelogResponseItemVersion? Type1708 { get; set; }

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
        public global::System.Collections.Generic.List<global::Composio.ToolRouterToolkitsListResponseItem>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostInternalTriggerLogsRequestSearchParam>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostInternalActionExecutionLogsRequestSearchParam>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostOrgOwnerProjectNewRequestApiKeyPermission>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolsExecuteByToolSlugRequestCustomAuthParamsParameter>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolsExecuteProxyRequestParameter>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.AnyOf<global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionRequestToolsVariant3Tag>, global::Composio.PostToolRouterSessionRequestToolsVariant3Tags>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionRequestToolsVariant3Tag>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionRequestToolsVariant3TagsEnableItem>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionRequestToolsVariant3TagsDisableItem>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionRequestToolsVariant3TagsRequireApprovalItem>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.AnyOf<global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionRequestTag>, global::Composio.PostToolRouterSessionRequestTags>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionRequestTag>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionRequestTagsEnableItem>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionRequestTagsDisableItem>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionRequestTagsRequireApprovalItem>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionRequestExperimentalCustomToolkit>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionRequestExperimentalCustomToolkitTool>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionRequestExperimentalCustomTool>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PatchToolRouterSessionBySessionIdRequestToolsVariant3Tag>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsEnableItem>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsDisableItem>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsRequireApprovalItem>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.AnyOf<global::System.Collections.Generic.List<global::Composio.PatchToolRouterSessionBySessionIdRequestTag>, global::Composio.PatchToolRouterSessionBySessionIdRequestTags>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PatchToolRouterSessionBySessionIdRequestTag>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PatchToolRouterSessionBySessionIdRequestTagsEnableItem>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PatchToolRouterSessionBySessionIdRequestTagsDisableItem>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PatchToolRouterSessionBySessionIdRequestTagsRequireApprovalItem>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestParameter>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionBySessionIdSearchRequestQuerie>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetConnectedAccountsStatuse>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Composio.OneOf<string, global::System.Collections.Generic.List<string>>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetAuthConfigsResponseItem>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetAuthConfigsResponseItemExpectedInputField>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetAuthConfigsByNanoidResponseExpectedInputField>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetConnectedAccountsResponseItem>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostInternalTriggerLogsResponseDataItem>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostInternalActionExecutionLogsResponseDataItem>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Composio.GetInternalActionExecutionFieldsResponseField>>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetInternalActionExecutionFieldsResponseField>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetInternalActionExecutionLogByIdResponseStep>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetInternalActionExecutionLogByIdResponseStepLog>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetOrgListResponseOrganization>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetOrgProjectListResponseDataItem>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetOrgOwnerProjectListResponseDataItem>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetOrgOwnerProjectByNanoIdResponseApiKey>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetWebhookSubscriptionsResponseItem>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetWebhookSubscriptionsEventTypesResponseItem>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetWebhookSubscriptionsEventTypesResponseItemSupportedVersion>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetWebhookEndpointsResponseItem>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetToolkitsResponseItem>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetToolkitsResponseItemMetaCategorie>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetToolkitsCategoriesResponseItem>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetToolkitsBySlugResponseComposioManagedAuthItem>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetToolkitsBySlugResponseAuthConfigDetail>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetToolkitsBySlugResponseAuthConfigDetailFieldsAuthConfigCreationRequiredItem>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetToolkitsBySlugResponseAuthConfigDetailFieldsAuthConfigCreationOptionalItem>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetToolkitsBySlugResponseAuthConfigDetailFieldsConnectedAccountInitiationRequiredItem>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetToolkitsBySlugResponseAuthConfigDetailFieldsConnectedAccountInitiationOptionalItem>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetToolkitsBySlugResponseMetaCategorie>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, object?>>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolkitsMultiResponseItem>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolkitsMultiResponseItemMetaCategorie>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetTriggerInstancesActiveResponseItem>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetTriggersTypesResponseItem>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetMcpServersResponseItem>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetMcpAppByAppKeyResponseItem>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetMcpServersByServerIdInstancesResponseInstance>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetFilesListResponseItem>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionResponseConfigToolsVariant3TagsEnabledItem>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionResponseConfigToolsVariant3TagsDisabledItem>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionResponseConfigToolsVariant3TagsRequireApprovalItem>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionResponseConfigTagsEnabledItem>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionResponseConfigTagsDisabledItem>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionResponseConfigTagsRequireApprovalItem>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionResponseExperimentalCustomToolkit>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionResponseExperimentalCustomToolkitTool>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionResponseExperimentalCustomTool>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionResponseWarning>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItem>? ListType87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsDisabledItem>? ListType88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsRequireApprovalItem>? ListType89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetToolRouterSessionBySessionIdResponseConfigTagsEnabledItem>? ListType90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetToolRouterSessionBySessionIdResponseConfigTagsDisabledItem>? ListType91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetToolRouterSessionBySessionIdResponseConfigTagsRequireApprovalItem>? ListType92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetToolRouterSessionBySessionIdResponseExperimentalCustomToolkit>? ListType93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetToolRouterSessionBySessionIdResponseExperimentalCustomToolkitTool>? ListType94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetToolRouterSessionBySessionIdResponseExperimentalCustomTool>? ListType95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetToolRouterSessionBySessionIdResponseWarning>? ListType96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PatchToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItem>? ListType97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PatchToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsDisabledItem>? ListType98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PatchToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsRequireApprovalItem>? ListType99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PatchToolRouterSessionBySessionIdResponseConfigTagsEnabledItem>? ListType100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PatchToolRouterSessionBySessionIdResponseConfigTagsDisabledItem>? ListType101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PatchToolRouterSessionBySessionIdResponseConfigTagsRequireApprovalItem>? ListType102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PatchToolRouterSessionBySessionIdResponseExperimentalCustomToolkit>? ListType103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PatchToolRouterSessionBySessionIdResponseExperimentalCustomToolkitTool>? ListType104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PatchToolRouterSessionBySessionIdResponseExperimentalCustomTool>? ListType105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PatchToolRouterSessionBySessionIdResponseWarning>? ListType106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionBySessionIdSearchResponseResult>? ListType107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionBySessionIdSearchResponseResultReferenceWorkbenchSnippet>? ListType108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuse>? ListType109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccount>? ListType110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetToolRouterSessionBySessionIdMountsByMountIdItemsResponseItem>? ListType111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetToolkitsChangelogResponseItem>? ListType112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Composio.GetToolkitsChangelogResponseItemVersion>? ListType113 { get; set; }
    }
}