#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct BlockReason : global::System.IEquatable<BlockReason>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Composio.BlockReasonVariant1? BlockReasonVariant1 { get; init; }
#else
        public global::Composio.BlockReasonVariant1? BlockReasonVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BlockReasonVariant1))]
#endif
        public bool IsBlockReasonVariant1 => BlockReasonVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBlockReasonVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Composio.BlockReasonVariant1? value)
        {
            value = BlockReasonVariant1;
            return IsBlockReasonVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Composio.BlockReasonVariant1 PickBlockReasonVariant1() => BlockReasonVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BlockReasonVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Composio.BlockReasonVariant2? BlockReasonVariant2 { get; init; }
#else
        public global::Composio.BlockReasonVariant2? BlockReasonVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BlockReasonVariant2))]
#endif
        public bool IsBlockReasonVariant2 => BlockReasonVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBlockReasonVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Composio.BlockReasonVariant2? value)
        {
            value = BlockReasonVariant2;
            return IsBlockReasonVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Composio.BlockReasonVariant2 PickBlockReasonVariant2() => BlockReasonVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BlockReasonVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BlockReason(global::Composio.BlockReasonVariant1 value) => new BlockReason((global::Composio.BlockReasonVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Composio.BlockReasonVariant1?(BlockReason @this) => @this.BlockReasonVariant1;

        /// <summary>
        ///
        /// </summary>
        public BlockReason(global::Composio.BlockReasonVariant1? value)
        {
            BlockReasonVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BlockReason FromBlockReasonVariant1(global::Composio.BlockReasonVariant1? value) => new BlockReason(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BlockReason(global::Composio.BlockReasonVariant2 value) => new BlockReason((global::Composio.BlockReasonVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Composio.BlockReasonVariant2?(BlockReason @this) => @this.BlockReasonVariant2;

        /// <summary>
        ///
        /// </summary>
        public BlockReason(global::Composio.BlockReasonVariant2? value)
        {
            BlockReasonVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BlockReason FromBlockReasonVariant2(global::Composio.BlockReasonVariant2? value) => new BlockReason(value);

        /// <summary>
        ///
        /// </summary>
        public BlockReason(
            global::Composio.BlockReasonVariant1? blockReasonVariant1,
            global::Composio.BlockReasonVariant2? blockReasonVariant2
            )
        {
            BlockReasonVariant1 = blockReasonVariant1;
            BlockReasonVariant2 = blockReasonVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            BlockReasonVariant2 as object ??
            BlockReasonVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            BlockReasonVariant1?.ToString() ??
            BlockReasonVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBlockReasonVariant1 && !IsBlockReasonVariant2 || !IsBlockReasonVariant1 && IsBlockReasonVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Composio.BlockReasonVariant1, TResult>? blockReasonVariant1 = null,
            global::System.Func<global::Composio.BlockReasonVariant2, TResult>? blockReasonVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BlockReasonVariant1 is { } __value0 && blockReasonVariant1 != null)
            {
                return blockReasonVariant1(__value0);
            }
            else if (BlockReasonVariant2 is { } __value1 && blockReasonVariant2 != null)
            {
                return blockReasonVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Composio.BlockReasonVariant1>? blockReasonVariant1 = null,

            global::System.Action<global::Composio.BlockReasonVariant2>? blockReasonVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BlockReasonVariant1 is { } __value0)
            {
                blockReasonVariant1?.Invoke(__value0);
            }
            else if (BlockReasonVariant2 is { } __value1)
            {
                blockReasonVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Composio.BlockReasonVariant1>? blockReasonVariant1 = null,
            global::System.Action<global::Composio.BlockReasonVariant2>? blockReasonVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BlockReasonVariant1 is { } __value0)
            {
                blockReasonVariant1?.Invoke(__value0);
            }
            else if (BlockReasonVariant2 is { } __value1)
            {
                blockReasonVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BlockReasonVariant1,
                typeof(global::Composio.BlockReasonVariant1),
                BlockReasonVariant2,
                typeof(global::Composio.BlockReasonVariant2),
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
        public bool Equals(BlockReason other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Composio.BlockReasonVariant1?>.Default.Equals(BlockReasonVariant1, other.BlockReasonVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Composio.BlockReasonVariant2?>.Default.Equals(BlockReasonVariant2, other.BlockReasonVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BlockReason obj1, BlockReason obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BlockReason>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BlockReason obj1, BlockReason obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BlockReason o && Equals(o);
        }
    }
}
