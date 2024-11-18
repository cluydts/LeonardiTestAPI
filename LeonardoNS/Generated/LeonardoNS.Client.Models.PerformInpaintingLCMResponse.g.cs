
#nullable enable

namespace LeonardoNS.Client
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PerformInpaintingLCMResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lcmGenerationJob")]
        public global::LeonardoNS.Client.PerformInpaintingLCMResponseLcmGenerationJob? LcmGenerationJob { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PerformInpaintingLCMResponse" /> class.
        /// </summary>
        /// <param name="lcmGenerationJob"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PerformInpaintingLCMResponse(
            global::LeonardoNS.Client.PerformInpaintingLCMResponseLcmGenerationJob? lcmGenerationJob)
        {
            this.LcmGenerationJob = lcmGenerationJob;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PerformInpaintingLCMResponse" /> class.
        /// </summary>
        public PerformInpaintingLCMResponse()
        {
        }
    }
}