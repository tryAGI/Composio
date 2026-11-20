
#nullable enable

namespace Composio
{
    /// <summary>
    /// Present only when the session stored the code_challenge sent with this request, and every lookup of the session by ID then requires its verifier. A client that sent a challenge should not continue the login without it.
    /// </summary>
    public enum PostCliCreateSessionResponseCodeChallengeMethod
    {
        /// <summary>
        ///
        /// </summary>
        S256,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostCliCreateSessionResponseCodeChallengeMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostCliCreateSessionResponseCodeChallengeMethod value)
        {
            return value switch
            {
                PostCliCreateSessionResponseCodeChallengeMethod.S256 => "S256",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostCliCreateSessionResponseCodeChallengeMethod? ToEnum(string value)
        {
            return value switch
            {
                "S256" => PostCliCreateSessionResponseCodeChallengeMethod.S256,
                _ => null,
            };
        }
    }
}