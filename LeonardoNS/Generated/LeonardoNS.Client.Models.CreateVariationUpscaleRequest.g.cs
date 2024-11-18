
#nullable enable

namespace LeonardoNS.Client
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVariationUpscaleRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVariationUpscaleRequest" /> class.
        /// </summary>
        /// <param name="id"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateVariationUpscaleRequest(
            string id)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVariationUpscaleRequest" /> class.
        /// </summary>
        public CreateVariationUpscaleRequest()
        {
        }
    }
}