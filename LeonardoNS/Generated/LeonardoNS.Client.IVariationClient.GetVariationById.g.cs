#nullable enable

namespace LeonardoNS.Client
{
    public partial interface IVariationClient
    {
        /// <summary>
        /// Get variation by ID<br/>
        /// This endpoint will get the variation by ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LeonardoNS.Client.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LeonardoNS.Client.GetVariationByIdResponse> GetVariationByIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}