#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct PostToolRouterSessionBySessionIdProxyExecuteResponse : global::System.IEquatable<PostToolRouterSessionBySessionIdProxyExecuteResponse>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteResponseDiscriminatorResultType? ResultType { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Composio.ProxyExecuteForSessionCompleted? Completed { get; init; }
#else
        public global::Composio.ProxyExecuteForSessionCompleted? Completed { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Completed))]
#endif
        public bool IsCompleted => Completed != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCompleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Composio.ProxyExecuteForSessionCompleted? value)
        {
            value = Completed;
            return IsCompleted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Composio.ProxyExecuteForSessionCompleted PickCompleted() => Completed is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Completed' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Composio.ToolRouterInputRequiredResponse? InputRequired { get; init; }
#else
        public global::Composio.ToolRouterInputRequiredResponse? InputRequired { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputRequired))]
#endif
        public bool IsInputRequired => InputRequired != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInputRequired(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Composio.ToolRouterInputRequiredResponse? value)
        {
            value = InputRequired;
            return IsInputRequired;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Composio.ToolRouterInputRequiredResponse PickInputRequired() => InputRequired is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputRequired' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator PostToolRouterSessionBySessionIdProxyExecuteResponse(global::Composio.ProxyExecuteForSessionCompleted value) => new PostToolRouterSessionBySessionIdProxyExecuteResponse((global::Composio.ProxyExecuteForSessionCompleted?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Composio.ProxyExecuteForSessionCompleted?(PostToolRouterSessionBySessionIdProxyExecuteResponse @this) => @this.Completed;

        /// <summary>
        ///
        /// </summary>
        public PostToolRouterSessionBySessionIdProxyExecuteResponse(global::Composio.ProxyExecuteForSessionCompleted? value)
        {
            Completed = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PostToolRouterSessionBySessionIdProxyExecuteResponse FromCompleted(global::Composio.ProxyExecuteForSessionCompleted? value) => new PostToolRouterSessionBySessionIdProxyExecuteResponse(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PostToolRouterSessionBySessionIdProxyExecuteResponse(global::Composio.ToolRouterInputRequiredResponse value) => new PostToolRouterSessionBySessionIdProxyExecuteResponse((global::Composio.ToolRouterInputRequiredResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Composio.ToolRouterInputRequiredResponse?(PostToolRouterSessionBySessionIdProxyExecuteResponse @this) => @this.InputRequired;

        /// <summary>
        ///
        /// </summary>
        public PostToolRouterSessionBySessionIdProxyExecuteResponse(global::Composio.ToolRouterInputRequiredResponse? value)
        {
            InputRequired = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PostToolRouterSessionBySessionIdProxyExecuteResponse FromInputRequired(global::Composio.ToolRouterInputRequiredResponse? value) => new PostToolRouterSessionBySessionIdProxyExecuteResponse(value);

        /// <summary>
        ///
        /// </summary>
        public PostToolRouterSessionBySessionIdProxyExecuteResponse(
            global::Composio.PostToolRouterSessionBySessionIdProxyExecuteResponseDiscriminatorResultType? resultType,
            global::Composio.ProxyExecuteForSessionCompleted? completed,
            global::Composio.ToolRouterInputRequiredResponse? inputRequired
            )
        {
            ResultType = resultType;

            Completed = completed;
            InputRequired = inputRequired;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            InputRequired as object ??
            Completed as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Completed?.ToString() ??
            InputRequired?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsCompleted && !IsInputRequired || !IsCompleted && IsInputRequired;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Composio.ProxyExecuteForSessionCompleted, TResult>? completed = null,
            global::System.Func<global::Composio.ToolRouterInputRequiredResponse, TResult>? inputRequired = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Completed is { } __value0 && completed != null)
            {
                return completed(__value0);
            }
            else if (InputRequired is { } __value1 && inputRequired != null)
            {
                return inputRequired(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Composio.ProxyExecuteForSessionCompleted>? completed = null,

            global::System.Action<global::Composio.ToolRouterInputRequiredResponse>? inputRequired = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Completed is { } __value0)
            {
                completed?.Invoke(__value0);
            }
            else if (InputRequired is { } __value1)
            {
                inputRequired?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Composio.ProxyExecuteForSessionCompleted>? completed = null,
            global::System.Action<global::Composio.ToolRouterInputRequiredResponse>? inputRequired = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Completed is { } __value0)
            {
                completed?.Invoke(__value0);
            }
            else if (InputRequired is { } __value1)
            {
                inputRequired?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Completed,
                typeof(global::Composio.ProxyExecuteForSessionCompleted),
                InputRequired,
                typeof(global::Composio.ToolRouterInputRequiredResponse),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(PostToolRouterSessionBySessionIdProxyExecuteResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Composio.ProxyExecuteForSessionCompleted?>.Default.Equals(Completed, other.Completed) &&
                global::System.Collections.Generic.EqualityComparer<global::Composio.ToolRouterInputRequiredResponse?>.Default.Equals(InputRequired, other.InputRequired)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(PostToolRouterSessionBySessionIdProxyExecuteResponse obj1, PostToolRouterSessionBySessionIdProxyExecuteResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PostToolRouterSessionBySessionIdProxyExecuteResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(PostToolRouterSessionBySessionIdProxyExecuteResponse obj1, PostToolRouterSessionBySessionIdProxyExecuteResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PostToolRouterSessionBySessionIdProxyExecuteResponse o && Equals(o);
        }
    }
}
