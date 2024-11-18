
#nullable enable

namespace LeonardoNS.Client
{
    /// <summary>
    /// columns and relationships of "model_asset_texture_generations"
    /// </summary>
    public sealed partial class GetTextureGenerationsByModelIdResponseModelAssetTextureGeneration
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_asset_texture_images")]
        public global::System.Collections.Generic.IList<global::LeonardoNS.Client.GetTextureGenerationsByModelIdResponseModelAssetTextureGenerationModelAssetTextureImage>? ModelAssetTextureImages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negativePrompt")]
        public string? NegativePrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// The status of the current task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LeonardoNS.Client.JsonConverters.JobStatusJsonConverter))]
        public global::LeonardoNS.Client.JobStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTextureGenerationsByModelIdResponseModelAssetTextureGeneration" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="id"></param>
        /// <param name="modelAssetTextureImages"></param>
        /// <param name="negativePrompt"></param>
        /// <param name="prompt"></param>
        /// <param name="seed"></param>
        /// <param name="status">
        /// The status of the current task.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetTextureGenerationsByModelIdResponseModelAssetTextureGeneration(
            string? createdAt,
            string? id,
            global::System.Collections.Generic.IList<global::LeonardoNS.Client.GetTextureGenerationsByModelIdResponseModelAssetTextureGenerationModelAssetTextureImage>? modelAssetTextureImages,
            string? negativePrompt,
            string? prompt,
            int? seed,
            global::LeonardoNS.Client.JobStatus? status)
        {
            this.CreatedAt = createdAt;
            this.Id = id;
            this.ModelAssetTextureImages = modelAssetTextureImages;
            this.NegativePrompt = negativePrompt;
            this.Prompt = prompt;
            this.Seed = seed;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTextureGenerationsByModelIdResponseModelAssetTextureGeneration" /> class.
        /// </summary>
        public GetTextureGenerationsByModelIdResponseModelAssetTextureGeneration()
        {
        }
    }
}