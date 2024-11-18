#nullable enable

namespace LeonardoNS.Client
{
    public partial interface IInitImagesClient
    {
        /// <summary>
        /// Upload Canvas Editor init and mask image<br/>
        /// This endpoint returns presigned details to upload an init image and a mask image to S3
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LeonardoNS.Client.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LeonardoNS.Client.UploadCanvasInitImageResponse> UploadCanvasInitImageAsync(
            global::LeonardoNS.Client.UploadCanvasInitImageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload Canvas Editor init and mask image<br/>
        /// This endpoint returns presigned details to upload an init image and a mask image to S3
        /// </summary>
        /// <param name="initExtension">
        /// Has to be png, jpg, jpeg, or webp.
        /// </param>
        /// <param name="maskExtension">
        /// Has to be png, jpg, jpeg, or webp.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LeonardoNS.Client.UploadCanvasInitImageResponse> UploadCanvasInitImageAsync(
            string initExtension,
            string maskExtension,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}