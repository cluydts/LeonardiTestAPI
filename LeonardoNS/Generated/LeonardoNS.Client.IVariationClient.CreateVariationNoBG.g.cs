#nullable enable

namespace LeonardoNS.Client
{
    public partial interface IVariationClient
    {
        /// <summary>
        /// Create no background<br/>
        /// This endpoint will create a no background variation of the provided image ID
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LeonardoNS.Client.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LeonardoNS.Client.CreateVariationNoBGResponse> CreateVariationNoBGAsync(
            global::LeonardoNS.Client.CreateVariationNoBGRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create no background<br/>
        /// This endpoint will create a no background variation of the provided image ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="isVariation"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LeonardoNS.Client.CreateVariationNoBGResponse> CreateVariationNoBGAsync(
            string id,
            bool? isVariation = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}