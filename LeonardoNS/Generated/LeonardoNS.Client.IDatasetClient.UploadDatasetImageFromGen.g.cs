#nullable enable

namespace LeonardoNS.Client
{
    public partial interface IDatasetClient
    {
        /// <summary>
        /// Upload a Single Generated Image to a Dataset<br/>
        /// This endpoint will upload a previously generated image to the dataset
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LeonardoNS.Client.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LeonardoNS.Client.UploadDatasetImageFromGenResponse> UploadDatasetImageFromGenAsync(
            string datasetId,
            global::LeonardoNS.Client.UploadDatasetImageFromGenRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload a Single Generated Image to a Dataset<br/>
        /// This endpoint will upload a previously generated image to the dataset
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="generatedImageId">
        /// The ID of the image to upload to the dataset.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LeonardoNS.Client.UploadDatasetImageFromGenResponse> UploadDatasetImageFromGenAsync(
            string datasetId,
            string generatedImageId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}