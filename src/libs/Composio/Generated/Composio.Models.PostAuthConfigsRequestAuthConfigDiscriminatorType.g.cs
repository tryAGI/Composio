
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum PostAuthConfigsRequestAuthConfigDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        UseComposioManagedAuth,
        /// <summary>
        ///
        /// </summary>
        UseCustomAuth,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostAuthConfigsRequestAuthConfigDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostAuthConfigsRequestAuthConfigDiscriminatorType value)
        {
            return value switch
            {
                PostAuthConfigsRequestAuthConfigDiscriminatorType.UseComposioManagedAuth => "use_composio_managed_auth",
                PostAuthConfigsRequestAuthConfigDiscriminatorType.UseCustomAuth => "use_custom_auth",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostAuthConfigsRequestAuthConfigDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "use_composio_managed_auth" => PostAuthConfigsRequestAuthConfigDiscriminatorType.UseComposioManagedAuth,
                "use_custom_auth" => PostAuthConfigsRequestAuthConfigDiscriminatorType.UseCustomAuth,
                _ => null,
            };
        }
    }
}