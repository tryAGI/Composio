
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2Mode
    {
        /// <summary>
        ///
        /// </summary>
        ApiKey,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2ModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2Mode value)
        {
            return value switch
            {
                PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2Mode.ApiKey => "API_KEY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2Mode? ToEnum(string value)
        {
            return value switch
            {
                "API_KEY" => PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2Mode.ApiKey,
                _ => null,
            };
        }
    }
}