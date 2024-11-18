#nullable enable

namespace LeonardoNS.Client
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// List Platform Models<br/>
        /// Get a list of public Platform Models available for use with generations.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LeonardoNS.Client.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LeonardoNS.Client.ListPlatformModelsResponse> ListPlatformModelsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}