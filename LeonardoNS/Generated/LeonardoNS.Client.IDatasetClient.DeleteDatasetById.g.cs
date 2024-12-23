#nullable enable

namespace LeonardoNS.Client
{
    public partial interface IDatasetClient
    {
        /// <summary>
        /// Delete a Single Dataset by ID<br/>
        /// This endpoint deletes the specific dataset
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LeonardoNS.Client.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LeonardoNS.Client.DeleteDatasetByIdResponse> DeleteDatasetByIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}