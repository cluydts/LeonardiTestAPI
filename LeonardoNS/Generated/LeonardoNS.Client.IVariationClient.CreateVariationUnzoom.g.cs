#nullable enable

namespace LeonardoNS.Client
{
    public partial interface IVariationClient
    {
        /// <summary>
        /// Create unzoom<br/>
        /// This endpoint will create an unzoom variation for the provided image ID
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LeonardoNS.Client.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LeonardoNS.Client.CreateVariationUnzoomResponse> CreateVariationUnzoomAsync(
            global::LeonardoNS.Client.CreateVariationUnzoomRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create unzoom<br/>
        /// This endpoint will create an unzoom variation for the provided image ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="isVariation"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LeonardoNS.Client.CreateVariationUnzoomResponse> CreateVariationUnzoomAsync(
            string? id = default,
            bool? isVariation = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}