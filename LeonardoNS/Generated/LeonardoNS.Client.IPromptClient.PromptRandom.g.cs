#nullable enable

namespace LeonardoNS.Client
{
    public partial interface IPromptClient
    {
        /// <summary>
        /// Generate a Random prompt<br/>
        /// This endpoint returns a random prompt
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LeonardoNS.Client.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LeonardoNS.Client.PromptRandomResponse> PromptRandomAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}