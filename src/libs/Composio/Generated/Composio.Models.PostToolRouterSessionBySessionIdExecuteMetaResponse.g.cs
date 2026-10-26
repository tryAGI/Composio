#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct PostToolRouterSessionBySessionIdExecuteMetaResponse : global::System.IEquatable<PostToolRouterSessionBySessionIdExecuteMetaResponse>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PostToolRouterSessionBySessionIdExecuteMetaResponseDiscriminatorResultType? ResultType { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Composio.ExecuteCompleted? Completed { get; init; }
#else
        public global::Composio.ExecuteCompleted? Completed { get; }
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
            out global::Composio.ExecuteCompleted? value)
        {
            value = Completed;
            return IsCompleted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Composio.ExecuteCompleted PickCompleted() => Completed is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Completed' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Composio.ExecuteFailed? Failed { get; init; }
#else
        public global::Composio.ExecuteFailed? Failed { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Failed))]
#endif
        public bool IsFailed => Failed != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFailed(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Composio.ExecuteFailed? value)
        {
            value = Failed;
            return IsFailed;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Composio.ExecuteFailed PickFailed() => Failed is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Failed' but the value was {ToString()}.");

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
        public static implicit operator PostToolRouterSessionBySessionIdExecuteMetaResponse(global::Composio.ExecuteCompleted value) => new PostToolRouterSessionBySessionIdExecuteMetaResponse((global::Composio.ExecuteCompleted?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Composio.ExecuteCompleted?(PostToolRouterSessionBySessionIdExecuteMetaResponse @this) => @this.Completed;

        /// <summary>
        ///
        /// </summary>
        public PostToolRouterSessionBySessionIdExecuteMetaResponse(global::Composio.ExecuteCompleted? value)
        {
            Completed = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PostToolRouterSessionBySessionIdExecuteMetaResponse FromCompleted(global::Composio.ExecuteCompleted? value) => new PostToolRouterSessionBySessionIdExecuteMetaResponse(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PostToolRouterSessionBySessionIdExecuteMetaResponse(global::Composio.ExecuteFailed value) => new PostToolRouterSessionBySessionIdExecuteMetaResponse((global::Composio.ExecuteFailed?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Composio.ExecuteFailed?(PostToolRouterSessionBySessionIdExecuteMetaResponse @this) => @this.Failed;

        /// <summary>
        ///
        /// </summary>
        public PostToolRouterSessionBySessionIdExecuteMetaResponse(global::Composio.ExecuteFailed? value)
        {
            Failed = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PostToolRouterSessionBySessionIdExecuteMetaResponse FromFailed(global::Composio.ExecuteFailed? value) => new PostToolRouterSessionBySessionIdExecuteMetaResponse(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PostToolRouterSessionBySessionIdExecuteMetaResponse(global::Composio.ExecuteRequiresUserInput value) => new PostToolRouterSessionBySessionIdExecuteMetaResponse((global::Composio.ExecuteRequiresUserInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Composio.ExecuteRequiresUserInput?(PostToolRouterSessionBySessionIdExecuteMetaResponse @this) => @this.InputRequired;

        /// <summary>
        ///
        /// </summary>
        public PostToolRouterSessionBySessionIdExecuteMetaResponse(global::Composio.ExecuteRequiresUserInput? value)
        {
            InputRequired = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PostToolRouterSessionBySessionIdExecuteMetaResponse FromInputRequired(global::Composio.ExecuteRequiresUserInput? value) => new PostToolRouterSessionBySessionIdExecuteMetaResponse(value);

        /// <summary>
        ///
        /// </summary>
        public PostToolRouterSessionBySessionIdExecuteMetaResponse(
            global::Composio.PostToolRouterSessionBySessionIdExecuteMetaResponseDiscriminatorResultType? resultType,
            global::Composio.ExecuteCompleted? completed,
            global::Composio.ExecuteFailed? failed,
            global::Composio.ExecuteRequiresUserInput? inputRequired
            )
        {
            ResultType = resultType;

            Completed = completed;
            Failed = failed;
            InputRequired = inputRequired;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            InputRequired as object ??
            Failed as object ??
            Completed as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Completed?.ToString() ??
            Failed?.ToString() ??
            InputRequired?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsCompleted && !IsFailed && !IsInputRequired || !IsCompleted && IsFailed && !IsInputRequired || !IsCompleted && !IsFailed && IsInputRequired;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Composio.ExecuteCompleted, TResult>? completed = null,
            global::System.Func<global::Composio.ExecuteFailed, TResult>? failed = null,
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
            else if (Failed is { } __value1 && failed != null)
            {
                return failed(__value1);
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
            global::System.Action<global::Composio.ExecuteCompleted>? completed = null,

            global::System.Action<global::Composio.ExecuteFailed>? failed = null,

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
            else if (Failed is { } __value1)
            {
                failed?.Invoke(__value1);
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
            global::System.Action<global::Composio.ExecuteCompleted>? completed = null,
            global::System.Action<global::Composio.ExecuteFailed>? failed = null,
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
            else if (Failed is { } __value1)
            {
                failed?.Invoke(__value1);
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
                typeof(global::Composio.ExecuteCompleted),
                Failed,
                typeof(global::Composio.ExecuteFailed),
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
        public bool Equals(PostToolRouterSessionBySessionIdExecuteMetaResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Composio.ExecuteCompleted?>.Default.Equals(Completed, other.Completed) &&
                global::System.Collections.Generic.EqualityComparer<global::Composio.ExecuteFailed?>.Default.Equals(Failed, other.Failed) &&
                global::System.Collections.Generic.EqualityComparer<global::Composio.ExecuteRequiresUserInput?>.Default.Equals(InputRequired, other.InputRequired)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(PostToolRouterSessionBySessionIdExecuteMetaResponse obj1, PostToolRouterSessionBySessionIdExecuteMetaResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PostToolRouterSessionBySessionIdExecuteMetaResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(PostToolRouterSessionBySessionIdExecuteMetaResponse obj1, PostToolRouterSessionBySessionIdExecuteMetaResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PostToolRouterSessionBySessionIdExecuteMetaResponse o && Equals(o);
        }
    }
}
