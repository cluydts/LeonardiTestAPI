#nullable enable

namespace LeonardoNS.Client
{
    public partial interface IImageClient
    {
        /// <summary>
        /// Delete a Single Generation<br/>
        /// This endpoint deletes a specific generation
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LeonardoNS.Client.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LeonardoNS.Client.DeleteGenerationByIdResponse> DeleteGenerationByIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}