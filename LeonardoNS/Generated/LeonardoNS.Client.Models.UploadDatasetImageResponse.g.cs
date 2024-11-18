
#nullable enable

namespace LeonardoNS.Client
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadDatasetImageResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploadDatasetImage")]
        public global::LeonardoNS.Client.UploadDatasetImageResponseUploadDatasetImage? UploadDatasetImage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadDatasetImageResponse" /> class.
        /// </summary>
        /// <param name="uploadDatasetImage"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UploadDatasetImageResponse(
            global::LeonardoNS.Client.UploadDatasetImageResponseUploadDatasetImage? uploadDatasetImage)
        {
            this.UploadDatasetImage = uploadDatasetImage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadDatasetImageResponse" /> class.
        /// </summary>
        public UploadDatasetImageResponse()
        {
        }
    }
}