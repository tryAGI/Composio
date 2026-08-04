
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public enum PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant3Mode
    {
        /// <summary>
        /// 
        /// </summary>
        DcrOauth,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant3ModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant3Mode value)
        {
            return value switch
            {
                PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant3Mode.DcrOauth => "DCR_OAUTH",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant3Mode? ToEnum(string value)
        {
            return value switch
            {
                "DCR_OAUTH" => PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant3Mode.DcrOauth,
                _ => null,
            };
        }
    }
}