#nullable enable

namespace Composio
{
    public partial interface IAuthenticationClient
    {
        /// <summary>
        /// End user session and clear authentication<br/>
        /// Terminates the current user session by invalidating authentication cookies and tokens. This effectively signs the user out of the application. After logout, the user will need to authenticate again to access protected resources.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PostAuthSessionLogoutResponse> PostAuthSessionLogoutAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}