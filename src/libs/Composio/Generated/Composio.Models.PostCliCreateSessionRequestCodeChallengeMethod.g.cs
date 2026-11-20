
#nullable enable

namespace Composio
{
    /// <summary>
    /// Method used to derive code_challenge from the verifier. Only S256 is supported. Send together with code_challenge.
    /// </summary>
    public enum PostCliCreateSessionRequestCodeChallengeMethod
    {
        /// <summary>
        ///
        /// </summary>
        S256,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostCliCreateSessionRequestCodeChallengeMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostCliCreateSessionRequestCodeChallengeMethod value)
        {
            return value switch
            {
                PostCliCreateSessionRequestCodeChallengeMethod.S256 => "S256",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostCliCreateSessionRequestCodeChallengeMethod? ToEnum(string value)
        {
            return value switch
            {
                "S256" => PostCliCreateSessionRequestCodeChallengeMethod.S256,
                _ => null,
            };
        }
    }
}