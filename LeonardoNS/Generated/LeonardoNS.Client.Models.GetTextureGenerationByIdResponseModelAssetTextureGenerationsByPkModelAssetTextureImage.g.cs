
#nullable enable

namespace LeonardoNS.Client
{
    /// <summary>
    /// columns and relationships of "model_asset_texture_images"
    /// </summary>
    public sealed partial class GetTextureGenerationByIdResponseModelAssetTextureGenerationsByPkModelAssetTextureImage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// When training model assets these are the texture types available to use.<br/>
        /// Default Value: NORMAL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LeonardoNS.Client.JsonConverters.MODELASSETTEXTURETYPESJsonConverter))]
        public global::LeonardoNS.Client.MODELASSETTEXTURETYPES? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTextureGenerationByIdResponseModelAssetTextureGenerationsByPkModelAssetTextureImage" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type">
        /// When training model assets these are the texture types available to use.<br/>
        /// Default Value: NORMAL
        /// </param>
        /// <param name="url"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetTextureGenerationByIdResponseModelAssetTextureGenerationsByPkModelAssetTextureImage(
            string? id,
            global::LeonardoNS.Client.MODELASSETTEXTURETYPES? type,
            string? url)
        {
            this.Id = id;
            this.Type = type;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTextureGenerationByIdResponseModelAssetTextureGenerationsByPkModelAssetTextureImage" /> class.
        /// </summary>
        public GetTextureGenerationByIdResponseModelAssetTextureGenerationsByPkModelAssetTextureImage()
        {
        }
    }
}