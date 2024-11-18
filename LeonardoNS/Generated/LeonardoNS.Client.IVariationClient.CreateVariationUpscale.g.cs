#nullable enable

namespace LeonardoNS.Client
{
    public partial interface IVariationClient
    {
        /// <summary>
        /// Create upscale<br/>
        /// This endpoint will create an upscale for the provided image ID
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LeonardoNS.Client.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LeonardoNS.Client.CreateVariationUpscaleResponse> CreateVariationUpscaleAsync(
            global::LeonardoNS.Client.CreateVariationUpscaleRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create upscale<br/>
        /// This endpoint will create an upscale for the provided image ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LeonardoNS.Client.CreateVariationUpscaleResponse> CreateVariationUpscaleAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}