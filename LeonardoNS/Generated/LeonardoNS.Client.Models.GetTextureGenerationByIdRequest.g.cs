
#nullable enable

namespace LeonardoNS.Client
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTextureGenerationByIdRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTextureGenerationByIdRequest" /> class.
        /// </summary>
        /// <param name="id"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetTextureGenerationByIdRequest(
            string? id)
        {
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTextureGenerationByIdRequest" /> class.
        /// </summary>
        public GetTextureGenerationByIdRequest()
        {
        }
    }
}