
#nullable enable

namespace LeonardoNS.Client
{
    /// <summary>
    /// columns and relationships of "generated_image_variation_generic"
    /// </summary>
    public sealed partial class GetGenerationByIdResponseGenerationsByPkGeneratedImageGeneratedImageVariationGeneric
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The status of the current task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LeonardoNS.Client.JsonConverters.JobStatusJsonConverter))]
        public global::LeonardoNS.Client.JobStatus? Status { get; set; }

        /// <summary>
        /// The type of variation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transformType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LeonardoNS.Client.JsonConverters.VARIATIONTYPEJsonConverter))]
        public global::LeonardoNS.Client.VARIATIONTYPE? TransformType { get; set; }

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
        /// Initializes a new instance of the <see cref="GetGenerationByIdResponseGenerationsByPkGeneratedImageGeneratedImageVariationGeneric" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="status">
        /// The status of the current task.
        /// </param>
        /// <param name="transformType">
        /// The type of variation.
        /// </param>
        /// <param name="url"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetGenerationByIdResponseGenerationsByPkGeneratedImageGeneratedImageVariationGeneric(
            string? id,
            global::LeonardoNS.Client.JobStatus? status,
            global::LeonardoNS.Client.VARIATIONTYPE? transformType,
            string? url)
        {
            this.Id = id;
            this.Status = status;
            this.TransformType = transformType;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGenerationByIdResponseGenerationsByPkGeneratedImageGeneratedImageVariationGeneric" /> class.
        /// </summary>
        public GetGenerationByIdResponseGenerationsByPkGeneratedImageGeneratedImageVariationGeneric()
        {
        }
    }
}