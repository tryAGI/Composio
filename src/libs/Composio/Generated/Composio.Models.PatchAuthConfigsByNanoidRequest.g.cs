#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct PatchAuthConfigsByNanoidRequest : global::System.IEquatable<PatchAuthConfigsByNanoidRequest>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Composio.PatchAuthConfigsByNanoidRequestDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Composio.CustomAuthConfigUpdate? Custom { get; init; }
#else
        public global::Composio.CustomAuthConfigUpdate? Custom { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Custom))]
#endif
        public bool IsCustom => Custom != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCustom(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Composio.CustomAuthConfigUpdate? value)
        {
            value = Custom;
            return IsCustom;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Composio.CustomAuthConfigUpdate PickCustom() => IsCustom
            ? Custom!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Custom' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Composio.DefaultAuthConfigUpdate? Default { get; init; }
#else
        public global::Composio.DefaultAuthConfigUpdate? Default { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Default))]
#endif
        public bool IsDefault => Default != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDefault(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Composio.DefaultAuthConfigUpdate? value)
        {
            value = Default;
            return IsDefault;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Composio.DefaultAuthConfigUpdate PickDefault() => IsDefault
            ? Default!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Default' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator PatchAuthConfigsByNanoidRequest(global::Composio.CustomAuthConfigUpdate value) => new PatchAuthConfigsByNanoidRequest((global::Composio.CustomAuthConfigUpdate?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Composio.CustomAuthConfigUpdate?(PatchAuthConfigsByNanoidRequest @this) => @this.Custom;

        /// <summary>
        ///
        /// </summary>
        public PatchAuthConfigsByNanoidRequest(global::Composio.CustomAuthConfigUpdate? value)
        {
            Custom = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PatchAuthConfigsByNanoidRequest FromCustom(global::Composio.CustomAuthConfigUpdate? value) => new PatchAuthConfigsByNanoidRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PatchAuthConfigsByNanoidRequest(global::Composio.DefaultAuthConfigUpdate value) => new PatchAuthConfigsByNanoidRequest((global::Composio.DefaultAuthConfigUpdate?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Composio.DefaultAuthConfigUpdate?(PatchAuthConfigsByNanoidRequest @this) => @this.Default;

        /// <summary>
        ///
        /// </summary>
        public PatchAuthConfigsByNanoidRequest(global::Composio.DefaultAuthConfigUpdate? value)
        {
            Default = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PatchAuthConfigsByNanoidRequest FromDefault(global::Composio.DefaultAuthConfigUpdate? value) => new PatchAuthConfigsByNanoidRequest(value);

        /// <summary>
        ///
        /// </summary>
        public PatchAuthConfigsByNanoidRequest(
            global::Composio.PatchAuthConfigsByNanoidRequestDiscriminatorType? type,
            global::Composio.CustomAuthConfigUpdate? custom,
            global::Composio.DefaultAuthConfigUpdate? @default
            )
        {
            Type = type;

            Custom = custom;
            Default = @default;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Default as object ??
            Custom as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Custom?.ToString() ??
            Default?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsCustom && !IsDefault || !IsCustom && IsDefault;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Composio.CustomAuthConfigUpdate, TResult>? custom = null,
            global::System.Func<global::Composio.DefaultAuthConfigUpdate, TResult>? @default = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCustom && custom != null)
            {
                return custom(Custom!);
            }
            else if (IsDefault && @default != null)
            {
                return @default(Default!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Composio.CustomAuthConfigUpdate>? custom = null,

            global::System.Action<global::Composio.DefaultAuthConfigUpdate>? @default = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCustom)
            {
                custom?.Invoke(Custom!);
            }
            else if (IsDefault)
            {
                @default?.Invoke(Default!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Composio.CustomAuthConfigUpdate>? custom = null,
            global::System.Action<global::Composio.DefaultAuthConfigUpdate>? @default = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCustom)
            {
                custom?.Invoke(Custom!);
            }
            else if (IsDefault)
            {
                @default?.Invoke(Default!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Custom,
                typeof(global::Composio.CustomAuthConfigUpdate),
                Default,
                typeof(global::Composio.DefaultAuthConfigUpdate),
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
        public bool Equals(PatchAuthConfigsByNanoidRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Composio.CustomAuthConfigUpdate?>.Default.Equals(Custom, other.Custom) &&
                global::System.Collections.Generic.EqualityComparer<global::Composio.DefaultAuthConfigUpdate?>.Default.Equals(Default, other.Default)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(PatchAuthConfigsByNanoidRequest obj1, PatchAuthConfigsByNanoidRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PatchAuthConfigsByNanoidRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(PatchAuthConfigsByNanoidRequest obj1, PatchAuthConfigsByNanoidRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PatchAuthConfigsByNanoidRequest o && Equals(o);
        }
    }
}
