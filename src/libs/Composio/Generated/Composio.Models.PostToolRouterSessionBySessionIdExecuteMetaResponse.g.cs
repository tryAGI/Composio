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
        public global::Composio.ToolRouterSessionExecuteCompleted? Completed { get; init; }
#else
        public global::Composio.ToolRouterSessionExecuteCompleted? Completed { get; }
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
            out global::Composio.ToolRouterSessionExecuteCompleted? value)
        {
            value = Completed;
            return IsCompleted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Composio.ToolRouterSessionExecuteCompleted PickCompleted() => Completed is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Completed' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Composio.ToolRouterSessionExecuteFailed? Failed { get; init; }
#else
        public global::Composio.ToolRouterSessionExecuteFailed? Failed { get; }
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
            out global::Composio.ToolRouterSessionExecuteFailed? value)
        {
            value = Failed;
            return IsFailed;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Composio.ToolRouterSessionExecuteFailed PickFailed() => Failed is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Failed' but the value was {ToString()}.");

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
        public static implicit operator PostToolRouterSessionBySessionIdExecuteMetaResponse(global::Composio.ToolRouterSessionExecuteCompleted value) => new PostToolRouterSessionBySessionIdExecuteMetaResponse((global::Composio.ToolRouterSessionExecuteCompleted?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Composio.ToolRouterSessionExecuteCompleted?(PostToolRouterSessionBySessionIdExecuteMetaResponse @this) => @this.Completed;

        /// <summary>
        ///
        /// </summary>
        public PostToolRouterSessionBySessionIdExecuteMetaResponse(global::Composio.ToolRouterSessionExecuteCompleted? value)
        {
            Completed = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PostToolRouterSessionBySessionIdExecuteMetaResponse FromCompleted(global::Composio.ToolRouterSessionExecuteCompleted? value) => new PostToolRouterSessionBySessionIdExecuteMetaResponse(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PostToolRouterSessionBySessionIdExecuteMetaResponse(global::Composio.ToolRouterSessionExecuteFailed value) => new PostToolRouterSessionBySessionIdExecuteMetaResponse((global::Composio.ToolRouterSessionExecuteFailed?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Composio.ToolRouterSessionExecuteFailed?(PostToolRouterSessionBySessionIdExecuteMetaResponse @this) => @this.Failed;

        /// <summary>
        ///
        /// </summary>
        public PostToolRouterSessionBySessionIdExecuteMetaResponse(global::Composio.ToolRouterSessionExecuteFailed? value)
        {
            Failed = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PostToolRouterSessionBySessionIdExecuteMetaResponse FromFailed(global::Composio.ToolRouterSessionExecuteFailed? value) => new PostToolRouterSessionBySessionIdExecuteMetaResponse(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PostToolRouterSessionBySessionIdExecuteMetaResponse(global::Composio.ToolRouterInputRequiredResponse value) => new PostToolRouterSessionBySessionIdExecuteMetaResponse((global::Composio.ToolRouterInputRequiredResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Composio.ToolRouterInputRequiredResponse?(PostToolRouterSessionBySessionIdExecuteMetaResponse @this) => @this.InputRequired;

        /// <summary>
        ///
        /// </summary>
        public PostToolRouterSessionBySessionIdExecuteMetaResponse(global::Composio.ToolRouterInputRequiredResponse? value)
        {
            InputRequired = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PostToolRouterSessionBySessionIdExecuteMetaResponse FromInputRequired(global::Composio.ToolRouterInputRequiredResponse? value) => new PostToolRouterSessionBySessionIdExecuteMetaResponse(value);

        /// <summary>
        ///
        /// </summary>
        public PostToolRouterSessionBySessionIdExecuteMetaResponse(
            global::Composio.PostToolRouterSessionBySessionIdExecuteMetaResponseDiscriminatorResultType? resultType,
            global::Composio.ToolRouterSessionExecuteCompleted? completed,
            global::Composio.ToolRouterSessionExecuteFailed? failed,
            global::Composio.ToolRouterInputRequiredResponse? inputRequired
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
            global::System.Func<global::Composio.ToolRouterSessionExecuteCompleted, TResult>? completed = null,
            global::System.Func<global::Composio.ToolRouterSessionExecuteFailed, TResult>? failed = null,
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
            global::System.Action<global::Composio.ToolRouterSessionExecuteCompleted>? completed = null,

            global::System.Action<global::Composio.ToolRouterSessionExecuteFailed>? failed = null,

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
            global::System.Action<global::Composio.ToolRouterSessionExecuteCompleted>? completed = null,
            global::System.Action<global::Composio.ToolRouterSessionExecuteFailed>? failed = null,
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
                typeof(global::Composio.ToolRouterSessionExecuteCompleted),
                Failed,
                typeof(global::Composio.ToolRouterSessionExecuteFailed),
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
        public bool Equals(PostToolRouterSessionBySessionIdExecuteMetaResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Composio.ToolRouterSessionExecuteCompleted?>.Default.Equals(Completed, other.Completed) &&
                global::System.Collections.Generic.EqualityComparer<global::Composio.ToolRouterSessionExecuteFailed?>.Default.Equals(Failed, other.Failed) &&
                global::System.Collections.Generic.EqualityComparer<global::Composio.ToolRouterInputRequiredResponse?>.Default.Equals(InputRequired, other.InputRequired)
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
