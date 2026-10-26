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
        public global::Composio.ProxyExecuteCompleted? Completed { get; init; }
#else
        public global::Composio.ProxyExecuteCompleted? Completed { get; }
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
            out global::Composio.ProxyExecuteCompleted? value)
        {
            value = Completed;
            return IsCompleted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Composio.ProxyExecuteCompleted PickCompleted() => Completed is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Completed' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Composio.ProxyExecuteBlocked? Blocked { get; init; }
#else
        public global::Composio.ProxyExecuteBlocked? Blocked { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Blocked))]
#endif
        public bool IsBlocked => Blocked != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBlocked(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Composio.ProxyExecuteBlocked? value)
        {
            value = Blocked;
            return IsBlocked;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Composio.ProxyExecuteBlocked PickBlocked() => Blocked is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Blocked' but the value was {ToString()}.");

        /// <summary>
        /// The call needs the user's input before it runs. Returned only when the session is configured to ask for user approval before tool execution. Show each question in `input_requests` to the user, then repeat the same call with their answers in `input_responses`, along with this `request_state` if present.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Composio.ExecuteRequiresUserInput? InputRequired { get; init; }
#else
        public global::Composio.ExecuteRequiresUserInput? InputRequired { get; }
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
            out global::Composio.ExecuteRequiresUserInput? value)
        {
            value = InputRequired;
            return IsInputRequired;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Composio.ExecuteRequiresUserInput PickInputRequired() => InputRequired is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputRequired' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator PostToolRouterSessionBySessionIdProxyExecuteResponse(global::Composio.ProxyExecuteCompleted value) => new PostToolRouterSessionBySessionIdProxyExecuteResponse((global::Composio.ProxyExecuteCompleted?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Composio.ProxyExecuteCompleted?(PostToolRouterSessionBySessionIdProxyExecuteResponse @this) => @this.Completed;

        /// <summary>
        ///
        /// </summary>
        public PostToolRouterSessionBySessionIdProxyExecuteResponse(global::Composio.ProxyExecuteCompleted? value)
        {
            Completed = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PostToolRouterSessionBySessionIdProxyExecuteResponse FromCompleted(global::Composio.ProxyExecuteCompleted? value) => new PostToolRouterSessionBySessionIdProxyExecuteResponse(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PostToolRouterSessionBySessionIdProxyExecuteResponse(global::Composio.ProxyExecuteBlocked value) => new PostToolRouterSessionBySessionIdProxyExecuteResponse((global::Composio.ProxyExecuteBlocked?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Composio.ProxyExecuteBlocked?(PostToolRouterSessionBySessionIdProxyExecuteResponse @this) => @this.Blocked;

        /// <summary>
        ///
        /// </summary>
        public PostToolRouterSessionBySessionIdProxyExecuteResponse(global::Composio.ProxyExecuteBlocked? value)
        {
            Blocked = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PostToolRouterSessionBySessionIdProxyExecuteResponse FromBlocked(global::Composio.ProxyExecuteBlocked? value) => new PostToolRouterSessionBySessionIdProxyExecuteResponse(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PostToolRouterSessionBySessionIdProxyExecuteResponse(global::Composio.ExecuteRequiresUserInput value) => new PostToolRouterSessionBySessionIdProxyExecuteResponse((global::Composio.ExecuteRequiresUserInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Composio.ExecuteRequiresUserInput?(PostToolRouterSessionBySessionIdProxyExecuteResponse @this) => @this.InputRequired;

        /// <summary>
        ///
        /// </summary>
        public PostToolRouterSessionBySessionIdProxyExecuteResponse(global::Composio.ExecuteRequiresUserInput? value)
        {
            InputRequired = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PostToolRouterSessionBySessionIdProxyExecuteResponse FromInputRequired(global::Composio.ExecuteRequiresUserInput? value) => new PostToolRouterSessionBySessionIdProxyExecuteResponse(value);

        /// <summary>
        ///
        /// </summary>
        public PostToolRouterSessionBySessionIdProxyExecuteResponse(
            global::Composio.PostToolRouterSessionBySessionIdProxyExecuteResponseDiscriminatorResultType? resultType,
            global::Composio.ProxyExecuteCompleted? completed,
            global::Composio.ProxyExecuteBlocked? blocked,
            global::Composio.ExecuteRequiresUserInput? inputRequired
            )
        {
            ResultType = resultType;

            Completed = completed;
            Blocked = blocked;
            InputRequired = inputRequired;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            InputRequired as object ??
            Blocked as object ??
            Completed as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Completed?.ToString() ??
            Blocked?.ToString() ??
            InputRequired?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsCompleted && !IsBlocked && !IsInputRequired || !IsCompleted && IsBlocked && !IsInputRequired || !IsCompleted && !IsBlocked && IsInputRequired;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Composio.ProxyExecuteCompleted, TResult>? completed = null,
            global::System.Func<global::Composio.ProxyExecuteBlocked, TResult>? blocked = null,
            global::System.Func<global::Composio.ExecuteRequiresUserInput, TResult>? inputRequired = null,
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
            else if (Blocked is { } __value1 && blocked != null)
            {
                return blocked(__value1);
            }
            else if (InputRequired is { } __value2 && inputRequired != null)
            {
                return inputRequired(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Composio.ProxyExecuteCompleted>? completed = null,

            global::System.Action<global::Composio.ProxyExecuteBlocked>? blocked = null,

            global::System.Action<global::Composio.ExecuteRequiresUserInput>? inputRequired = null,
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
            else if (Blocked is { } __value1)
            {
                blocked?.Invoke(__value1);
            }
            else if (InputRequired is { } __value2)
            {
                inputRequired?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Composio.ProxyExecuteCompleted>? completed = null,
            global::System.Action<global::Composio.ProxyExecuteBlocked>? blocked = null,
            global::System.Action<global::Composio.ExecuteRequiresUserInput>? inputRequired = null,
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
            else if (Blocked is { } __value1)
            {
                blocked?.Invoke(__value1);
            }
            else if (InputRequired is { } __value2)
            {
                inputRequired?.Invoke(__value2);
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
                typeof(global::Composio.ProxyExecuteCompleted),
                Blocked,
                typeof(global::Composio.ProxyExecuteBlocked),
                InputRequired,
                typeof(global::Composio.ExecuteRequiresUserInput),
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
                global::System.Collections.Generic.EqualityComparer<global::Composio.ProxyExecuteCompleted?>.Default.Equals(Completed, other.Completed) &&
                global::System.Collections.Generic.EqualityComparer<global::Composio.ProxyExecuteBlocked?>.Default.Equals(Blocked, other.Blocked) &&
                global::System.Collections.Generic.EqualityComparer<global::Composio.ExecuteRequiresUserInput?>.Default.Equals(InputRequired, other.InputRequired)
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
