
#nullable enable

namespace Composio
{
    /// <summary>
    /// Image MIME type of the encoded bytes
    /// </summary>
    public enum PostCustomToolkitsUpsertRequestToolkitConfigLogoFileMimeType
    {
        /// <summary>
        ///
        /// </summary>
        ImageJpeg,
        /// <summary>
        ///
        /// </summary>
        ImagePng,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostCustomToolkitsUpsertRequestToolkitConfigLogoFileMimeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostCustomToolkitsUpsertRequestToolkitConfigLogoFileMimeType value)
        {
            return value switch
            {
                PostCustomToolkitsUpsertRequestToolkitConfigLogoFileMimeType.ImageJpeg => "image/jpeg",
                PostCustomToolkitsUpsertRequestToolkitConfigLogoFileMimeType.ImagePng => "image/png",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostCustomToolkitsUpsertRequestToolkitConfigLogoFileMimeType? ToEnum(string value)
        {
            return value switch
            {
                "image/jpeg" => PostCustomToolkitsUpsertRequestToolkitConfigLogoFileMimeType.ImageJpeg,
                "image/png" => PostCustomToolkitsUpsertRequestToolkitConfigLogoFileMimeType.ImagePng,
                _ => null,
            };
        }
    }
}