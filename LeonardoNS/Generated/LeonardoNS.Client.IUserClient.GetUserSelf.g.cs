#nullable enable

namespace LeonardoNS.Client
{
    public partial interface IUserClient
    {
        /// <summary>
        /// Get user information<br/>
        /// This endpoint will return your user information such as your user id, username, token renewal date and current amounts of the following: subscription tokens, gpt (prompt generation) tokens, and model training tokens
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LeonardoNS.Client.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LeonardoNS.Client.GetUserSelfResponse> GetUserSelfAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}