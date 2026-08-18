#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Composio
{
    /// <summary>
    /// Default Value: {"type":"use_composio_managed_auth","credentials":{},"restrict_to_following_tools":[]}
    /// </summary>
    public readonly partial struct AuthConfig : global::System.IEquatable<AuthConfig>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Composio.PostAuthConfigsRequestAuthConfigDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Composio.ComposioManagedAuthConfigCreate? UseComposioManagedAuth { get; init; }
#else
        public global::Composio.ComposioManagedAuthConfigCreate? UseComposioManagedAuth { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UseComposioManagedAuth))]
#endif
        public bool IsUseComposioManagedAuth => UseComposioManagedAuth != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickUseComposioManagedAuth(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Composio.ComposioManagedAuthConfigCreate? value)
        {
            value = UseComposioManagedAuth;
            return IsUseComposioManagedAuth;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Composio.ComposioManagedAuthConfigCreate PickUseComposioManagedAuth() => IsUseComposioManagedAuth
            ? UseComposioManagedAuth!
            : throw new global::System.InvalidOperationException($"Expected union variant 'UseComposioManagedAuth' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Composio.CustomAuthConfigCreate? UseCustomAuth { get; init; }
#else
        public global::Composio.CustomAuthConfigCreate? UseCustomAuth { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UseCustomAuth))]
#endif
        public bool IsUseCustomAuth => UseCustomAuth != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickUseCustomAuth(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Composio.CustomAuthConfigCreate? value)
        {
            value = UseCustomAuth;
            return IsUseCustomAuth;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Composio.CustomAuthConfigCreate PickUseCustomAuth() => IsUseCustomAuth
            ? UseCustomAuth!
            : throw new global::System.InvalidOperationException($"Expected union variant 'UseCustomAuth' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AuthConfig(global::Composio.ComposioManagedAuthConfigCreate value) => new AuthConfig((global::Composio.ComposioManagedAuthConfigCreate?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Composio.ComposioManagedAuthConfigCreate?(AuthConfig @this) => @this.UseComposioManagedAuth;

        /// <summary>
        /// 
        /// </summary>
        public AuthConfig(global::Composio.ComposioManagedAuthConfigCreate? value)
        {
            UseComposioManagedAuth = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AuthConfig FromUseComposioManagedAuth(global::Composio.ComposioManagedAuthConfigCreate? value) => new AuthConfig(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AuthConfig(global::Composio.CustomAuthConfigCreate value) => new AuthConfig((global::Composio.CustomAuthConfigCreate?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Composio.CustomAuthConfigCreate?(AuthConfig @this) => @this.UseCustomAuth;

        /// <summary>
        /// 
        /// </summary>
        public AuthConfig(global::Composio.CustomAuthConfigCreate? value)
        {
            UseCustomAuth = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AuthConfig FromUseCustomAuth(global::Composio.CustomAuthConfigCreate? value) => new AuthConfig(value);

        /// <summary>
        /// 
        /// </summary>
        public AuthConfig(
            global::Composio.PostAuthConfigsRequestAuthConfigDiscriminatorType? type,
            global::Composio.ComposioManagedAuthConfigCreate? useComposioManagedAuth,
            global::Composio.CustomAuthConfigCreate? useCustomAuth
            )
        {
            Type = type;

            UseComposioManagedAuth = useComposioManagedAuth;
            UseCustomAuth = useCustomAuth;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            UseCustomAuth as object ??
            UseComposioManagedAuth as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            UseComposioManagedAuth?.ToString() ??
            UseCustomAuth?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUseComposioManagedAuth && !IsUseCustomAuth || !IsUseComposioManagedAuth && IsUseCustomAuth;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Composio.ComposioManagedAuthConfigCreate, TResult>? useComposioManagedAuth = null,
            global::System.Func<global::Composio.CustomAuthConfigCreate, TResult>? useCustomAuth = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUseComposioManagedAuth && useComposioManagedAuth != null)
            {
                return useComposioManagedAuth(UseComposioManagedAuth!);
            }
            else if (IsUseCustomAuth && useCustomAuth != null)
            {
                return useCustomAuth(UseCustomAuth!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Composio.ComposioManagedAuthConfigCreate>? useComposioManagedAuth = null,

            global::System.Action<global::Composio.CustomAuthConfigCreate>? useCustomAuth = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUseComposioManagedAuth)
            {
                useComposioManagedAuth?.Invoke(UseComposioManagedAuth!);
            }
            else if (IsUseCustomAuth)
            {
                useCustomAuth?.Invoke(UseCustomAuth!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Composio.ComposioManagedAuthConfigCreate>? useComposioManagedAuth = null,
            global::System.Action<global::Composio.CustomAuthConfigCreate>? useCustomAuth = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUseComposioManagedAuth)
            {
                useComposioManagedAuth?.Invoke(UseComposioManagedAuth!);
            }
            else if (IsUseCustomAuth)
            {
                useCustomAuth?.Invoke(UseCustomAuth!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                UseComposioManagedAuth,
                typeof(global::Composio.ComposioManagedAuthConfigCreate),
                UseCustomAuth,
                typeof(global::Composio.CustomAuthConfigCreate),
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
        public bool Equals(AuthConfig other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Composio.ComposioManagedAuthConfigCreate?>.Default.Equals(UseComposioManagedAuth, other.UseComposioManagedAuth) &&
                global::System.Collections.Generic.EqualityComparer<global::Composio.CustomAuthConfigCreate?>.Default.Equals(UseCustomAuth, other.UseCustomAuth) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AuthConfig obj1, AuthConfig obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AuthConfig>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AuthConfig obj1, AuthConfig obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AuthConfig o && Equals(o);
        }
    }
}
