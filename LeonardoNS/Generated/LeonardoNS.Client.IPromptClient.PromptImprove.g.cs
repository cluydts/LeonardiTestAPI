#nullable enable

namespace LeonardoNS.Client
{
    public partial interface IPromptClient
    {
        /// <summary>
        /// Improve a Prompt<br/>
        /// This endpoint returns a improved prompt
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LeonardoNS.Client.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LeonardoNS.Client.PromptImproveResponse> PromptImproveAsync(
            global::LeonardoNS.Client.PromptImproveRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Improve a Prompt<br/>
        /// This endpoint returns a improved prompt
        /// </summary>
        /// <param name="prompt">
        /// The prompt to improve.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LeonardoNS.Client.PromptImproveResponse> PromptImproveAsync(
            string prompt,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}