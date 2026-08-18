
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Composio
{
    public partial class ToolsClient
    {


        private static readonly global::Composio.EndPointSecurityRequirement s_PostToolsExecuteByToolSlugSecurityRequirement0 =
            new global::Composio.EndPointSecurityRequirement
            {
                Authorizations = new global::Composio.EndPointAuthorizationRequirement[]
                {                    new global::Composio.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Composio.EndPointSecurityRequirement[] s_PostToolsExecuteByToolSlugSecurityRequirements =
            new global::Composio.EndPointSecurityRequirement[]
            {                s_PostToolsExecuteByToolSlugSecurityRequirement0,
            };
        partial void PreparePostToolsExecuteByToolSlugArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string toolSlug,
            ref string? xLlmGatewayHeaders,
            global::Composio.PostToolsExecuteByToolSlugRequest request);
        partial void PreparePostToolsExecuteByToolSlugRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string toolSlug,
            string? xLlmGatewayHeaders,
            global::Composio.PostToolsExecuteByToolSlugRequest request);
        partial void ProcessPostToolsExecuteByToolSlugResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPostToolsExecuteByToolSlugResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Execute tool<br/>
        /// Execute a specific tool operation with provided arguments and authentication. This is the primary endpoint for integrating with third-party services and executing tools. You can provide structured arguments or use natural language processing by providing a text description of what you want to accomplish.
        /// </summary>
        /// <param name="toolSlug"></param>
        /// <param name="xLlmGatewayHeaders">
        /// JSON object containing custom headers to pass to LLM providers (OpenAI, Bedrock, etc.)<br/>
        /// Example: {"x-custom-header": "value", "authorization": "Bearer token"}
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Composio.PostToolsExecuteByToolSlugResponse> PostToolsExecuteByToolSlugAsync(
            string toolSlug,

            global::Composio.PostToolsExecuteByToolSlugRequest request,
            string? xLlmGatewayHeaders = default,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await PostToolsExecuteByToolSlugAsResponseAsync(
                toolSlug: toolSlug,

                request: request,
                xLlmGatewayHeaders: xLlmGatewayHeaders,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Execute tool<br/>
        /// Execute a specific tool operation with provided arguments and authentication. This is the primary endpoint for integrating with third-party services and executing tools. You can provide structured arguments or use natural language processing by providing a text description of what you want to accomplish.
        /// </summary>
        /// <param name="toolSlug"></param>
        /// <param name="xLlmGatewayHeaders">
        /// JSON object containing custom headers to pass to LLM providers (OpenAI, Bedrock, etc.)<br/>
        /// Example: {"x-custom-header": "value", "authorization": "Bearer token"}
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Composio.AutoSDKHttpResponse<global::Composio.PostToolsExecuteByToolSlugResponse>> PostToolsExecuteByToolSlugAsResponseAsync(
            string toolSlug,

            global::Composio.PostToolsExecuteByToolSlugRequest request,
            string? xLlmGatewayHeaders = default,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PreparePostToolsExecuteByToolSlugArguments(
                httpClient: HttpClient,
                toolSlug: ref toolSlug,
                xLlmGatewayHeaders: ref xLlmGatewayHeaders,
                request: request);


            var __authorizations = global::Composio.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_PostToolsExecuteByToolSlugSecurityRequirements,
                operationName: "PostToolsExecuteByToolSlugAsync");

            using var __timeoutCancellationTokenSource = global::Composio.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Composio.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Composio.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::Composio.PathBuilder(
                                path: $"/api/v3/tools/execute/{toolSlug}",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::Composio.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                } 
            }

            if (xLlmGatewayHeaders != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("x-llm-gateway-headers", xLlmGatewayHeaders.ToString());
            }

                            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::Composio.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PreparePostToolsExecuteByToolSlugRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    toolSlug: toolSlug!,
                    xLlmGatewayHeaders: xLlmGatewayHeaders,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Composio.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Composio.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "PostToolsExecuteByToolSlug",
                                methodName: "PostToolsExecuteByToolSlugAsync",
                                pathTemplate: "$\"/api/v3/tools/execute/{toolSlug}\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::Composio.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Composio.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Composio.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "PostToolsExecuteByToolSlug",
                                methodName: "PostToolsExecuteByToolSlugAsync",
                                pathTemplate: "$\"/api/v3/tools/execute/{toolSlug}\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Composio.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Composio.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::Composio.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::Composio.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Composio.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "PostToolsExecuteByToolSlug",
                                methodName: "PostToolsExecuteByToolSlugAsync",
                                pathTemplate: "$\"/api/v3/tools/execute/{toolSlug}\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Composio.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessPostToolsExecuteByToolSlugResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Composio.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Composio.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "PostToolsExecuteByToolSlug",
                                methodName: "PostToolsExecuteByToolSlugAsync",
                                pathTemplate: "$\"/api/v3/tools/execute/{toolSlug}\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Composio.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Composio.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "PostToolsExecuteByToolSlug",
                                methodName: "PostToolsExecuteByToolSlugAsync",
                                pathTemplate: "$\"/api/v3/tools/execute/{toolSlug}\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Bad request - Invalid request parameters, missing required arguments, or conflicting parameters
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                global::Composio.Error? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::Composio.Error.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = global::Composio.Error.FromJson(__content_400, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }


                                throw global::Composio.ApiException<global::Composio.Error>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_400,
                                    responseBody: __content_400,
                                    responseObject: __value_400,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Unauthorized - Authentication credentials are missing or invalid
                            if ((int)__response.StatusCode == 401)
                            {
                                string? __content_401 = null;
                                global::System.Exception? __exception_401 = null;
                                global::Composio.Error? __value_401 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_401 = global::Composio.Error.FromJson(__content_401, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_401 = global::Composio.Error.FromJson(__content_401, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_401 = __ex;
                                }


                                throw global::Composio.ApiException<global::Composio.Error>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_401,
                                    responseBody: __content_401,
                                    responseObject: __value_401,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Forbidden - Connected account does not have permission to execute this tool or access the requested resource
                            if ((int)__response.StatusCode == 403)
                            {
                                string? __content_403 = null;
                                global::System.Exception? __exception_403 = null;
                                global::Composio.Error? __value_403 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_403 = global::Composio.Error.FromJson(__content_403, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_403 = global::Composio.Error.FromJson(__content_403, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_403 = __ex;
                                }


                                throw global::Composio.ApiException<global::Composio.Error>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_403,
                                    responseBody: __content_403,
                                    responseObject: __value_403,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Not found - Tool or connected account not found
                            if ((int)__response.StatusCode == 404)
                            {
                                string? __content_404 = null;
                                global::System.Exception? __exception_404 = null;
                                global::Composio.Error? __value_404 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_404 = global::Composio.Error.FromJson(__content_404, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_404 = global::Composio.Error.FromJson(__content_404, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_404 = __ex;
                                }


                                throw global::Composio.ApiException<global::Composio.Error>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_404,
                                    responseBody: __content_404,
                                    responseObject: __value_404,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Request timeout - Tool execution exceeded the maximum allowed time
                            if ((int)__response.StatusCode == 408)
                            {
                                string? __content_408 = null;
                                global::System.Exception? __exception_408 = null;
                                global::Composio.Error? __value_408 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_408 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_408 = global::Composio.Error.FromJson(__content_408, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_408 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_408 = global::Composio.Error.FromJson(__content_408, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_408 = __ex;
                                }


                                throw global::Composio.ApiException<global::Composio.Error>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_408 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_408,
                                    responseBody: __content_408,
                                    responseObject: __value_408,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Gone - Tool has been deprecated and is no longer available
                            if ((int)__response.StatusCode == 410)
                            {
                                string? __content_410 = null;
                                global::System.Exception? __exception_410 = null;
                                global::Composio.Error? __value_410 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_410 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_410 = global::Composio.Error.FromJson(__content_410, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_410 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_410 = global::Composio.Error.FromJson(__content_410, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_410 = __ex;
                                }


                                throw global::Composio.ApiException<global::Composio.Error>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_410 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_410,
                                    responseBody: __content_410,
                                    responseObject: __value_410,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Payload too large - Request or response payload exceeds size limits
                            if ((int)__response.StatusCode == 413)
                            {
                                string? __content_413 = null;
                                global::System.Exception? __exception_413 = null;
                                global::Composio.Error? __value_413 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_413 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_413 = global::Composio.Error.FromJson(__content_413, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_413 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_413 = global::Composio.Error.FromJson(__content_413, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_413 = __ex;
                                }


                                throw global::Composio.ApiException<global::Composio.Error>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_413 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_413,
                                    responseBody: __content_413,
                                    responseObject: __value_413,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Unprocessable entity - Invalid state of the connected account
                            if ((int)__response.StatusCode == 422)
                            {
                                string? __content_422 = null;
                                global::System.Exception? __exception_422 = null;
                                global::Composio.Error? __value_422 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_422 = global::Composio.Error.FromJson(__content_422, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_422 = global::Composio.Error.FromJson(__content_422, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_422 = __ex;
                                }


                                throw global::Composio.ApiException<global::Composio.Error>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_422,
                                    responseBody: __content_422,
                                    responseObject: __value_422,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Rate limit exceeded - Too many requests to the tool or underlying API
                            if ((int)__response.StatusCode == 429)
                            {
                                string? __content_429 = null;
                                global::System.Exception? __exception_429 = null;
                                global::Composio.Error? __value_429 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_429 = global::Composio.Error.FromJson(__content_429, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_429 = global::Composio.Error.FromJson(__content_429, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_429 = __ex;
                                }


                                throw global::Composio.ApiException<global::Composio.Error>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_429 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_429,
                                    responseBody: __content_429,
                                    responseObject: __value_429,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Internal server error - Something went wrong on the server
                            if ((int)__response.StatusCode == 500)
                            {
                                string? __content_500 = null;
                                global::System.Exception? __exception_500 = null;
                                global::Composio.Error? __value_500 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_500 = global::Composio.Error.FromJson(__content_500, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_500 = global::Composio.Error.FromJson(__content_500, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_500 = __ex;
                                }


                                throw global::Composio.ApiException<global::Composio.Error>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_500,
                                    responseBody: __content_500,
                                    responseObject: __value_500,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Not implemented
                            if ((int)__response.StatusCode == 501)
                            {
                                string? __content_501 = null;
                                global::System.Exception? __exception_501 = null;
                                global::Composio.Error? __value_501 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_501 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_501 = global::Composio.Error.FromJson(__content_501, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_501 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_501 = global::Composio.Error.FromJson(__content_501, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_501 = __ex;
                                }


                                throw global::Composio.ApiException<global::Composio.Error>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_501 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_501,
                                    responseBody: __content_501,
                                    responseObject: __value_501,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Bad gateway - Error communicating with the tool provider API
                            if ((int)__response.StatusCode == 502)
                            {
                                string? __content_502 = null;
                                global::System.Exception? __exception_502 = null;
                                global::Composio.Error? __value_502 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_502 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_502 = global::Composio.Error.FromJson(__content_502, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_502 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_502 = global::Composio.Error.FromJson(__content_502, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_502 = __ex;
                                }


                                throw global::Composio.ApiException<global::Composio.Error>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_502 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_502,
                                    responseBody: __content_502,
                                    responseObject: __value_502,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Upstream service unavailable - Tool provider API is currently down or unavailable
                            if ((int)__response.StatusCode == 503)
                            {
                                string? __content_503 = null;
                                global::System.Exception? __exception_503 = null;
                                global::Composio.Error? __value_503 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_503 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_503 = global::Composio.Error.FromJson(__content_503, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_503 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_503 = global::Composio.Error.FromJson(__content_503, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_503 = __ex;
                                }


                                throw global::Composio.ApiException<global::Composio.Error>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_503 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_503,
                                    responseBody: __content_503,
                                    responseObject: __value_503,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessPostToolsExecuteByToolSlugResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Composio.PostToolsExecuteByToolSlugResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Composio.AutoSDKHttpResponse<global::Composio.PostToolsExecuteByToolSlugResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Composio.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::Composio.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::Composio.PostToolsExecuteByToolSlugResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Composio.AutoSDKHttpResponse<global::Composio.PostToolsExecuteByToolSlugResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Composio.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw global::Composio.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Execute tool<br/>
        /// Execute a specific tool operation with provided arguments and authentication. This is the primary endpoint for integrating with third-party services and executing tools. You can provide structured arguments or use natural language processing by providing a text description of what you want to accomplish.
        /// </summary>
        /// <param name="toolSlug"></param>
        /// <param name="xLlmGatewayHeaders">
        /// JSON object containing custom headers to pass to LLM providers (OpenAI, Bedrock, etc.)<br/>
        /// Example: {"x-custom-header": "value", "authorization": "Bearer token"}
        /// </param>
        /// <param name="connectedAccountId">
        /// Unique identifier for the connected account to use for authentication<br/>
        /// Example: ca_1a2b3c4d5e6f
        /// </param>
        /// <param name="userId">
        /// User id for multi-user connected accounts (e.g. multiple users, organizations)<br/>
        /// Example: user-123
        /// </param>
        /// <param name="version">
        /// Tool version to execute. Defaults to the pinned version ("00000000_00") when omitted.<br/>
        /// Example: latest
        /// </param>
        /// <param name="customAuthParams">
        /// Custom authentication parameters for tools that support parameterized authentication<br/>
        /// Example: {"base_url":"https://api.example.com","parameters":[{"name":"x-api-key","value":"secret-key","in":"header"}]}
        /// </param>
        /// <param name="customConnectionData">
        /// Custom connection data for tools that support custom connection data<br/>
        /// Example: {"authScheme":"OAUTH2","toolkitSlug":"github","val":{"access_token":"secret-token"}}
        /// </param>
        /// <param name="arguments">
        /// Key-value pairs of arguments required by the tool (mutually exclusive with text)<br/>
        /// Example: {"repository":"octocat/Hello-World","workflow_id":"main.yml","ref":"main","inputs":{"environment":"production"}}
        /// </param>
        /// <param name="text">
        /// Natural language description of the task to perform (mutually exclusive with arguments)<br/>
        /// Example: Trigger the main workflow in the octocat/Hello-World repository on the main branch for the production environment
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Composio.PostToolsExecuteByToolSlugResponse> PostToolsExecuteByToolSlugAsync(
            string toolSlug,
            string? xLlmGatewayHeaders = default,
            string? connectedAccountId = default,
            string? userId = default,
            string? version = default,
            global::Composio.PostToolsExecuteByToolSlugRequestCustomAuthParams? customAuthParams = default,
            global::Composio.OneOf<global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant1, global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant2, global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant3, global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant4, global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant5, global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant6, global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant7, global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant8, global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant9, global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant10, global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant11>? customConnectionData = default,
            global::System.Collections.Generic.Dictionary<string, object?>? arguments = default,
            string? text = default,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Composio.PostToolsExecuteByToolSlugRequest
            {
                ConnectedAccountId = connectedAccountId,
                UserId = userId,
                Version = version,
                CustomAuthParams = customAuthParams,
                CustomConnectionData = customConnectionData,
                Arguments = arguments,
                Text = text,
            };

            return await PostToolsExecuteByToolSlugAsync(
                toolSlug: toolSlug,
                xLlmGatewayHeaders: xLlmGatewayHeaders,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}