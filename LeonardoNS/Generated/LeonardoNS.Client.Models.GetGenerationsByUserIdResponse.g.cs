
#nullable enable

namespace LeonardoNS.Client
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetGenerationsByUserIdResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generations")]
        public global::System.Collections.Generic.IList<global::LeonardoNS.Client.GetGenerationsByUserIdResponseGeneration>? Generations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGenerationsByUserIdResponse" /> class.
        /// </summary>
        /// <param name="generations"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetGenerationsByUserIdResponse(
            global::System.Collections.Generic.IList<global::LeonardoNS.Client.GetGenerationsByUserIdResponseGeneration>? generations)
        {
            this.Generations = generations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGenerationsByUserIdResponse" /> class.
        /// </summary>
        public GetGenerationsByUserIdResponse()
        {
        }
    }
}