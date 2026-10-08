
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum PostOrgOwnerProjectNewRequestApiKeyPermissionAccess
    {
        /// <summary>
        ///
        /// </summary>
        None,
        /// <summary>
        ///
        /// </summary>
        Read,
        /// <summary>
        ///
        /// </summary>
        ReadWrite,
        /// <summary>
        ///
        /// </summary>
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostOrgOwnerProjectNewRequestApiKeyPermissionAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostOrgOwnerProjectNewRequestApiKeyPermissionAccess value)
        {
            return value switch
            {
                PostOrgOwnerProjectNewRequestApiKeyPermissionAccess.None => "none",
                PostOrgOwnerProjectNewRequestApiKeyPermissionAccess.Read => "read",
                PostOrgOwnerProjectNewRequestApiKeyPermissionAccess.ReadWrite => "read_write",
                PostOrgOwnerProjectNewRequestApiKeyPermissionAccess.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostOrgOwnerProjectNewRequestApiKeyPermissionAccess? ToEnum(string value)
        {
            return value switch
            {
                "none" => PostOrgOwnerProjectNewRequestApiKeyPermissionAccess.None,
                "read" => PostOrgOwnerProjectNewRequestApiKeyPermissionAccess.Read,
                "read_write" => PostOrgOwnerProjectNewRequestApiKeyPermissionAccess.ReadWrite,
                "write" => PostOrgOwnerProjectNewRequestApiKeyPermissionAccess.Write,
                _ => null,
            };
        }
    }
}