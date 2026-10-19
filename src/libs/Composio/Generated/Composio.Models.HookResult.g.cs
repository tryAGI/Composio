#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct HookResult : global::System.IEquatable<HookResult>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Composio.HookResultVariant1? HookResultVariant1 { get; init; }
#else
        public global::Composio.HookResultVariant1? HookResultVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(HookResultVariant1))]
#endif
        public bool IsHookResultVariant1 => HookResultVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickHookResultVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Composio.HookResultVariant1? value)
        {
            value = HookResultVariant1;
            return IsHookResultVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Composio.HookResultVariant1 PickHookResultVariant1() => HookResultVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'HookResultVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Composio.HookResultVariant2? HookResultVariant2 { get; init; }
#else
        public global::Composio.HookResultVariant2? HookResultVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(HookResultVariant2))]
#endif
        public bool IsHookResultVariant2 => HookResultVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickHookResultVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Composio.HookResultVariant2? value)
        {
            value = HookResultVariant2;
            return IsHookResultVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Composio.HookResultVariant2 PickHookResultVariant2() => HookResultVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'HookResultVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator HookResult(global::Composio.HookResultVariant1 value) => new HookResult((global::Composio.HookResultVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Composio.HookResultVariant1?(HookResult @this) => @this.HookResultVariant1;

        /// <summary>
        ///
        /// </summary>
        public HookResult(global::Composio.HookResultVariant1? value)
        {
            HookResultVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static HookResult FromHookResultVariant1(global::Composio.HookResultVariant1? value) => new HookResult(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator HookResult(global::Composio.HookResultVariant2 value) => new HookResult((global::Composio.HookResultVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Composio.HookResultVariant2?(HookResult @this) => @this.HookResultVariant2;

        /// <summary>
        ///
        /// </summary>
        public HookResult(global::Composio.HookResultVariant2? value)
        {
            HookResultVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static HookResult FromHookResultVariant2(global::Composio.HookResultVariant2? value) => new HookResult(value);

        /// <summary>
        ///
        /// </summary>
        public HookResult(
            global::Composio.HookResultVariant1? hookResultVariant1,
            global::Composio.HookResultVariant2? hookResultVariant2
            )
        {
            HookResultVariant1 = hookResultVariant1;
            HookResultVariant2 = hookResultVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            HookResultVariant2 as object ??
            HookResultVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            HookResultVariant1?.ToString() ??
            HookResultVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsHookResultVariant1 && !IsHookResultVariant2 || !IsHookResultVariant1 && IsHookResultVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Composio.HookResultVariant1, TResult>? hookResultVariant1 = null,
            global::System.Func<global::Composio.HookResultVariant2, TResult>? hookResultVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (HookResultVariant1 is { } __value0 && hookResultVariant1 != null)
            {
                return hookResultVariant1(__value0);
            }
            else if (HookResultVariant2 is { } __value1 && hookResultVariant2 != null)
            {
                return hookResultVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Composio.HookResultVariant1>? hookResultVariant1 = null,

            global::System.Action<global::Composio.HookResultVariant2>? hookResultVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (HookResultVariant1 is { } __value0)
            {
                hookResultVariant1?.Invoke(__value0);
            }
            else if (HookResultVariant2 is { } __value1)
            {
                hookResultVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Composio.HookResultVariant1>? hookResultVariant1 = null,
            global::System.Action<global::Composio.HookResultVariant2>? hookResultVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (HookResultVariant1 is { } __value0)
            {
                hookResultVariant1?.Invoke(__value0);
            }
            else if (HookResultVariant2 is { } __value1)
            {
                hookResultVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                HookResultVariant1,
                typeof(global::Composio.HookResultVariant1),
                HookResultVariant2,
                typeof(global::Composio.HookResultVariant2),
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
        public bool Equals(HookResult other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Composio.HookResultVariant1?>.Default.Equals(HookResultVariant1, other.HookResultVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Composio.HookResultVariant2?>.Default.Equals(HookResultVariant2, other.HookResultVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(HookResult obj1, HookResult obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<HookResult>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(HookResult obj1, HookResult obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is HookResult o && Equals(o);
        }
    }
}
