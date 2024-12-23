
#nullable enable

namespace LeonardoNS.Client
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTextureGenerationResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("textureGenerationJob")]
        public global::LeonardoNS.Client.CreateTextureGenerationResponseTextureGenerationJob? TextureGenerationJob { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextureGenerationResponse" /> class.
        /// </summary>
        /// <param name="textureGenerationJob"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateTextureGenerationResponse(
            global::LeonardoNS.Client.CreateTextureGenerationResponseTextureGenerationJob? textureGenerationJob)
        {
            this.TextureGenerationJob = textureGenerationJob;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextureGenerationResponse" /> class.
        /// </summary>
        public CreateTextureGenerationResponse()
        {
        }
    }
}