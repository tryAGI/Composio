
#nullable enable

namespace Composio
{
    /// <summary>
    /// Mutate the sharing model. PRIVATE → SHARED promotes the existing connection without re-auth; SHARED → PRIVATE revokes all non-creator access and clears the stored ACL atomically. Omit to leave unchanged.
    /// </summary>
    public enum PatchConnectedAccountBodyExperimentalAccountType
    {
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Shared,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchConnectedAccountBodyExperimentalAccountTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchConnectedAccountBodyExperimentalAccountType value)
        {
            return value switch
            {
                PatchConnectedAccountBodyExperimentalAccountType.Private => "PRIVATE",
                PatchConnectedAccountBodyExperimentalAccountType.Shared => "SHARED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchConnectedAccountBodyExperimentalAccountType? ToEnum(string value)
        {
            return value switch
            {
                "PRIVATE" => PatchConnectedAccountBodyExperimentalAccountType.Private,
                "SHARED" => PatchConnectedAccountBodyExperimentalAccountType.Shared,
                _ => null,
            };
        }
    }
}