#nullable enable

namespace LeonardoNS.Client
{
    public partial interface IElementsClient
    {
        /// <summary>
        /// List Elements<br/>
        /// Get a list of public Elements available for use with generations.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LeonardoNS.Client.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LeonardoNS.Client.ListElementsResponse> ListElementsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}