#nullable enable

namespace LeonardoNS.Client
{
    public partial interface IInitImagesClient
    {
        /// <summary>
        /// Delete init image<br/>
        /// This endpoint deletes an init image
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LeonardoNS.Client.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LeonardoNS.Client.DeleteInitImageByIdResponse> DeleteInitImageByIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}