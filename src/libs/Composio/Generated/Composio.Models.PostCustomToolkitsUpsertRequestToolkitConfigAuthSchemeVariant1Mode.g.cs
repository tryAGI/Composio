
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public enum PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant1Mode
    {
        /// <summary>
        /// 
        /// </summary>
        NoAuth,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant1ModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant1Mode value)
        {
            return value switch
            {
                PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant1Mode.NoAuth => "NO_AUTH",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant1Mode? ToEnum(string value)
        {
            return value switch
            {
                "NO_AUTH" => PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant1Mode.NoAuth,
                _ => null,
            };
        }
    }
}